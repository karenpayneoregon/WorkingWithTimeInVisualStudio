using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using TimeLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly DataOperations _dataOperations = new DataOperations();
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            // columns have been created in the designer and data property set
            dataGridView1.AutoGenerateColumns = false;

            // get people in List<Person>
            _bindingSource.DataSource = _dataOperations.ReadTimeTable();

            // subscribe to current change to handle sync'ing Time ComboBox
            _bindingSource.CurrentChanged += _bindingSource_CurrentChanged;           

            // bind person list to DataGridView
            dataGridView1.DataSource = _bindingSource;

            // using hours range to populate the DomainUpDown control
            var hours = new Hours();
            HoursDomainUpDown.Items.AddRange(hours.Range(TimeIncrement.Quarterly));

            timeComboBox1.SelectedIndexChanged += TimeComboBox1_SelectedIndexChanged;

            // sync current person's start time with Time ComboBox
            //HandleCurrentChanged();
            _bindingSource.MoveLast();
            // see comments in ReadDifferences
            _dataOperations.ReadTimeTableDifferences();

            Console.WriteLine(dateTimePicker1.Value.TimeOfDay.Formatted());
        }
        /// <summary>
        /// Sync HourDomainUpDown with TimeComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = HoursDomainUpDown.Items.IndexOf(timeComboBox1.Text);
            if (index > -1)
            {
                HoursDomainUpDown.SelectedIndex = index;
            }
        }
        private void _bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentChanged();
        }
        /// <summary>
        /// Set TimeComboBox to current person in DataGridView
        /// </summary>
        /// <remarks>
        /// The logic for the DomainUpDown is only here because to
        /// methods of showing/changing time are being used while out
        /// in the wild only one would be used.
        /// </remarks>
        private void HandleCurrentChanged()
        {
            var person = ((Person) _bindingSource.Current);
            timeComboBox1.SetCurrentItem(person.StartTime);

            var index = HoursDomainUpDown.Items.IndexOf(timeComboBox1.Text);
            if (index > -1)
            {
                HoursDomainUpDown.SelectedIndex = index;
            }

            lblValid.Text = person.IsValidEndTime ? $"Valid end time: {person.EndTime.Formatted()}" : $"Invalid end time: {person.EndTime.Formatted()}";

        }
        /// <summary>
        /// Update start time of current person in DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Although the TimeComboBox is used to update the current person
        /// using the DomainUpDown could had been used.
        /// </remarks>
        private void UpdateStartTimeButton_Click(object sender, EventArgs e)
        {
            var person = (Person) _bindingSource.Current;
            var startTime = person.StartTime;
            

            if (timeComboBox1.TimeSpan.IsValidStartTime(person.EndTime))
            {
                var success = _dataOperations.UpdateStartTime(person.Id, timeComboBox1.TimeSpan);
                if (!success)
                {
                    MessageBox.Show($"Update failed: {_dataOperations.LastExceptionMessage}");
                }
            }
            else
            {
                MessageBox.Show("Start time must be prior to end time");
                person.StartTime = startTime;
                timeComboBox1.SetCurrentItem(person.StartTime);
            }
        }
        /// <summary>
        /// Show currently select TimeSpan formatted via a language extension
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeSpanFormattedButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timeComboBox1.Formatted);
        }
        /// <summary>
        /// Show segments of currently selected TimeSpan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeSpanHourMinutes_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hour/Minutes: {timeComboBox1.Hours}:{timeComboBox1.Minutes}\nAM? {timeComboBox1.IsAM}\nPM? {timeComboBox1.IsPM}");
        }
        /// <summary>
        /// Set the current time for the current person.
        /// Returns the new index if the string provided could be converted
        /// to a TimeSpan and that it was in the ComboBox Items. If the
        /// string was not found or not a valid time span -1 is returned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Note in place of a TextBox a DomainUpDown as setup on this form
        /// could be used by using an object list rather than a string array.
        /// </remarks>
        private void SetCurrentFromStringButton_Click(object sender, EventArgs e)
        {
            timeComboBox1.SetCurrentItem(txtTime.Text);
        }

        private void domainCurrentValueButton_Click(object sender, EventArgs e)
        {
            TimeSpan selectedTime = HoursDomainUpDown.Text.TimeSpan();
            MessageBox.Show($"DomainUpDown: {HoursDomainUpDown.Text.TimeSpan().Formatted()}");
        }

        private void dateTimeValueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Time().Formatted());
        }

        /// <summary>
        /// Inspired by
        /// https://stackoverflow.com/questions/68180488/remove-comobox-items-between-2-indexs-c-sharp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveHoursButton_Click(object sender, EventArgs e)
        {
            
            var hours = new HoursItems();
            hours.Range(TimeIncrement.Quarterly);

            Console.WriteLine(hours.HourItems.Count);

            var newHours = new List<HourItem>();
            foreach (var hourItem in hours.HourItems)
            {
                // times below would be from user selections
                if (!hourItem.TimeSpan.Between("07:45 AM".ToTimeSpan(), "10:45 AM".ToTimeSpan()))
                {
                    newHours.Add(hourItem);
                }
            }

            hours.HourItems = newHours;
            Console.WriteLine(hours.HourItems.Count);

        }

        
    }

}
