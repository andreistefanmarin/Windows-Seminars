using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Xml.Serialization;
using WinFormsApp11.Entities;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        #region Properties
        private List<Participant> _participants;
        #endregion
        public Form1()
        {
            InitializeComponent();

            _participants = new List<Participant>();

        }


        public void DisplayParticipants()
        {
            lvParticipants.Items.Clear();

            foreach (Participant participant in _participants)
            {
                var listViewItem = new ListViewItem(participant.LastName);
                listViewItem.SubItems.Add(participant.FirstName);
                listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());

                lvParticipants.Items.Add(listViewItem);
            }
        }

        private bool IsLastNameValid()
        {
            return string.IsNullOrWhiteSpace(tbLastName.Text.Trim());
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (IsLastNameValid())
            {
                e.Cancel = true; //prevents the user from changing the focus to another control
                errorProvider.SetError((Control)sender, "Last Name is empty!");

            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            DateTime birthDate = dtpBirthDate.Value;

            var participant = new Participant(lastName, firstName, birthDate);
            _participants.Add(participant);

            DisplayParticipants();

        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.Create("example.json"))
            {
                JsonSerializer.Serialize(stream, _participants);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.OpenRead("example.json"))
            {
                var JSONparticipants = JsonSerializer.Deserialize<List<Participant>>(stream);
                _participants = JSONparticipants;
                DisplayParticipants();
            }
        }

       

        private void serializationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.Create("example.xml"))
            {
                serializer.Serialize(stream, _participants);
            }

        }

        private void deserializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.OpenRead("example.xml"))
            {
                _participants = (List<Participant>)serializer.Deserialize(stream);
                DisplayParticipants();
            }
        }
    }
}
