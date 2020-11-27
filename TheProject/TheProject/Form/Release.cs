using System;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Release : Form
    {
        public Release()
        {
            InitializeComponent();
        }


        private int totalCost = 0;


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // dgv에 표시
            //dgvList.DataSource = list;
            // totalCost 계산
            //foreach (var item in list)
            //{
            //    totalCost += Convert.ToInt32(item.cost);
            //}

            if(totalCost == 0)
            {
                chargeLabel.Visible = false;
            }
            else if(totalCost != 0)
            {
                chargeLabel.Text = Convert.ToString(totalCost);
            }
        }



        private void releaseBtn_Click(object sender, EventArgs e)
        {
            if(chargeLabel.Visible == false)
            {
                MessageBox.Show("이용 감사");
            }
            Close();
        }
    }
}
