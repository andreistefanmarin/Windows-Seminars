using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            btn.Text = "My second text";
        }

        private void bt_MouseHover(object sender, MouseEventArgs e)
        {
            btn.Text = "My third text";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {
            var value1 = Int32.Parse(textBox1.Text);
            var value2 = Int32.Parse(textBox2.Text);
            var result = value1 + value2;
            textBox3.Text = result.ToString();
        }
    }
}
