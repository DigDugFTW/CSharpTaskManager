﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
//using System.Windows.Forms;
namespace CSTM_Tests
{
    class ProcessUpdater
    {
        public delegate void ProcessUpdateHandler(object sender, ProcessUpdaterEventArgs e);
        public static event ProcessUpdateHandler OnProcessUpdated;
        public static event ProcessUpdateHandler OnProcessKilled;
        public static event ProcessUpdateHandler OnFailure;


        public static void KillProc(Process proc)
        {
            try
            {
                proc.Kill();
                OnProcessKilled(null , new ProcessUpdaterEventArgs(proc));
            }catch(Exception e)
            {
                OnFailure(null , new ProcessUpdaterEventArgs(proc, e));
            }
        }
        //public static void UpdateProc(int PID, ListView listView)
        //{

            
        //    foreach(ListViewItem row in listView.Items)
        //    {

        //    }

        //    OnProcessUpdated(null, new ProcessUpdaterEventArgs(proc));
        //}

    }
}
