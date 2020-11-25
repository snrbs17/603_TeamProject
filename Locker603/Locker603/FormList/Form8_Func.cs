using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cus.Form5.NewFolder1
{
    public class Form8_Func
    {
        private List<Button> _btns = new List<Button>();

        

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);

        //    foreach (Button button in _btns)
        //    {
        //        button.Click += NumberButton_Click;
        //    }
        //}


        int Maxnum = 7;
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
 
            int pageNum = Convert.ToInt32(btn.Text);

            if (pageNum > 1)
            {
                btn.Text = Convert.ToString(pageNum - 1);
            }
            else if (pageNum == 1)
            {
                btn.BackColor = Color.DeepSkyBlue;
            }
            else if (pageNum < Maxnum)
            {
                btn.Text = Convert.ToString(pageNum + 1);
            }
            else if (pageNum == Maxnum)
            {
                btn.BackColor = Color.DeepSkyBlue;
            }

        }

        // Reflection 사용해야함
        // 맨 앞에 버튼 누르면 < 와 현재 1번 버튼
        //public void FirstPageBtnClick(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    int pageNum = Convert.ToInt32(btn.Text);

        //    if (pageNum > 1)
        //    {
        //        btn.Text = Convert.ToString(pageNum - 1);
        //    }
        //    else if (pageNum == 1)
        //    {
        //        btn.BackColor = Color.DeepSkyBlue;
        //    }
        //}


        // 맨 뒤에 버튼 누르면 > 와 현재 3번 버튼
        /*public void LastPageBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int pageNum = Convert.ToInt32(btn.Text);

            if (pageNum < 최대값페이지 구해야함)
            {
                btn.Text = Convert.ToString(pageNum + 1);
            }
            else if (pageNum == 최대값페이지 구해야하는거)
            {
                btn.BackColor = Color.DeepSkyBlue;
            }
        }
        */
    }
}
