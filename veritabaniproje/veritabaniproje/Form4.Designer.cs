
namespace veritabaniproje
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.tcLBguncelle = new System.Windows.Forms.Label();
            this.adSoyadLBguncelle = new System.Windows.Forms.Label();
            this.sehirCBguncelle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTBguncelle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::veritabaniproje.Properties.Resources.personicon;
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Acumin Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Acumin Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TckNo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Acumin Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir:";
            // 
            // guncelleButton
            // 
            this.guncelleButton.BackColor = System.Drawing.Color.SlateBlue;
            this.guncelleButton.Font = new System.Drawing.Font("Alibaba Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleButton.Location = new System.Drawing.Point(136, 334);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(109, 38);
            this.guncelleButton.TabIndex = 5;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = false;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // tcLBguncelle
            // 
            this.tcLBguncelle.AutoSize = true;
            this.tcLBguncelle.Font = new System.Drawing.Font("Acumin Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLBguncelle.Location = new System.Drawing.Point(131, 174);
            this.tcLBguncelle.Name = "tcLBguncelle";
            this.tcLBguncelle.Size = new System.Drawing.Size(29, 25);
            this.tcLBguncelle.TabIndex = 6;
            this.tcLBguncelle.Text = "tc";
            // 
            // adSoyadLBguncelle
            // 
            this.adSoyadLBguncelle.AutoSize = true;
            this.adSoyadLBguncelle.Font = new System.Drawing.Font("Acumin Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adSoyadLBguncelle.Location = new System.Drawing.Point(131, 126);
            this.adSoyadLBguncelle.Name = "adSoyadLBguncelle";
            this.adSoyadLBguncelle.Size = new System.Drawing.Size(78, 25);
            this.adSoyadLBguncelle.TabIndex = 7;
            this.adSoyadLBguncelle.Text = "anonim";
            // 
            // sehirCBguncelle
            // 
            this.sehirCBguncelle.FormattingEnabled = true;
            this.sehirCBguncelle.Location = new System.Drawing.Point(136, 277);
            this.sehirCBguncelle.Name = "sehirCBguncelle";
            this.sehirCBguncelle.Size = new System.Drawing.Size(121, 21);
            this.sehirCBguncelle.TabIndex = 8;
            this.sehirCBguncelle.SelectedIndexChanged += new System.EventHandler(this.sehirCBguncelle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Acumin Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // passwordTBguncelle
            // 
            this.passwordTBguncelle.Location = new System.Drawing.Point(135, 235);
            this.passwordTBguncelle.Name = "passwordTBguncelle";
            this.passwordTBguncelle.Size = new System.Drawing.Size(122, 20);
            this.passwordTBguncelle.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Alibaba Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTBguncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sehirCBguncelle);
            this.Controls.Add(this.adSoyadLBguncelle);
            this.Controls.Add(this.tcLBguncelle);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label tcLBguncelle;
        private System.Windows.Forms.Label adSoyadLBguncelle;
        private System.Windows.Forms.ComboBox sehirCBguncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTBguncelle;
        private System.Windows.Forms.Button button1;
    }
}