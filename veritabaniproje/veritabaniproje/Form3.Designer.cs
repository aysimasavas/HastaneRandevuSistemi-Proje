
namespace veritabaniproje
{
    partial class Form3
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
            this.dLb = new System.Windows.Forms.Label();
            this.tLb = new System.Windows.Forms.Label();
            this.doktorLB = new System.Windows.Forms.Label();
            this.tarihLb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dLb
            // 
            this.dLb.AutoSize = true;
            this.dLb.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dLb.ForeColor = System.Drawing.Color.DarkGreen;
            this.dLb.Location = new System.Drawing.Point(12, 49);
            this.dLb.Name = "dLb";
            this.dLb.Size = new System.Drawing.Size(73, 23);
            this.dLb.TabIndex = 9;
            this.dLb.Text = "Doktor:";
            // 
            // tLb
            // 
            this.tLb.AutoSize = true;
            this.tLb.BackColor = System.Drawing.Color.Transparent;
            this.tLb.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tLb.ForeColor = System.Drawing.Color.DarkGreen;
            this.tLb.Location = new System.Drawing.Point(12, 9);
            this.tLb.Name = "tLb";
            this.tLb.Size = new System.Drawing.Size(58, 23);
            this.tLb.TabIndex = 10;
            this.tLb.Text = "Tarih:";
            // 
            // doktorLB
            // 
            this.doktorLB.AutoSize = true;
            this.doktorLB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorLB.Location = new System.Drawing.Point(91, 49);
            this.doktorLB.Name = "doktorLB";
            this.doktorLB.Size = new System.Drawing.Size(87, 23);
            this.doktorLB.TabIndex = 11;
            this.doktorLB.Text = "dr. ahmet";
            // 
            // tarihLb
            // 
            this.tarihLb.AutoSize = true;
            this.tarihLb.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihLb.Location = new System.Drawing.Point(91, 9);
            this.tarihLb.Name = "tarihLb";
            this.tarihLb.Size = new System.Drawing.Size(93, 23);
            this.tarihLb.TabIndex = 12;
            this.tarihLb.Text = "27.12.2020";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Alibaba Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(36, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Randevu Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Alibaba Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(151, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(16, 97);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(278, 188);
            this.flp.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(317, 374);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarihLb);
            this.Controls.Add(this.doktorLB);
            this.Controls.Add(this.tLb);
            this.Controls.Add(this.dLb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label dLb;
        public System.Windows.Forms.Label tLb;
        public System.Windows.Forms.Label doktorLB;
        public System.Windows.Forms.Label tarihLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}