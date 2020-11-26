using EF.Data.Dao;
using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        private int toggleFlag = 0;
        private int nomalboxMaxNum = 14;
        private int payBtnClickFlag = 0;

        private List<Label> _labels = new List<Label>();
        List<StorageInfoForClientEntity> saveData = new List<StorageInfoForClientEntity>();
        List<StorageInfoForClientEntity> dbList = Dao.StorageInfoForClient.GetList();
        List<StorageInfoForClientEntity> addDataList = new List<StorageInfoForClientEntity>();

        //초기 시작시
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CreateLabelList();

            // 데이터를 받아 storageTypeId 에 따라 색을 부여
            toggle();

            //dgv
            dgvStorageInfo.DataSource = null;

        }

        // _labels를 만들기 위해 reflection 하는 메서드
        private void CreateLabelList()
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

        // toggle에 따라 색상 변화하는 메서드
        public void ToggleClick(object sender, EventArgs e)
        {
            if (payBtnClickFlag == 1)
            {
                dgvStorageInfo.DataSource = null;
                dgvStorageInfo.Rows.Clear();

                addDataList = saveData;
                saveData.Clear();
                payBtnClickFlag = 0;
            }
            ToggleSliderComponent tog = (ToggleSliderComponent)sender;
            if (tog.ToggleCircleColor == Color.Silver)
            {
                tog.ToggleCircleColor = Color.Green;
                tog.ToggleBarText = " 신선";
                toggleFlag = 1;
                toggleReverse();
            }
            else
            {
                tog.ToggleCircleColor = Color.Silver;
                tog.ToggleBarText = " 일반";
                toggleFlag = 0;
                toggle();
            }

            selectCheck();
        }

        // 선택체크
        private void selectCheck()
        {
            addDataList.Clear();
            foreach (var item in _labels)
            {
                if (item.BackColor == Color.Yellow)
                {
                    int index = Convert.ToInt32(item.Text)-1;
                    addDataList.Add(dbList[index]);
                }
            }
        }
        // 토글 기능
        public void toggle()
        {
            foreach (var item in _labels)
            {
                int labelNum = Convert.ToInt32(item.Text)-1;
                
                if(item.BackColor == Color.Yellow)
                {
                    continue;
                }
                else
                {
                    // 사용불가(누가 사용중임)
                    if (dbList[labelNum].CanUse == false)
                    {
                        item.BackColor = Color.Red;
                    }
                    // 사용 가능하고 일반일경우 
                    else if (dbList[labelNum].CanUse == true && dbList[labelNum].StorageTypeId == 1)
                    {
                        item.BackColor = Color.White;
                    }
                    // 사용 가능하지만 신선
                    else if (dbList[labelNum].CanUse == true && dbList[labelNum].StorageTypeId == 2)
                    {
                        item.BackColor = Color.DarkGray;
                    }
                }
            }
        }
        public void toggleReverse()
        {
            foreach (var item in _labels)
            {
                int labelNum = Convert.ToInt32(item.Text)-1;
                if (item.BackColor == Color.Yellow)
                {
                    continue;
                }
                else
                {
                    // 사용불가(누가 사용중임)
                    if (dbList[labelNum].CanUse == false)
                    {
                        item.BackColor = Color.Red;
                    }
                    // 사용 가능하고 일반일경우 
                    else if (dbList[labelNum].CanUse == true && dbList[labelNum].StorageTypeId == 2)
                    {
                        item.BackColor = Color.White;
                    }
                    // 사용 가능하지만 신선
                    else if (dbList[labelNum].CanUse == true && dbList[labelNum].StorageTypeId == 1)
                    {
                        item.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        // 라벨 선택시 데이터를 dgv에 표시해주고 색상 변화를 주는 메서드
        public void ClickLabel(object sender, EventArgs e)
        {
            if(payBtnClickFlag == 1)
            {
                dgvStorageInfo.DataSource = null;
                dgvStorageInfo.Rows.Clear();
                addDataList.Clear();
                addDataList = saveData;
                saveData.Clear();
                payBtnClickFlag = 0;
            }

            List<StorageInfoForClientEntity> dbList = Dao.StorageInfoForClient.GetList();
           
            Label labelBox = (Label)sender;

            int labelNum = Convert.ToInt32(labelBox.Text);
            // 만약 누른 라벨의 배경색이 하얀거라면 노랗게 만들고
            if (labelBox.BackColor == Color.White)
            {
                labelBox.BackColor = Color.Yellow;
                // 그리고 리스트에 나오게 만들어아햠
                //dgvStorageInfo.DataSource = dbList[labelNum];
                addDataList.Add(dbList[labelNum]);
                // 이 사이에
            }
            // 노란건 이미 선택된거기 때문에 다시 하얀색으로
            else if (labelBox.BackColor == Color.Yellow)
            {
                int labelCheckNum = Convert.ToInt32(labelBox.Text);

                if((labelCheckNum < nomalboxMaxNum && toggleFlag == 0) || (labelCheckNum >= nomalboxMaxNum && toggleFlag == 1))
                {
                    labelBox.BackColor = Color.White;
                }
                else if ((labelCheckNum < nomalboxMaxNum && toggleFlag == 1)|| (labelCheckNum >= nomalboxMaxNum && toggleFlag == 0))
                {
                    labelBox.BackColor = Color.DarkGray;
                }
            }
            // 빨간건 이미 사용중인거라 결제버튼 비활성화하고 검정색으로
            else if (labelBox.BackColor == Color.Red)
            {
                labelBox.BackColor = Color.Black;
                labelBox.ForeColor = Color.White;
            }
            else if (labelBox.BackColor == Color.Black)
            {
                labelBox.BackColor = Color.Red;
                labelBox.ForeColor = Color.Black;
            }
            // 다크그레이는 신선이나 일반에서 비활성화인것들
            else if (labelBox.BackColor == Color.DarkGray)
            {
                // 아무것도 안되도록
                // 정보도 뜨면 안된다
            }

            

            int blackLabelCount = 0;
            foreach (var item in _labels)
            {
                if(item.BackColor == Color.Black)
                {
                    blackLabelCount++;
                }
            }

            if(blackLabelCount > 0)
            {
                payBtn.Enabled = false;
            }
            else if(blackLabelCount == 0)
            {
                payBtn.Enabled = true;
            }
        }

        private void saveListPush(List<StorageInfoForClientEntity> addDataList)
        {
            saveData = addDataList;
        }

        // 결제버튼 누르면 화면 띄우는 메서드
        public void boxCheckClick(object sender, EventArgs e)
        {
            dgvStorageInfo.DataSource = null;
            dgvStorageInfo.Rows.Clear();
            selectCheck();
            
            dgvStorageInfo.DataSource = addDataList.OrderBy(o => o.StorageId).ToList();
            payBtnClickFlag = 1;   
        }

        public void PayBtnClick(object sender, EventArgs e)
        {
            dgvStorageInfo.DataSource = null;
            dgvStorageInfo.Rows.Clear();
            
            dgvStorageInfo.DataSource = addDataList.OrderBy(o => o.StorageId).ToList();
            saveListPush(addDataList);
            payBtnClickFlag = 1;
            Payment payment = new Payment(saveData);
            payment.Show();
        }

        private void exitBtn(object sender, EventArgs e)
        {
            Close();
        }
    }
}
