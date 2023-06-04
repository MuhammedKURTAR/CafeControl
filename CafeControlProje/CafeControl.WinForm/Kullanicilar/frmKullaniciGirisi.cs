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
using CafeControl.Entities.Models;

namespace CafeControl.WinForm.Kullanicilar
{
    public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context=new CafeContext();
        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {

                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }


        void BilgileriKaydet()
        {

            if (checkBeniHatirla.Checked)
            {

                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }

            else
            {


                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }

        }

        public frmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void frmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(k=>k.KullanıcıAdi==txtKullaniciAdi.Text && k.Parola==txtParola.Text))
            {
                giris = true;
                BilgileriKaydet(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parolanız yanlış.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void lblKaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frm = new frmKaydol(new Entities.Models.Kullanicilar());
            frm.ShowDialog();

        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            frmParolamıUnuttum frm = new frmParolamıUnuttum();
            frm.ShowDialog();
        }

        private void frmKullaniciGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}