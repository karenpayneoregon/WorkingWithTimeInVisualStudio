using TimeLibrary;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
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
            this.UpdateStartTimeButton = new System.Windows.Forms.Button();
            this.TimeSpanFormattedButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpanHourMinutes = new System.Windows.Forms.Button();
            this.SetCurrentFromStringButton = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timeComboBox1 = new TimeLibrary.TimeComboBox();
            this.HoursDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.lblValid = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeValueButton = new System.Windows.Forms.Button();
            this.domainCurrentValueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateStartTimeButton
            // 
            this.UpdateStartTimeButton.Location = new System.Drawing.Point(271, 85);
            this.UpdateStartTimeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateStartTimeButton.Name = "UpdateStartTimeButton";
            this.UpdateStartTimeButton.Size = new System.Drawing.Size(202, 23);
            this.UpdateStartTimeButton.TabIndex = 4;
            this.UpdateStartTimeButton.Text = "Update current person start time";
            this.UpdateStartTimeButton.UseVisualStyleBackColor = true;
            this.UpdateStartTimeButton.Click += new System.EventHandler(this.UpdateStartTimeButton_Click);
            // 
            // TimeSpanFormattedButton
            // 
            this.TimeSpanFormattedButton.Location = new System.Drawing.Point(271, 114);
            this.TimeSpanFormattedButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeSpanFormattedButton.Name = "TimeSpanFormattedButton";
            this.TimeSpanFormattedButton.Size = new System.Drawing.Size(202, 23);
            this.TimeSpanFormattedButton.TabIndex = 5;
            this.TimeSpanFormattedButton.Text = "TimeSpan to string formatted";
            this.TimeSpanFormattedButton.UseVisualStyleBackColor = true;
            this.TimeSpanFormattedButton.Click += new System.EventHandler(this.TimeSpanFormattedButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.LastNameColumn});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(230, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // TimeSpanHourMinutes
            // 
            this.TimeSpanHourMinutes.Location = new System.Drawing.Point(271, 143);
            this.TimeSpanHourMinutes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeSpanHourMinutes.Name = "TimeSpanHourMinutes";
            this.TimeSpanHourMinutes.Size = new System.Drawing.Size(202, 23);
            this.TimeSpanHourMinutes.TabIndex = 6;
            this.TimeSpanHourMinutes.Text = "TimeSpan hour and minutes";
            this.TimeSpanHourMinutes.UseVisualStyleBackColor = true;
            this.TimeSpanHourMinutes.Click += new System.EventHandler(this.TimeSpanHourMinutes_Click);
            // 
            // SetCurrentFromStringButton
            // 
            this.SetCurrentFromStringButton.Location = new System.Drawing.Point(271, 172);
            this.SetCurrentFromStringButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SetCurrentFromStringButton.Name = "SetCurrentFromStringButton";
            this.SetCurrentFromStringButton.Size = new System.Drawing.Size(202, 23);
            this.SetCurrentFromStringButton.TabIndex = 7;
            this.SetCurrentFromStringButton.Text = "Set Current from string";
            this.SetCurrentFromStringButton.UseVisualStyleBackColor = true;
            this.SetCurrentFromStringButton.Click += new System.EventHandler(this.SetCurrentFromStringButton_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(494, 175);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 20);
            this.txtTime.TabIndex = 8;
            this.txtTime.Text = "08:45";
            // 
            // timeComboBox1
            // 
            this.timeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox1.FormattingEnabled = true;
            this.timeComboBox1.Increment = TimeLibrary.TimeIncrement.Quarterly;
            this.timeComboBox1.IntegralHeight = false;
            this.timeComboBox1.Items.AddRange(new object[] {
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "01:00 AM",
            "01:15 AM",
            "01:30 AM",
            "01:45 AM",
            "02:00 AM",
            "02:15 AM",
            "02:30 AM",
            "02:45 AM",
            "03:00 AM",
            "03:15 AM",
            "03:30 AM",
            "03:45 AM",
            "04:00 AM",
            "04:15 AM",
            "04:30 AM",
            "04:45 AM",
            "05:00 AM",
            "05:15 AM",
            "05:30 AM",
            "05:45 AM",
            "06:00 AM",
            "06:15 AM",
            "06:30 AM",
            "06:45 AM",
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM",
            "04:15 PM",
            "04:30 PM",
            "04:45 PM",
            "05:00 PM",
            "05:15 PM",
            "05:30 PM",
            "05:45 PM",
            "06:00 PM",
            "06:15 PM",
            "06:30 PM",
            "06:45 PM",
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM",
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "01:00 AM",
            "01:15 AM",
            "01:30 AM",
            "01:45 AM",
            "02:00 AM",
            "02:15 AM",
            "02:30 AM",
            "02:45 AM",
            "03:00 AM",
            "03:15 AM",
            "03:30 AM",
            "03:45 AM",
            "04:00 AM",
            "04:15 AM",
            "04:30 AM",
            "04:45 AM",
            "05:00 AM",
            "05:15 AM",
            "05:30 AM",
            "05:45 AM",
            "06:00 AM",
            "06:15 AM",
            "06:30 AM",
            "06:45 AM",
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM",
            "04:15 PM",
            "04:30 PM",
            "04:45 PM",
            "05:00 PM",
            "05:15 PM",
            "05:30 PM",
            "05:45 PM",
            "06:00 PM",
            "06:15 PM",
            "06:30 PM",
            "06:45 PM",
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM",
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "01:00 AM",
            "01:15 AM",
            "01:30 AM",
            "01:45 AM",
            "02:00 AM",
            "02:15 AM",
            "02:30 AM",
            "02:45 AM",
            "03:00 AM",
            "03:15 AM",
            "03:30 AM",
            "03:45 AM",
            "04:00 AM",
            "04:15 AM",
            "04:30 AM",
            "04:45 AM",
            "05:00 AM",
            "05:15 AM",
            "05:30 AM",
            "05:45 AM",
            "06:00 AM",
            "06:15 AM",
            "06:30 AM",
            "06:45 AM",
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM",
            "04:15 PM",
            "04:30 PM",
            "04:45 PM",
            "05:00 PM",
            "05:15 PM",
            "05:30 PM",
            "05:45 PM",
            "06:00 PM",
            "06:15 PM",
            "06:30 PM",
            "06:45 PM",
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM",
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "01:00 AM",
            "01:15 AM",
            "01:30 AM",
            "01:45 AM",
            "02:00 AM",
            "02:15 AM",
            "02:30 AM",
            "02:45 AM",
            "03:00 AM",
            "03:15 AM",
            "03:30 AM",
            "03:45 AM",
            "04:00 AM",
            "04:15 AM",
            "04:30 AM",
            "04:45 AM",
            "05:00 AM",
            "05:15 AM",
            "05:30 AM",
            "05:45 AM",
            "06:00 AM",
            "06:15 AM",
            "06:30 AM",
            "06:45 AM",
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM",
            "04:15 PM",
            "04:30 PM",
            "04:45 PM",
            "05:00 PM",
            "05:15 PM",
            "05:30 PM",
            "05:45 PM",
            "06:00 PM",
            "06:15 PM",
            "06:30 PM",
            "06:45 PM",
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM",
            "12: 00 AM",
            "12: 15 AM",
            "12: 30 AM",
            "12: 45 AM",
            "01: 00 AM",
            "01: 15 AM",
            "01: 30 AM",
            "01: 45 AM",
            "02: 00 AM",
            "02: 15 AM",
            "02: 30 AM",
            "02: 45 AM",
            "03: 00 AM",
            "03: 15 AM",
            "03: 30 AM",
            "03: 45 AM",
            "04: 00 AM",
            "04: 15 AM",
            "04: 30 AM",
            "04: 45 AM",
            "05: 00 AM",
            "05: 15 AM",
            "05: 30 AM",
            "05: 45 AM",
            "06: 00 AM",
            "06: 15 AM",
            "06: 30 AM",
            "06: 45 AM",
            "07: 00 AM",
            "07: 15 AM",
            "07: 30 AM",
            "07: 45 AM",
            "08: 00 AM",
            "08: 15 AM",
            "08: 30 AM",
            "08: 45 AM",
            "09: 00 AM",
            "09: 15 AM",
            "09: 30 AM",
            "09: 45 AM",
            "10: 00 AM",
            "10: 15 AM",
            "10: 30 AM",
            "10: 45 AM",
            "11: 00 AM",
            "11: 15 AM",
            "11: 30 AM",
            "11: 45 AM",
            "12: 00 PM",
            "12: 15 PM",
            "12: 30 PM",
            "12: 45 PM",
            "01: 00 PM",
            "01: 15 PM",
            "01: 30 PM",
            "01: 45 PM",
            "02: 00 PM",
            "02: 15 PM",
            "02: 30 PM",
            "02: 45 PM",
            "03: 00 PM",
            "03: 15 PM",
            "03: 30 PM",
            "03: 45 PM",
            "04: 00 PM",
            "04: 15 PM",
            "04: 30 PM",
            "04: 45 PM",
            "05: 00 PM",
            "05: 15 PM",
            "05: 30 PM",
            "05: 45 PM",
            "06: 00 PM",
            "06: 15 PM",
            "06: 30 PM",
            "06: 45 PM",
            "07: 00 PM",
            "07: 15 PM",
            "07: 30 PM",
            "07: 45 PM",
            "08: 00 PM",
            "08: 15 PM",
            "08: 30 PM",
            "08: 45 PM",
            "09: 00 PM",
            "09: 15 PM",
            "09: 30 PM",
            "09: 45 PM",
            "10: 00 PM",
            "10: 15 PM",
            "10: 30 PM",
            "10: 45 PM",
            "11: 00 PM",
            "11: 15 PM",
            "11: 30 PM",
            "11: 45 PM",
            "12: 00 AM",
            "12: 15 AM",
            "12: 30 AM",
            "12: 45 AM",
            "01: 00 AM",
            "01: 15 AM",
            "01: 30 AM",
            "01: 45 AM",
            "02: 00 AM",
            "02: 15 AM",
            "02: 30 AM",
            "02: 45 AM",
            "03: 00 AM",
            "03: 15 AM",
            "03: 30 AM",
            "03: 45 AM",
            "04: 00 AM",
            "04: 15 AM",
            "04: 30 AM",
            "04: 45 AM",
            "05: 00 AM",
            "05: 15 AM",
            "05: 30 AM",
            "05: 45 AM",
            "06: 00 AM",
            "06: 15 AM",
            "06: 30 AM",
            "06: 45 AM",
            "07: 00 AM",
            "07: 15 AM",
            "07: 30 AM",
            "07: 45 AM",
            "08: 00 AM",
            "08: 15 AM",
            "08: 30 AM",
            "08: 45 AM",
            "09: 00 AM",
            "09: 15 AM",
            "09: 30 AM",
            "09: 45 AM",
            "10: 00 AM",
            "10: 15 AM",
            "10: 30 AM",
            "10: 45 AM",
            "11: 00 AM",
            "11: 15 AM",
            "11: 30 AM",
            "11: 45 AM",
            "12: 00 PM",
            "12: 15 PM",
            "12: 30 PM",
            "12: 45 PM",
            "01: 00 PM",
            "01: 15 PM",
            "01: 30 PM",
            "01: 45 PM",
            "02: 00 PM",
            "02: 15 PM",
            "02: 30 PM",
            "02: 45 PM",
            "03: 00 PM",
            "03: 15 PM",
            "03: 30 PM",
            "03: 45 PM",
            "04: 00 PM",
            "04: 15 PM",
            "04: 30 PM",
            "04: 45 PM",
            "05: 00 PM",
            "05: 15 PM",
            "05: 30 PM",
            "05: 45 PM",
            "06: 00 PM",
            "06: 15 PM",
            "06: 30 PM",
            "06: 45 PM",
            "07: 00 PM",
            "07: 15 PM",
            "07: 30 PM",
            "07: 45 PM",
            "08: 00 PM",
            "08: 15 PM",
            "08: 30 PM",
            "08: 45 PM",
            "09: 00 PM",
            "09: 15 PM",
            "09: 30 PM",
            "09: 45 PM",
            "10: 00 PM",
            "10: 15 PM",
            "10: 30 PM",
            "10: 45 PM",
            "11: 00 PM",
            "11: 15 PM",
            "11: 30 PM",
            "11: 45 PM",
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "01:00 AM",
            "01:15 AM",
            "01:30 AM",
            "01:45 AM",
            "02:00 AM",
            "02:15 AM",
            "02:30 AM",
            "02:45 AM",
            "03:00 AM",
            "03:15 AM",
            "03:30 AM",
            "03:45 AM",
            "04:00 AM",
            "04:15 AM",
            "04:30 AM",
            "04:45 AM",
            "05:00 AM",
            "05:15 AM",
            "05:30 AM",
            "05:45 AM",
            "06:00 AM",
            "06:15 AM",
            "06:30 AM",
            "06:45 AM",
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM",
            "04:15 PM",
            "04:30 PM",
            "04:45 PM",
            "05:00 PM",
            "05:15 PM",
            "05:30 PM",
            "05:45 PM",
            "06:00 PM",
            "06:15 PM",
            "06:30 PM",
            "06:45 PM",
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM"});
            this.timeComboBox1.Location = new System.Drawing.Point(271, 49);
            this.timeComboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timeComboBox1.MaxDropDownItems = 10;
            this.timeComboBox1.Name = "timeComboBox1";
            this.timeComboBox1.Size = new System.Drawing.Size(80, 21);
            this.timeComboBox1.TabIndex = 1;
            this.timeComboBox1.Time = "08:15 AM";
            // 
            // HoursDomainUpDown
            // 
            this.HoursDomainUpDown.Location = new System.Drawing.Point(358, 49);
            this.HoursDomainUpDown.Name = "HoursDomainUpDown";
            this.HoursDomainUpDown.Size = new System.Drawing.Size(115, 20);
            this.HoursDomainUpDown.TabIndex = 2;
            this.HoursDomainUpDown.Text = "domainUpDown1";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(27, 273);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(96, 13);
            this.lblValid.TabIndex = 8;
            this.lblValid.Text = "validate end time ?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimeValueButton
            // 
            this.dateTimeValueButton.Location = new System.Drawing.Point(494, 235);
            this.dateTimeValueButton.Name = "dateTimeValueButton";
            this.dateTimeValueButton.Size = new System.Drawing.Size(75, 23);
            this.dateTimeValueButton.TabIndex = 10;
            this.dateTimeValueButton.Text = "Value";
            this.dateTimeValueButton.UseVisualStyleBackColor = true;
            this.dateTimeValueButton.Click += new System.EventHandler(this.dateTimeValueButton_Click);
            // 
            // domainCurrentValueButton
            // 
            this.domainCurrentValueButton.Location = new System.Drawing.Point(494, 49);
            this.domainCurrentValueButton.Name = "domainCurrentValueButton";
            this.domainCurrentValueButton.Size = new System.Drawing.Size(75, 23);
            this.domainCurrentValueButton.TabIndex = 3;
            this.domainCurrentValueButton.Text = "Value";
            this.domainCurrentValueButton.UseVisualStyleBackColor = true;
            this.domainCurrentValueButton.Click += new System.EventHandler(this.domainCurrentValueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DateTimePicker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DomainUpDown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ComboBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainCurrentValueButton);
            this.Controls.Add(this.dateTimeValueButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.HoursDomainUpDown);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.SetCurrentFromStringButton);
            this.Controls.Add(this.TimeSpanHourMinutes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimeSpanFormattedButton);
            this.Controls.Add(this.UpdateStartTimeButton);
            this.Controls.Add(this.timeComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time controls";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimeComboBox timeComboBox1;
        private System.Windows.Forms.Button UpdateStartTimeButton;
        private System.Windows.Forms.Button TimeSpanFormattedButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.Button TimeSpanHourMinutes;
        private System.Windows.Forms.Button SetCurrentFromStringButton;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DomainUpDown HoursDomainUpDown;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dateTimeValueButton;
        private System.Windows.Forms.Button domainCurrentValueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

