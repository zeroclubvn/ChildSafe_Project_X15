﻿
namespace ChildSafe
{
    partial class blockOptions
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btWhiteList = new System.Windows.Forms.Button();
            this.tbBlacklist = new System.Windows.Forms.DataGridView();
            this.urlAdded2Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemove = new System.Windows.Forms.Button();
            this.btReportUrl2Server = new System.Windows.Forms.Button();
            this.btAdd2Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txUrl2AddBlackList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btFilterBrowsing = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.filterDetails = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.errorReporter = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklist)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReporter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btWhiteList);
            this.groupBox1.Controls.Add(this.tbBlacklist);
            this.groupBox1.Controls.Add(this.btRemove);
            this.groupBox1.Controls.Add(this.btReportUrl2Server);
            this.groupBox1.Controls.Add(this.btAdd2Table);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txUrl2AddBlackList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom block";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(597, 24);
            this.label3.MaximumSize = new System.Drawing.Size(2, 100);
            this.label3.MinimumSize = new System.Drawing.Size(2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 15);
            this.label3.TabIndex = 6;
            // 
            // btWhiteList
            // 
            this.btWhiteList.Location = new System.Drawing.Point(685, 19);
            this.btWhiteList.Name = "btWhiteList";
            this.btWhiteList.Size = new System.Drawing.Size(75, 23);
            this.btWhiteList.TabIndex = 5;
            this.btWhiteList.Text = "White list";
            this.btWhiteList.UseVisualStyleBackColor = true;
            // 
            // tbBlacklist
            // 
            this.tbBlacklist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbBlacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbBlacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlAdded2Table});
            this.tbBlacklist.Location = new System.Drawing.Point(9, 48);
            this.tbBlacklist.Name = "tbBlacklist";
            this.tbBlacklist.Size = new System.Drawing.Size(753, 203);
            this.tbBlacklist.TabIndex = 4;
            this.tbBlacklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbBlacklist_CellClick);
            this.tbBlacklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbBlacklist_CellContentClick);
            // 
            // urlAdded2Table
            // 
            this.urlAdded2Table.HeaderText = "Website";
            this.urlAdded2Table.Name = "urlAdded2Table";
            this.urlAdded2Table.Width = 700;
            // 
            // btRemove
            // 
            this.btRemove.Enabled = false;
            this.btRemove.Location = new System.Drawing.Point(519, 19);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(72, 23);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btReportUrl2Server
            // 
            this.btReportUrl2Server.Enabled = false;
            this.btReportUrl2Server.Location = new System.Drawing.Point(605, 19);
            this.btReportUrl2Server.Name = "btReportUrl2Server";
            this.btReportUrl2Server.Size = new System.Drawing.Size(74, 23);
            this.btReportUrl2Server.TabIndex = 3;
            this.btReportUrl2Server.Text = "Report";
            this.btReportUrl2Server.UseVisualStyleBackColor = true;
            // 
            // btAdd2Table
            // 
            this.btAdd2Table.Enabled = false;
            this.btAdd2Table.Location = new System.Drawing.Point(438, 19);
            this.btAdd2Table.Name = "btAdd2Table";
            this.btAdd2Table.Size = new System.Drawing.Size(75, 23);
            this.btAdd2Table.TabIndex = 2;
            this.btAdd2Table.Text = "Block";
            this.btAdd2Table.UseVisualStyleBackColor = true;
            this.btAdd2Table.Click += new System.EventHandler(this.btAdd2Table_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a  website to black list";
            // 
            // txUrl2AddBlackList
            // 
            this.txUrl2AddBlackList.FormattingEnabled = true;
            this.txUrl2AddBlackList.Location = new System.Drawing.Point(157, 21);
            this.txUrl2AddBlackList.Name = "txUrl2AddBlackList";
            this.txUrl2AddBlackList.Size = new System.Drawing.Size(275, 21);
            this.txUrl2AddBlackList.TabIndex = 0;
            this.txUrl2AddBlackList.SelectedIndexChanged += new System.EventHandler(this.txUrl2AddBlackList_SelectedIndexChanged);
            this.txUrl2AddBlackList.TextChanged += new System.EventHandler(this.txUrl2AddBlackList_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 564);
            this.panel1.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(604, 529);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(685, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btFilterBrowsing);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.filterDetails);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other options";
            // 
            // btFilterBrowsing
            // 
            this.btFilterBrowsing.Location = new System.Drawing.Point(651, 22);
            this.btFilterBrowsing.Name = "btFilterBrowsing";
            this.btFilterBrowsing.Size = new System.Drawing.Size(117, 23);
            this.btFilterBrowsing.TabIndex = 8;
            this.btFilterBrowsing.Text = "Browsing..";
            this.btFilterBrowsing.UseVisualStyleBackColor = true;
            this.btFilterBrowsing.Click += new System.EventHandler(this.btFilterBrowsing_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search filter";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Adware & malware filter",
            "Fakenews filter",
            "Gambling filter",
            "Social filter"});
            this.comboBox2.Location = new System.Drawing.Point(86, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(478, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // filterDetails
            // 
            this.filterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterDetails.Location = new System.Drawing.Point(564, 54);
            this.filterDetails.Name = "filterDetails";
            this.filterDetails.Size = new System.Drawing.Size(196, 198);
            this.filterDetails.TabIndex = 5;
            this.filterDetails.Text = "Updated: 22/10/2021";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(546, 200);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(207, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Child Safe Adult Content Base filter";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Tracking Protection filter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Social Media filter";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Annoyance filter";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // errorReporter
            // 
            this.errorReporter.ContainerControl = this;
            // 
            // blockOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 564);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "blockOptions";
            this.Text = "BlockOptions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReporter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbBlacklist;
        private System.Windows.Forms.Button btReportUrl2Server;
        private System.Windows.Forms.Button btAdd2Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txUrl2AddBlackList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox filterDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btWhiteList;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btFilterBrowsing;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlAdded2Table;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ErrorProvider errorReporter;
        private System.Windows.Forms.ToolTip toolTip;
    }
}