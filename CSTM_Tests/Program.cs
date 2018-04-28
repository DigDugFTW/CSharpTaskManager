using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CSTM_Tests
{
    class Program
    {

        static void Main(string[] args)
        {
            var procs = ProcCache.ProcessList;
            //ListViewItem listViewItemA = new ListViewItem(ListViewItemWrapper.ProcessToListViewItem());

            DummyProcess dummyProcessNotepad = new DummyProcess("notepad", 369021, 1);
            DummyProcess dummyProcessCalculator = new DummyProcess("calculator", 123000, 2);
            DummyProcess dummyProcessRepeat = new DummyProcess("notepad", 329041, 1);

            

        }

        public class DummyProcess
        {
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
                return (int)obj.WorkingSet ^ obj.PID;
            }
        }


        public class DummyProcessWrapper
        {
            public DummyProcessWrapper()
            {
                
              
            }
            public DummyProcessWrapper(DummyProcess dummyProcess)
            {

            }
            
        }

    }
}
