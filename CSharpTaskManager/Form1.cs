using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace CSharpTaskManager
{
    /*TODO
     *  Update items that are in the list, but not replace them (Too expensive)
     *  Target removed items by ID so you don't kill multiple processes that might have the same name?
     *  Efficiently remove items from list, without search via string value, use integer. Either index or PID.
     */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ContextMenu _contextMenu = default(ContextMenu);

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessCache.OnProcessKilled += ProcessCache_OnProcessKilled;
            ProcessCache.OnProcessStarted += ProcessCache_OnProcessStarted;

            #region Event Subscription
            ProcessUpdater.OnProcessKilled += ProcessUpdater_OnProcessKilled;
            ProcessUpdater.OnProcessUpdated += ProcessUpdater_OnProcessUpdated;
            ProcessUpdater.OnFailure += ProcessUpdater_OnFailure;
            #endregion
            MenuItem[] menuItems = new MenuItem[]
            {
                new MenuItem("Kill", OnProcessKilled)
                // Add  get thread information
            };
            _contextMenu = new ContextMenu(menuItems);



            ProcessCache.ComparisonProperty = ComparisonType.PID;
            ProcessCache.AddRange(Process.GetProcesses());

            ProcessCache.ContinousCacheUpdate();

            listViewProcesses.Items.AddRange(ProcessCache.Instance.ConvertToListViewArray());
        }

        private void ProcessCache_OnProcessStarted(object sender, ProcessUpdaterEventArgs e)
        {
            MessageBox.Show("Process started " + e.Name+" Index: "+e.Index);
            
            ControlInvokeRequired(listViewProcesses, () => listViewProcesses.Items.Add(e.Instance.ConvertToListViewItem()));
        }

        private void ProcessCache_OnProcessKilled(object sender, ProcessUpdaterEventArgs e)
        {
            MessageBox.Show("Removing " + e.Name);
            // Will need to remove by ID
            ControlInvokeRequired(listViewProcesses, () => listViewProcesses.Items.RemoveAt(e.Index));
            
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired)
            {
                c.Invoke(new MethodInvoker(delegate { a(); }));
                return true;
            }
            return false;


        }

        public void UpdateListViewItems(ListView listView)
        {
            //ListView.CheckForIllegalCrossThreadCalls = false;



            //new Task(() => 
            //{
            //    while (true)
            //    {


            //        Thread.Sleep(1000);
            //    }

            //}
            //);
        }

        #region Context Menu Actions
        private void OnProcessKilled(object sender, EventArgs e)
        {
            var selectedItems = listViewProcesses.SelectedItems;
            foreach (ListViewItem proc in selectedItems)
            {
                var procS = Process.GetProcessesByName(proc.Text);
                listViewProcesses.Items.Remove(proc);
                foreach (var pr in procS)
                {
                    ProcessUpdater.KillProc(pr);
                }
            }
        }
        #endregion

        #region Process Updater Events
        private void ProcessUpdater_OnFailure(object sender, ProcessUpdaterEventArgs e)
        {
            MessageBox.Show($"Process couldn't be killed {e.Name}, reason:\n{e.Error.Message}");
        }

        private void ProcessUpdater_OnProcessUpdated(object sender, ProcessUpdaterEventArgs e)
        {

        }

        private void ProcessUpdater_OnProcessKilled(object sender, ProcessUpdaterEventArgs e)
        {
            MessageBox.Show($"Process killed {e.Name}");

        }
        #endregion

        private void listViewProcesses_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                _contextMenu.Show(this, e.Location);
            }
        }

        #region Form buttons, buttons that aren't on the tab controls.
        private void buttonSearchProcess_Click(object sender, EventArgs e)
        {
            var res = listViewProcesses.FindItemWithText(textBoxSearchProcess.Text);
            listViewProcesses.Sort();
        }
        #endregion
    }
}
