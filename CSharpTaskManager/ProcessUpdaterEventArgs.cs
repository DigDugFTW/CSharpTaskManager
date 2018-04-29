using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CSharpTaskManager
{
    public class ProcessUpdaterEventArgs : EventArgs
    {
        public ProcessUpdaterEventArgs(Process proc, Exception error)
        {
            Name = proc.ProcessName;
            ID = proc.Id;
            Memory = proc.WorkingSet64;
            Instance = proc;
            Error = error;
        }
        public ProcessUpdaterEventArgs(Process proc)
        {
            Name = proc.ProcessName;
            ID = proc.Id;
            Memory = proc.WorkingSet64;
            Instance = proc;
        }
        public string Name { set; get; }
        public int ID { set; get; }
        public long Memory { set; get; }
        public Process Instance { set; get; }
        public Exception Error { set; get; }
    }
}
