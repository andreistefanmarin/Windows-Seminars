using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar7._2.ViewModel;

namespace Seminar7._2
{
    public partial class Form1 : Form
    {
        private ViewModel1 _viewModel;
        public Form1()
        {
            InitializeComponent();
            _viewModel = new ViewModel1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _viewModel.Participants;

            textBox1.DataBindings.Add("Text", _viewModel, nameof(ViewModel1.LastName));
            textBox2.DataBindings.Add("Text", _viewModel, nameof(ViewModel1.FirstName));
            dateTimePicker1.DataBindings.Add("Value", _viewModel, nameof(ViewModel1.LastName));

        }
    }
}
