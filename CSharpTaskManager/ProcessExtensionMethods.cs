using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.ListView;
using System.Collections.ObjectModel;

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
            if (process == null) MessageBox.Show("WHY ARE YOU PASSING NULL!!");
            return new ListViewItem(new string[] { process.ProcessName, process.WorkingSet64.ToString(), process.Id.ToString()});
        }

       

        public static ListViewItem[] ConvertToListViewArray(this ICollection<Process> collection)
        {
            ListViewItem[] tempItemCollection = new ListViewItem[collection.Count];
            int count = 0;
            foreach(var proc in collection)
            {
                if (proc != null)
                    tempItemCollection[count] = proc.ConvertToListViewItem();
                   
                
                count++;
            }
            return tempItemCollection;
        }

       

       

        public static int getIndexOfLVI(this ListViewItemCollection listViewItemCollection, ListViewItem targetItem)
        {
            int count = 0;
            foreach(ListViewItem item in listViewItemCollection)
            {
                if(ProcessCache._processComparer.Equals(item.ToProcessObject(), targetItem.ToProcessObject()))
                {
                    Debug.WriteLine("Get index of LVI found a match at index: "+count);
                    return count;
                }
                count++;
            }
            Debug.WriteLine("Get index of LVI couldn't find a match");
            return -1;
        }

        public static ProcessObject ToProcessObject(this ListViewItem listViewItem)
        {
            if(listViewItem == null) { MessageBox.Show("List view item is null in ToProcessObject"); }
            var tmpProc = new ProcessObject()
            {
                ProcessName = listViewItem.SubItems[0].Text,
                Id = int.Parse(listViewItem.SubItems[2].Text)
            };

            Debug.WriteLine(tmpProc);

            return tmpProc;
        }
    }
}
