using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CSharpTaskManager
{
    class ProcessComparer : IEqualityComparer<Process>
    {
        public bool Equals(Process x, Process y)
        {
            if (ProcessCache.ComparisonProperty == ComparisonType.PID)
            {
                return x.Id == y.Id;
            }
            else if (ProcessCache.ComparisonProperty == ComparisonType.NAME)
            {
                return x.ProcessName == y.ProcessName;
            }
            else
                throw new Exception("Comparison type not specified. ComparisonType is set to NA, choose PID or NAME in Cache constructor");
        }

        public int GetHashCode(Process obj)
        {
            return obj.ProcessName.GetHashCode() ^ obj.Id;
        }
    }
}
