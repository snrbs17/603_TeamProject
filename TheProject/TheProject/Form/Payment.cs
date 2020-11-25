using System;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 넘어간 폼의 기존 화면 쓰게
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 나중에 넘어간 Form 데이터 리셋시켜야함
            Close();
        }
    }
}
