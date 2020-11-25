using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ToggleSlider;

namespace TheProject
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        // 이건 나중에 5번 폼 시작하면 그룹박스안에 있는 라벨들의 이름을 DB와 매칭 시킨다
        // 아직 미완성
        /*public void Form1_Load(object sender, EventArgs e)
        {
            for (int iCount = 1; iCount <= 10; iCount++)
            {
                this.FindByName<Label>("Label" + iCount.ToString()).Text = "Test" + iCount.ToString();
            }
        }*/



        // 처음 들어오면 시작되어 DB를 가져와서 색 정해지게, 색상이 이상하면 나중에 바꾸면 됨
        // 박스랑 라벨이랑 일치시켜줘야함(어떻게 해야할까나)
        /*public void startMainWindowBox()
        {
            box = DB에서 가져온 박스의 이름
           
            if (box.사용여부 == 0)
            {
                if(box.종류?(신선/일반) == 일반)
                    box.BackColor = Color.White;
                else (box.종류 ? (신선 / 일반) == 신선)
                     box.BackColor = Color.DarkGray;
            }
            // 1인건 사용중이니깐 
            else
            {
                 box.BackColor = Color.Red;
            }
        }
        */

        // 이건 DB에서 신선박스들을 가져와서 변경해야할듯, 박스리스트에 조건을 넣어서 검색해서 가져옴
        // 하얀색(일반이나 신선 선택된것)만 누르는거 가능

        private List<Label> _labels = new List<Label>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ChangeLabelColor();
        }
        private void ChangeLabelColor()
        {
            Type type = GetType();
            FieldInfo[] fieldInfos =
            type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var info in fieldInfos)
            {
                Label label = info.GetValue(this) as Label;
                if (label == null)
                    continue;

                _labels.Add(label);
            }
        }

        // 우선 보관함종류에 대해 데이터를 받고 일반/신선에 따라 색을 부여해야함
        // 지금 코드를 좀 바꿔야할듯
        public void button1_Click(object sender, EventArgs e)
        {

            ToggleSliderComponent tog = (ToggleSliderComponent)sender;
            if (tog.ToggleCircleColor == Color.Silver)
            {
                tog.ToggleCircleColor = Color.Green;
                tog.ToggleBarText = " 신선";

                foreach (var label in _labels)
                {
                    if (label.BackColor == Color.DarkGray)
                    {
                        label.BackColor = Color.White;
                    }
                    else if (label.BackColor == Color.White)
                    {
                        label.BackColor = Color.DarkGray;
                    }
                }
            }
            else
            {
                tog.ToggleCircleColor = Color.Silver;
                tog.ToggleBarText = " 일반";

                foreach (var label in _labels)
                {
                    if (label.BackColor == Color.DarkGray)
                    {
                        label.BackColor = Color.White;
                    }
                    else if (label.BackColor == Color.White)
                    {
                        label.BackColor = Color.DarkGray;
                    }
                }
            }

        }
        // 여기까지


        // 라벨 버튼 선택시, freshCheckNumber=1 신선만 가능, 스위치로 할까나
        public void ClickBox(object sender, EventArgs e)
        {
            Label labelbox = (Label)sender;
            // 만약 누른 라벨의 배경색이 하얀거라면 노랗게 만들고
            if (labelbox.BackColor == Color.White)
            {
                labelbox.BackColor = Color.Yellow;
                // 그리고 리스트에 나오게 만들어아햠

                // 이 사이에
            }
            // 노란건 이미 선택된거기 때문에 다시 하얀색으로
            else if (labelbox.BackColor == Color.Yellow)
            {
                labelbox.BackColor = Color.White;
                // 그리고 리스트에 사라지게 만들어아햠

                // 이 사이에
            }
            // 빨간건 이미 사용중인거라 결제버튼 비활성화하고 검정색으로
            else if (labelbox.BackColor == Color.Red)
            {
                labelbox.BackColor = Color.Black;
                labelbox.ForeColor = Color.White;
                payBtn.Enabled = false;
            }
            else if (labelbox.BackColor == Color.Black)
            {
                labelbox.BackColor = Color.Red;
                labelbox.ForeColor = Color.Black;

                payBtn.Enabled = true;
            }
            // 다크그레이는 신선이나 일반에서 비활성화인것들
            else if (labelbox.BackColor == Color.DarkGray)
            {
                // 아무것도 안되도록
                // 정보도 뜨면 안된다
            }
        }

        public void PayBtnClick(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void Storage_Load(object sender, EventArgs e)
        {

        }

        // 여기까지

        // 만약 결제버튼을 누른다면
        // 상세 내역중에 사용중인게 있는지 확인
        /*public void ClickPay()
        {
            if(보관소 정보 리스트 항목중에 하나라도 사용가능여부 == 사용중)
            {
                MessageBox.Show("사용중인 항목이 들어있습니다");
            }
            else if(전부 == 사용가능)
            {
                다음화면으로 넘어감
            }
        }
        */

        //public void dgvDataCheck(object sender, EventArgs e)
        //{
        //    DataGridView dgvInfo = (DataGridView)sender;
        //    dgvInfo.Rows[0]="hi";
        //}
    }
}
