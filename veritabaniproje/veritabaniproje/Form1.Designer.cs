namespace veritabaniproje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.girisButton = new System.Windows.Forms.Button();
            this.girispasLB = new System.Windows.Forms.Label();
            this.tckLB = new System.Windows.Forms.Label();
            this.loginPasTB = new System.Windows.Forms.TextBox();
            this.loginTckTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sehirCBreg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adSoyadTBreg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.TckTBreg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTBReg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kaynakLB = new System.Windows.Forms.Label();
            this.duyuruLB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cocukEkleButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cocukAdSoyadTb = new System.Windows.Forms.TextBox();
            this.ebeveynTcknTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Yap";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.girisButton);
            this.panel1.Controls.Add(this.girispasLB);
            this.panel1.Controls.Add(this.tckLB);
            this.panel1.Controls.Add(this.loginPasTB);
            this.panel1.Controls.Add(this.loginTckTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 230);
            this.panel1.TabIndex = 2;
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.Location = new System.Drawing.Point(106, 134);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(93, 34);
            this.girisButton.TabIndex = 10;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // girispasLB
            // 
            this.girispasLB.AutoSize = true;
            this.girispasLB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girispasLB.Location = new System.Drawing.Point(3, 78);
            this.girispasLB.Name = "girispasLB";
            this.girispasLB.Size = new System.Drawing.Size(48, 23);
            this.girispasLB.TabIndex = 8;
            this.girispasLB.Text = "şifre";
            // 
            // tckLB
            // 
            this.tckLB.AutoSize = true;
            this.tckLB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tckLB.Location = new System.Drawing.Point(3, 38);
            this.tckLB.Name = "tckLB";
            this.tckLB.Size = new System.Drawing.Size(70, 23);
            this.tckLB.TabIndex = 7;
            this.tckLB.Text = "Tck No:";
            // 
            // loginPasTB
            // 
            this.loginPasTB.Location = new System.Drawing.Point(106, 78);
            this.loginPasTB.Name = "loginPasTB";
            this.loginPasTB.PasswordChar = '*';
            this.loginPasTB.Size = new System.Drawing.Size(183, 20);
            this.loginPasTB.TabIndex = 5;
            // 
            // loginTckTB
            // 
            this.loginTckTB.Location = new System.Drawing.Point(106, 42);
            this.loginTckTB.MaxLength = 11;
            this.loginTckTB.Name = "loginTckTB";
            this.loginTckTB.Size = new System.Drawing.Size(183, 20);
            this.loginTckTB.TabIndex = 4;
            this.loginTckTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTckTB_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.sehirCBreg);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.adSoyadTBreg);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.TckTBreg);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.passwordTBReg);
            this.panel2.Location = new System.Drawing.Point(345, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 230);
            this.panel2.TabIndex = 3;
            // 
            // sehirCBreg
            // 
            this.sehirCBreg.FormattingEnabled = true;
            this.sehirCBreg.Location = new System.Drawing.Point(134, 109);
            this.sehirCBreg.Name = "sehirCBreg";
            this.sehirCBreg.Size = new System.Drawing.Size(183, 21);
            this.sehirCBreg.TabIndex = 21;
            this.sehirCBreg.SelectedIndexChanged += new System.EventHandler(this.sehirCBreg_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Şehir:";
            // 
            // adSoyadTBreg
            // 
            this.adSoyadTBreg.Location = new System.Drawing.Point(134, 41);
            this.adSoyadTBreg.MaxLength = 255;
            this.adSoyadTBreg.Name = "adSoyadTBreg";
            this.adSoyadTBreg.Size = new System.Drawing.Size(183, 20);
            this.adSoyadTBreg.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ad-Soyad:";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReg.Location = new System.Drawing.Point(134, 183);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(93, 34);
            this.btnReg.TabIndex = 16;
            this.btnReg.Text = "Kayıt Ol";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // TckTBreg
            // 
            this.TckTBreg.Location = new System.Drawing.Point(134, 74);
            this.TckTBreg.MaxLength = 11;
            this.TckTBreg.Name = "TckTBreg";
            this.TckTBreg.Size = new System.Drawing.Size(183, 20);
            this.TckTBreg.TabIndex = 12;
            this.TckTBreg.TextChanged += new System.EventHandler(this.TckTBreg_TextChanged);
            this.TckTBreg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.regTckTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kayıt Ol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tck No:";
            // 
            // passwordTBReg
            // 
            this.passwordTBReg.Location = new System.Drawing.Point(134, 142);
            this.passwordTBReg.Name = "passwordTBReg";
            this.passwordTBReg.PasswordChar = '*';
            this.passwordTBReg.Size = new System.Drawing.Size(183, 20);
            this.passwordTBReg.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Alibaba Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(166, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "HASTANE RANDEVU SİSTEMİ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.kaynakLB);
            this.panel3.Controls.Add(this.duyuruLB);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(12, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 189);
            this.panel3.TabIndex = 12;
            // 
            // kaynakLB
            // 
            this.kaynakLB.AutoSize = true;
            this.kaynakLB.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakLB.ForeColor = System.Drawing.Color.Red;
            this.kaynakLB.Location = new System.Drawing.Point(15, 151);
            this.kaynakLB.Name = "kaynakLB";
            this.kaynakLB.Size = new System.Drawing.Size(58, 19);
            this.kaynakLB.TabIndex = 23;
            this.kaynakLB.Text = "kaynak";
            // 
            // duyuruLB
            // 
            this.duyuruLB.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyuruLB.Location = new System.Drawing.Point(15, 47);
            this.duyuruLB.Name = "duyuruLB";
            this.duyuruLB.Size = new System.Drawing.Size(274, 104);
            this.duyuruLB.TabIndex = 11;
            this.duyuruLB.Text = "duyuru";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(14, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Duyurular";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.cocukEkleButton);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cocukAdSoyadTb);
            this.panel4.Controls.Add(this.ebeveynTcknTB);
            this.panel4.Location = new System.Drawing.Point(345, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 189);
            this.panel4.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(13, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Çocuk Ekle";
            // 
            // cocukEkleButton
            // 
            this.cocukEkleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cocukEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cocukEkleButton.Location = new System.Drawing.Point(161, 136);
            this.cocukEkleButton.Name = "cocukEkleButton";
            this.cocukEkleButton.Size = new System.Drawing.Size(93, 34);
            this.cocukEkleButton.TabIndex = 21;
            this.cocukEkleButton.Text = "Ekle";
            this.cocukEkleButton.UseVisualStyleBackColor = false;
            this.cocukEkleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ebeveyn Tck No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(13, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Çocuk Ad-Soyad:";
            // 
            // cocukAdSoyadTb
            // 
            this.cocukAdSoyadTb.Location = new System.Drawing.Point(161, 97);
            this.cocukAdSoyadTb.MaxLength = 255;
            this.cocukAdSoyadTb.Name = "cocukAdSoyadTb";
            this.cocukAdSoyadTb.Size = new System.Drawing.Size(156, 20);
            this.cocukAdSoyadTb.TabIndex = 1;
            // 
            // ebeveynTcknTB
            // 
            this.ebeveynTcknTB.Location = new System.Drawing.Point(161, 59);
            this.ebeveynTcknTB.MaxLength = 11;
            this.ebeveynTcknTB.Name = "ebeveynTcknTB";
            this.ebeveynTcknTB.Size = new System.Drawing.Size(156, 20);
            this.ebeveynTcknTB.TabIndex = 0;
            this.ebeveynTcknTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(704, 519);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button girisButton;
        public System.Windows.Forms.Label girispasLB;
        public System.Windows.Forms.Label tckLB;
        public System.Windows.Forms.TextBox loginPasTB;
        public System.Windows.Forms.TextBox loginTckTB;
        public System.Windows.Forms.Button btnReg;
        public System.Windows.Forms.TextBox TckTBreg;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox passwordTBReg;
        public System.Windows.Forms.TextBox adSoyadTBreg;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button cocukEkleButton;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cocukAdSoyadTb;
        private System.Windows.Forms.TextBox ebeveynTcknTB;
        private System.Windows.Forms.ComboBox sehirCBreg;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label kaynakLB;
        public System.Windows.Forms.Label duyuruLB;
    }
}

