using EF.Data.Dao;
using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Payment : Form
    {

        // Storage에서 리스트를 payList에 받아옴
        //private List<StorageInfoForClientEntity> selectList = new List<StorageInfoForClientEntity>();
        public List<PaymentEntity> paymentList = new List<PaymentEntity>();
        public List<PaymentEntity> sendPaymentList = new List<PaymentEntity>();
        Storage storageForm;
        private int memberID = 0;
        private int sumTotal = 0;
        private int showFlag = 0;

        private Payment()
        {
            InitializeComponent();
        }

        public Payment(List<StorageInfoForClientEntity> list, Storage form, int memberId) : this()
        {
            ExtractStorageData(list);
            storageForm = form;
            memberID = memberId;
        }

        private void ExtractStorageData(List<StorageInfoForClientEntity> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //paymentList[i].StorageId = list[i].StorageId;
                //paymentList[i].StorageTypeId = list[i].StorageTypeId;
                //paymentList[i].EntryDate = DateTime.Now;
                //paymentList[i].ExitDateExpected = null;
                //paymentList[i].TimePassId = 0;
                //paymentList[i].Cost = 0;
                //payList.Add(paymentList[i]);

                paymentList.Add(new PaymentEntity()
                {
                    StorageId = list[i].StorageId,
                    StorageTypeId = list[i].StorageTypeId,
                    EntryDate = DateTime.Now,
                    ExitDateExpected = null,
                    TimePassId = 0,
                    Cost = 0
                });
            }
            dgvInfo.DataSource = paymentList;
        }

        // combobox list
        private DataGridViewComboBoxCell dgvComboBox()
        {
            DataGridViewComboBoxCell cCell = new DataGridViewComboBoxCell();
            cCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            for (int i = 0; i < 25; i++)
            {
                cCell.Items.Add(i);
            }
            return cCell;
        }

        // dgvCell readonly
        private void DgvCellReadOnly()
        {
            for (int i = 0; i < dgvInfo.Columns.Count; i++)
            {
                dgvInfo.Columns[i].ReadOnly = true;
            }
        }

        // dgv error
        private void DgvTest_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message.Contains("DataGridViewComboBoxCell"))
                {
                    object value = dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvInfo.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        ((DataGridViewComboBoxColumn)dgvInfo.Columns[e.ColumnIndex]).Items.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                //do nothing
            }
        }

        // 시작시
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 우선 받아온 payList만 보여줌
            // 여기에 따로 받아온 List를 넣어줘야함
            dgvInfo.DataSource = paymentList.OrderBy(o => o.StorageId).ToList();

            for (int i = 0; i < paymentList.Count; i++)
            {
                dgvInfo.Rows[i].Cells[4] = dgvComboBox();
            }
            DgvCellReadOnly();
            dgvInfo.Columns[4].ReadOnly = false;

            TextCheck();
            infoTotalFee.Text = "시간을 선택해주세요.";
            infoPayFee.Text = "0원 입니다.";
        }

        private void AddBtnClick(object sender, EventArgs e)
        {
            // 넘어간 폼의 기존 화면 쓰게 그냥 close
            Close();
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            // 나중에 메인으로 연결하기
            // ex) MainForm mainForm = new MainForm(고객아이디)    mainForm.show()
            storageForm.Close();
            Close();
        }


        // 입금금액과 총금액이 맞는지 확인
        private void TextCheck()
        {
            if (infoPayFee.Text == infoTotalFee.Text)
            {
                payBtn.Enabled = true;
                payBtn.BackColor = Color.Firebrick;
            }
            else
            {
                payBtn.Enabled = false;
                payBtn.BackColor = Color.DarkGray;
            }
        }

        // 결제 버튼 누른겨
        private void PayBtnClick(object sender, EventArgs e)
        {
            // 여기에 데이터 넘겨줘야함
            // Dao.Payment.InputData(paymentList);

            foreach (DataGridViewRow dr in dgvInfo.Rows)
            {
                //Create object of your list type pl
                PaymentEntity pl = new PaymentEntity();
                pl.StorageId = Convert.ToInt32(dr.Cells[0].Value);
                pl.StorageTypeId = Convert.ToInt32(dr.Cells[1].Value);
                pl.EntryDate = Convert.ToDateTime(dr.Cells[2].Value);
                pl.ExitDateExpected = Convert.ToDateTime(dr.Cells[3].Value);
                pl.TimePassId = Convert.ToInt32(dr.Cells[4].Value);
                pl.Cost = Convert.ToInt32(dr.Cells[5].Value);
                //Add pl to your List  
                sendPaymentList.Add(pl);
            }
            // todo 데이터 업데이트
            // 만약 입출고선택화면도 꺼져있다면 여기서 열어주기
            MessageBox.Show($"{memberID} 고객님 결제가 완료되었습니다.");
            storageForm.Close();
            Close();
        }

        // todo 카드나 돈을 받아서 넣게 해야할듯
        private void PayTestBtnClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                if(dgvInfo.Rows[i].Cells[3].Value == null || Convert.ToString(dgvInfo.Rows[i].Cells[5].Value)=="0")
                {
                    payBtn.Enabled = false;
                    payBtn.BackColor = Color.DarkGray;
                    payBtn.ForeColor = Color.White;
                    MessageBox.Show("아직 사용시간이 선택되지 않았습니다.");
                    showFlag = 1;
                    break;
                }
                else
                {
                    showFlag = 0;
                }
            }
            if(showFlag == 0)
            {
                infoPayFee.Text = $"{sumTotal:c} 원 입니다.";
                TextCheck();
            }
            
        }

        // comboBoxClick시 
        // 아직 바로 떠야되는데 안뜸
        private void ComboBoxClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            int selectCellRow = e.RowIndex;
            if (e.ColumnIndex == 4)
            {
                int selectTime = Convert.ToInt32(dgvInfo.Rows[selectCellRow].Cells[4].Value);
                DateTime date = Convert.ToDateTime(dgvInfo.Rows[selectCellRow].Cells[2].Value);
                dgvInfo.Rows[selectCellRow].Cells[3].Value = date.AddHours(selectTime);
                dgvInfo.Rows[selectCellRow].Cells[5].Value = selectTime * 1000;
            }

            sumTotal = 0;
            for (int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                sumTotal += Convert.ToInt32(dgvInfo.Rows[i].Cells[5].Value);
            }

            infoTotalFee.Text = $"{sumTotal:C} 원 입니다.";
            
        }

        private void BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void BGWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        /*private void changedCell(DataGridViewCellEventArgs e)
        {
            int selectCellRow = e.RowIndex;
            if (e.ColumnIndex == 4)
            {
                int selectTime = Convert.ToInt32(dgvInfo.Rows[selectCellRow].Cells[4].Value);
                DateTime date = Convert.ToDateTime(dgvInfo.Rows[selectCellRow].Cells[2].Value);
                dgvInfo.Rows[selectCellRow].Cells[3].Value = date.AddHours(selectTime);
                dgvInfo.Rows[selectCellRow].Cells[5].Value = selectTime * 1000;
            }

            int sumTotal = 0;
            for (int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                sumTotal += Convert.ToInt32(dgvInfo.Rows[i].Cells[5].Value);
            }

            infoTotalFee.Text = $"{sumTotal:C} 원 입니다.";
        }*/


        // todo Payment
        // 1. 콤보박스 선택 후 반응 바로 안되는거
        // 2. date 전부 나올 수 있게 칸 사이즈 조절
        // 3. DB에 업데이트 가능하게
        // 4. 카드결제 가능하게(테스트 버튼 대신에)

    }
}
