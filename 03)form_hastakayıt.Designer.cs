namespace Proje_hastane
{
    partial class form_hastakayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_hastakayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masktc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(233, 155);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(160, 34);
            this.textad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(233, 205);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(160, 34);
            this.textsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC Kimlik No:";
            // 
            // masktc
            // 
            this.masktc.Location = new System.Drawing.Point(233, 254);
            this.masktc.Mask = "00000000000";
            this.masktc.Name = "masktc";
            this.masktc.Size = new System.Drawing.Size(160, 34);
            this.masktc.TabIndex = 5;
            this.masktc.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon No:";
            // 
            // masktel
            // 
            this.masktel.Location = new System.Drawing.Point(233, 306);
            this.masktel.Mask = "(999) 000-0000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(160, 34);
            this.masktel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şifre:";
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(233, 354);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(160, 34);
            this.textsifre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cinsiyet:";
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combocinsiyet.Location = new System.Drawing.Point(233, 402);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(121, 35);
            this.combocinsiyet.TabIndex = 11;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(193, 475);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(106, 53);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(144, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hasta Kayıt Formu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 53);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_hastakayıt
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnkaydet);
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
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "form_hastakayıt";
            this.Text = "Hasta Kayıt Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}