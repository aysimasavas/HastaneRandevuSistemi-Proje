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
    public partial class Form3 : Form
    {
        List<string> saatler;
        Api api;

        public Form3()
        {
            InitializeComponent();

            saatler = new List<string>();
            api = new Api();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2;
            form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var basSaat = Constants.doktor.BosSaatBas;
            var sonSaat = Constants.doktor.BosSaatSon;

            DateTime basSaatDT = DateTime.Parse(basSaat);
            DateTime sonSaatDT = DateTime.Parse(sonSaat);
            DateTime temp = basSaatDT;

            while (DateTime.Compare(temp,sonSaatDT)!=0)
            {
                saatler.Add(temp.ToString(Constants.saatFormat));
                temp=temp.AddHours(1);


            }



            var doktorMesgulSaat = api.GetDoktorSaatler(Constants.doktor.Id);

            foreach (var item in saatler)
            {
                var rb = new RadioButton();
                rb.Text = item;
                if (KontrolMesgul(doktorMesgulSaat, item))
                {
                    rb.Enabled = false;
                }
                flp.Controls.Add(rb);
            }





        }

        public string GetSelectedHour()
        {
            RadioButton rbSelected = flp.Controls
                             .OfType<RadioButton>()
                             .FirstOrDefault(r => r.Checked);

            return rbSelected == null ? null : rbSelected.Text;
        }

        public bool KontrolMesgul(List<string> list, string saat)
        {
            foreach (var item in list)
            {
                if (item.Equals(saat)) return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var selectedH = GetSelectedHour();
            if (selectedH == null || selectedH == "")
            {
                MessageBox.Show("Lütfen Saat Seçiniz", "Basarısız", MessageBoxButtons.OK);
                return;
            }
            Constants.randevu.Saat = selectedH;


            bool randevu;

            if (Constants.randevu.CocukId == 0)
            {

                randevu = api.RandevuOlustur(Constants.randevu);

            }
            else
            {
                randevu = api.CocukRandevuOlustur(Constants.randevu);
            
            
            }

            if (randevu == true)
            {
                MessageBox.Show("randevunuz alındı", "Basarılı", MessageBoxButtons.OK);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();


            }
            else
            {

                MessageBox.Show("randevunuz alınamadı.", "Basarısız", MessageBoxButtons.OK);


            }
        }
    }
}
