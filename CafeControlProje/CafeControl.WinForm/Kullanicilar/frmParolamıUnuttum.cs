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

namespace CafeControl.WinForm.Kullanicilar
{
    public partial class frmParolamıUnuttum : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        public frmParolamıUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = kullanicilarDal.GetByFilter(context,
                k => k.KullanıcıAdi == txtKullaniciAdiEmail.Text || k.Email == txtKullaniciAdiEmail.Text);
            if (entity != null)
            {
                if (entity.HatirlatmaSorusu == txtSoru.Text && entity.Cevap == txtCevap.Text)
                {
                    if (txtYeniParola.Text==txtParolaTekrar.Text)
                    {
                        entity.Parola = txtYeniParola.Text;
                        if(kullanicilarDal.AddOrUpdate(context,entity))
                        {
                            kullanicilarDal.Save(context);
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Soru veya Cevap Yanlış.");
                }

            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}