namespace Proje_hastane
{
    partial class form_doktorbilgidüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_doktorbilgidüzenle));
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.masktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combobranş = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(254, 360);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(160, 34);
            this.textsifre.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "Şifre:";
            // 
            // masktc
            // 
            this.masktc.Enabled = false;
            this.masktc.Location = new System.Drawing.Point(254, 260);
            this.masktc.Mask = "00000000000";
            this.masktc.Name = "masktc";
            this.masktc.Size = new System.Drawing.Size(160, 34);
            this.masktc.TabIndex = 29;
            this.masktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "TC Kimlik No:";
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(254, 211);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(160, 34);
            this.textsoyad.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Soyad:";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(254, 161);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(160, 34);
            this.textad.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(46, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(485, 38);
            this.label7.TabIndex = 34;
            this.label7.Text = "Doktor Bilgilerini Düzenle Formu";
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.btngüncelle.Location = new System.Drawing.Point(202, 423);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(106, 53);
            this.btngüncelle.TabIndex = 35;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "Branş:";
            // 
            // combobranş
            // 
            this.combobranş.FormattingEnabled = true;
            this.combobranş.Location = new System.Drawing.Point(254, 308);
            this.combobranş.Name = "combobranş";
            this.combobranş.Size = new System.Drawing.Size(160, 35);
            this.combobranş.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_doktorbilgidüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 654);
            this.Controls.Add(this.combobranş);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.label5);
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
            this.Name = "form_doktorbilgidüzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.form_doktorbilgidüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox masktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobranş;
        private System.Windows.Forms.Timer timer1;
    }
}