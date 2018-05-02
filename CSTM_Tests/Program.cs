using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;

namespace CSTM_Tests
{
    class Program
    {

        static void Main(string[] args)
        {


            ProcessComparer<Component> procCompObjProc = new ProcessComparer<Component>();

            procCompObjProc.ComparisonProperty = ComparisonType.PID;
            HashSet<Component> componentHashSet = new HashSet<Component>(procCompObjProc);


            componentHashSet.Add(new ProcessObject() { ProcessName = "notepad", Id = 23400 });
            componentHashSet.Add(new ProcessObject() { ProcessName = "asdasdd", Id = 23400 });


            foreach(var item in componentHashSet)
            {
                Console.WriteLine((item as ProcessObject).ProcessName);
            }
            Console.ReadKey();

        }

    }
}
