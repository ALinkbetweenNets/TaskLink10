namespace TaskLink10Server
{
    partial class FormServer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.buttonSPSet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonIPLoad = new System.Windows.Forms.Button();
            this.buttonIPClear = new System.Windows.Forms.Button();
            this.buttonIPAdd = new System.Windows.Forms.Button();
            this.listBoxProc = new System.Windows.Forms.ListBox();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.buttonIPRemove = new System.Windows.Forms.Button();
            this.buttonIPSave = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSPSave = new System.Windows.Forms.Button();
            this.buttonProcKill = new System.Windows.Forms.Button();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.buttonLocalIPRefresh = new System.Windows.Forms.Button();
            this.labelLocalIP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSPSet
            // 
            this.buttonSPSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSPSet.AutoSize = true;
            this.buttonSPSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSPSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonSPSet, 2);
            this.buttonSPSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSPSet.Location = new System.Drawing.Point(3, 3);
            this.buttonSPSet.Name = "buttonSPSet";
            this.buttonSPSet.Size = new System.Drawing.Size(232, 30);
            this.buttonSPSet.TabIndex = 0;
            this.buttonSPSet.Text = "Set Session Password";
            this.buttonSPSet.UseVisualStyleBackColor = true;
            this.buttonSPSet.Click += new System.EventHandler(this.buttonSPSet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.buttonIPLoad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonSPSet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonIPClear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonIPAdd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxProc, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxIP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonIPRemove, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonIPSave, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLog, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonConnect, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSPSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonProcKill, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonLogClear, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonLocalIPRefresh, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLocalIP, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 482);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonIPLoad
            // 
            this.buttonIPLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIPLoad.AutoSize = true;
            this.buttonIPLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIPLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIPLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonIPLoad.Location = new System.Drawing.Point(122, 448);
            this.buttonIPLoad.Name = "buttonIPLoad";
            this.buttonIPLoad.Size = new System.Drawing.Size(113, 31);
            this.buttonIPLoad.TabIndex = 8;
            this.buttonIPLoad.Text = "Load IPs";
            this.buttonIPLoad.UseVisualStyleBackColor = true;
            this.buttonIPLoad.Click += new System.EventHandler(this.buttonIPLoad_Click);
            // 
            // buttonIPClear
            // 
            this.buttonIPClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIPClear.AutoSize = true;
            this.buttonIPClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIPClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIPClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonIPClear.Location = new System.Drawing.Point(122, 412);
            this.buttonIPClear.Name = "buttonIPClear";
            this.buttonIPClear.Size = new System.Drawing.Size(113, 30);
            this.buttonIPClear.TabIndex = 6;
            this.buttonIPClear.Text = "Clear IPs";
            this.buttonIPClear.UseVisualStyleBackColor = true;
            this.buttonIPClear.Click += new System.EventHandler(this.buttonIPClear_Click);
            // 
            // buttonIPAdd
            // 
            this.buttonIPAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIPAdd.AutoSize = true;
            this.buttonIPAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIPAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonIPAdd, 2);
            this.buttonIPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonIPAdd.Location = new System.Drawing.Point(3, 39);
            this.buttonIPAdd.Name = "buttonIPAdd";
            this.buttonIPAdd.Size = new System.Drawing.Size(232, 30);
            this.buttonIPAdd.TabIndex = 3;
            this.buttonIPAdd.Text = "Add Client IP";
            this.buttonIPAdd.UseVisualStyleBackColor = true;
            this.buttonIPAdd.Click += new System.EventHandler(this.buttonIPAdd_Click);
            // 
            // listBoxProc
            // 
            this.listBoxProc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProc.FormattingEnabled = true;
            this.listBoxProc.Location = new System.Drawing.Point(241, 75);
            this.listBoxProc.Name = "listBoxProc";
            this.listBoxProc.ScrollAlwaysVisible = true;
            this.listBoxProc.Size = new System.Drawing.Size(232, 329);
            this.listBoxProc.Sorted = true;
            this.listBoxProc.TabIndex = 10;
            // 
            // listBoxIP
            // 
            this.listBoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxIP, 2);
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.Location = new System.Drawing.Point(3, 75);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.ScrollAlwaysVisible = true;
            this.listBoxIP.Size = new System.Drawing.Size(232, 329);
            this.listBoxIP.Sorted = true;
            this.listBoxIP.TabIndex = 9;
            // 
            // buttonIPRemove
            // 
            this.buttonIPRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIPRemove.AutoSize = true;
            this.buttonIPRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIPRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIPRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonIPRemove.Location = new System.Drawing.Point(3, 412);
            this.buttonIPRemove.Name = "buttonIPRemove";
            this.buttonIPRemove.Size = new System.Drawing.Size(113, 30);
            this.buttonIPRemove.TabIndex = 5;
            this.buttonIPRemove.Text = "Remove IP";
            this.buttonIPRemove.UseVisualStyleBackColor = true;
            this.buttonIPRemove.Click += new System.EventHandler(this.buttonIPRemove_Click);
            // 
            // buttonIPSave
            // 
            this.buttonIPSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIPSave.AutoSize = true;
            this.buttonIPSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIPSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIPSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonIPSave.Location = new System.Drawing.Point(3, 448);
            this.buttonIPSave.Name = "buttonIPSave";
            this.buttonIPSave.Size = new System.Drawing.Size(113, 31);
            this.buttonIPSave.TabIndex = 7;
            this.buttonIPSave.Text = "Save IPs";
            this.buttonIPSave.UseVisualStyleBackColor = true;
            this.buttonIPSave.Click += new System.EventHandler(this.buttonIPSave_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(479, 75);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(314, 331);
            this.textBoxLog.TabIndex = 11;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.AutoSize = true;
            this.buttonConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonConnect.Location = new System.Drawing.Point(241, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(232, 30);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSPSave
            // 
            this.buttonSPSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSPSave.AutoSize = true;
            this.buttonSPSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSPSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSPSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSPSave.Location = new System.Drawing.Point(241, 3);
            this.buttonSPSave.Name = "buttonSPSave";
            this.buttonSPSave.Size = new System.Drawing.Size(232, 30);
            this.buttonSPSave.TabIndex = 2;
            this.buttonSPSave.Text = "Save Session Password";
            this.buttonSPSave.UseVisualStyleBackColor = true;
            this.buttonSPSave.Click += new System.EventHandler(this.buttonSPSave_Click);
            // 
            // buttonProcKill
            // 
            this.buttonProcKill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcKill.AutoSize = true;
            this.buttonProcKill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProcKill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonProcKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonProcKill.Location = new System.Drawing.Point(241, 412);
            this.buttonProcKill.Name = "buttonProcKill";
            this.buttonProcKill.Size = new System.Drawing.Size(232, 30);
            this.buttonProcKill.TabIndex = 12;
            this.buttonProcKill.Text = "End Process";
            this.buttonProcKill.UseVisualStyleBackColor = true;
            this.buttonProcKill.Click += new System.EventHandler(this.buttonProcKill_Click);
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogClear.AutoSize = true;
            this.buttonLogClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonLogClear.Location = new System.Drawing.Point(479, 412);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(314, 30);
            this.buttonLogClear.TabIndex = 13;
            this.buttonLogClear.Text = "Clear Log";
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.buttonLogClear_Click);
            // 
            // buttonLocalIPRefresh
            // 
            this.buttonLocalIPRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLocalIPRefresh.AutoSize = true;
            this.buttonLocalIPRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLocalIPRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLocalIPRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonLocalIPRefresh.Location = new System.Drawing.Point(479, 3);
            this.buttonLocalIPRefresh.Name = "buttonLocalIPRefresh";
            this.buttonLocalIPRefresh.Size = new System.Drawing.Size(314, 30);
            this.buttonLocalIPRefresh.TabIndex = 14;
            this.buttonLocalIPRefresh.Text = "Refresh Local IP";
            this.buttonLocalIPRefresh.UseVisualStyleBackColor = true;
            this.buttonLocalIPRefresh.Click += new System.EventHandler(this.buttonLocalIPRefresh_Click);
            // 
            // labelLocalIP
            // 
            this.labelLocalIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocalIP.AutoEllipsis = true;
            this.labelLocalIP.AutoSize = true;
            this.labelLocalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalIP.Location = new System.Drawing.Point(479, 36);
            this.labelLocalIP.Name = "labelLocalIP";
            this.labelLocalIP.Size = new System.Drawing.Size(314, 36);
            this.labelLocalIP.TabIndex = 15;
            this.labelLocalIP.Text = "Local IP: ";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServer";
            this.Text = "TaskLink 10 Server";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSPSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonIPSave;
        private System.Windows.Forms.Button buttonIPLoad;
        private System.Windows.Forms.Button buttonIPClear;
        private System.Windows.Forms.Button buttonSPSave;
        private System.Windows.Forms.Button buttonIPAdd;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.ListBox listBoxProc;
        private System.Windows.Forms.Button buttonIPRemove;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonProcKill;
        private System.Windows.Forms.Button buttonLogClear;
        private System.Windows.Forms.Button buttonLocalIPRefresh;
        private System.Windows.Forms.Label labelLocalIP;
    }
}

