using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using TimeLibrary;

namespace WindowsFormsApp1
{
    public partial class DateTimePickerForm : Form
    {
        private readonly DataOperations _dataOperations = new DataOperations();
        private readonly BindingSource _bindingSource = new BindingSource();
        public DateTimePickerForm()
        {
            InitializeComponent();
            Shown += DateTimePickerForm_Shown;
        }

        private void DateTimePickerForm_Shown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _dataOperations.ReadTimeTableDifferences();
            bindingNavigator1.BindingSource = _bindingSource;

            txtFirstName.DataBindings.Add("Text", _bindingSource, "FirstName");
            txtlastName.DataBindings.Add("Text", _bindingSource, "LastName");

            _bindingSource.CurrentChanged += _bindingSource_CurrentChanged;
            StartTimeDateTimePicker.ValueChanged += StartTimeDateTimePicker_ValueChanged;

            HandleCurrentChanged();
          
        }
        /// <summary>
        /// Manually update StartTime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var row = ((DataRowView)_bindingSource.Current).Row;
            row.SetField("StartTime", StartTimeDateTimePicker.Value.TimeOfDay);
        }
        private void _bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentChanged();
        }
        /// <summary>
        /// Handle manually updating StartTime on current change of the BindingSource
        /// </summary>
        private void HandleCurrentChanged()
        {
            var row = ((DataRowView) _bindingSource.Current).Row;
            StartTimeDateTimePicker.Value = row.Field<TimeSpan>("StartTime").ToDateTime();
        }
        /// <summary>
        /// Update current DataRow StartTime back to the SQL-Server database table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)_bindingSource.Current).Row;
            var success = _dataOperations.UpdateStartTime(row.Field<int>("id"), row.Field<TimeSpan>("StartTime"));
            if (!success)
            {
                MessageBox.Show($"Update failed: {_dataOperations.LastExceptionMessage}");
            }
        }
    }
}
