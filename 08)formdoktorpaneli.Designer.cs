namespace Proje_hastane
{
    partial class formdoktorpaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdoktorpaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combobrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Ad:";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(176, 91);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(184, 34);
            this.textad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Soyad:";
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(176, 136);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(184, 34);
            this.textsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Branş:";
            // 
            // combobrans
            // 
            this.combobrans.FormattingEnabled = true;
            this.combobrans.Location = new System.Drawing.Point(176, 176);
            this.combobrans.Name = "combobrans";
            this.combobrans.Size = new System.Drawing.Size(184, 35);
            this.combobrans.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tc:";
            // 
            // masktc
            // 
            this.masktc.Location = new System.Drawing.Point(176, 225);
            this.masktc.Mask = "00000000000";
            this.masktc.Name = "masktc";
            this.masktc.Size = new System.Drawing.Size(184, 34);
            this.masktc.TabIndex = 13;
            this.masktc.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre:";
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(176, 270);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(184, 34);
            this.textsifre.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 268);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnekle.Location = new System.Drawing.Point(70, 345);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(122, 42);
            this.btnekle.TabIndex = 17;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.MediumPurple;
            this.btnsil.Location = new System.Drawing.Point(208, 345);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(122, 42);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btngüncelle.Location = new System.Drawing.Point(345, 345);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(122, 42);
            this.btngüncelle.TabIndex = 19;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 27);
            this.label6.TabIndex = 20;
            this.label6.Visible = false;
            // 
            // formdoktorpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 420);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masktc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formdoktorpaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.formdoktorpaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label6;
    }
}