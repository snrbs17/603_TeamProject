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
using EFLibrary;
using MyLibrary;

namespace TheProject
{
    public partial class DataForOwner : Form
    {
        int timeUnitValue;
        public DataForOwner()
        {
            InitializeComponent();
        }

        private void DataForOwner_Load(object sender, EventArgs e)
        {
            var list = Dao.Storage.GetAll();
            foreach (var item in list)
            {
                if (item.Activation == true && item.StorageId <= 20)
                    checkedListBox1.SetItemChecked(item.StorageId - 1, true);
            }

            radioButton3.PerformClick();
            radioButton1.PerformClick();

            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndex = DateTime.Now.Month -1;

            chart1.Series.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            List<ImportEntity> list =
                Dao.Import.ImpoprtPerUnitTime(DataCreator.TimeScope, DataCreator.TimeUnit, DataCreator.TypeSelect);
            dataGridView1.DataSource = list;

            chart1.Series.Add("Import");
            foreach (var x in list)
                chart1.Series["Import"].Points.AddXY(x.TimeUnit,x.Cost);
            //chart1.Series["Import"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //MyLibrary.DataCreator.function(int month) = x => x.PaymentDate.Month == month;
            comboBox1.Enabled = true;
            comboBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            comboBox1.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeUnitValue = comboBox1.SelectedIndex+1;
            DataCreator.TimeScope = Dao.Import.Monthly(timeUnitValue);
            DataCreator.TimeUnit = Dao.Import.DaylyUnit();
            button1.Enabled = true;
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int timeUnitValue = DateTime.Now.Year - comboBox3.SelectedIndex;
            DataCreator.TimeScope = Dao.Import.Yearly(timeUnitValue);
            DataCreator.TimeUnit = Dao.Import.MonthlyUnit();
            button1.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            DataCreator.TypeSelect = Dao.Import.Normal();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DataCreator.TypeSelect = Dao.Import.Fridge();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataCreator.TypeSelect = Dao.Import.AnyType();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //checkedListBox1.CheckedItems.
            //var list = Dao.Storage.GetAll();
            /*list[0].Activation = false;
            using (var context = DbContextCreator.Context())
            {
                context.Entry(Dao.Storage.GetByPK(1).state = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
            Dao.Storage.Update(Dao.Storage.GetByPK(1));*/

            button2.Enabled = false;
            button2.BackColor = SystemColors.ControlLight;
            //todo update : var x = context.Fees.Where(x =>조건(ex x.FeeId ==1)).ToList();
            //https://www.csharpstudy.com/Data/SQL-linq-dml.aspx 마지막 줄 submitChanges 대신에 SaveChanges
            using (var context = new projectEntities())
            {
                var x = context.Storages.ToList();
                if(x != null)
                {
                    foreach (var item in x)
                    {
                        if (item.StorageId <= 20)
                            item.Activation = checkedListBox1.GetItemChecked(item.StorageId - 1);
                    }
                    context.SaveChanges();
                }
            }
            //update ends
            button2.Enabled = true;
            button2.BackColor = SystemColors.GradientActiveCaption;
        }
    }
}
