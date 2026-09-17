namespace LiveSplit.Portal2Split
{
    partial class Portal2SplitSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbMapBlacklist = new LiveSplit.Portal2Split.EditableListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAutoSplitEnabled = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoWhitelist = new System.Windows.Forms.RadioButton();
            this.lblMaps = new System.Windows.Forms.Label();
            this.rdoInterval = new System.Windows.Forms.RadioButton();
            this.dmnSplitInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbMapWhitelist = new LiveSplit.Portal2Split.EditableListBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpAutoStartEndReset = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMisc = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowMapTimes = new System.Windows.Forms.Button();
            this.chkShowGameTime = new System.Windows.Forms.CheckBox();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkAutoStartEndReset = new System.Windows.Forms.CheckBox();
            this.gbAutoStartEndReset = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbMapBlacklist)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSplitInterval)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbMapWhitelist)).BeginInit();
            this.tlpAutoStartEndReset.SuspendLayout();
            this.tlpMisc.SuspendLayout();
            this.gbMisc.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbAutoStartEndReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 100;
            // 
            // groupBox1
            // 
            this.tlpAutoStartEndReset.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 157);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Split";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkAutoSplitEnabled, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 138);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbMapBlacklist);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(225, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 102);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Map Blacklist";
            // 
            // lbMapBlacklist
            // 
            this.lbMapBlacklist.AllowUserToResizeRows = false;
            this.lbMapBlacklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lbMapBlacklist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.lbMapBlacklist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMapBlacklist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lbMapBlacklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.lbMapBlacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lbMapBlacklist.ColumnHeadersVisible = false;
            this.lbMapBlacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lbMapBlacklist.DefaultCellStyle = dataGridViewCellStyle14;
            this.lbMapBlacklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMapBlacklist.Location = new System.Drawing.Point(3, 16);
            this.lbMapBlacklist.Name = "lbMapBlacklist";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lbMapBlacklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.lbMapBlacklist.RowHeadersVisible = false;
            this.lbMapBlacklist.RowTemplate.Height = 14;
            this.lbMapBlacklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lbMapBlacklist.Size = new System.Drawing.Size(210, 83);
            this.lbMapBlacklist.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // chkAutoSplitEnabled
            // 
            this.chkAutoSplitEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSplitEnabled.AutoSize = true;
            this.chkAutoSplitEnabled.Location = new System.Drawing.Point(3, 6);
            this.chkAutoSplitEnabled.Name = "chkAutoSplitEnabled";
            this.chkAutoSplitEnabled.Size = new System.Drawing.Size(216, 17);
            this.chkAutoSplitEnabled.TabIndex = 5;
            this.chkAutoSplitEnabled.Text = "Enabled";
            this.chkAutoSplitEnabled.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.rdoWhitelist, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblMaps, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdoInterval, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dmnSplitInterval, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(225, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(216, 24);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // rdoWhitelist
            // 
            this.rdoWhitelist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoWhitelist.AutoSize = true;
            this.rdoWhitelist.Location = new System.Drawing.Point(3, 3);
            this.rdoWhitelist.Name = "rdoWhitelist";
            this.rdoWhitelist.Size = new System.Drawing.Size(65, 17);
            this.rdoWhitelist.TabIndex = 18;
            this.rdoWhitelist.Text = "Whitelist";
            this.rdoWhitelist.UseVisualStyleBackColor = true;
            // 
            // lblMaps
            // 
            this.lblMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaps.AutoSize = true;
            this.lblMaps.Location = new System.Drawing.Point(173, 5);
            this.lblMaps.Name = "lblMaps";
            this.lblMaps.Size = new System.Drawing.Size(40, 13);
            this.lblMaps.TabIndex = 11;
            this.lblMaps.Text = "maps";
            // 
            // rdoInterval
            // 
            this.rdoInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoInterval.AutoSize = true;
            this.rdoInterval.Checked = true;
            this.rdoInterval.Location = new System.Drawing.Point(74, 3);
            this.rdoInterval.Name = "rdoInterval";
            this.rdoInterval.Size = new System.Drawing.Size(52, 17);
            this.rdoInterval.TabIndex = 17;
            this.rdoInterval.TabStop = true;
            this.rdoInterval.Text = "Every";
            this.rdoInterval.UseVisualStyleBackColor = true;
            // 
            // dmnSplitInterval
            // 
            this.dmnSplitInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dmnSplitInterval.Enabled = false;
            this.dmnSplitInterval.Location = new System.Drawing.Point(132, 3);
            this.dmnSplitInterval.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.dmnSplitInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dmnSplitInterval.Name = "dmnSplitInterval";
            this.dmnSplitInterval.Size = new System.Drawing.Size(35, 20);
            this.dmnSplitInterval.TabIndex = 10;
            this.dmnSplitInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbMapWhitelist);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 102);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Map Whitelist";
            // 
            // lbMapWhitelist
            // 
            this.lbMapWhitelist.AllowUserToResizeRows = false;
            this.lbMapWhitelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lbMapWhitelist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.lbMapWhitelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMapWhitelist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lbMapWhitelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.lbMapWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lbMapWhitelist.ColumnHeadersVisible = false;
            this.lbMapWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lbMapWhitelist.DefaultCellStyle = dataGridViewCellStyle17;
            this.lbMapWhitelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMapWhitelist.Location = new System.Drawing.Point(3, 16);
            this.lbMapWhitelist.Name = "lbMapWhitelist";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lbMapWhitelist.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.lbMapWhitelist.RowHeadersVisible = false;
            this.lbMapWhitelist.RowTemplate.Height = 14;
            this.lbMapWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lbMapWhitelist.Size = new System.Drawing.Size(210, 83);
            this.lbMapWhitelist.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // tlpAutoStartEndReset
            // 
            this.tlpAutoStartEndReset.ColumnCount = 2;
            this.tlpAutoStartEndReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tlpAutoStartEndReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAutoStartEndReset.Controls.Add(this.gbMisc, 1, 1);
            this.tlpAutoStartEndReset.Controls.Add(this.groupBox1, 0, 0);
            this.tlpAutoStartEndReset.Controls.Add(this.gbAutoStartEndReset, 0, 1);
            this.tlpAutoStartEndReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAutoStartEndReset.Location = new System.Drawing.Point(7, 7);
            this.tlpAutoStartEndReset.Name = "tlpAutoStartEndReset";
            this.tlpAutoStartEndReset.RowCount = 3;
            this.tlpAutoStartEndReset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tlpAutoStartEndReset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tlpAutoStartEndReset.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAutoStartEndReset.Size = new System.Drawing.Size(456, 435);
            this.tlpAutoStartEndReset.TabIndex = 13;
            // 
            // tlpMisc
            // 
            this.tlpMisc.ColumnCount = 1;
            this.tlpMisc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMisc.Controls.Add(this.chkShowGameTime, 0, 0);
            this.tlpMisc.Controls.Add(this.btnShowMapTimes, 0, 1);
            this.tlpMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMisc.Location = new System.Drawing.Point(3, 16);
            this.tlpMisc.Name = "tlpMisc";
            this.tlpMisc.RowCount = 3;
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMisc.Size = new System.Drawing.Size(216, 86);
            this.tlpMisc.TabIndex = 0;
            // 
            // btnShowMapTimes
            // 
            this.btnShowMapTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowMapTimes.Location = new System.Drawing.Point(3, 26);
            this.btnShowMapTimes.Name = "btnShowMapTimes";
            this.btnShowMapTimes.Size = new System.Drawing.Size(210, 25);
            this.btnShowMapTimes.TabIndex = 20;
            this.btnShowMapTimes.Text = "Show Map Times";
            this.btnShowMapTimes.UseVisualStyleBackColor = true;
            // 
            // chkShowGameTime
            // 
            this.chkShowGameTime.AutoSize = true;
            this.chkShowGameTime.Location = new System.Drawing.Point(3, 3);
            this.chkShowGameTime.Name = "chkShowGameTime";
            this.chkShowGameTime.Size = new System.Drawing.Size(187, 17);
            this.chkShowGameTime.TabIndex = 12;
            this.chkShowGameTime.Text = "Show alternate timing method time";
            this.chkShowGameTime.UseVisualStyleBackColor = true;
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.tlpMisc);
            this.gbMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMisc.Location = new System.Drawing.Point(231, 166);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(222, 105);
            this.gbMisc.TabIndex = 15;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Misc.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.chkAutoStartEndReset, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(216, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chkAutoStartEndReset
            // 
            this.chkAutoStartEndReset.AutoSize = true;
            this.chkAutoStartEndReset.Location = new System.Drawing.Point(3, 3);
            this.chkAutoStartEndReset.Name = "chkAutoStartEndReset";
            this.chkAutoStartEndReset.Size = new System.Drawing.Size(65, 17);
            this.chkAutoStartEndReset.TabIndex = 0;
            this.chkAutoStartEndReset.Text = "Enabled";
            this.chkAutoStartEndReset.UseVisualStyleBackColor = true;
            // 
            // gbAutoStartEndReset
            // 
            this.gbAutoStartEndReset.Controls.Add(this.tableLayoutPanel2);
            this.gbAutoStartEndReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAutoStartEndReset.Location = new System.Drawing.Point(3, 166);
            this.gbAutoStartEndReset.Name = "gbAutoStartEndReset";
            this.gbAutoStartEndReset.Size = new System.Drawing.Size(222, 105);
            this.gbAutoStartEndReset.TabIndex = 13;
            this.gbAutoStartEndReset.TabStop = false;
            this.gbAutoStartEndReset.Text = "Auto Start / End / Reset";
            // 
            // Portal2SplitSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpAutoStartEndReset);
            this.Name = "Portal2SplitSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(470, 449);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbMapBlacklist)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSplitInterval)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbMapWhitelist)).EndInit();
            this.tlpAutoStartEndReset.ResumeLayout(false);
            this.tlpMisc.ResumeLayout(false);
            this.tlpMisc.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbAutoStartEndReset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpAutoStartEndReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private EditableListBox lbMapBlacklist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox chkAutoSplitEnabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rdoWhitelist;
        private System.Windows.Forms.Label lblMaps;
        private System.Windows.Forms.RadioButton rdoInterval;
        private System.Windows.Forms.NumericUpDown dmnSplitInterval;
        private System.Windows.Forms.GroupBox groupBox3;
        private EditableListBox lbMapWhitelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.TableLayoutPanel tlpMisc;
        private System.Windows.Forms.CheckBox chkShowGameTime;
        private System.Windows.Forms.Button btnShowMapTimes;
        private System.Windows.Forms.GroupBox gbAutoStartEndReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkAutoStartEndReset;
    }
}
