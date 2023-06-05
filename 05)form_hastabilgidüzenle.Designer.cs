namespace Proje_hastane
{
    partial class form_hastabilgidüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_hastabilgidüzenle));
            this.label7 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(56, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(470, 38);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hasta Bilgilerini Düzenle Formu";
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.btngüncelle.Location = new System.Drawing.Point(198, 469);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(106, 53);
            this.btngüncelle.TabIndex = 26;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combocinsiyet.Location = new System.Drawing.Point(262, 406);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(121, 35);
            this.combocinsiyet.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cinsiyet:";
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(262, 358);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(160, 34);
            this.textsifre.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Şifre:";
            // 
            // masktel
            // 
            this.masktel.Location = new System.Drawing.Point(262, 310);
            this.masktel.Mask = "(999) 000-0000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(160, 34);
            this.masktel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefon No:";
            // 
            // masktc
            // 
            this.masktc.Enabled = false;
            this.masktc.Location = new System.Drawing.Point(262, 258);
            this.masktc.Mask = "00000000000";
            this.masktc.Name = "masktc";
            this.masktc.Size = new System.Drawing.Size(160, 34);
            this.masktc.TabIndex = 19;
            this.masktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "TC Kimlik No:";
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(262, 209);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(160, 34);
            this.textsoyad.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad:";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(262, 159);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(160, 34);
            this.textad.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 55);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_hastabilgidüzenle
            // 
            this.AcceptButton = this.btngüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.combocinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masktel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.masktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "form_hastabilgidüzenle";
            this.Text = "Hasta Bilgi Düzenleme Formu";
            this.Load += new System.EventHandler(this.form_hastabilgidüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox masktel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}