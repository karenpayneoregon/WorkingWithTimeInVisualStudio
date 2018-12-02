﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace TimeLibrary
{
    public class TimeComboBox : ComboBox
    {
        private bool _shown = false;
        public TimeComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;

            if (!DesignMode)
            {
                var hours = new Hours();
                Items.AddRange(hours.Range(Increment));
            }

            Size = new Size(80, 21);
            MaxDropDownItems = 10;
            IntegralHeight = false;
        }
        /// <summary>
        /// Disable sorting
        /// </summary>
    #pragma warning disable 108,114
        public bool Sorted => false;
    #pragma warning restore 108,114
        /// <summary>
        /// Set current item in the ComboBox using a TimeSpan. 
        /// If the value passed in is not in the ComboBox -1 is returned.
        /// </summary>
        /// <param name="pTime"></param>
        /// <returns>Index of item or -1 if not found</returns>
        public int SetCurrentItem(TimeSpan pTime)
        {
            var dateTimeime = DateTime.Today.Add(pTime);
            var displayTime = dateTimeime.ToString("hh:mm tt");
            var index = FindString(displayTime);
            SelectedIndex = index;

            return index;

        }
        /// <summary>
        /// Set current item by string which represents a valid TimeSpan
        /// </summary>
        /// <param name="pTime"></param>
        /// <returns></returns>
        public int SetCurrentItem(string pTime)
        {
            if (TimeSpan.TryParse(pTime, out var time)) 
            {
                var dateTimeime = DateTime.Today.Add(time);
                var displayTime = dateTimeime.ToString("hh:mm tt");
                var index = FindString(displayTime);
                if (index > -1)
                {
                    SelectedIndex = index;
                }
                
                return index;
            }
            else
            {
                return -1;
            }
            
        }

        private TimeSpan _timeSpan;
        /// <summary>
        /// Get current selected item as a TimeSpan
        /// </summary>
        [Browsable(false)]
        public TimeSpan TimeSpan => Convert.ToDateTime(Text.TrimStart('0')).TimeOfDay;

        private int _hours;
        /// <summary>
        /// Get hour for selected item
        /// </summary>
        [Browsable(false)]
        public int Hours => TimeSpan.Hours;

        private int _Minutes;
        /// <summary>
        /// Get minutes for selected item
        /// </summary>
        [Browsable(false)]
        public int Minutes => TimeSpan.Minutes;

        /// <summary>
        /// Determine if current selected item is AM
        /// </summary>
        [Browsable(false)]
        public bool IsAM
        {
            get
            {
                var check = new DateTime(
                    DateTime.Now.Year, 
                    DateTime.Now.Month, 
                    DateTime.Now.Day, 
                    TimeSpan.Hours, 
                    TimeSpan.Minutes, 0);

                return check.ToString("tt") == "AM";

            }
        }
        /// <summary>
        /// Determine if current selected item is PM
        /// </summary>
        [Browsable(false)]
        public bool IsPM => !IsAM;
        /// <summary>
        /// Provides formatting e.g. 3:45 PM
        /// </summary>
        public string Formatted => TimeSpan.Formatted();

        protected static TimeIncrement ParentIncrement { get; set; }

        private TimeIncrement _increment;
        /// <summary>
        /// Get/set increment <see cref="TimeIncrement"/>
        /// </summary>
        [Category("Behavior"), Browsable(true), Description("Time increment")]
        public TimeIncrement Increment
        {
            set
            {
                _increment = value;
                ParentIncrement = value;
                Items.Clear();

                var hours = new Hours();
                Items.AddRange(hours.Range(Increment));
            }
            get
            {
                return _increment;
            }
        }

        private static string _hour = "";

        [Category("Behavior"), Browsable(true), Editor(typeof(Editor), typeof(UITypeEditor)), Description("Hour get/set")]
        public string Time
        {
            set
            {
                _hour = value;
                SetHour();
            }
            get
            {
                return _hour;
            }
        }
        private bool SetHour()
        {
            bool success = false;
            if (string.IsNullOrWhiteSpace(Time))
            {
                Time = "00:00";
            }

            int result = FindString(Time);
            if (result > -1)
            {
                SelectedIndex = result;
                var item = Items.Count;
                success = true;
            }
            else
            {
                SelectedIndex = 0;
            }
            return success;
        }
        private void TimeComboBox_VisibleChanged(object sender, EventArgs e)
        {
            if (!_shown)
            {
                SetHour();
                _shown = true;
            }
        }

        internal class Editor : UITypeEditor
        {
            private IWindowsFormsEditorService _svc;
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.DropDown;
            }
            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                _svc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

                var listBox = new ListBox();
                var hours = new Hours();
                var data = hours.Range(ParentIncrement);

                foreach (var item in data)
                {
                    listBox.Items.Add(item);
                }

                if (value != null)
                {
                    listBox.SelectedItem = value;
                }

                _svc.DropDownControl(listBox);

                value = (string)listBox.SelectedItem;

                return value;
            }

        }
    }
}