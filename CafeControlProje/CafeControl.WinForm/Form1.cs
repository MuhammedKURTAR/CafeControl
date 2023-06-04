using CafeControl.Entities.DAL;
using CafeControl.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeControl.WinForm
{
    public partial class Form1 : Form
    {
        CafeContext context = new CafeContext();
        MenuDal MenuDal = new MenuDal();
        Entities.Models.Menu entity;

       

        public Form1()
        {
            InitializeComponent();
            entity= new Entities.Models.Menu();
            txtMenuAdi.DataBindings.Add("Text", entity, "MenuAdi");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (MenuDal.AddOrUpdate(context,entity))
            {
                MenuDal.Save(context);
            }
        }
    }
}
