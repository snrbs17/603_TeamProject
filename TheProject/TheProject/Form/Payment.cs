﻿using EF.Data.Dao;
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
        private Payment()
        {
            InitializeComponent();
        }

        // Storage에서 리스트를 payList에 받아옴
        private List<StorageInfoForClientEntity> selectList = new List<StorageInfoForClientEntity>();
        public List<PaymentEntity> paymentList = new List<PaymentEntity>();

        public Payment(List<StorageInfoForClientEntity> list)
        {
            InitializeComponent();
            ExtractStorageData(list);
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
        private void dgvCellReadOnly()
        {
            for (int i = 0; i < dgvInfo.Columns.Count; i++)
            {
                dgvInfo.Columns[i].ReadOnly = true;
            }
        }

        // dgv error
        private void dgvTest_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            dgvCellReadOnly();
            dgvInfo.Columns[4].ReadOnly = false;

            payBtn.Enabled = false;
            payBtn.BackColor = Color.DarkGray;
            infoTotalFee.Text = "시간을 선택해주세요.";
            infoPayFee.Text = "0원 입니다.";
        }

        private void addBtn(object sender, EventArgs e)
        {
            // 넘어간 폼의 기존 화면 쓰게
            Close();
        }

        private void exitBtn(object sender, EventArgs e)
        {
            // 나중에 넘어간 Form 데이터 리셋시켜야함
            Close();
        }


        // 입금금액과 총금액이 맞는지 확인
        private void textChanged(object sender, EventArgs e)
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
        /*private void payBtnClick(object sender, EventArgs e)
        {
            // 여기에 데이터 넘겨줘야함
            Dao.Payment.InputData(paymentList);
            Close();
        }*/


        // comboBoxClick시 
        // 아직 바로 떠야되는데 안뜸
        private void comboBoxClick(object sender, DataGridViewCellEventArgs e)
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

            int sumTotal = 0;
            for (int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                sumTotal += Convert.ToInt32(dgvInfo.Rows[i].Cells[5].Value);
            }

            infoTotalFee.Text = $"{sumTotal:C} 원 입니다.";
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
    }
}
