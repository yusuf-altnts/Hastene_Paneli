namespace Proje_hastane
{
    partial class form_Girişler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Girişler));
            this.btnhasta = new System.Windows.Forms.Button();
            this.btndoktor = new System.Windows.Forms.Button();
            this.btnsekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.BackColor = System.Drawing.Color.White;
            this.btnhasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhasta.BackgroundImage")));
            this.btnhasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhasta.Location = new System.Drawing.Point(101, 238);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(229, 185);
            this.btnhasta.TabIndex = 0;
            this.btnhasta.UseVisualStyleBackColor = false;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // btndoktor
            // 
            this.btndoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktor.BackgroundImage")));
            this.btndoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktor.Location = new System.Drawing.Point(440, 238);
            this.btndoktor.Name = "btndoktor";
            this.btndoktor.Size = new System.Drawing.Size(226, 185);
            this.btndoktor.TabIndex = 1;
            this.btndoktor.UseVisualStyleBackColor = true;
            this.btndoktor.Click += new System.EventHandler(this.btndoktor_Click);
            // 
            // btnsekreter
            // 
            this.btnsekreter.BackColor = System.Drawing.Color.White;
            this.btnsekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekreter.BackgroundImage")));
            this.btnsekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekreter.Location = new System.Drawing.Point(750, 238);
            this.btnsekreter.Name = "btnsekreter";
            this.btnsekreter.Size = new System.Drawing.Size(213, 185);
            this.btnsekreter.TabIndex = 2;
            this.btnsekreter.UseVisualStyleBackColor = false;
            this.btnsekreter.Click += new System.EventHandler(this.btnsekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(505, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(801, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(35, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "NoCamp Hospital";
            // 
            // form_Girişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1134, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekreter);
            this.Controls.Add(this.btndoktor);
            this.Controls.Add(this.btnhasta);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_Girişler";
            this.Text = "NoCamp Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btndoktor;
        private System.Windows.Forms.Button btnsekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

