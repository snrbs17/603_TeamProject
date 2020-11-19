using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public Form2(int checkNumber) : this()
        {
           textBox3.Text = checkNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
