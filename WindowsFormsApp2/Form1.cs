using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Entities;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Person> _persons;

        public Form1()
        {
            InitializeComponent();

            _persons = new List<Person>();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox1, "Last name is empty");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Error");
                return;
            }
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            DateTime birthDate = dateTimePicker1.Value;
            var person = new Person(firstName, lastName, birthDate);
            _persons.Add(person);
            textBox1.Clear();
            textBox2.Clear();
            DisplayPerson();
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime limit = today.AddYears(-18);
            if(dateTimePicker1.Value > limit)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimePicker1, "The person should be at least 18y of age");
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        public void DisplayPerson()
        {
            listView1.Items.Clear();
            foreach (Person person in _persons)
            {
                var listViewItem = new ListViewItem(person.FirstName);
                listViewItem.SubItems.Add(person.LastName);
                listViewItem.SubItems.Add(person.BirthDate.ToShortDateString());

                listView1.Items.Add(listViewItem);
            }
        }

    } //end of Form
} //end of namespace
