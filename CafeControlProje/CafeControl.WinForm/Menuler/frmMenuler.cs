using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeControl.Entities.Models;

namespace CafeControl.WinForm.Menuler
{
    public partial class frmMenuler : DevExpress.XtraEditors.XtraForm
    {
       private CafeContext context = new CafeContext();
        public frmMenuler()
        {
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource= context.Menu.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan menü silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}