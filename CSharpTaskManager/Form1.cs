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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ContextMenu _contextMenu = default(ContextMenu);

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Event Subscription
            ProcessUpdater.OnProcessKilled += ProcessUpdater_OnProcessKilled;
            ProcessUpdater.OnProcessUpdated += ProcessUpdater_OnProcessUpdated;
            ProcessUpdater.OnFailure += ProcessUpdater_OnFailure;
            #endregion
            MenuItem[] menuItems = new MenuItem[]
            {
                new MenuItem("Kill", OnProcessKilled)
            };
            _contextMenu = new ContextMenu(menuItems);

            UpdateListViewItems(listViewProcesses);


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



            new Task(() =>
            {
                while (true)
                {
                    Process[] procs = Process.GetProcesses();
                    foreach (Process proc in procs)
                    {
                        var listViewItem = new ListViewItem(new string[] { proc.ProcessName, proc.WorkingSet64.ToString(), proc.Id.ToString() });
                        listViewItem.Tag = proc.Id;
                        if (listViewProcesses.InvokeRequired)
                        {
                            ControlInvokeRequired(listView, new Action(() =>
                            {
                                if (listView.Items.Find(listViewItem.Tag.ToString(), true).Length == 0)
                                    listView.Items.Add(listViewItem);
                                else
                                    Debug.WriteLine($"Attemping to add LVI that already exists {listViewItem}");
                            }));
                        }
                        else
                            listView.Items.Add(listViewItem);
                    }

                    if (listView.InvokeRequired)
                    {
                        ControlInvokeRequired(listView, new Action(() =>
                        {
                            try
                            {
                                foreach (ListViewItem lvi in listView.Items)
                                {
                                    var lviProc = Process.GetProcessesByName(lvi.SubItems[0].Text);

                                    //long mem = 0;
                                    //foreach (Process proc in lviProc)
                                    //{
                                    //    mem += proc.WorkingSet64;
                                    //}
                                    if (lvi.SubItems.Count > 0 && lviProc.Length >= 0)
                                    {
                                        //Debug.WriteLine(lviProc[0]);
                                        lvi.SubItems[1] = new ListViewItem.ListViewSubItem(null, lviProc[0].WorkingSet64.ToString());
                                        //Debug.WriteLine(lvi.SubItems[1] + " set to " + lviProc[0].WorkingSet64);
                                    }
                                    else
                                    {
                                        //Debug.WriteLine(lvi.Name + ":" + lvi.SubItems.Count + ", " + lviProc.Length);
                                    }
                                    //Debug.WriteLine("end");

                                }
                            }
                            catch (InvalidOperationException f)
                            {
                                Debug.WriteLine(f);
                            }
                        }));
                    }
                    else
                    {
                        foreach (ListViewItem lvi in listView.Items)
                        {
                            var lviProc = Process.GetProcessesByName(lvi.SubItems[0].Name);
                            Debug.WriteLine($"lvi.SubItems[0].Name => {lvi.SubItems[0].Name}");

                            long mem = 0;
                            foreach (Process proc in lviProc)
                            {
                                Debug.WriteLine($"Name[{proc.ProcessName}] Mem[{proc.WorkingSet64}]");
                                mem += proc.WorkingSet64;
                            }
                            Debug.WriteLine($"Setting {lvi.SubItems[1].Text} to {mem.ToString()}");
                            lvi.SubItems[1].Text = mem.ToString();
                        }
                    }
                    Debug.WriteLine("Sleeping to two seconds");
                    Thread.Sleep(10000);
                }
            }).Start();





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
