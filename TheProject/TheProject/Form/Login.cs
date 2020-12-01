using EF.Data;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            idtxtBox.Select();
            this.ActiveControl = idtxtBox;
            idtxtBox.Focus();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Selection selectionform = new Selection();
            selectionform.ShowDialog();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            SignUp signUpform = new SignUp();
            signUpform.ShowDialog();
        }
        
        private void KeyBoard_Click(object sender, EventArgs e)
        {

            var txtBoxposition = Convert.ToInt32(Cursor.Position.Y.ToString());

            Button key = sender as Button;

            
            if (txtBoxposition > 280)            
               idtxtBox.Text = idtxtBox.Text + key.Text;
               //pwtxtBox.Text = pwtxtBox.Text + key.Text;

        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            Selection selectionform = new Selection();
            selectionform.ShowDialog();
        }

        private void backspacebtn_Click(object sender, EventArgs e)
        {
            
            if (idtxtBox.Text.Length > 0)
                idtxtBox.Text = idtxtBox.Text.Remove(idtxtBox.Text.Length - 1, 1);
        }

        private void idtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtxtBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void pwtxtBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
