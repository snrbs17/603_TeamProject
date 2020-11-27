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

        // 사용하는 필드 (나중에 모아서 클래스 이동)
        private int toggleFlag = 0;
        private int nomalboxMaxNum = 14;
        private int payBtnClickFlag = 0;

        // 사용하는 리스트
        private List<Label> _labels = new List<Label>();
        private List<StorageInfoForClientEntity> dbList = Dao.StorageInfoForClient.GetList();
        private List<StorageInfoForClientEntity> addDataList = new List<StorageInfoForClientEntity>();
        public List<StorageInfoForClientEntity> saveData = new List<StorageInfoForClientEntity>();

        // CreateLabelList - _labels를 만들기 위해 reflection 하는 메서드
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

        // OnLoad - 초기 시작시
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CreateLabelList();

            // 데이터를 받아 storageTypeId 에 따라 색을 부여
            Toggle();

            //dgv
            dgvStorageInfo.DataSource = null;
            CheckRedBox();
        }

        // CheckRedBox - 사용중인 박스 찾아서 Red로 표현해주는 메서드
        private void CheckRedBox()
        {
            foreach (var item in _labels)
            {
                List<StorageInfoForClientEntity> dbList = Dao.StorageInfoForClient.GetList();
                for (int i = 0; i < dbList.Count; i++)
                {
                    if (item.Text == Convert.ToString(dbList[i].StorageId) && dbList[i].Activation == false)
                    {
                        item.BackColor = Color.Red;
                    }
                }
            }
        }

        // ToggleClick - toggle에 따라 색상 변화하는 메서드
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
                ToggleReverse();
            }
            else
            {
                tog.ToggleCircleColor = Color.Silver;
                tog.ToggleBarText = " 일반";
                toggleFlag = 0;
                Toggle();
            }

            SelectCheck();
        }
        
        // Toggle, ToggleReverse - 토글 기능
        public void Toggle()
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
            CheckRedBox();
        }
        public void ToggleReverse()
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
            CheckRedBox();
        }

        // ClickLabel - 라벨 선택시 데이터를 dgv에 표시해주고 색상 변화를 주는 메서드
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
                addDataList.Add(dbList[labelNum]);
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

            int yellowCount = 0;
            foreach (var item in _labels)
            {
                if (item.BackColor == Color.Yellow)
                    yellowCount++;
            }
            infoBtn.Text = $"현재 보관함 {yellowCount}개를 선택하셨습니다.";
        }

        // BoxCheckClick - 박스 정보를 보기위해 누르는
        public void BoxCheckClick(object sender, EventArgs e)
        {
            ShowDgv();
        }

        // PayBtnClick - 버튼 누르면 결제창르로 이동
        public void PayBtnClick(object sender, EventArgs e)
        {
            ShowDgv();

            SaveListPush(addDataList);

            Payment payment = new Payment(saveData, this);
            payment.Show();
        }

        // SaveListPush - 저장해서 결제화면으로 보내주기 위해 리스트를 저장
        private void SaveListPush(List<StorageInfoForClientEntity> addDataList)
        {
            saveData = addDataList;
        }
        
        // SelectCheck - 다시 화면 돌아왔을때 선택되어 있는 박스를 체크
        private void SelectCheck()
        {
            addDataList.Clear();
            foreach (var item in _labels)
            {
                if (item.BackColor == Color.Yellow)
                {
                    int index = Convert.ToInt32(item.Text) - 1;
                    addDataList.Add(dbList[index]);
                }
            }
        }

        // ShowDgv - dgv 보여주는 메서드
        public void ShowDgv()
        {
            dgvStorageInfo.DataSource = null;
            dgvStorageInfo.Rows.Clear();
            SelectCheck();
            dgvStorageInfo.DataSource = addDataList.OrderBy(o => o.StorageId).ToList();
            for (int i = 0; i < dgvStorageInfo.ColumnCount; i++)
            {
                DataGridViewColumn column = dgvStorageInfo.Columns[i];
                dgvStorageInfo.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.Width = 191;
            }
            
            dgvStorageInfo.Columns[4].Visible = false;
            payBtnClickFlag = 1;
        }

        // ExitBtn - 나가기 버튼
        private void ExitBtn(object sender, EventArgs e)
        {
            Close();
        }
    }
}
