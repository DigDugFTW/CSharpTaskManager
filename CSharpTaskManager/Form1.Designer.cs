namespace CSharpTaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKillProcess = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageProcInfo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKillProc = new System.Windows.Forms.Button();
            this.textBoxKillProcName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonHidden = new System.Windows.Forms.RadioButton();
            this.radioButtonMaximized = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonMinimized = new System.Windows.Forms.RadioButton();
            this.buttonStartTask = new System.Windows.Forms.Button();
            this.textBoxProcArgs = new System.Windows.Forms.TextBox();
            this.textBoxStartProcName = new System.Windows.Forms.TextBox();
            this.tabPageServiceInfo = new System.Windows.Forms.TabPage();
            this.buttonRegisterService = new System.Windows.Forms.Button();
            this.buttonStopService = new System.Windows.Forms.Button();
            this.buttonStartService = new System.Windows.Forms.Button();
            this.labelServiceExecLocation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelServiceStartupType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelServiceStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageStartupInfo = new System.Windows.Forms.TabPage();
            this.listViewStartupInfo = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchProcess = new System.Windows.Forms.TextBox();
            this.buttonSearchProcess = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.tabPageProcInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageServiceInfo.SuspendLayout();
            this.tabPageStartupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKillProcess
            // 
            this.buttonKillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKillProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKillProcess.Location = new System.Drawing.Point(472, 397);
            this.buttonKillProcess.Name = "buttonKillProcess";
            this.buttonKillProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonKillProcess.TabIndex = 1;
            this.buttonKillProcess.Text = "End Task";
            this.buttonKillProcess.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageProcesses);
            this.tabControlMain.Controls.Add(this.tabPageProcInfo);
            this.tabControlMain.Controls.Add(this.tabPageServiceInfo);
            this.tabControlMain.Controls.Add(this.tabPageStartupInfo);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(561, 391);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.listViewProcesses);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(553, 365);
            this.tabPageProcesses.TabIndex = 0;
            this.tabPageProcesses.Text = "Processes";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.Location = new System.Drawing.Point(0, 0);
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(553, 365);
            this.listViewProcesses.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewProcesses.TabIndex = 0;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            this.listViewProcesses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProcesses_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Memory Usage";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PID";
            this.columnHeader3.Width = 125;
            // 
            // tabPageProcInfo
            // 
            this.tabPageProcInfo.Controls.Add(this.groupBox2);
            this.tabPageProcInfo.Controls.Add(this.groupBox1);
            this.tabPageProcInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcInfo.Name = "tabPageProcInfo";
            this.tabPageProcInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcInfo.Size = new System.Drawing.Size(553, 365);
            this.tabPageProcInfo.TabIndex = 1;
            this.tabPageProcInfo.Text = "Process information";
            this.tabPageProcInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonKillProc);
            this.groupBox2.Controls.Add(this.textBoxKillProcName);
            this.groupBox2.Location = new System.Drawing.Point(9, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 134);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kill Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Process Name";
            // 
            // buttonKillProc
            // 
            this.buttonKillProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKillProc.Location = new System.Drawing.Point(16, 61);
            this.buttonKillProc.Name = "buttonKillProc";
            this.buttonKillProc.Size = new System.Drawing.Size(170, 23);
            this.buttonKillProc.TabIndex = 2;
            this.buttonKillProc.Text = "Kill Process";
            this.buttonKillProc.UseVisualStyleBackColor = true;
            // 
            // textBoxKillProcName
            // 
            this.textBoxKillProcName.Location = new System.Drawing.Point(16, 35);
            this.textBoxKillProcName.Name = "textBoxKillProcName";
            this.textBoxKillProcName.Size = new System.Drawing.Size(170, 20);
            this.textBoxKillProcName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonHidden);
            this.groupBox1.Controls.Add(this.radioButtonMaximized);
            this.groupBox1.Controls.Add(this.radioButtonNormal);
            this.groupBox1.Controls.Add(this.radioButtonMinimized);
            this.groupBox1.Controls.Add(this.buttonStartTask);
            this.groupBox1.Controls.Add(this.textBoxProcArgs);
            this.groupBox1.Controls.Add(this.textBoxStartProcName);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arguments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Process Name";
            // 
            // radioButtonHidden
            // 
            this.radioButtonHidden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonHidden.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonHidden.AutoSize = true;
            this.radioButtonHidden.Location = new System.Drawing.Point(474, 102);
            this.radioButtonHidden.Name = "radioButtonHidden";
            this.radioButtonHidden.Size = new System.Drawing.Size(51, 23);
            this.radioButtonHidden.TabIndex = 6;
            this.radioButtonHidden.TabStop = true;
            this.radioButtonHidden.Text = "Hidden";
            this.radioButtonHidden.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaximized
            // 
            this.radioButtonMaximized.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonMaximized.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMaximized.AutoSize = true;
            this.radioButtonMaximized.Location = new System.Drawing.Point(459, 15);
            this.radioButtonMaximized.Name = "radioButtonMaximized";
            this.radioButtonMaximized.Size = new System.Drawing.Size(66, 23);
            this.radioButtonMaximized.TabIndex = 5;
            this.radioButtonMaximized.TabStop = true;
            this.radioButtonMaximized.Text = "Maximized";
            this.radioButtonMaximized.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(475, 73);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(50, 23);
            this.radioButtonNormal.TabIndex = 4;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinimized
            // 
            this.radioButtonMinimized.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonMinimized.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMinimized.AutoSize = true;
            this.radioButtonMinimized.Location = new System.Drawing.Point(462, 44);
            this.radioButtonMinimized.Name = "radioButtonMinimized";
            this.radioButtonMinimized.Size = new System.Drawing.Size(63, 23);
            this.radioButtonMinimized.TabIndex = 3;
            this.radioButtonMinimized.TabStop = true;
            this.radioButtonMinimized.Text = "Minimized";
            this.radioButtonMinimized.UseVisualStyleBackColor = true;
            // 
            // buttonStartTask
            // 
            this.buttonStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTask.Location = new System.Drawing.Point(16, 61);
            this.buttonStartTask.Name = "buttonStartTask";
            this.buttonStartTask.Size = new System.Drawing.Size(170, 23);
            this.buttonStartTask.TabIndex = 2;
            this.buttonStartTask.Text = "Start Task";
            this.buttonStartTask.UseVisualStyleBackColor = true;
            // 
            // textBoxProcArgs
            // 
            this.textBoxProcArgs.Location = new System.Drawing.Point(203, 35);
            this.textBoxProcArgs.Name = "textBoxProcArgs";
            this.textBoxProcArgs.Size = new System.Drawing.Size(170, 20);
            this.textBoxProcArgs.TabIndex = 1;
            // 
            // textBoxStartProcName
            // 
            this.textBoxStartProcName.Location = new System.Drawing.Point(16, 35);
            this.textBoxStartProcName.Name = "textBoxStartProcName";
            this.textBoxStartProcName.Size = new System.Drawing.Size(170, 20);
            this.textBoxStartProcName.TabIndex = 0;
            // 
            // tabPageServiceInfo
            // 
            this.tabPageServiceInfo.Controls.Add(this.buttonRegisterService);
            this.tabPageServiceInfo.Controls.Add(this.buttonStopService);
            this.tabPageServiceInfo.Controls.Add(this.buttonStartService);
            this.tabPageServiceInfo.Controls.Add(this.labelServiceExecLocation);
            this.tabPageServiceInfo.Controls.Add(this.label9);
            this.tabPageServiceInfo.Controls.Add(this.labelServiceStartupType);
            this.tabPageServiceInfo.Controls.Add(this.label7);
            this.tabPageServiceInfo.Controls.Add(this.labelServiceStatus);
            this.tabPageServiceInfo.Controls.Add(this.label3);
            this.tabPageServiceInfo.Controls.Add(this.listViewServices);
            this.tabPageServiceInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageServiceInfo.Name = "tabPageServiceInfo";
            this.tabPageServiceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServiceInfo.Size = new System.Drawing.Size(553, 365);
            this.tabPageServiceInfo.TabIndex = 2;
            this.tabPageServiceInfo.Text = "Service Info";
            this.tabPageServiceInfo.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterService
            // 
            this.buttonRegisterService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegisterService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterService.Location = new System.Drawing.Point(412, 331);
            this.buttonRegisterService.Name = "buttonRegisterService";
            this.buttonRegisterService.Size = new System.Drawing.Size(135, 23);
            this.buttonRegisterService.TabIndex = 9;
            this.buttonRegisterService.Text = "Register Service";
            this.buttonRegisterService.UseVisualStyleBackColor = true;
            // 
            // buttonStopService
            // 
            this.buttonStopService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopService.Location = new System.Drawing.Point(412, 302);
            this.buttonStopService.Name = "buttonStopService";
            this.buttonStopService.Size = new System.Drawing.Size(135, 23);
            this.buttonStopService.TabIndex = 8;
            this.buttonStopService.Text = "Stop Service";
            this.buttonStopService.UseVisualStyleBackColor = true;
            // 
            // buttonStartService
            // 
            this.buttonStartService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartService.Location = new System.Drawing.Point(412, 273);
            this.buttonStartService.Name = "buttonStartService";
            this.buttonStartService.Size = new System.Drawing.Size(135, 23);
            this.buttonStartService.TabIndex = 7;
            this.buttonStartService.Text = "Start Service";
            this.buttonStartService.UseVisualStyleBackColor = true;
            // 
            // labelServiceExecLocation
            // 
            this.labelServiceExecLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelServiceExecLocation.AutoSize = true;
            this.labelServiceExecLocation.Location = new System.Drawing.Point(93, 318);
            this.labelServiceExecLocation.Name = "labelServiceExecLocation";
            this.labelServiceExecLocation.Size = new System.Drawing.Size(19, 13);
            this.labelServiceExecLocation.TabIndex = 6;
            this.labelServiceExecLocation.Text = "__";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Exec. Location";
            // 
            // labelServiceStartupType
            // 
            this.labelServiceStartupType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelServiceStartupType.AutoSize = true;
            this.labelServiceStartupType.Location = new System.Drawing.Point(79, 292);
            this.labelServiceStartupType.Name = "labelServiceStartupType";
            this.labelServiceStartupType.Size = new System.Drawing.Size(19, 13);
            this.labelServiceStartupType.TabIndex = 4;
            this.labelServiceStartupType.Text = "__";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Startup type";
            // 
            // labelServiceStatus
            // 
            this.labelServiceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelServiceStatus.AutoSize = true;
            this.labelServiceStatus.Location = new System.Drawing.Point(53, 270);
            this.labelServiceStatus.Name = "labelServiceStatus";
            this.labelServiceStatus.Size = new System.Drawing.Size(19, 13);
            this.labelServiceStatus.TabIndex = 2;
            this.labelServiceStatus.Text = "__";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // listViewServices
            // 
            this.listViewServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewServices.FullRowSelect = true;
            this.listViewServices.Location = new System.Drawing.Point(0, 0);
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(553, 263);
            this.listViewServices.TabIndex = 0;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Location";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            // 
            // tabPageStartupInfo
            // 
            this.tabPageStartupInfo.Controls.Add(this.listViewStartupInfo);
            this.tabPageStartupInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartupInfo.Name = "tabPageStartupInfo";
            this.tabPageStartupInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartupInfo.Size = new System.Drawing.Size(553, 365);
            this.tabPageStartupInfo.TabIndex = 3;
            this.tabPageStartupInfo.Text = "Startup Info";
            this.tabPageStartupInfo.UseVisualStyleBackColor = true;
            // 
            // listViewStartupInfo
            // 
            this.listViewStartupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStartupInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewStartupInfo.FullRowSelect = true;
            this.listViewStartupInfo.Location = new System.Drawing.Point(0, 0);
            this.listViewStartupInfo.Name = "listViewStartupInfo";
            this.listViewStartupInfo.Size = new System.Drawing.Size(553, 365);
            this.listViewStartupInfo.TabIndex = 1;
            this.listViewStartupInfo.UseCompatibleStateImageBehavior = false;
            this.listViewStartupInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Location";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Status";
            // 
            // textBoxSearchProcess
            // 
            this.textBoxSearchProcess.Location = new System.Drawing.Point(4, 397);
            this.textBoxSearchProcess.Name = "textBoxSearchProcess";
            this.textBoxSearchProcess.Size = new System.Drawing.Size(191, 20);
            this.textBoxSearchProcess.TabIndex = 3;
            // 
            // buttonSearchProcess
            // 
            this.buttonSearchProcess.Location = new System.Drawing.Point(201, 395);
            this.buttonSearchProcess.Name = "buttonSearchProcess";
            this.buttonSearchProcess.Size = new System.Drawing.Size(130, 23);
            this.buttonSearchProcess.TabIndex = 4;
            this.buttonSearchProcess.Text = "Find Process";
            this.buttonSearchProcess.UseVisualStyleBackColor = true;
            this.buttonSearchProcess.Click += new System.EventHandler(this.buttonSearchProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 429);
            this.Controls.Add(this.buttonSearchProcess);
            this.Controls.Add(this.textBoxSearchProcess);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonKillProcess);
            this.MinimumSize = new System.Drawing.Size(575, 468);
            this.Name = "Form1";
            this.Text = "CSharp Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tabPageProcInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageServiceInfo.ResumeLayout(false);
            this.tabPageServiceInfo.PerformLayout();
            this.tabPageStartupInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKillProcess;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProcesses;
        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPageProcInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKillProc;
        private System.Windows.Forms.TextBox textBoxKillProcName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonHidden;
        private System.Windows.Forms.RadioButton radioButtonMaximized;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonMinimized;
        private System.Windows.Forms.Button buttonStartTask;
        private System.Windows.Forms.TextBox textBoxProcArgs;
        private System.Windows.Forms.TextBox textBoxStartProcName;
        private System.Windows.Forms.TabPage tabPageServiceInfo;
        private System.Windows.Forms.Button buttonRegisterService;
        private System.Windows.Forms.Button buttonStopService;
        private System.Windows.Forms.Button buttonStartService;
        private System.Windows.Forms.Label labelServiceExecLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelServiceStartupType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelServiceStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPageStartupInfo;
        private System.Windows.Forms.ListView listViewStartupInfo;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox textBoxSearchProcess;
        private System.Windows.Forms.Button buttonSearchProcess;
    }
}

