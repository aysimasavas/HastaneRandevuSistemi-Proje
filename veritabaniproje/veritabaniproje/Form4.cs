using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabaniproje.Helpers;

namespace veritabaniproje
{
    public partial class Form4 : Form
    {
        Api api;
        
        public Form4()
        {
            InitializeComponent();
            api = new Api();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var user = Constants.user;

            adSoyadLBguncelle.Text = user.AdSoyad;
            tcLBguncelle.Text = user.Tckn;

            var list = api.GetSehirler();

            foreach (var item in list)
            {
                sehirCBguncelle.Items.Add(item.Name);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2;
            form2 = new Form2();

            form2.Show();
            this.Hide();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {

            
            
            var user = Constants.user;

            if (passwordTBguncelle.Text != "" && sehirCBguncelle.SelectedItem.ToString() != "")
            {
                if (passwordTBguncelle.Text.Length >= 6 && passwordTBguncelle.Text.Length <= 20)
                {
                    user.SehirId = api.GetSehirId(sehirCBguncelle.SelectedItem.ToString());
                    user.Password = passwordTBguncelle.Text;

                    
                    api.UserUpdate(user);

                    MessageBox.Show("bilgileriniz güncellendi", "Basarılı", MessageBoxButtons.OK);
                }
                

            }
            else {


                MessageBox.Show("Başarısız.Eksik bilgi girmeyin.", "Basarılı", MessageBoxButtons.OK);

            }

        }

        private void sehirCBguncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
