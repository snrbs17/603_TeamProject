using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF.Data.Dao;
using EF.Data.Entities;

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
            // TODO: This line of code loads data into the 'projectDataSet.StorageSelection' table. You can move, or remove it, as needed.
            this.storageSelectionTableAdapter.Fill(this.projectDataSet.StorageSelection);
            // TODO: This line of code loads data into the 'projectDataSet.Reciept' table. You can move, or remove it, as needed.
            this.recieptTableAdapter.Fill(this.projectDataSet.Reciept);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ImportEntity> list = Dao.Import.MonthlyImpoprt(11);

            dataGridView1.DataSource = list;

            foreach (var x in list)
                chart1.Series[0].Points.AddXY(x.Day,x.Cost);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
