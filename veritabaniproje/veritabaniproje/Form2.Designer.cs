
namespace veritabaniproje
{
    partial class Form2
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
            this.hosgeldinLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hastaneDTP = new System.Windows.Forms.DateTimePicker();
            this.randevuAraButton = new System.Windows.Forms.Button();
            this.hastaneLb = new System.Windows.Forms.Label();
            this.doktorCB = new System.Windows.Forms.ComboBox();
            this.bölümLB = new System.Windows.Forms.Label();
            this.bolumCB = new System.Windows.Forms.ComboBox();
            this.doktorLb = new System.Windows.Forms.Label();
            this.hastaneCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cocukCB = new System.Windows.Forms.ComboBox();
            this.asmDTP = new System.Windows.Forms.DateTimePicker();
            this.cocukCheck = new System.Windows.Forms.CheckBox();
            this.asmRandevuAraBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.asmDokCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mahCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AsmCB = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hosgeldinAdLb = new System.Windows.Forms.Label();
            this.cikisBT = new System.Windows.Forms.Button();
            this.girisSayfasiBt = new System.Windows.Forms.Button();
            this.talepButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RandevuLV = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hosgeldinLB
            // 
            this.hosgeldinLB.AutoSize = true;
            this.hosgeldinLB.Font = new System.Drawing.Font("Alibaba Sans Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldinLB.ForeColor = System.Drawing.Color.Brown;
            this.hosgeldinLB.Location = new System.Drawing.Point(12, 12);
            this.hosgeldinLB.Name = "hosgeldinLB";
            this.hosgeldinLB.Size = new System.Drawing.Size(148, 33);
            this.hosgeldinLB.TabIndex = 17;
            this.hosgeldinLB.Text = "Hoşgeldiniz ";
            this.hosgeldinLB.Click += new System.EventHandler(this.hosgeldinLB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.hastaneDTP);
            this.panel1.Controls.Add(this.randevuAraButton);
            this.panel1.Controls.Add(this.hastaneLb);
            this.panel1.Controls.Add(this.doktorCB);
            this.panel1.Controls.Add(this.bölümLB);
            this.panel1.Controls.Add(this.bolumCB);
            this.panel1.Controls.Add(this.doktorLb);
            this.panel1.Controls.Add(this.hastaneCB);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 219);
            this.panel1.TabIndex = 18;
            // 
            // hastaneDTP
            // 
            this.hastaneDTP.Location = new System.Drawing.Point(35, 129);
            this.hastaneDTP.MaxDate = new System.DateTime(2020, 12, 7, 0, 0, 0, 0);
            this.hastaneDTP.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.hastaneDTP.Name = "hastaneDTP";
            this.hastaneDTP.Size = new System.Drawing.Size(221, 20);
            this.hastaneDTP.TabIndex = 16;
            this.hastaneDTP.Value = new System.DateTime(2020, 12, 7, 0, 0, 0, 0);
            this.hastaneDTP.ValueChanged += new System.EventHandler(this.hastaneDTP_ValueChanged);
            // 
            // randevuAraButton
            // 
            this.randevuAraButton.BackColor = System.Drawing.Color.Brown;
            this.randevuAraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuAraButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.randevuAraButton.Location = new System.Drawing.Point(133, 162);
            this.randevuAraButton.Name = "randevuAraButton";
            this.randevuAraButton.Size = new System.Drawing.Size(121, 34);
            this.randevuAraButton.TabIndex = 15;
            this.randevuAraButton.Text = "Randevu Ara";
            this.randevuAraButton.UseVisualStyleBackColor = false;
            this.randevuAraButton.Click += new System.EventHandler(this.randevuAraButton_Click);
            // 
            // hastaneLb
            // 
            this.hastaneLb.AutoSize = true;
            this.hastaneLb.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneLb.Location = new System.Drawing.Point(31, 14);
            this.hastaneLb.Name = "hastaneLb";
            this.hastaneLb.Size = new System.Drawing.Size(81, 23);
            this.hastaneLb.TabIndex = 8;
            this.hastaneLb.Text = "Hastane:";
            // 
            // doktorCB
            // 
            this.doktorCB.FormattingEnabled = true;
            this.doktorCB.Location = new System.Drawing.Point(133, 91);
            this.doktorCB.Name = "doktorCB";
            this.doktorCB.Size = new System.Drawing.Size(121, 21);
            this.doktorCB.TabIndex = 13;
            this.doktorCB.SelectedIndexChanged += new System.EventHandler(this.doktorCB_SelectedIndexChanged);
            // 
            // bölümLB
            // 
            this.bölümLB.AutoSize = true;
            this.bölümLB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölümLB.Location = new System.Drawing.Point(31, 51);
            this.bölümLB.Name = "bölümLB";
            this.bölümLB.Size = new System.Drawing.Size(68, 23);
            this.bölümLB.TabIndex = 9;
            this.bölümLB.Text = "Bölüm:";
            // 
            // bolumCB
            // 
            this.bolumCB.FormattingEnabled = true;
            this.bolumCB.Location = new System.Drawing.Point(135, 51);
            this.bolumCB.Name = "bolumCB";
            this.bolumCB.Size = new System.Drawing.Size(121, 21);
            this.bolumCB.TabIndex = 12;
            this.bolumCB.SelectedIndexChanged += new System.EventHandler(this.bolumCB_SelectedIndexChanged);
            // 
            // doktorLb
            // 
            this.doktorLb.AutoSize = true;
            this.doktorLb.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorLb.Location = new System.Drawing.Point(31, 87);
            this.doktorLb.Name = "doktorLb";
            this.doktorLb.Size = new System.Drawing.Size(73, 23);
            this.doktorLb.TabIndex = 10;
            this.doktorLb.Text = "Doktor:";
            // 
            // hastaneCB
            // 
            this.hastaneCB.FormattingEnabled = true;
            this.hastaneCB.Location = new System.Drawing.Point(135, 14);
            this.hastaneCB.Name = "hastaneCB";
            this.hastaneCB.Size = new System.Drawing.Size(121, 21);
            this.hastaneCB.TabIndex = 11;
            this.hastaneCB.SelectedIndexChanged += new System.EventHandler(this.hastaneCB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.cocukCB);
            this.panel2.Controls.Add(this.asmDTP);
            this.panel2.Controls.Add(this.cocukCheck);
            this.panel2.Controls.Add(this.asmRandevuAraBut);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.asmDokCB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mahCB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AsmCB);
            this.panel2.Location = new System.Drawing.Point(375, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 283);
            this.panel2.TabIndex = 19;
            // 
            // cocukCB
            // 
            this.cocukCB.FormattingEnabled = true;
            this.cocukCB.Location = new System.Drawing.Point(210, 17);
            this.cocukCB.Name = "cocukCB";
            this.cocukCB.Size = new System.Drawing.Size(121, 21);
            this.cocukCB.TabIndex = 22;
            this.cocukCB.SelectedIndexChanged += new System.EventHandler(this.cocukCB_SelectedIndexChanged);
            // 
            // asmDTP
            // 
            this.asmDTP.Location = new System.Drawing.Point(22, 193);
            this.asmDTP.MaxDate = new System.DateTime(2020, 12, 7, 0, 0, 0, 0);
            this.asmDTP.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.asmDTP.Name = "asmDTP";
            this.asmDTP.Size = new System.Drawing.Size(309, 20);
            this.asmDTP.TabIndex = 17;
            this.asmDTP.Value = new System.DateTime(2020, 12, 7, 0, 0, 0, 0);
            // 
            // cocukCheck
            // 
            this.cocukCheck.AutoSize = true;
            this.cocukCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cocukCheck.Location = new System.Drawing.Point(22, 17);
            this.cocukCheck.Name = "cocukCheck";
            this.cocukCheck.Size = new System.Drawing.Size(164, 22);
            this.cocukCheck.TabIndex = 21;
            this.cocukCheck.Text = "Çocuk Randevusu";
            this.cocukCheck.UseVisualStyleBackColor = true;
            this.cocukCheck.CheckedChanged += new System.EventHandler(this.cocukCheck_CheckedChanged);
            // 
            // asmRandevuAraBut
            // 
            this.asmRandevuAraBut.BackColor = System.Drawing.Color.Brown;
            this.asmRandevuAraBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asmRandevuAraBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asmRandevuAraBut.Location = new System.Drawing.Point(210, 226);
            this.asmRandevuAraBut.Name = "asmRandevuAraBut";
            this.asmRandevuAraBut.Size = new System.Drawing.Size(121, 34);
            this.asmRandevuAraBut.TabIndex = 15;
            this.asmRandevuAraBut.Text = "Randevu Ara";
            this.asmRandevuAraBut.UseVisualStyleBackColor = false;
            this.asmRandevuAraBut.Click += new System.EventHandler(this.asmRandevuAraBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aile Sağlık Merkezi:";
            // 
            // asmDokCB
            // 
            this.asmDokCB.FormattingEnabled = true;
            this.asmDokCB.Location = new System.Drawing.Point(210, 157);
            this.asmDokCB.Name = "asmDokCB";
            this.asmDokCB.Size = new System.Drawing.Size(121, 21);
            this.asmDokCB.TabIndex = 13;
            this.asmDokCB.SelectedIndexChanged += new System.EventHandler(this.asmDokCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mahalle:";
            // 
            // mahCB
            // 
            this.mahCB.FormattingEnabled = true;
            this.mahCB.Location = new System.Drawing.Point(210, 111);
            this.mahCB.Name = "mahCB";
            this.mahCB.Size = new System.Drawing.Size(121, 21);
            this.mahCB.TabIndex = 12;
            this.mahCB.SelectedIndexChanged += new System.EventHandler(this.mahCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doktor:";
            // 
            // AsmCB
            // 
            this.AsmCB.FormattingEnabled = true;
            this.AsmCB.Location = new System.Drawing.Point(210, 64);
            this.AsmCB.Name = "AsmCB";
            this.AsmCB.Size = new System.Drawing.Size(121, 21);
            this.AsmCB.TabIndex = 11;
            this.AsmCB.SelectedIndexChanged += new System.EventHandler(this.AsmCB_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.RandevuLV);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 295);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 210);
            this.panel4.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Randevu Geçmişi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(740, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Profili Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hosgeldinAdLb
            // 
            this.hosgeldinAdLb.AutoSize = true;
            this.hosgeldinAdLb.Font = new System.Drawing.Font("Alibaba Sans Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldinAdLb.ForeColor = System.Drawing.Color.Brown;
            this.hosgeldinAdLb.Location = new System.Drawing.Point(153, 12);
            this.hosgeldinAdLb.Name = "hosgeldinAdLb";
            this.hosgeldinAdLb.Size = new System.Drawing.Size(148, 33);
            this.hosgeldinAdLb.TabIndex = 25;
            this.hosgeldinAdLb.Text = "Hoşgeldiniz ";
            // 
            // cikisBT
            // 
            this.cikisBT.BackColor = System.Drawing.Color.Red;
            this.cikisBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cikisBT.Location = new System.Drawing.Point(869, 11);
            this.cikisBT.Name = "cikisBT";
            this.cikisBT.Size = new System.Drawing.Size(101, 33);
            this.cikisBT.TabIndex = 17;
            this.cikisBT.Text = "ÇIKIŞ";
            this.cikisBT.UseVisualStyleBackColor = false;
            this.cikisBT.Click += new System.EventHandler(this.cikisBT_Click);
            // 
            // girisSayfasiBt
            // 
            this.girisSayfasiBt.BackColor = System.Drawing.Color.Green;
            this.girisSayfasiBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisSayfasiBt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.girisSayfasiBt.Location = new System.Drawing.Point(869, 47);
            this.girisSayfasiBt.Name = "girisSayfasiBt";
            this.girisSayfasiBt.Size = new System.Drawing.Size(101, 35);
            this.girisSayfasiBt.TabIndex = 18;
            this.girisSayfasiBt.Text = "Geri Dön";
            this.girisSayfasiBt.UseVisualStyleBackColor = false;
            this.girisSayfasiBt.Click += new System.EventHandler(this.girisSayfasiBt_Click);
            // 
            // talepButton
            // 
            this.talepButton.BackColor = System.Drawing.Color.DarkOrange;
            this.talepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.talepButton.Location = new System.Drawing.Point(869, 96);
            this.talepButton.Name = "talepButton";
            this.talepButton.Size = new System.Drawing.Size(101, 76);
            this.talepButton.TabIndex = 26;
            this.talepButton.Text = "Talep Kutusu";
            this.talepButton.UseVisualStyleBackColor = false;
            this.talepButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::veritabaniproje.Properties.Resources.personicon;
            this.pictureBox1.Location = new System.Drawing.Point(740, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // RandevuLV
            // 
            this.RandevuLV.HideSelection = false;
            this.RandevuLV.Location = new System.Drawing.Point(6, 48);
            this.RandevuLV.Name = "RandevuLV";
            this.RandevuLV.Size = new System.Drawing.Size(688, 113);
            this.RandevuLV.TabIndex = 25;
            this.RandevuLV.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(250, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Seçili Randevuyu Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 537);
            this.Controls.Add(this.talepButton);
            this.Controls.Add(this.cikisBT);
            this.Controls.Add(this.girisSayfasiBt);
            this.Controls.Add(this.hosgeldinAdLb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hosgeldinLB);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button randevuAraButton;
        public System.Windows.Forms.Label hastaneLb;
        public System.Windows.Forms.ComboBox doktorCB;
        public System.Windows.Forms.Label bölümLB;
        public System.Windows.Forms.ComboBox bolumCB;
        public System.Windows.Forms.Label doktorLb;
        public System.Windows.Forms.ComboBox hastaneCB;
        public System.Windows.Forms.Label hosgeldinLB;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button asmRandevuAraBut;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox asmDokCB;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox mahCB;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox AsmCB;
        private System.Windows.Forms.CheckBox cocukCheck;
        private System.Windows.Forms.ComboBox cocukCB;
        private System.Windows.Forms.DateTimePicker hastaneDTP;
        private System.Windows.Forms.DateTimePicker asmDTP;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label hosgeldinAdLb;
        public System.Windows.Forms.Button cikisBT;
        public System.Windows.Forms.Button girisSayfasiBt;
        public System.Windows.Forms.Button talepButton;
        private System.Windows.Forms.ListView RandevuLV;
        public System.Windows.Forms.Button button2;
    }
}