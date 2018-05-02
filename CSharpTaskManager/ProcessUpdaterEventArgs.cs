using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace CSharpTaskManager
{
    public class ProcessUpdaterEventArgs : EventArgs
    {
        public ProcessUpdaterEventArgs(Process proc, Exception error)
        {
            if (proc != null)
            {
                Name = proc.ProcessName;
                ID = proc.Id;
                Memory = proc.WorkingSet64;
                Instance = proc;
            }
            Error = error;
        }
        public ProcessUpdaterEventArgs(Component component)
        {
            Debug.WriteLine("ProcessUpdaterEventArgs(Component)");
            if (component != null)
            {
                Debug.WriteLine("Component wasn't null");
                if (component.GetType() == typeof(Process))
                {
                    Debug.WriteLine("Type: Process\nID:");
                    Debug.WriteLine(((Process)component).Id);
                    Name = ((Process)component).ProcessName;
                    ID = ((Process)component).Id;
                    Memory = ((Process)component).WorkingSet64;
                    Instance = ((Process)component);
                }
                else
                {
                    Debug.WriteLine("Type: ProcessObject");
                    Name = ((ProcessObject)component).ProcessName;
                    ID = ((ProcessObject)component).Id;
                }
            }else
                throw new Exception("ProcessUpdaterEventArgs, takes one parameter. (Process) This cannot be null, use other constructor.");

        }
        public ProcessUpdaterEventArgs(Component component, int index)
        {
            Debug.WriteLine("ProcessUpdaterEventArgs(Component, int");
            if (component != null)
            {
                Debug.WriteLine("Component wasn't null");
                if (component.GetType() == typeof(Process))
                {
                    Debug.WriteLine("Type: process");
                    Name = (component as Process).ProcessName;
                    ID = (component as Process).Id;
                    Memory = (component as Process).WorkingSet64;
                    Instance = (component as Process);
                }
                else
                {
                    Debug.WriteLine("Type: ProcessObject");
                    Name = (component as ProcessObject).ProcessName;
                    ID = (component as ProcessObject).Id;
                }
            }
            Index = index;
        }
       



        public string Name { set; get; }
        public int ID { set; get; }
        public long Memory { set; get; }
        public Process Instance { set; get; }
        public Exception Error { set; get; }
        public int Index { set; get; } = -1;
    }
}
