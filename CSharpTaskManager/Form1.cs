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
using System.Collections.Specialized;
using System.Management;
using static ControlInvokeRequired;
namespace CSharpTaskManager
{
    /*TODO
     * 
     *  Update list though:
     *      Updating of observable list.
     *      Updating of process status directly.
     * 
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

            ProcessCache.ProcessComparerComparisonType = ComparisonType.PID;
            ProcessCache.ParentListView = listViewProcesses;
            // Init before subscription
            ProcessCache.InitWQL();
            // Subscribe


            ProcessCache.watchStartEvent.EventArrived += WatchStartEvent_EventArrived;
            ProcessCache.watchStopEvent.EventArrived += WatchStopEvent_EventArrived;
            #region Process cache event subscription
            ProcessCache.OnProcessKilled += ProcessCache_OnProcessKilled;
            ProcessCache.OnProcessStarted += ProcessCache_OnProcessStarted;


            #endregion


            // Initialize menu items
            MenuItem[] menuItems = new MenuItem[]
            {
                new MenuItem("Kill", OnProcessKilled)
                // Add  get thread information
            };
            _contextMenu = new ContextMenu(menuItems);



            // Fill Hashset with current processes.
            ProcessCache.AddRangeHashSet(Process.GetProcesses());

            // Init. list view, with hashset processes then convert all items to list view array
            listViewProcesses.Items.AddRange(ProcessCache.Instance.ConvertToListViewArray());


        }

        #region W[MI]QL events
        // stop event
        private void WatchStopEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            int processId = int.Parse(e.NewEvent.Properties["ProcessID"].Value.ToString());
            ProcessCache.RemoveHashSet(processId);
        }
        // start event
        private void WatchStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            int processId = int.Parse(e.NewEvent.Properties["ProcessID"].Value.ToString());
            try
            {
                var tempProcObj = new ProcessObject();
                var proc = Process.GetProcessById(processId);

                ProcessCache.AddHashSet(proc);
            }
            catch (Exception f)
            {
                Debug.WriteLine(f.Message);
            }

        }
        #endregion

        #region Process Cache events, for list view control
        private void ProcessCache_OnProcessStarted(object sender, ProcessUpdaterEventArgs e)
        {

            invoke(listViewProcesses, () =>
            {
                if (e.Instance != null)
                {
                    var lvi = e.Instance.ConvertToListViewItem();

                    listViewProcesses.Items.Add(lvi);
                    Debug.WriteLine("Index of " + e.Name + " " + listViewProcesses.Items.getIndexOfLVI(lvi));
                }
                else
                    MessageBox.Show("Saved your ass, e.Instance was null!");
            });

        }

        private void ProcessCache_OnProcessKilled(object sender, ProcessUpdaterEventArgs e)
        {
          
                ProcessObject tempProcObj = new ProcessObject()
                {
                    ProcessName = e.Name,
                    Id = e.ID
                };

                int removeIndex = listViewProcesses.Items.getIndexOfLVI(tempProcObj.ConvertToListViewItem());
                if (removeIndex >= 0)
                {
                    listViewProcesses.Items.RemoveAt(removeIndex);
                }
            
        }
        #endregion

        #region Context Menu Actions
        private void OnProcessKilled(object sender, EventArgs e)
        {
            var selectedItems = listViewProcesses.SelectedItems;
            foreach (ListViewItem proc in selectedItems)
            {
                var procS = Process.GetProcessesByName(proc.SubItems[0].Text);
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



        private void ProcessUpdater_OnProcessKilled(object sender, ProcessUpdaterEventArgs e)
        {
            MessageBox.Show($"Process killed {e.Name}");

        }
        #endregion

        #region List view process, events
        private void listViewProcesses_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                _contextMenu.Show(this, e.Location);
            }
        }
        #endregion

        #region Form buttons, buttons that aren't on the tab controls.
        private void buttonSearchProcess_Click(object sender, EventArgs e)
        {
            try
            {
                var res = listViewProcesses.FindItemWithText(textBoxSearchProcess.Text);
                int loc = listViewProcesses.Items.getIndexOfLVI(res);
                listViewProcesses.Items[loc].BackColor = Color.LightBlue;
            }catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

        }
        #endregion

        #region Process information controls
        private void buttonStartTask_Click(object sender, EventArgs e)
        {
            ProcessStartInfo procStart = new ProcessStartInfo();
            procStart.FileName = textBoxStartProcName.Text;
            procStart.Arguments = textBoxProcArgs.TextLength > 0 ? textBoxProcArgs.Text : "";
            procStart.WindowStyle = radioButtonNormal.Checked ? ProcessWindowStyle.Normal : radioButtonMaximized.Checked ? ProcessWindowStyle.Maximized : radioButtonMinimized.Checked ? ProcessWindowStyle.Minimized : ProcessWindowStyle.Hidden;
            try
            {
                Process.Start(procStart);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
        private void buttonKillProc_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] procs = Process.GetProcessesByName(textBoxKillProcName.Text);
                foreach (var proc in procs)
                {
                    proc.Kill();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        #endregion

        #region Process information events
        private void textBoxStartProcName_TextChanged(object sender, EventArgs e)
        {
            buttonStartTask.Enabled = textBoxStartProcName.TextLength > 0 ? true : false;
        }

        private void textBoxKillProcName_TextChanged(object sender, EventArgs e)
        {
            buttonKillProc.Enabled = textBoxKillProcName.Text.Length > 0 ? true : false;
        }

        #endregion

        private void buttonKillProcess_Click(object sender, EventArgs e)
        {
            OnProcessKilled(this, EventArgs.Empty);
        }

        private void textBoxSearchProcess_TextChanged(object sender, EventArgs e)
        {
            buttonSearchProcess.Enabled = textBoxSearchProcess.TextLength > 0 ? true : false;
        }
    }



}
// Helper class 
public class ControlInvokeRequired
{
    public static bool invoke(Control c, Action a)
    {
        if (c.InvokeRequired)
        {
            c.Invoke(new MethodInvoker(delegate { a(); }));
            return true;
        }
        return false;
    }
}

