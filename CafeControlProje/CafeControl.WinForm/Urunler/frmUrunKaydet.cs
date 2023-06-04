using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeControl.Entities.DAL;
using CafeControl.Entities.Models;

namespace CafeControl.WinForm.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private MenuDal menuDal = new MenuDal();
        private UrunDal urunDal= new UrunDal();
        private Urun _entity;
        private CafeContext context=new CafeContext();
        public bool kaydet = false;

        public frmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            lookUpMenü.Properties.DataSource = menuDal.GetAll(context);
            lookUpMenü.DataBindings.Add("EditValue", _entity, "MenuId");
            txtUrunKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", _entity, "UrunAdi");
            calcBirimFiyati1.DataBindings.Add("Text", _entity, "BirimFiyati1",true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity, "BirimFiyati2",true);
            calcBirimFiyati3.DataBindings.Add("Text", _entity, "BirimFiyati3", true);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            dateEdit1.DataBindings.Add("Text", _entity, "Tarih",true);
            if (_entity.Id!=0)
            {
                if (_entity.Resim!=null)
                {
                    pictureEdit1.Image =Image.FromFile(_entity.Resim); ;
                }
            }



        }

        private void frmUrunKaydet_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation()!="")
            {
                string hedefyol = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hedefyol);
                _entity.Resim = $"Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png"; 
            }
            if (urunDal.AddOrUpdate(context, _entity))
            {
                urunDal.Save(context);
                kaydet = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
}