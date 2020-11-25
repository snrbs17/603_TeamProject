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
    public partial class Release : Form
    {
        public Release()
        {
            InitializeComponent();
        }

        private List<Button> _btns = new List<Button>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadNumberButtons();
        }

        // 이건 나중에 DB에서 집어넣어야함
        int MaxNum = 7;

        private void TestBtn(object sender, EventArgs e)
        {
            Button selectBtn = (Button)sender;
            int selectNum = Convert.ToInt32(selectBtn.Text);

            if (selectNum > 1 && selectBtn.Name == "firstPageBtn")
            {
                foreach (Button button in _btns)
                {
                    if (button.Name == "btn1" || button.Name == "btn2" || button.Name == "btn3")
                    {
                        button.BackColor = SystemColors.Control;
                        continue;
                    }
                    else if (button.Name == "centerPageBtn")
                    {
                        button.Text = Convert.ToString(selectNum);
                        button.BackColor = Color.DeepSkyBlue;
                    }
                    else if (button.Name == "lastPageBtn")
                    {
                        button.BackColor = SystemColors.Control;
                        button.Text = Convert.ToString(selectNum + 1);
                    }
                    selectBtn.Text = Convert.ToString(selectNum - 1);

                }
            }
            else if (selectNum > 1 && selectBtn.Name == "centerPageBtn")
            {
                foreach (Button button in _btns)
                {
                    button.BackColor = SystemColors.Control;
                }
                selectBtn.BackColor = Color.DeepSkyBlue;
            }
            else if (selectNum > 2 && selectBtn.Name == "lastPageBtn")
            {
                if (selectNum == MaxNum)
                {
                    foreach (Button button in _btns)
                    {
                        button.BackColor = SystemColors.Control;
                    }
                    selectBtn.BackColor = Color.DeepSkyBlue;
                }
                else if (selectNum < MaxNum)
                {
                    foreach (Button button in _btns)
                    {
                        if (button.Name == "btn1" || button.Name == "btn2" || button.Name == "btn3")
                        {
                            button.BackColor = SystemColors.Control;
                            continue;
                        }
                        else if (button.Name == "centerPageBtn")
                        {
                            button.Text = Convert.ToString(selectNum);
                            button.BackColor = Color.DeepSkyBlue;
                        }
                        else if (button.Name == "firstPageBtn")
                        {
                            button.BackColor = SystemColors.Control;
                            button.Text = Convert.ToString(selectNum - 1);
                        }
                        selectBtn.Text = Convert.ToString(selectNum + 1);

                    }
                }
            }
            else if (selectNum == 1)
            {
                foreach (Button button in _btns)
                {
                    button.BackColor = SystemColors.Control;
                }
                selectBtn.BackColor = Color.DeepSkyBlue;
            }
        }


        private void LoadNumberButtons()
        {
            Type type = GetType();
            FieldInfo[] fieldInfos =
            type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var info in fieldInfos)
            {
                Button button = info.GetValue(this) as Button;
                if (button == null)
                    continue;

                _btns.Add(button);
            }
        }


    }
}
