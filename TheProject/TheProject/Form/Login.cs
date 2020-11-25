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
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }


        private List<Button> _keys = new List<Button>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadKeyButtons();

            foreach (Button key in _keys)
            {
                key.Click += KeyBoard_Click;
            }
        }

        private void KeyBoard_Click(object sender, EventArgs e)
        {
            Button key = sender as Button;
            Text += key.Text;
        }

        //private List<Button> LoadKeyButtons()
        private void LoadKeyButtons()
        {
            List<Button> keys = new List<Button>();

            Type type = GetType();
            FieldInfo[] fieldInfos =
            type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var info in fieldInfos)
            {
                Button key = info.GetValue(this) as Button;
                if (key == null)
                    continue;

                _keys.Add(key);
            }

            //return keys;
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
    }
}
