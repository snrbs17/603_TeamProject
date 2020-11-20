using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_winform_ver
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort("COM7", 115200);
        int flag=0;
        //string data;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag ^= 1;
            sp.WriteLine(flag.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sp.Open();
        }
    }
}
