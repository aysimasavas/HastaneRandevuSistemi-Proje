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
using veritabaniproje.Models;

namespace veritabaniproje
{
    public partial class Form1 : Form
    {
        Api api;

        public Form1()
        {
            InitializeComponent();

            api = new Api();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = api.GetSehirler();

            foreach (var item in list)
            {
                sehirCBreg.Items.Add(item.Name);
            }

            Kaynak kaynak;

            var duyuru = api.GetDuyuru(14,out kaynak);

            duyuruLB.Text = duyuru.Text;

            kaynakLB.Text = kaynak.Name;

            


        }

        private void regTckTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if (adSoyadTBreg.Text != "" && TckTBreg.Text != "" && passwordTBReg.Text != "" && sehirCBreg.SelectedItem != null)
            {


                if (TckTBreg.Text.Length == 11 && passwordTBReg.Text.Length >= 6 && passwordTBReg.Text.Length <= 20)
                {

                    var user = new User();
                    user.AdSoyad = adSoyadTBreg.Text;
                    user.Password = passwordTBReg.Text;
                    user.Tckn = TckTBreg.Text;
                    user.SehirId = api.GetSehirId(sehirCBreg.SelectedItem.ToString());

                    bool isOk = api.RegisterUser(user);

                    if (isOk)
                    {
                        MessageBox.Show("Kaydınız başarıyla alınmıştır.", "Başarılı", MessageBoxButtons.OK);

                    }
                    else {

                        MessageBox.Show("Kaydınız alınamadı", "Başarısız", MessageBoxButtons.OK);

                    }

                   



                }
                else
                {

                    MessageBox.Show("Tckn 11 haneli olmalı. Şifre en az 6 en uzun 20 haneli olmalı.Kontrol edin.", "Uyarı", MessageBoxButtons.OK);

                }

            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız", "Uyarı" ,MessageBoxButtons.OK);
            
            }


        }

        private void TckTBreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTckTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (loginTckTB.Text != "" && loginPasTB.Text != "")
            {

                if (loginTckTB.Text.Length == 11 && loginPasTB.Text.Length >= 6 && passwordTBReg.Text.Length <= 20)
                {

                    var user = api.LoginUser(loginTckTB.Text, loginPasTB.Text);
                    if (user.AdSoyad != null)
                    {
                        Constants.user = user;

                        GoHome();
                    }

                    else
                    {
                        MessageBox.Show("Giriş yapılamadı.Kayıt olun veya bilgileri kontrol edin.", "Başarısız", MessageBoxButtons.OK);
                    }


                }
                else
                {

                    MessageBox.Show("Tckn 11 haneli olmalı. Şifre en az 6 en uzun 20 haneli olmalı.Kontrol edin.", "Uyarı", MessageBoxButtons.OK);

                }

            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız. ", "Uyarı", MessageBoxButtons.OK);
            }
        }

        private void GoHome()
        {
            var f2 = new Form2();

            f2.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ebeveynTcknTB.Text != "" && cocukAdSoyadTb.Text != "")
            {


                if (ebeveynTcknTB.Text.Length == 11)
                {

                    var cocuk = new Cocuk();

                    cocuk.AdSoyad = cocukAdSoyadTb.Text;
                    var isOk = api.AddChild(cocuk,ebeveynTcknTB.Text);
                    MessageBox.Show("kayıt alındı", "Basarılı", MessageBoxButtons.OK);

                }
                else
                {

                    MessageBox.Show("Tckn 11 haneli olmalı.Kontrol edin.", "Uyarı", MessageBoxButtons.OK);

                }
            }
            else 
            {
                MessageBox.Show("Boş alan bırakmayınız. ", "Uyarı", MessageBoxButtons.OK);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sehirCBreg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
