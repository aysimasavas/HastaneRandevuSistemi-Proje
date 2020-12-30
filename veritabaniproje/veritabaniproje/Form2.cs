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
    public partial class Form2 : Form
    {


        Api api;
        bool isCocukRandevu = false;

        public Form2()
        {
            InitializeComponent();
            api = new Api();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            bolumCB.Enabled = false;
            doktorCB.Enabled = false;
            mahCB.Enabled = false;
            asmDokCB.Enabled = false;
            cocukCB.Enabled = false;
            randevuAraButton.Enabled = false;
            asmRandevuAraBut.Enabled = false;

            var user1 = Constants.user;
            hosgeldinAdLb.Text = user1.AdSoyad;

            var list = api.GetHastanes();
            if (list == null)
            {
                MessageBox.Show("hastane bulunamadı", "hata", MessageBoxButtons.OK);
                return;

            }

            foreach (var item in list)
            {

                hastaneCB.Items.Add(item.Name);

            }

            var list2 = api.GetASM();

            if (list2 == null)
            {
                MessageBox.Show("hastane bulunamadı", "hata", MessageBoxButtons.OK);
                return;
            }

            foreach (var item in list2)
            {

                AsmCB.Items.Add(item.Name);

            }

            SetUpListView();
            UpdateListView();


        }

        private void hastaneCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bolumCB.Enabled = true;

            var id = api.GetHastaneId(hastaneCB.SelectedItem.ToString());
            if (id == -1)
            {
                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }

            var list = api.GetBolum(id);
            if (list == null)
            {

                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }
            bolumCB.Items.Clear();
           

            foreach (var item in list)
            {
                bolumCB.Items.Add(item.Name);
            }

        }

        private void bolumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCB.Enabled = true;
            var skId = api.GetHastaneId(hastaneCB.SelectedItem.ToString());
            var id = api.GetBolumId(bolumCB.SelectedItem.ToString(),skId);
            
            if (id == -1)
            {
                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }
            var list = api.GetDoktor(id,skId);
            if (list == null)
            {

                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }
            doktorCB.Items.Clear();
            foreach (var item in list)
            {
                doktorCB.Items.Add(item.Name);
            }
        }

        private void AsmCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahCB.Enabled = true;


            var id = api.GetAsmId(AsmCB.SelectedItem.ToString());
            if (id == -1)
            {
                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }

            var list = api.GetMah(id);

            if (list == null)
            {

                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }
            mahCB.Items.Clear();

            foreach (var item in list)
            {
                mahCB.Items.Add(item.Name);
            }

        }

        private void mahCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            asmDokCB.Enabled = true;

            var id = api.GetMahId(mahCB.SelectedItem.ToString());

            if (id == -1)
            {
                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }
            var list = api.GetDoktorAsm(id);
            if (list == null)
            {
                MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                return;
            }

            asmDokCB.Items.Clear();
            foreach (var item in list)
            {
                asmDokCB.Items.Add(item.Name);
            }
        }

        private void cocukCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (cocukCheck.Checked == true)
            {
                cocukCB.Enabled = true;
                var user = Constants.user;


                var id = user.Id;
                
                if (id == -1)
                {
                    MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                    return;
                }
                var list = api.GetCocuk(id);

                if (list == null)
                {
                    MessageBox.Show("hata", "hata", MessageBoxButtons.OK);
                    return;
                }
                cocukCB.Items.Clear();
                foreach (var item in list)
                {
                    cocukCB.Items.Add(item.AdSoyad);
                }

            }
            else 
            
            {
                cocukCB.Enabled = false;
                isCocukRandevu = false;
            }
            
            

            
        }

        private void hastaneDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4;

            form4 = new Form4();
            form4.Show();
            this.Hide();
            
        }

        private void hosgeldinLB_Click(object sender, EventArgs e)
        {

        }

        private void cikisBT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void girisSayfasiBt_Click(object sender, EventArgs e)
        {
            Form1 form1;
            form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void randevuAraButton_Click(object sender, EventArgs e)
        {

            var randevu = new Randevu();

            randevu.DoktorId = Constants.doktor.Id;
            randevu.SaglikKurumuId = api.GetHastaneId(hastaneCB.SelectedItem.ToString());
            randevu.UserId = Constants.user.Id;

            var tarih = hastaneDTP.Value.ToString(Constants.tarihFormat);

            randevu.Tarih = tarih;
            Constants.randevu = randevu;
            Form3 form3;
            form3 = new Form3();
            form3.Show();
            this.Hide();

           
            

        }

        private void doktorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doktr = api.GetDoktorFromName(doktorCB.SelectedItem.ToString());
            Constants.doktor = doktr;
            randevuAraButton.Enabled = true;
        }

        private void asmRandevuAraBut_Click(object sender, EventArgs e)
        {
            var randevuAsm = new Randevu();

            randevuAsm.DoktorId = Constants.doktor.Id;
            randevuAsm.SaglikKurumuId = api.GetAsmId(AsmCB.SelectedItem.ToString());
            randevuAsm.UserId = Constants.user.Id;

            if (isCocukRandevu)
            {
                randevuAsm.CocukId = Constants.cocuk.Id;
            
            }

            var tarih = asmDTP.Value.ToString(Constants.tarihFormat);

            randevuAsm.Tarih = tarih;
            Constants.randevu = randevuAsm;
            Form3 form3;
            form3 = new Form3();
            form3.Show();
            this.Hide();

           
        }

        private void asmDokCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doktor = api.GetDoktorAsmFromName(asmDokCB.SelectedItem.ToString());
            Constants.doktor = doktor;
            asmRandevuAraBut.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();


        }

        private void cocukCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cocuk = api.GetCocukFromName(cocukCB.SelectedItem.ToString());

            if (cocuk != null)
            {
                Constants.cocuk=cocuk;
                isCocukRandevu = true;
            }

        }


        public void UpdateListView()
        {
            var list = api.GetRandevu(Constants.user.Id);


            RandevuLV.Items.Clear();
            foreach (var item in list)
            {
                string doktorAd = api.GetDoktorFromId(item.DoktorId).Name;
                string skName = api.GetSaglikKurumuFromId(item.SaglikKurumuId).Name;
                if (item.CocukId == 0)
                {
                    string[] rowAr = { item.Id.ToString(), Constants.user.AdSoyad, item.Tarih, item.Saat, doktorAd, skName };
                    var row = new ListViewItem(rowAr);
                    RandevuLV.Items.Add(row);

                }
                else {

                    var cocuk = api.GetCocukFromId(item.CocukId);
                    string[] rowAr = { item.Id.ToString(),cocuk.AdSoyad, item.Tarih, item.Saat, doktorAd, skName };
                    var row = new ListViewItem(rowAr);
                    RandevuLV.Items.Add(row);

                }
            }


        }

        public void SetUpListView()
        {
            RandevuLV.View = View.Details;
            RandevuLV.GridLines = true;
            RandevuLV.FullRowSelect = true;
            RandevuLV.Columns.Add("Id", 30);
            RandevuLV.Columns.Add("Ad Soyad", 70);
            RandevuLV.Columns.Add("Tarih", 100);
            RandevuLV.Columns.Add("Saat", 50);
            RandevuLV.Columns.Add("Doktor", 70);
            RandevuLV.Columns.Add("Sağlık Kurumu", 120);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                var rId = Convert.ToInt32(RandevuLV.SelectedItems[0].Text);
                var b = api.RandevuSil(rId);
                if (b)
                {
                    MessageBox.Show("Randevu başarı ile silindi", "Randevu Sil", MessageBoxButtons.OK);
                    UpdateListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }
        }
    }
}
