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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OpenForm2()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        public void OpenForm4()
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void OpenForm2(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void OpenForm4(object sender, EventArgs e)
        {
            OpenForm4();
        }

        
    }
}
