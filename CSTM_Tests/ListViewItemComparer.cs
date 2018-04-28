using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Diagnostics;
namespace CSTM_Tests
{
    public enum ComparisonType
    {
        PID, NAME
    }

    public static class ProcCache
    {
        private static HashSet<Process> _procs = new HashSet<Process>(Process.GetProcesses(), new ListViewItemComparer(ComparisonType.PID));
        public static HashSet<Process> ProcessList
        {
            get => _procs;
        }
    }
    public class ListViewItemWrapper
    {
        public ListViewItemWrapper()
        {

        }

        public string Name { set; get; }
        public int PID { set; get; }
        public long Memory { set; get; }

        //public ListViewItem ToListViewItem()
        //{
        //    return new ListViewItem(new string[] { Name, PID.ToString(), Memory.ToString() });
        //}

        public static string[] ProcessToListViewItem(Process proc)
        {
            return new string[] { proc.ProcessName, proc.WorkingSet64.ToString(), proc.Id.ToString() };
        }
    }

    public class ListViewItemComparer : IEqualityComparer<Process>
    {
        public ListViewItemComparer()
        {

        }
        public ListViewItemComparer(ComparisonType comparisonType)
        {
            Comparison = comparisonType;
        }
        public ComparisonType Comparison{set;get;}
        public bool Equals(Process x, Process y)
        {
            if(Comparison == ComparisonType.PID)
            {
                return x.Id == y.Id;
            }
            else
            {
                return x.ProcessName == y.ProcessName;
            }
        }
        public int GetHashCode(Process obj)
        {
            return (int)obj.WorkingSet64 ^ obj.Id;
        }
    }
}
