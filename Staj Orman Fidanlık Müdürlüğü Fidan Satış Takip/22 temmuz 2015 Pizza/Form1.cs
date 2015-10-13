using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework.Forms;

namespace Fidan_Satis
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double yas;
        double[] fiyat = { 10.00, 20.00, 30.00, 5.00, 6.00, 7.00 };

        private string BuyukHarf(string gelen)
        {

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(gelen.ToLower());
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtAdSoyad.Text = BuyukHarf(txtAdSoyad.Text);
            //txtAdSoyad.SelectionStart = txtAdSoyad.Text.Length;
        }

        private void txtAdSoyad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAdSoyad.Text != "")
            {
                try
                {
                    txtAdSoyad.Text = BuyukHarf(txtAdSoyad.Text);
                    txtAdres.Enabled = true;
                    txtAdres.Focus();

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        /// <summary>
        /// Burada texboxa yazdıktan sonra enter dediğimizde imlec nereye gitsin focus olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtAdres.Text != "")
            {
                try
                {
                    grpUrunTur.Enabled = true;

                    grpUrunTur.Focus();
                    rbtnCam.Checked = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        //Radio butnda seçilen ağaç türüne göre fiyat döndürür
        private double agacFiyatHesapla(double agacFiyat)
        {

            if (rbtnCam.Checked)
            {
                agacFiyat = fiyat[0];
            }
            else if (rbtnKaraAgac.Checked)
            {
                agacFiyat = fiyat[1];
            }

            else if (rbtnKayin.Checked)
            {
                agacFiyat = fiyat[2];
            }
            else { agacFiyat = 0.0; }

            return agacFiyat;
        }

        /// <summary>
        /// Burada checkbox seçim işlminde ek olarak alınacak ürünler fiyata eklerin
        /// </summary>
        /// <param name="ekleme"></param>
        /// <returns></returns>
        private double EklemeFiyatHesapla(double ekleme)
        {

            for (int i = 0; i < 3; i++)
            {
                if (chcEkleme.GetItemChecked(i))
                {
                    ekleme += fiyat[i + 3];
                }
            }
            return ekleme;
        }



        private void rbtnCam_CheckedChanged(object sender, EventArgs e)
        {
            nmrAdet.Value = 1;
            double eklemeFiyat = 0.0;
            double birimFiyat = 0.00;
            txtBirimFiyat.Text = (agacFiyatHesapla(birimFiyat) + agacFiyatHesapla(birimFiyat) * yas + EklemeFiyatHesapla(eklemeFiyat)).ToString();
            txtToplamFiyat.Text = ((double)nmrAdet.Value * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
            grpEk.Enabled = true;
            pictureBox1.Image = ımageList1.Images[1];

        }

        private void rbtnKaraAgac_CheckedChanged(object sender, EventArgs e)
        {
            nmrAdet.Value = 1;
            double eklemeFiyat = 0.0;
            double birimFiyat = 0.00;
            txtBirimFiyat.Text = (agacFiyatHesapla(birimFiyat) + agacFiyatHesapla(birimFiyat) * yas + EklemeFiyatHesapla(eklemeFiyat)).ToString();
            txtToplamFiyat.Text = ((double)nmrAdet.Value * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
            grpEk.Enabled = true;
            pictureBox1.Image = ımageList1.Images[0];

        }

        private void rbtnKayin_CheckedChanged(object sender, EventArgs e)
        {
            nmrAdet.Value = 1;
            double eklemeFiyat = 0.00;
            double birimFiyat = 0.00;
            txtBirimFiyat.Text = (agacFiyatHesapla(birimFiyat) + agacFiyatHesapla(birimFiyat) * yas + EklemeFiyatHesapla(eklemeFiyat)).ToString();
            txtToplamFiyat.Text = ((double)nmrAdet.Value * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
            grpEk.Enabled = true;
            pictureBox1.Image = ımageList1.Images[2];
        }

        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {
            double eklemeFiyat = 0.00;
            double birimFiyat = 0.00;
            txtBirimFiyat.Text = (agacFiyatHesapla(birimFiyat) + agacFiyatHesapla(birimFiyat) * yas + EklemeFiyatHesapla(eklemeFiyat)).ToString();
            txtToplamFiyat.Text = ((double)nmrAdet.Value * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }

        private void cmbYas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double eklemeFiyat = 0.00;
            double birimFiyat = 0.00;
            yas = Convert.ToDouble(cmbYas.SelectedIndex) * 0.5;
            txtBirimFiyat.Text = (agacFiyatHesapla(birimFiyat) + agacFiyatHesapla(birimFiyat) * yas + EklemeFiyatHesapla(eklemeFiyat)).ToString();
            txtToplamFiyat.Text = ((double)nmrAdet.Value * Convert.ToDouble(txtBirimFiyat.Text)).ToString();

        }


        //Burada secm yapılması durumunda yada seçim kaldırılması durumunda fiyat güncellemesi yapar

        private void chcEkleme_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (chcEkleme.SelectedIndex.Equals(0))
                {
                    txtBirimFiyat.Text = Convert.ToString(Double.Parse(txtBirimFiyat.Text) + fiyat[3]);
                    txtToplamFiyat.Text = (Convert.ToDouble(txtBirimFiyat.Text) * (double)nmrAdet.Value).ToString();

                }

                if (chcEkleme.SelectedIndex.Equals(1))
                {
                    txtBirimFiyat.Text = Convert.ToString(Double.Parse(txtBirimFiyat.Text) + fiyat[4]);
                    txtToplamFiyat.Text = (Convert.ToDouble(txtBirimFiyat.Text) * (double)nmrAdet.Value).ToString();

                }

                if (chcEkleme.SelectedIndex.Equals(2))
                {
                    txtBirimFiyat.Text = Convert.ToString(Double.Parse(txtBirimFiyat.Text) + fiyat[5]);
                    txtToplamFiyat.Text = (Convert.ToDouble(txtBirimFiyat.Text) * (double)nmrAdet.Value).ToString();

                }
            }

            else if (e.NewValue == CheckState.Unchecked)
            {
                if (chcEkleme.SelectedIndex.Equals(0))
                {
                    txtBirimFiyat.Text = Convert.ToString(Double.Parse(txtBirimFiyat.Text) - (fiyat[3]));
                    txtToplamFiyat.Text = (Convert.ToDouble(txtBirimFiyat.Text) * (double)nmrAdet.Value).ToString();


                }

                if (chcEkleme.SelectedIndex.Equals(1))
                {
                    txtBirimFiyat.Text = Convert.ToString(Double.Parse(txtBirimFiyat.Text) - fiyat[4]);
                    txtToplamFiyat.Text = (Convert.ToDouble(txtBirimFiyat.Text) * (double)nmrAdet.Value).ToString();

                }

                if (chcEkleme.SelectedIndex.Equals(2))
                {
                    txtBirimFiyat.Text = Convert.ToString(Double.Parse(txtBirimFiyat.Text) - fiyat[5]);
                    txtToplamFiyat.Text = (Convert.ToDouble(txtBirimFiyat.Text) * (double)nmrAdet.Value).ToString();
                }

            }

        }


        private string EklemelerGoster()
        {
            string eklemeFatura = "";

            if (chcEkleme.GetItemChecked(0))
            {
                eklemeFatura += "Ç,";
            }
            if (chcEkleme.GetItemChecked(1))
            {
                eklemeFatura += "K,";
            }
            if (chcEkleme.GetItemChecked(2))
            {
                eklemeFatura += "Kyn,";
            }
            if ((chcEkleme.GetItemChecked(0) || chcEkleme.GetItemChecked(1) || chcEkleme.GetItemChecked(2)))
            {
                eklemeFatura = eklemeFatura.Substring(0, eklemeFatura.Length - 1);

            }
            else
                eklemeFatura = "-";

            return eklemeFatura;


        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //subitem eklemek için itemin listede bulunduğu sırayı tutar. 
            int sira = listView1.Items.Count;

            //ilk eklediğimiz ana itemdir, ilk sütundan sonra gelen sütunları doldurabilmek için altitem(subitem) kullanırız.
            listView1.Items.Add(txtAdSoyad.Text);
            listView1.Items[sira].SubItems.Add(txtAdres.Text);
            if (rbtnCam.Checked)
            {
                listView1.Items[sira].SubItems.Add(rbtnCam.Text);
            }
            else if (rbtnKaraAgac.Checked)
            {
                listView1.Items[sira].SubItems.Add(rbtnKaraAgac.Text);
            }

            else if (rbtnKayin.Checked)
            {
                listView1.Items[sira].SubItems.Add(rbtnKayin.Text);
            }

            listView1.Items[sira].SubItems.Add(EklemelerGoster());
            listView1.Items[sira].SubItems.Add(txtBirimFiyat.Text);
            listView1.Items[sira].SubItems.Add(nmrAdet.Value.ToString());
            listView1.Items[sira].SubItems.Add(txtToplamFiyat.Text);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Görünümünü Details olarak değiştirir. Alt alta liste şeklinde gösterilmesi için gereklidir.
            listView1.View = View.Details;

            cmbAraTur.SelectedIndex = 0;

            // Ad, Soyad ve No isimlerinde, 100 genişliğinde, sola yatık şekilde 4 tane sütun(column)ekler.
            listView1.Columns.Add("Ad Soyad", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Adres", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ağaç Türü", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ekler", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Birim Fiyat", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Adet", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Toplam Fiyat", 100, HorizontalAlignment.Left);
        }


        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {

                CheckBox cbox = new CheckBox();
                if (c is TextBox && c is ComboBox)
                {
                    ((TextBox)c).Clear();
                }


                if (c.Controls.Count > 0)
                {
                    ClearAll(c);
                }
            }

            foreach (int i in chcEkleme.CheckedIndices)
            {
                chcEkleme.SetItemCheckState(i, CheckState.Unchecked);
            }

            rbtnCam.Checked = false;
            rbtnKaraAgac.Checked = false;
            rbtnKayin.Checked = false;
            grpEk.Enabled = false;
            grpUrunTur.Enabled = false;
            txtAdres.Enabled = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index); //Seçili satırın index i ni yakalayarak satırı sildik.
        }

        private void btnTumSil_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //listview i boşalttık.
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].ForeColor = Color.Empty;
            }

                for (int i = 0; i < listView1.Items.Count; i++)
            {

                if (listView1.Items[i].SubItems[cmbAraTur.SelectedIndex].Text.ToUpper() == txtAra.Text.ToUpper())
                {
                    listView1.Items[i].ForeColor = Color.Blue; //Aynıymış ozaman buldugumuz belli olsun işaretleyelim. Yazı rengini mavi yaptık.
                    listView1.Focus(); // !!! Satırı seçebilmek için nesne üzerine odaklandık. Yoksa alttaki komut iş görmeyecekti. Hata vermezdi ama işlevini yerine getiremezdi.
                    listView1.Items[i].Selected = true; //Üzerinde oldugumuz satırı seçtik.
                    break; // !!! Diğer satırları boş yere dolaşmayalım diye döngüden çıktım. Farklı amaçlar için çıkılmayada bilir. Mesela buldugu tüm değerleri işaretlesin yazı rengini mavi yapsın diye.
                }
                else
                {
                    listView1.Items[i].ForeColor = Color.Empty; //Bir önceki aramada mavi olarak işaretlen değer varsa şimdiki aramayla karışmaması için rengi kaldırdık.
                }
            }
        }


        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }


        private void btnSayfaAyarlari_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.untitled_1_59, 100, 20);

            e.Graphics.DrawString("ORMAN BÖLGE MÜDÜRLÜĞÜ", myFont, sbrush, 300, 120);
            e.Graphics.DrawString("SİPARİŞLER", myFont, sbrush, 400, 150);
            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Ad Soyad", myFont, sbrush, 100, 328);
            e.Graphics.DrawString("Adres", myFont, sbrush, 200, 328);
            e.Graphics.DrawString("Ağaç Türü", myFont, sbrush, 300, 328);
            e.Graphics.DrawString("Ekler", myFont, sbrush, 400, 328);
            e.Graphics.DrawString("Birim Fiyat", myFont, sbrush, 500, 328);
            e.Graphics.DrawString("Adet", myFont, sbrush, 600, 328);
            e.Graphics.DrawString("Toplam Fiyat", myFont, sbrush, 700, 328);
            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;
            foreach (ListViewItem lvi in listView1.Items)
            {

                e.Graphics.DrawString(lvi.SubItems[0].Text, myFont, sbrush, 150, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont, sbrush, 250, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[2].Text, myFont, sbrush, 350, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[3].Text, myFont, sbrush, 450, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[4].Text, myFont, sbrush, 550, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[5].Text, myFont, sbrush, 650, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[6].Text, myFont, sbrush, 750, y, myStringFormat);

                y += 20;

            }

        }

        private void grpEk_Click(object sender, EventArgs e)
        {

        }

        private void cmbAraTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
