using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CSTM_Tests
{
    class Program
    {

        static void Main(string[] args)
        {
            //var procs = ProcCache.ProcessList;
            ////ListViewItem listViewItemA = new ListViewItem(ListViewItemWrapper.ProcessToListViewItem());

            //DummyProcess dummyProcessNotepad = new DummyProcess("notepad", 369021, 3);
            //DummyProcess dummyProcessCalculator = new DummyProcess("calculator", 123000, 2);
            //DummyProcess dummyProcessRepeat = new DummyProcess("notepad", 329041, 1);

            //DummyProcess[] dummyProcAr = 
            //{
            //    new DummyProcess("mspaint", 200000, 1),
            //    new DummyProcess("3dpaint", 369021, 2),
            //    new DummyProcess("notepad", 434634, 3),
            //    new DummyProcess("notepad", 639468, 3),
            //    new DummyProcess("sketchable", 7665777, 4),
            //    new DummyProcess("edge", 34567557, 8),
            //};



            //foreach(var dummyProcess in dummyProcSet)
            //{
            //    Console.WriteLine(dummyProcess);
            //}

            Process[] procs = Process.GetProcesses();
            Console.WriteLine("Start");
            foreach(Process pr in procs)
            {
                Console.WriteLine(pr.ConvertToLVIString());
            }
            Console.WriteLine("End");
            
            

            Console.ReadKey();

        }

        public class DummyProcess
        {
            public DummyProcess(Process proc)
            {
                Name = proc.ProcessName;
                WorkingSet = proc.WorkingSet64;
                PID = proc.Id;
            }
            public DummyProcess(string name, long workingSet, int pid)
            {
                Name = name;
                WorkingSet = workingSet;
                PID = pid;
            }
            public DummyProcess()
            {

            }
            public string Name { set; get; }
            public long WorkingSet { set; get; }
            public int PID { set; get; }

            public override string ToString()
            {
                return $"[{Name} {WorkingSet} {PID}]";
            }

        }

        public class DummyProcessComparer : IEqualityComparer<DummyProcess>
        {

            public DummyProcessComparer()
            {

            }
            public DummyProcessComparer(ComparisonType comparisonType)
            {
                Comparison = comparisonType;
            }
            public ComparisonType Comparison { set; get; }
            public bool Equals(DummyProcess x, DummyProcess y)
            {
                if (Comparison == ComparisonType.PID)
                {
                    return x.PID == y.PID;
                }
                else
                {
                    return x.Name == y.Name;
                }
            }
            public int GetHashCode(DummyProcess obj)
            {
                return obj.Name.GetHashCode()^obj.PID;
            }
        }


        public struct DummyProcessWrapper
        {
            
            public DummyProcessWrapper(DummyProcess dummyProcess)
            {

            }

        }

    }
}
