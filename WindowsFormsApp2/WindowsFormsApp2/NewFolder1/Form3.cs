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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int CheckNumber { get; set; }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Bitmap img1 = Properties.Resources._in;
        Bitmap img2 = Properties.Resources._123;
        private void PB_Click(object sender, EventArgs e)
        {
            PictureBox test = (PictureBox)sender;
            CheckNumber = int.Parse(test.AccessibleName);

            // 이건 이미지 변환용
            //if (pictureBox5.Image == img1)
            //{
            //    pictureBox5.Image = img2;
            //}
            //else
            //    pictureBox5.Image = img1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form2 fr22 = new Form2(CheckNumber);
            fr22.Show();
            Close();
        }
    }
}
