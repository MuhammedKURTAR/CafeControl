using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeControl.WinForm.Kullanicilar;
using CafeControl.WinForm.Masalar;
using CafeControl.WinForm.Menuler;
using CafeControl.WinForm.Urunler;
using DevExpress.XtraEditors;

namespace CafeControl.WinForm.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        void FormGetir(XtraForm frm)
        {
            frm.MdiParent=this;
            frm.Show();
        }
        public frmAnaMenu()
        {
            InitializeComponent();
            frmKullaniciGirisi frm = new frmKullaniciGirisi();
            frm.ShowDialog();
        }

        private void btnYardim_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            FormGetir(frm);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMenuler frm = new frmMenuler();
            frm.ShowDialog();
        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            FormGetir(frm);
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}