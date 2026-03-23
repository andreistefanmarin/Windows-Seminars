using System;
using System.Windows.Forms;
using WinFormsApp11.Entities;

namespace WinFormsApp11
{
    public partial class EditForm : Form
    {
        private Participant _participant;

        public EditForm(Participant participant)
        {
            InitializeComponent();
            _participant = participant;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = _participant.FirstName;
            tbLastName.Text = _participant.LastName;
            dateTimePicker1.Value = _participant.BirthDate;
        }

        private void button1_Click(object sender, EventArgs e) // OK BUTTON
        {
            _participant.FirstName = tbFirstName.Text;
            _participant.LastName = tbLastName.Text;
            _participant.BirthDate = dateTimePicker1.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
