namespace ProjeodeviNW
{
    partial class ödemeşekli
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.onayla = new DevExpress.XtraEditors.SimpleButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Gadugi", 22F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(25, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Merhaba ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Gadugi", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAd.Location = new System.Drawing.Point(145, 23);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(104, 36);
            this.lblAd.TabIndex = 7;
            this.lblAd.Text = "label3";
            this.lblAd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(84, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ödeme Yöntemini Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(60, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Teslimat bilgileri (Adres)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 328);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 82);
            this.textBox1.TabIndex = 10;
            // 
            // onayla
            // 
            this.onayla.Appearance.BackColor = System.Drawing.Color.SandyBrown;
            this.onayla.Appearance.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(3)));
            this.onayla.Appearance.ForeColor = System.Drawing.Color.White;
            this.onayla.Appearance.Options.UseBackColor = true;
            this.onayla.Appearance.Options.UseFont = true;
            this.onayla.Appearance.Options.UseForeColor = true;
            this.onayla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.onayla.Location = new System.Drawing.Point(458, 371);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(155, 77);
            this.onayla.TabIndex = 50;
            this.onayla.Text = "Siparişi Onayla";
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(106, 119);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kredi Kartı";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 119);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nakit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(277, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 17);
            this.radioButton3.TabIndex = 53;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Çek";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textBox4);
            this.groupControl1.Controls.Add(this.textBox3);
            this.groupControl1.Controls.Add(this.textBox2);
            this.groupControl1.Location = new System.Drawing.Point(47, 142);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(449, 122);
            this.groupControl1.TabIndex = 54;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(155, 67);
            this.textBox4.MaxLength = 3;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 21);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "CVC";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(69, 67);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "11/22";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(42, 15);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Kart numarasını giriniz";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textBox5);
            this.groupControl2.Controls.Add(this.textBox7);
            this.groupControl2.Location = new System.Drawing.Point(47, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(449, 122);
            this.groupControl2.TabIndex = 55;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.Location = new System.Drawing.Point(42, 51);
            this.textBox5.MaxLength = 16;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 21);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Banka Adi";
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.Location = new System.Drawing.Point(42, 15);
            this.textBox7.MaxLength = 16;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(282, 21);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "Hesabın Sahibi";
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            // 
            // ödemeşekli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 484);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.labelControl1);
            this.Name = "ödemeşekli";
            this.Text = "ödemeşekli";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton onayla;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
    }
}