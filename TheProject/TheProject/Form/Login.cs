using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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


            //시작 포커스
            idtxtBox.Select();
            this.ActiveControl = idtxtBox;
            idtxtBox.Focus();

        }


        private void Login_Load(object sender, EventArgs e)
        {

        }



        private List<Button> _keys = new List<Button>();
        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //LoadKeyButtons();

            //foreach (Button key in _keys)
            //{
            //    key.Click += KeyBoard_Click;
            //}
        }


        //현재 입력하려는 텍스트 박스
        //private object focusedCtl;
        //private void idtxtBox_Enter(object sender, EventArgs e)
        //{
        //    focusedCtl = sender as Control;
        //}

        private void KeyBoard_Click(object sender, EventArgs e)
        {

            Point line = idtxtBox.GetPositionFromCharIndex(idtxtBox.SelectionStart);
            Point line2 = pwtxtBox.GetPositionFromCharIndex(pwtxtBox.SelectionStart);

            string txtBoxposition = Cursor.Position.Y.ToString();

            Button key = sender as Button;
            
            //if()
                idtxtBox.Text = idtxtBox.Text + key.Text;
            //else
                pwtxtBox.Text = pwtxtBox.Text + key.Text;

            ////키보드 tap 이용할 때 -> 터치로 수정해야함
            ///Button key = sender as Button;
            //string idtxtBoxposition = Cursor.Position.Y.ToString();           
            //MessageBox.Show(idtxtBoxposition);

            //if (Cursor.Position.Y.ToString() == idtxtBoxposition)
            //   idtxtBox.Text += key.Text;
            //else
            //   pwtxtBox.Text += key.Text;

        }







        //private List<Button> LoadKeyButtons()
        private void LoadKeyButtons()
        {
            //List<Button> keys = new List<Button>();

            //Type type = GetType();
            //FieldInfo[] fieldInfos =
            //type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (var info in fieldInfos)
            //{
            //    Button key = info.GetValue(this) as Button;
            //    if (key == null)
            //        continue;

            //    _keys.Add(key);
            //}

            //return keys;
            _keys.RemoveAll(x => x.Text.Contains("회원가입"));
            _keys.RemoveAll(x => x.Text.Contains("로그인"));

        }






        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logintoSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpform = new SignUp();
            signUpform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backspacebtn_Click(object sender, EventArgs e)
        {
            if(idtxtBox.Text.Length > 0)
                idtxtBox.Text = idtxtBox.Text.Remove(idtxtBox.Text.Length -1, 1);
        }

        private void idtxtBox_Click(object sender, EventArgs e)
        {
            string idtxtBoxposition = Cursor.Position.Y.ToString();
            MessageBox.Show(idtxtBoxposition);

            ((TextBox)sender).SelectAll();
            
        }

        private void pwtxtBox_Click(object sender, EventArgs e)
        {
            string pwtxtBoxposition = Cursor.Position.Y.ToString();
            MessageBox.Show(pwtxtBoxposition);
            ((TextBox)sender).SelectAll();
        }
    }
}
