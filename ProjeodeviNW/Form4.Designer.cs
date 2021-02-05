namespace ProjeodeviNW
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.lblCikis = new System.Windows.Forms.Label();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gainsboro;
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel14.Controls.Add(this.lblCikis);
            this.panel14.Controls.Add(this.btnMusteri);
            this.panel14.Controls.Add(this.txtKullaniciSifre);
            this.panel14.Controls.Add(this.txtKullaniciAd);
            this.panel14.Controls.Add(this.label108);
            this.panel14.Controls.Add(this.label133);
            this.panel14.Controls.Add(this.btnYonetici);
            this.panel14.Location = new System.Drawing.Point(101, 50);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(473, 322);
            this.panel14.TabIndex = 6;
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.White;
            this.btnMusteri.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(56, 209);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(142, 56);
            this.btnMusteri.TabIndex = 9;
            this.btnMusteri.Text = "Müşteri Girişi";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.Location = new System.Drawing.Point(214, 124);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(150, 28);
            this.txtKullaniciSifre.TabIndex = 8;
            this.txtKullaniciSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciSifre_KeyPress);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.Location = new System.Drawing.Point(214, 60);
            this.txtKullaniciAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(150, 28);
            this.txtKullaniciAd.TabIndex = 7;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.BackColor = System.Drawing.Color.Transparent;
            this.label108.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label108.Location = new System.Drawing.Point(70, 128);
            this.label108.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(64, 23);
            this.label108.TabIndex = 6;
            this.label108.Text = "Sifre:";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.BackColor = System.Drawing.Color.Transparent;
            this.label133.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label133.Location = new System.Drawing.Point(52, 60);
            this.label133.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(147, 23);
            this.label133.TabIndex = 5;
            this.label133.Text = "Kullanıcı Adı:";
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.Color.White;
            this.btnYonetici.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetici.Location = new System.Drawing.Point(248, 209);
            this.btnYonetici.Margin = new System.Windows.Forms.Padding(2);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(142, 56);
            this.btnYonetici.TabIndex = 3;
            this.btnYonetici.Text = "Yönetici Girişi";
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.Black;
            this.lblCikis.Location = new System.Drawing.Point(401, 280);
            this.lblCikis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(49, 18);
            this.lblCikis.TabIndex = 7;
            this.lblCikis.Text = "Çıkış";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 535);
            this.Controls.Add(this.panel14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label lblCikis;
    }
}