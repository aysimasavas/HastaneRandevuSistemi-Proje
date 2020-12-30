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
    public partial class Form5 : Form
    {

        Api api;
        public Form5()
        {
            InitializeComponent();
            api = new Api();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var list = api.GetOzelDurumlar();

            foreach (var item in list)
            {
                ozelDurumCb.Items.Add(item.Name);
            }
            SetUpListView();
            UpdateListView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && ozelDurumCb.SelectedItem.ToString() != "")
            {

                Talepler talep = new Talepler();

                talep.OzelDurumId = ozelDurumCb.SelectedIndex+1;
                talep.Text = richTextBox1.Text;
                api.TalepEkle(talep);
                UpdateListView();

                MessageBox.Show("Talebiniz alındı.İyi Günler.", "Başarılı", MessageBoxButtons.OK);


            }
            else {

                MessageBox.Show("Boş alan bırakmayınız.", "Başarılı", MessageBoxButtons.OK);

            }
        }
        public void UpdateListView()
        {
            var list = api.GetTalepler();


            listView1.Items.Clear();

            foreach (var item in list)
            {
               
                    string[] rowAr = { item.Id.ToString(), item.Text };
                    var row = new ListViewItem(rowAr);
                    listView1.Items.Add(row);

            }


        }

        public void SetUpListView()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Id", 30);
            listView1.Columns.Add("Text", 150);
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
