using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using TimeLibrary;

namespace WindowsFormsApp1
{
    public partial class ConventionalForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public ConventionalForm()
        {
            InitializeComponent();
            Shown += ConventionalForm_Shown;
        }

        private void ConventionalForm_Shown(object sender, EventArgs e)
        {
            var mockedDataops = new MockedDataTable();
            _bindingSource.DataSource = mockedDataops.Table();
            bindingNavigator1.BindingSource = _bindingSource;
            StartTimeDateTimePicker.DataBindings.Add("Text", _bindingSource, "StartTime");

        }

        private void currentTimeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StartTimeDateTimePicker.Time().Formatted());
        }
    }
}
