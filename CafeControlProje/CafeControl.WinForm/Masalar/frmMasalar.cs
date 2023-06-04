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

namespace CafeControl.WinForm.Masalar
{
    public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masalarDal=new MasalarDal();

        public frmMasalar()
        {
            InitializeComponent();
            gridControl1.DataSource = masalarDal.MasalariListele(context);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

        }
    }
}