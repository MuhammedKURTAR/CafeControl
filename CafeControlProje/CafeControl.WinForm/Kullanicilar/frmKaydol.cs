using CafeControl.Entities.DAL;
using CafeControl.Entities.Mapping;
using CafeControl.Entities.Models;
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

namespace CafeControl.WinForm.Kullanicilar
{
    public partial class frmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private Entities.Models.Kullanicilar _entity;
        public bool kaydet = false;
        public frmKaydol(Entities.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;

            toggleAktifMi.DataBindings.Add("EditValue", _entity, "AktifMi");
            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullanıcıAdi");
            txtParola.DataBindings.Add("Text", _entity, "Parola");
            txtSoru.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "Cevap");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtParola.Text == txtParolaTekrar.Text)
            {
                 _entity.KayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _entity))
                {

                    kullanicilarDal.Save(context);
                    kaydet = true;
                    this.Close();

                }
            }
            else
            {

                MessageBox.Show("Şifreler uyuşmuyor.");
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblYeniKullanici_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmKaydol_Load(object sender, EventArgs e)
        {

        }
    }
}