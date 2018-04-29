using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CSharpTaskManager
{
    /*
     * Extension methods on the process class, allows for the removal of a process wrapper class.
     * 
     */
    public static class ProcessExtensionMethods
    {
        /*
         * Extension method
         * Process: process to convert to type: ListViewItem
         * ListViewItem: Item that will be inserted into the ListView
         */
        public static ListViewItem ConvertToListViewItem(this Process process)
        {
            
            return new ListViewItem(new string[] { process.ProcessName, process.WorkingSet64.ToString(), process.Id.ToString()});
        }

        public static ListViewItem[] ConvertToListViewArray(this HashSet<Process> hashSet)
        {
            ListViewItem[] tempItemCollection = new ListViewItem[hashSet.Count];
            int count = 0;
            foreach(var proc in hashSet)
            {
                tempItemCollection[count] = proc.ConvertToListViewItem();
                count++;
            }
            return tempItemCollection;
        }

    }
}
