using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace CSharpTaskManager
{
    public enum ComparisonType
    {
        NAME, PID, NA
    }
    public static class ProcessCache
    {

        public delegate void ProcessCacheEventHandler(object sender, ProcessUpdaterEventArgs e);
        public static event ProcessCacheEventHandler OnProcessKilled;
        public static event ProcessCacheEventHandler OnProcessStarted;
       
        

        public static ComparisonType ComparisonProperty { set; get; } = ComparisonType.NA;
        private static HashSet<Process> _procWrap = new HashSet<Process>(new ProcessComparer());

        public static bool ContinueCacheUpdate { set; get; } = true;
        public static void AddRange(IEnumerable<Process> collection)
        {
            foreach (var proc in collection)
                _procWrap.Add(proc);
        }
        public static void Add(Process proc)
        {
            _procWrap.Add(proc);
        }
        public static void Remove(Process proc)
        {
            _procWrap.Remove(proc);
        }
        public static HashSet<Process> Instance { get => _procWrap; }

      
        public static void ContinousCacheUpdate()
        {
            
            Debug.WriteLine("Starting continuous cache thread");
            new Task(() => 
            {
                Debug.WriteLine("Cache size: " + _procWrap.Count);
               
                while (ContinueCacheUpdate)
                {
                  
                    foreach(Process proc in Process.GetProcesses())
                    {
                        if (!_procWrap.Contains(proc))
                        {
                            _procWrap.Add(proc);
                            OnProcessStarted(null, new ProcessUpdaterEventArgs(proc));
                            Debug.WriteLine("Adding: "+proc+" index: ");
                            
                        }
                       
                        // else
                        //Debug.WriteLine(proc+" already exists, not adding.");
                    }
                    foreach (var pr in _procWrap.ToList())
                    {
                        //Check if process is alive
                        try
                        {
                            if (Process.GetProcessById(pr.Id) == null) ;
                        }
                        catch (Exception e)
                        {
                            _procWrap.Remove(pr);
                            OnProcessKilled(null, new ProcessUpdaterEventArgs(pr));
                            Debug.WriteLine("Process has exited, removing");
                        }
                    }

                    //Debug.WriteLine("Cache size: " + _procWrap.Count);

                    Thread.Sleep(2000);
                }
            }).Start();
            Debug.WriteLine("Exited cache thread");
        }
    }
}
