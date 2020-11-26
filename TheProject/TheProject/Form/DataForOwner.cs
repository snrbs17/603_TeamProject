using System;
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
            //List<Import> list = Dao.Import.ImpoprtPerUnitTime(DataCreator.func);
            //dataGridView1.DataSource = list;
            List<ImportEntity> list = Dao.Import.YearlyImpoprt(2020);

            foreach (var x in list)
                chart1.Series[0].Points.AddXY(x.TimeUnit,x.Cost);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //MyLibrary.DataCreator.function(int month) = x => x.PaymentDate.Month == month;
            comboBox1.Visible = true;
            comboBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int year = 2020;
            DataCreator.TimeScope = Dao.Import.Yearly(year);

            comboBox3.Visible = true;
            comboBox1.Visible = false;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int timeUnitValue = comboBox1.SelectedIndex;
            DataCreator.TimeScope = Dao.Import.Monthly(timeUnitValue);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int timeUnitValue = comboBox3.SelectedIndex;
            DataCreator.TimeScope = Dao.Import.Yearly(timeUnitValue);
        }
    }
}
