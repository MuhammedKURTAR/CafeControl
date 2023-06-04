namespace CafeControl.WinForm.Kullanicilar
{
    partial class frmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGirisi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnParolamiUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.lblKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.checkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(733, 53);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Girişi";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(0, 53);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(311, 308);
            this.pictureEdit2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnParolamiUnuttum);
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(311, 267);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(422, 94);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(276, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(134, 51);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParolamiUnuttum.ImageOptions.Image")));
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(136, 31);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(126, 51);
            this.btnParolamiUnuttum.TabIndex = 0;
            this.btnParolamiUnuttum.Text = "Parolamı \r\nUnuttum";
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.ImageOptions.Image")));
            this.btnGirisYap.Location = new System.Drawing.Point(5, 31);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(125, 51);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(351, 101);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.Image")));
            this.txtKullaniciAdi.Properties.NullText = "Kullanıcı Adını Giriniz";
            this.txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adını Giriniz";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(370, 30);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(351, 156);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImageOptions.Image")));
            this.txtParola.Properties.NullText = "Şifrenizi Giriniz";
            this.txtParola.Properties.NullValuePrompt = "Şifrenizi Giriniz";
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(370, 30);
            this.txtParola.TabIndex = 5;
            // 
            // lblKaydol
            // 
            this.lblKaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydol.Appearance.Options.UseFont = true;
            this.lblKaydol.Location = new System.Drawing.Point(668, 208);
            this.lblKaydol.Name = "lblKaydol";
            this.lblKaydol.Size = new System.Drawing.Size(53, 22);
            this.lblKaydol.TabIndex = 6;
            this.lblKaydol.Text = "Kaydol";
            this.lblKaydol.Click += new System.EventHandler(this.lblKaydol_Click);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Location = new System.Drawing.Point(351, 206);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            this.checkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(149, 26);
            this.checkBeniHatirla.TabIndex = 7;
            // 
            // frmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 361);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.lblKaydol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciGirisi";
            this.Text = "frmKullaniciGirisi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciGirisi_FormClosing);
            this.Load += new System.EventHandler(this.frmKullaniciGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnParolamiUnuttum;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblKaydol;
        private DevExpress.XtraEditors.CheckEdit checkBeniHatirla;
    }
}