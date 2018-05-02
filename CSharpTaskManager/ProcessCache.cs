using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Management;
using System.Windows.Forms;

namespace CSharpTaskManager
{
    public enum ComparisonType
    {
        NA, FULL, NAME, PID
    }

    public static class ProcessCache
    {

        // MEW objects, for calling wmi with wql (wmiql)        
        public static ManagementEventWatcher watchStartEvent;
        public static ManagementEventWatcher watchStopEvent;

        #region Events and Delegates, for list view updating
        public delegate void ProcessCacheEventHandler(object sender, ProcessUpdaterEventArgs e);
        public static event ProcessCacheEventHandler OnProcessKilled;
        public static event ProcessCacheEventHandler OnProcessStarted;
        #endregion
        
        public static ProcessComparer<Component> _processComparer = new ProcessComparer<Component>();
        private static HashSet<Process> _procWrap = new HashSet<Process>(_processComparer);

        #region Properties
        // Instance of the parent list view.
        public static ListView ParentListView { set; get; }
        public static bool ContinueCacheUpdate { set; get; } = true;
        public static ComparisonType ProcessComparerComparisonType { set => _processComparer.ComparisonProperty = value; get => _processComparer.ComparisonProperty; }
        #endregion

        #region HashSet methods
        public static void AddRangeHashSet(IEnumerable<Process> collection)
        {
            foreach (var proc in collection)
                _procWrap.Add(proc);
        }
        public static void AddHashSet(Process proc)
        {
            OnProcessStarted(null, new ProcessUpdaterEventArgs(proc));
            _procWrap.Add(proc);
        }
        public static void RemoveHashSet(Process proc)
        {
           
            OnProcessKilled(null, new ProcessUpdaterEventArgs(proc));
            _procWrap.Remove(proc);

        }
        public static void RemoveHashSet(int procID)
        {
            
            try
            {
                var tempProcessObject = new ProcessObject()
                {
                    Id = procID
                };

                ControlInvokeRequired.invoke(ParentListView, () =>
                {
                    OnProcessKilled(null, new ProcessUpdaterEventArgs(tempProcessObject));
                    List<Process> tempProcList = new List<Process>(_procWrap);

                    // debug
                    foreach (var proc in tempProcList)
                    {
                        if (proc.Id == tempProcessObject.Id)
                        {
                            _procWrap.Remove(proc);
                        }
                    }
                });
               
            }
            catch(Exception f)
            {
                Debug.WriteLine("Exeption at RemoveHashSet: " + f.Message);
            }
            
        }
        public static HashSet<Process> Instance { get => _procWrap; }
        #endregion

       
        // init Wql and ManagementEventWatcher objects
        // Start listening to Win32_ start tract and stop trace
        public static void InitWQL()
        {
         

            WqlEventQuery startEventQuery = new WqlEventQuery("Win32_ProcessStartTrace");
            WqlEventQuery stopEventQuery = new WqlEventQuery("Win32_ProcessStopTrace");

            watchStartEvent = new ManagementEventWatcher(startEventQuery);
            watchStopEvent = new ManagementEventWatcher(stopEventQuery);

            watchStartEvent.Start();
            watchStopEvent.Start();
        }

    }
}
