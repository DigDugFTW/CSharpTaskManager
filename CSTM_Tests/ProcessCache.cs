using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CSTM_Tests
{
    public class ProcessCache
    {
        // private HashSet<Process>

        
       
        
        
    }

    public class testing : Process
    {
        public int pint { set; get; }
    }


    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class ProcessExtension
    {
        public static string ConvertToLVIString(this Process proc)
        {
            return proc.ProcessName + ", " + proc.WorkingSet64.ToString() + ", " + proc.Id;
        }
    }
}
