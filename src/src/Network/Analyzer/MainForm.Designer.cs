﻿namespace MUnique.OpenMU.Network.Analyzer
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.packetGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.packetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataTextBox = new System.Windows.Forms.TextBox();
            this.packetInfoGroup = new System.Windows.Forms.GroupBox();
            this.extractedInfoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.targetPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.targetHostTextBox = new System.Windows.Forms.TextBox();
            this.listenerPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnStartProxy = new System.Windows.Forms.Button();
            this.clientVersionComboBox = new System.Windows.Forms.ComboBox();
            this.connectedClientsGroup = new System.Windows.Forms.GroupBox();
            this.connectedClientsListBox = new System.Windows.Forms.ListBox();
            this.connectionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPacketSenderStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trafficGroup = new System.Windows.Forms.GroupBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.packetGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).BeginInit();
            this.packetInfoGroup.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetPortNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenerPortNumericUpDown)).BeginInit();
            this.connectedClientsGroup.SuspendLayout();
            this.connectionContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.trafficGroup.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // packetGridView
            // 
            this.packetGridView.AllowUserToAddRows = false;
            this.packetGridView.AllowUserToOrderColumns = true;
            this.packetGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packetGridView.AutoGenerateColumns = false;
            this.packetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packetGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Timestamp,
            this.PacketSize,
            this.Type,
            this.Code,
            this.Direction,
            this.PacketData});
            this.packetGridView.DataSource = this.packetBindingSource;
            this.packetGridView.FilterAndSortEnabled = true;
            this.packetGridView.Location = new System.Drawing.Point(4, 18);
            this.packetGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.packetGridView.MultiSelect = false;
            this.packetGridView.Name = "packetGridView";
            this.packetGridView.ReadOnly = true;
            this.packetGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.packetGridView.RowHeadersWidth = 20;
            this.packetGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.packetGridView.Size = new System.Drawing.Size(595, 689);
            this.packetGridView.TabIndex = 27;
            this.packetGridView.SelectionChanged += new System.EventHandler(this.OnPacketSelected);
            // 
            // packetBindingSource
            // 
            this.packetBindingSource.AllowNew = false;
            // 
            // rawDataTextBox
            // 
            this.rawDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rawDataTextBox.Location = new System.Drawing.Point(7, 320);
            this.rawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rawDataTextBox.Multiline = true;
            this.rawDataTextBox.Name = "rawDataTextBox";
            this.rawDataTextBox.ReadOnly = true;
            this.rawDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawDataTextBox.Size = new System.Drawing.Size(412, 363);
            this.rawDataTextBox.TabIndex = 29;
            // 
            // packetInfoGroup
            // 
            this.packetInfoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packetInfoGroup.Controls.Add(this.extractedInfoTextBox);
            this.packetInfoGroup.Controls.Add(this.label3);
            this.packetInfoGroup.Controls.Add(this.label1);
            this.packetInfoGroup.Controls.Add(this.rawDataTextBox);
            this.packetInfoGroup.Location = new System.Drawing.Point(605, 18);
            this.packetInfoGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.packetInfoGroup.Name = "packetInfoGroup";
            this.packetInfoGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.packetInfoGroup.Size = new System.Drawing.Size(427, 689);
            this.packetInfoGroup.TabIndex = 30;
            this.packetInfoGroup.TabStop = false;
            this.packetInfoGroup.Text = "Packet Info";
            // 
            // extractedInfoTextBox
            // 
            this.extractedInfoTextBox.Location = new System.Drawing.Point(7, 37);
            this.extractedInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.extractedInfoTextBox.Multiline = true;
            this.extractedInfoTextBox.Name = "extractedInfoTextBox";
            this.extractedInfoTextBox.ReadOnly = true;
            this.extractedInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.extractedInfoTextBox.Size = new System.Drawing.Size(412, 230);
            this.extractedInfoTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Extracted Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Raw Data:";
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.targetPortNumericUpDown);
            this.settingsGroup.Controls.Add(this.label6);
            this.settingsGroup.Controls.Add(this.label7);
            this.settingsGroup.Controls.Add(this.label4);
            this.settingsGroup.Controls.Add(this.label8);
            this.settingsGroup.Controls.Add(this.targetHostTextBox);
            this.settingsGroup.Controls.Add(this.listenerPortNumericUpDown);
            this.settingsGroup.Controls.Add(this.btnStartProxy);
            this.settingsGroup.Controls.Add(this.clientVersionComboBox);
            this.settingsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsGroup.Location = new System.Drawing.Point(0, 0);
            this.settingsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsGroup.Size = new System.Drawing.Size(233, 185);
            this.settingsGroup.TabIndex = 32;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // targetPortNumericUpDown
            // 
            this.targetPortNumericUpDown.Location = new System.Drawing.Point(85, 52);
            this.targetPortNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.targetPortNumericUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.targetPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetPortNumericUpDown.Name = "targetPortNumericUpDown";
            this.targetPortNumericUpDown.Size = new System.Drawing.Size(92, 23);
            this.targetPortNumericUpDown.TabIndex = 3;
            this.targetPortNumericUpDown.Value = new decimal(new int[] {
            55901,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Target IP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(7, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Target Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Local Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(7, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "MU Version:";
            // 
            // targetHostTextBox
            // 
            this.targetHostTextBox.Location = new System.Drawing.Point(85, 22);
            this.targetHostTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.targetHostTextBox.MaxLength = 15;
            this.targetHostTextBox.Name = "targetHostTextBox";
            this.targetHostTextBox.Size = new System.Drawing.Size(110, 23);
            this.targetHostTextBox.TabIndex = 1;
            this.targetHostTextBox.Text = "127.127.127.127";
            // 
            // listenerPortNumericUpDown
            // 
            this.listenerPortNumericUpDown.Location = new System.Drawing.Point(85, 82);
            this.listenerPortNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listenerPortNumericUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.listenerPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listenerPortNumericUpDown.Name = "listenerPortNumericUpDown";
            this.listenerPortNumericUpDown.Size = new System.Drawing.Size(92, 23);
            this.listenerPortNumericUpDown.TabIndex = 3;
            this.listenerPortNumericUpDown.Value = new decimal(new int[] {
            55900,
            0,
            0,
            0});
            // 
            // btnStartProxy
            // 
            this.btnStartProxy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartProxy.Location = new System.Drawing.Point(85, 142);
            this.btnStartProxy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartProxy.Name = "btnStartProxy";
            this.btnStartProxy.Size = new System.Drawing.Size(92, 27);
            this.btnStartProxy.TabIndex = 5;
            this.btnStartProxy.Text = "Start Proxy";
            this.btnStartProxy.UseVisualStyleBackColor = true;
            this.btnStartProxy.Click += new System.EventHandler(this.StartProxy);
            // 
            // clientVersionComboBox
            // 
            this.clientVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientVersionComboBox.Location = new System.Drawing.Point(85, 112);
            this.clientVersionComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clientVersionComboBox.Name = "clientVersionComboBox";
            this.clientVersionComboBox.Size = new System.Drawing.Size(116, 23);
            this.clientVersionComboBox.TabIndex = 4;
            // 
            // connectedClientsGroup
            // 
            this.connectedClientsGroup.Controls.Add(this.connectedClientsListBox);
            this.connectedClientsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedClientsGroup.Location = new System.Drawing.Point(0, 185);
            this.connectedClientsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectedClientsGroup.Name = "connectedClientsGroup";
            this.connectedClientsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectedClientsGroup.Size = new System.Drawing.Size(233, 529);
            this.connectedClientsGroup.TabIndex = 33;
            this.connectedClientsGroup.TabStop = false;
            this.connectedClientsGroup.Text = "Connected Clients";
            // 
            // connectedClientsListBox
            // 
            this.connectedClientsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.connectedClientsListBox.ContextMenuStrip = this.connectionContextMenu;
            this.connectedClientsListBox.DataSource = this.clientBindingSource;
            this.connectedClientsListBox.FormattingEnabled = true;
            this.connectedClientsListBox.ItemHeight = 15;
            this.connectedClientsListBox.Location = new System.Drawing.Point(4, 18);
            this.connectedClientsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectedClientsListBox.Name = "connectedClientsListBox";
            this.connectedClientsListBox.Size = new System.Drawing.Size(229, 499);
            this.connectedClientsListBox.TabIndex = 0;
            this.connectedClientsListBox.SelectedIndexChanged += new System.EventHandler(this.OnConnectionSelected);
            // 
            // connectionContextMenu
            // 
            this.connectionContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openPacketSenderStripMenuItem});
            this.connectionContextMenu.Name = "connectionContextMenu";
            this.connectionContextMenu.Size = new System.Drawing.Size(149, 92);
            this.connectionContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnBeforeContextMenuOpens);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.OnDisconnectClientClick);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadToolStripMenuItem.Text = "Load from file";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.OnLoadFromFileClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save to file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToFileClick);
            // 
            // openPacketSenderStripMenuItem
            // 
            this.openPacketSenderStripMenuItem.Name = "openPacketSenderStripMenuItem";
            this.openPacketSenderStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openPacketSenderStripMenuItem.Text = "Packet Sender";
            this.openPacketSenderStripMenuItem.Click += new System.EventHandler(this.OnSendPacketClick);
            // 
            // trafficGroup
            // 
            this.trafficGroup.Controls.Add(this.packetInfoGroup);
            this.trafficGroup.Controls.Add(this.packetGridView);
            this.trafficGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trafficGroup.Enabled = false;
            this.trafficGroup.Location = new System.Drawing.Point(233, 0);
            this.trafficGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trafficGroup.Name = "trafficGroup";
            this.trafficGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trafficGroup.Size = new System.Drawing.Size(1039, 714);
            this.trafficGroup.TabIndex = 34;
            this.trafficGroup.TabStop = false;
            this.trafficGroup.Text = "Traffic";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.connectedClientsGroup);
            this.leftPanel.Controls.Add(this.settingsGroup);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(233, 714);
            this.leftPanel.TabIndex = 35;
            // 
            // Timestamp
            // 
            this.Timestamp.DataPropertyName = "Timestamp";
            dataGridViewCellStyle1.Format = "g";
            this.Timestamp.DefaultCellStyle = dataGridViewCellStyle1;
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.MinimumWidth = 22;
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PacketSize
            // 
            this.PacketSize.DataPropertyName = "Size";
            this.PacketSize.HeaderText = "Size";
            this.PacketSize.MinimumWidth = 22;
            this.PacketSize.Name = "PacketSize";
            this.PacketSize.ReadOnly = true;
            this.PacketSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PacketSize.Width = 55;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            dataGridViewCellStyle2.Format = "X2";
            this.Type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 22;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Type.Width = 55;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            dataGridViewCellStyle3.Format = "X2";
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 22;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Code.Width = 55;
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "Direction";
            this.Direction.MinimumWidth = 22;
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Direction.Width = 75;
            // 
            // PacketData
            // 
            this.PacketData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PacketData.DataPropertyName = "PacketData";
            this.PacketData.HeaderText = "Data";
            this.PacketData.MinimumWidth = 22;
            this.PacketData.Name = "PacketData";
            this.PacketData.ReadOnly = true;
            this.PacketData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 714);
            this.Controls.Add(this.trafficGroup);
            this.Controls.Add(this.leftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MUnique OpenMU Network Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.packetGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).EndInit();
            this.packetInfoGroup.ResumeLayout(false);
            this.packetInfoGroup.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetPortNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenerPortNumericUpDown)).EndInit();
            this.connectedClientsGroup.ResumeLayout(false);
            this.connectionContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.trafficGroup.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView packetGridView;
        private System.Windows.Forms.TextBox rawDataTextBox;
        private System.Windows.Forms.GroupBox packetInfoGroup;
        private System.Windows.Forms.TextBox extractedInfoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.TextBox targetHostTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown targetPortNumericUpDown;
        private System.Windows.Forms.NumericUpDown listenerPortNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStartProxy;
        private System.Windows.Forms.GroupBox connectedClientsGroup;
        private System.Windows.Forms.ListBox connectedClientsListBox;
        private System.Windows.Forms.GroupBox trafficGroup;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource packetBindingSource;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ContextMenuStrip connectionContextMenu;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPacketSenderStripMenuItem;
        private System.Windows.Forms.ComboBox clientVersionComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketData;
    }
}

