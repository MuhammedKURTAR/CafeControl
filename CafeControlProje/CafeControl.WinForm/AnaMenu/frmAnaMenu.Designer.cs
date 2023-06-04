namespace CafeControl.WinForm.AnaMenu
{
    partial class frmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMasalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMasaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuler = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoller = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoviz = new DevExpress.XtraBars.BarButtonItem();
            this.btnYardim = new DevExpress.XtraBars.BarButtonItem();
            this.btnHakkimizda = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMasalar,
            this.btnMasaHareketleri,
            this.btnMenuler,
            this.btnMenuHareketleri,
            this.btnUrunler,
            this.barButtonItem1,
            this.btnKullanicilar,
            this.btnKullaniciHareketleri,
            this.btnRoller,
            this.btnDoviz,
            this.btnYardim,
            this.btnHakkimizda});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1049, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnMasalar
            // 
            this.btnMasalar.Caption = "Masalar";
            this.btnMasalar.Id = 1;
            this.btnMasalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasalar.ImageOptions.Image")));
            this.btnMasalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMasalar.ImageOptions.LargeImage")));
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasalar_ItemClick);
            // 
            // btnMasaHareketleri
            // 
            this.btnMasaHareketleri.Caption = "Masa Hareketleri";
            this.btnMasaHareketleri.Id = 2;
            this.btnMasaHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaHareketleri.ImageOptions.Image")));
            this.btnMasaHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMasaHareketleri.ImageOptions.LargeImage")));
            this.btnMasaHareketleri.Name = "btnMasaHareketleri";
            // 
            // btnMenuler
            // 
            this.btnMenuler.Caption = "Menüler";
            this.btnMenuler.Id = 3;
            this.btnMenuler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenuler.ImageOptions.SvgImage")));
            this.btnMenuler.Name = "btnMenuler";
            this.btnMenuler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenuler_ItemClick);
            // 
            // btnMenuHareketleri
            // 
            this.btnMenuHareketleri.Caption = "Menü Hareketleri";
            this.btnMenuHareketleri.Id = 4;
            this.btnMenuHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenuHareketleri.ImageOptions.SvgImage")));
            this.btnMenuHareketleri.Name = "btnMenuHareketleri";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 5;
            this.btnUrunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunler.ImageOptions.SvgImage")));
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ürün Hareketleri";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Caption = "Kullanıcılar";
            this.btnKullanicilar.Id = 7;
            this.btnKullanicilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.Image")));
            this.btnKullanicilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.LargeImage")));
            this.btnKullanicilar.Name = "btnKullanicilar";
            // 
            // btnKullaniciHareketleri
            // 
            this.btnKullaniciHareketleri.Caption = "Kullanıcı Hareketleri";
            this.btnKullaniciHareketleri.Id = 8;
            this.btnKullaniciHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.Image")));
            this.btnKullaniciHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.LargeImage")));
            this.btnKullaniciHareketleri.Name = "btnKullaniciHareketleri";
            // 
            // btnRoller
            // 
            this.btnRoller.Caption = "Rol Tanımla";
            this.btnRoller.Id = 9;
            this.btnRoller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoller.ImageOptions.Image")));
            this.btnRoller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRoller.ImageOptions.LargeImage")));
            this.btnRoller.Name = "btnRoller";
            // 
            // btnDoviz
            // 
            this.btnDoviz.Caption = "Döviz";
            this.btnDoviz.Id = 10;
            this.btnDoviz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoviz.ImageOptions.Image")));
            this.btnDoviz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoviz.ImageOptions.LargeImage")));
            this.btnDoviz.Name = "btnDoviz";
            // 
            // btnYardim
            // 
            this.btnYardim.Caption = "Yardım";
            this.btnYardim.Id = 11;
            this.btnYardim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.ImageOptions.Image")));
            this.btnYardim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYardim.ImageOptions.LargeImage")));
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYardim_ItemClick);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Caption = "Hakkımızda";
            this.btnHakkimizda.Id = 12;
            this.btnHakkimizda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.ImageOptions.Image")));
            this.btnHakkimizda.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.ImageOptions.LargeImage")));
            this.btnHakkimizda.Name = "btnHakkimizda";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cafe İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMasalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMasaHareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Masalar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenuler);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenuHareketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Menuler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Ürünler";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKullanicilar);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKullaniciHareketleri);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRoller);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kullanıcılar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoviz);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYardim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHakkimizda);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ayarlar";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 480);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1049, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 510);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmAnaMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cafe Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnMasalar;
        private DevExpress.XtraBars.BarButtonItem btnMasaHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnMenuler;
        private DevExpress.XtraBars.BarButtonItem btnMenuHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnRoller;
        private DevExpress.XtraBars.BarButtonItem btnDoviz;
        private DevExpress.XtraBars.BarButtonItem btnYardim;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnHakkimizda;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}