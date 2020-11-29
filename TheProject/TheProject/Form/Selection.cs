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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Search searchform = new Search();
            searchform.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void storage_Click(object sender, EventArgs e)
        {
            Storage storageform = new Storage();
            storageform.ShowDialog();
        }

        private void release_Click(object sender, EventArgs e)
        {
            Release releaseform = new Release();
            releaseform.ShowDialog();
        }
    }
}
