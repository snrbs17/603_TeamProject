using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cus.Form5
{
    public partial class BoxForm2 : Form
    {
        public BoxForm2()
        {
            InitializeComponent();
        }
        public BoxForm2(box box) : this()
        {
            _box = box;
        }

        private box _box;

        public void InsertOrUpdate()    
        {
            if (_box.boxID == 0)
                Dao.Box.Insert(_box);
            else
                Dao.Box.Update(_box);
        }

        //public void ReadFromEntity()
        //{
        //    txbArtistId.Text = _box.boxID.ToString();
        //    txbName.Text = _box.Name;
        //}

        //public void WriteToEntity()
        //{
        //    _box.Name = txbName.Text;
        //}
    }
}
