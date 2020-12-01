using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            SignUp signUpform = new SignUp();
            signUpform.ShowDialog();
        }

        private void idtxtBox_TextChanged(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void Cover_Load(object sender, EventArgs e)
        {

        }

        private void pwtxtBox_TextChanged(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            DataForOwner dataForOwner = new DataForOwner();
            dataForOwner.ShowDialog();
        }
    }
}
