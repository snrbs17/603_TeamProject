﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF.Data;
using EF.Data.Dao;
using EF.Data.Entities;
using MyLibrary;

namespace TheProject
{
    public partial class DataForOwner : Form
    {
        public DataForOwner()
        {
            InitializeComponent();
        }

        private void DataForOwner_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ImportEntity> list =
                Dao.Import.ImpoprtPerUnitTime(DataCreator.TimeScope, DataCreator.TimeUnit);
            dataGridView1.DataSource = list;

            foreach (var x in list)
                chart1.Series[0].Points.AddXY(x.TimeUnit,x.Cost);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //MyLibrary.DataCreator.function(int month) = x => x.PaymentDate.Month == month;
            comboBox1.Visible = true;
            comboBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            comboBox3.Visible = true;
            comboBox1.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int timeUnitValue = comboBox1.SelectedIndex+1;
            DataCreator.TimeScope = Dao.Import.Monthly(timeUnitValue);
            DataCreator.TimeUnit = Dao.Import.DaylyUnit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int timeUnitValue = DateTime.Now.Year - comboBox3.SelectedIndex;
            DataCreator.TimeScope = Dao.Import.Yearly(timeUnitValue);
            DataCreator.TimeUnit = Dao.Import.MonthlyUnit();
        }
    }
}
