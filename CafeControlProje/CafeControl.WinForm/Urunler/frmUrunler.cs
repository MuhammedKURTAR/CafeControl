using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeControl.Entities.DAL;
using CafeControl.Entities.Models;

namespace CafeControl.WinForm.Urunler
{
    public partial class frmUrunler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UrunDal urunDal = new UrunDal();
        
        public frmUrunler()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = urunDal.UrunListele(context);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmUrunKaydet frm = new frmUrunKaydet(new Urun());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
           
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliid=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmUrunKaydet frm = new frmUrunKaydet(urunDal.GetByFilter(context,u=>u.Id==seciliid));
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        { 
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt silinecek. Onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                urunDal.Delete(context,u=>u.Id==seciliId);
                urunDal.Save(context);
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}