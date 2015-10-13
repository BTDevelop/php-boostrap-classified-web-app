using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;
using System.Drawing;
using System.Threading;
using MetroFramework.Forms;
using MetroFramework;

namespace CSharp_Assignment2_
{

    public partial class frmAgenda : MetroForm
    {
        public frmAgenda()
        {
            InitializeComponent();
        }


        Hashtable ajandHashTable = new Hashtable();
        string geriDegeri = "";
        string geriKey = "";
        CultureInfo culture = new CultureInfo("tr-TR");

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            //Ajanda Dosyasını okur
            ReadAgenda();
            //Haftalık Tablo oluştur
            Haftalar(DateTime.Now.Date);
        }

        //Tarihi Formatlıyoruz.
        string TarihiAyarla(DateTime inDate)
        {
            string dt = "";
            if (inDate.ToString().Contains("/"))
            {
                string[] correctDate = inDate.ToShortDateString().Split('/');
                if (correctDate[0].Length == 1)
                {
                    dt += "0" + correctDate[0].ToString() + "/";
                }
                else
                {
                    dt += correctDate[0].ToString() + "/";
                }
                if (correctDate[1].Length == 1)
                {
                    dt += "0" + correctDate[1].ToString() + "/";
                }
                else
                {
                    dt += correctDate[1].ToString() + "/";
                }
                dt += correctDate[2].ToString();
            }
            else if (inDate.ToString().Contains("."))
            {
                string[] correctDate = inDate.ToShortDateString().Split('.');
                if (correctDate[0].Length == 1)
                {
                    dt += "0" + correctDate[0].ToString() + ".";
                }
                else
                {
                    dt += correctDate[0].ToString() + ".";
                }
                if (correctDate[1].Length == 1)
                {
                    dt += "0" + correctDate[1].ToString() + ".";
                }
                else
                {
                    dt += correctDate[1].ToString() + ".";
                }
                dt += correctDate[2].ToString();
            }
            return dt.ToString(culture);
        }
        //Bugün ki gün sarı olacak şekilde labellar initialize edildi.
        void checkDate(Label dateLable, DateTime content)
        {
            //Label forecolor (sarı ve beyaz) ayarlandı
            if (content == DateTime.Now.Date) { dateLable.ForeColor = Color.Yellow; }
            else { dateLable.ForeColor = Color.White; }

            //Text dosyamda olan verileri(şayet varsa) Load ediyorum
            if (ajandHashTable.ContainsKey(TarihiAyarla(content)))
            {
                //Split metoduyla içerik ayıklaması yapılacak
                string[] Hashcontent = ajandHashTable[TarihiAyarla(content)].ToString().Split('*');
                if (dateLable.Name == "lblMon")
                {
                    txtMonM.Text = Hashcontent[0].ToString();
                    txtMonA.Text = Hashcontent[1].ToString();
                }
                else if (dateLable.Name == "lblTues")
                {
                    txtTuesM.Text = Hashcontent[0].ToString();
                    txtTuesA.Text = Hashcontent[1].ToString();
                }
                else if (dateLable.Name == "lblWed")
                {
                    txtWedM.Text = Hashcontent[0].ToString();
                    txtWedA.Text = Hashcontent[1].ToString();
                }
                else if (dateLable.Name == "lblThurs")
                {
                    txtThursM.Text = Hashcontent[0].ToString();
                    txtThursA.Text = Hashcontent[1].ToString();
                }
                else if (dateLable.Name == "lblFri")
                {
                    txtFriM.Text = Hashcontent[0].ToString();
                    txtFriA.Text = Hashcontent[1].ToString();
                }
                else
                {
                    txtSatM.Text = Hashcontent[0].ToString();
                    txtSatA.Text = Hashcontent[1].ToString();
                }
            }
        }

        void Haftalar(DateTime Tday)
        {
            DateTime strDate = Tday.ToUniversalTime();
            if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
            {
                strDate = Tday.AddDays(-6); checkDate(lblMon, strDate);
                lblMon.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-5); checkDate(lblTues, strDate);
                lblTues.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-4); checkDate(lblWed, strDate);
                lblWed.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-3); checkDate(lblThurs, strDate);
                lblThurs.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-2); checkDate(lblFri, strDate);
                lblFri.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-1); checkDate(lblSat, strDate);
                lblSat.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
            }
            else if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
            {
                checkDate(lblMon, Tday);
                lblMon.Text = Tday.Day + " " + Tday.ToString("MMMM") + " " + Tday.ToString("dddd");
                strDate = Tday.AddDays(1); checkDate(lblTues, strDate);
                lblTues.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(2); checkDate(lblWed, strDate);
                lblWed.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(3); checkDate(lblThurs, strDate);
                lblThurs.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(4); checkDate(lblFri, strDate);
                lblFri.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(5); checkDate(lblSat, strDate);
                lblSat.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
            }
            else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
            {
                strDate = Tday.AddDays(-1); checkDate(lblMon, strDate);
                lblMon.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                checkDate(lblTues, Tday);
                lblTues.Text = Tday.Day + " " + Tday.ToString("MMMM") + " " + Tday.ToString("dddd");
                strDate = Tday.AddDays(1); checkDate(lblWed, strDate);
                lblWed.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(2); checkDate(lblThurs, strDate);
                lblThurs.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(3); checkDate(lblFri, strDate);
                lblFri.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(4); checkDate(lblSat, strDate);
                lblSat.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
            }
            else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
            {
                strDate = Tday.AddDays(-2);
                checkDate(lblMon, strDate);
                lblMon.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-1);
                checkDate(lblTues, strDate);
                lblTues.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                checkDate(lblWed, Tday);
                lblWed.Text = Tday.Day + " " + Tday.ToString("MMMM") + " " + Tday.ToString("dddd");
                strDate = Tday.AddDays(1);
                checkDate(lblThurs, strDate);
                lblThurs.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(2);
                checkDate(lblFri, strDate);
                lblFri.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(3);
                checkDate(lblSat, strDate);
                lblSat.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
            }
            else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
            {
                strDate = Tday.AddDays(-3); checkDate(lblMon, strDate);
                lblMon.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-2); checkDate(lblTues, strDate);
                lblTues.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-1); checkDate(lblWed, strDate);
                lblWed.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                checkDate(lblThurs, Tday);
                lblThurs.Text = Tday.Day + " " + Tday.ToString("MMMM") + " " + Tday.ToString("dddd");
                strDate = Tday.AddDays(1); checkDate(lblFri, strDate);
                lblFri.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(2); checkDate(lblSat, strDate);
                lblSat.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
            }
            else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
            {
                strDate = Tday.AddDays(-4);
                checkDate(lblMon, strDate);
                lblMon.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-3); checkDate(lblTues, strDate);
                lblTues.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-2); checkDate(lblWed, strDate);
                lblWed.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-1); checkDate(lblThurs, strDate);
                lblThurs.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                checkDate(lblFri, Tday);
                lblFri.Text = Tday.Day + " " + Tday.ToString("MMMM") + " " + Tday.ToString("dddd");
                strDate = Tday.AddDays(1); checkDate(lblSat, strDate);
                lblSat.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
            }
            else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
            {
                strDate = Tday.AddDays(-5); checkDate(lblMon, strDate);
                lblMon.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-4); checkDate(lblTues, strDate);
                lblTues.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-3); checkDate(lblWed, strDate);
                lblWed.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-2); checkDate(lblThurs, strDate);
                lblThurs.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                strDate = Tday.AddDays(-1); checkDate(lblFri, strDate);
                lblFri.Text = strDate.Day + " " + strDate.ToString("MMMM") + " " + strDate.ToString("dddd");
                checkDate(lblSat, Tday);
                lblSat.Text = Tday.Day + " " + Tday.ToString("MMMM") + " " + Tday.ToString("dddd");
            }
        }

        void ReadAgenda()
        {
            //Date Time objesininin başlangıç tarihi(işler için)
            DateTime dtBeginning = new DateTime(2011, 1, 1);
            string strKey = dtBeginning.ToShortDateString(); int count = 1;
            while (true)
            {
                ajandHashTable.Add(TarihiAyarla(Convert.ToDateTime(strKey)), " * ");
                strKey = dtBeginning.AddDays(count++).ToShortDateString();
                DateTime dtKey = Convert.ToDateTime(strKey);
                if (dtKey.Year == 2015 && dtKey.Day == 31 && dtKey.Month == 12) break;
            }

            //Ajand.txt dosyasından veri okutuyorum
            try
            {
                string rdline;
                //Culture'ı Türkçe yapıyoruz
                Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
                StreamReader rdLine = new StreamReader(Application.StartupPath + "\\ajand.txt");
                while ((rdline = rdLine.ReadLine()) != null)
                {
                    ajandHashTable[rdline.Substring(0, 10)] = rdline.Substring(10);
                }
                rdLine.Close();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Hata oluştu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void alanlarıTemizle()
        {
            txtMonM.Text = "";
            txtMonA.Text = "";
            txtTuesM.Text = "";
            txtTuesA.Text = "";
            txtWedA.Text = "";
            txtWedM.Text = "";
            txtThursM.Text = "";
            txtThursA.Text = "";
            txtFriM.Text = "";
            txtFriA.Text = "";
            txtSatM.Text = "";
            txtSatA.Text = "";
        }

        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter wrLine = new StreamWriter(Application.StartupPath + "\\ajand.txt");
                foreach (DictionaryEntry taskEntry in ajandHashTable)
                {
                    if (ajandHashTable[taskEntry.Key].ToString() != " * ")
                    {
                        wrLine.WriteLine(taskEntry.Key.ToString() + "" + taskEntry.Value.ToString());
                    }
                }
                wrLine.Close();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Hatalı yazım yapılmıştır", "Dosya Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                MetroMessageBox.Show(this, "Tüm Planların Kaydedildi", "Kapanıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DateTime strDate = Convert.ToDateTime(takvim.SelectionStart.ToString());
            if (strDate.DayOfWeek.ToString() == Day.Sunday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-6);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Monday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-7);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Tuesday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-8);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Wednesday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-9);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Thursday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-10);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Friday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-11);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Saturday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(-12);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime strDate = Convert.ToDateTime(takvim.SelectionStart.ToString());
            if (strDate.DayOfWeek.ToString() == Day.Sunday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(1);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Monday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(7);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Tuesday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(6);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Wednesday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(5);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Thursday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(4);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Friday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(3);
            }
            else if (strDate.DayOfWeek.ToString() == Day.Saturday.ToString())
            {
                takvim.SelectionStart = strDate.AddDays(2);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchStr = txtSearch.Text.Trim().ToLower();
                Boolean found = false;
                foreach (DictionaryEntry taskEntry in ajandHashTable)
                {
                    string EachEntry = Convert.ToString(taskEntry.Value).Trim().ToLower();
                    if (EachEntry.Contains(searchStr))
                    {
                        alanlarıTemizle();
                        takvim.SelectionStart = Convert.ToDateTime(Convert.ToDateTime(taskEntry.Key).ToString());
                        if (MetroMessageBox.Show(this, "Kayıt bulundu.", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            found = true; break;
                        }
                    }
                }
                if (found == false)
                    MetroMessageBox.Show(this, "Kayıt bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Hata Oluştu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMonM_Leave(object sender, EventArgs e)
        {
            if (txtMonM.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            Boolean found = false;
            foreach (DictionaryEntry taskEntry in ajandHashTable)
            {
                if (Convert.ToString(taskEntry.Value).Trim() == geriDegeri.Trim())
                {
                    ajandHashTable[taskEntry.Key] = txtMonM.Text.Trim() + " * " + txtMonA.Text.Trim();
                    found = true; break;
                }
            }
            if (found == false)
            {
                ajandHashTable.Add(getDate("Mon"), " " + txtMonM.Text.Trim() + " * " + txtMonA.Text.Trim());
            }
            geriDegeri = "";
        }

        string getDate(string sDay)
        {
            try
            {
                DateTime Tday = Convert.ToDateTime(takvim.SelectionStart.ToString()); DateTime strDate; string str = "";
                if (sDay == "Mon")
                {
                    if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
                    {
                        str = TarihiAyarla(Tday.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
                    {
                        strDate = Tday.AddDays(-1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
                    {
                        strDate = Tday.AddDays(-2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
                    {
                        strDate = Tday.AddDays(-3);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
                    {
                        strDate = Tday.AddDays(-4);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
                    {
                        strDate = Tday.AddDays(-5);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
                    {
                        strDate = Tday.AddDays(-6);
                        str = TarihiAyarla(strDate.Date);
                    }
                }
                else if (sDay == "Tues")
                {
                    if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
                    {
                        strDate = Tday.AddDays(1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
                    {
                        str = TarihiAyarla(Tday.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
                    {
                        strDate = Tday.AddDays(-1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
                    {
                        strDate = Tday.AddDays(-2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
                    {
                        strDate = Tday.AddDays(-3);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
                    {
                        strDate = Tday.AddDays(-4);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
                    {
                        strDate = Tday.AddDays(-5);
                        str = TarihiAyarla(strDate.Date);
                    }
                }
                else if (sDay == "Wed")
                {
                    if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
                    {
                        strDate = Tday.AddDays(2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
                    {
                        strDate = Tday.AddDays(1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
                    {
                        str = TarihiAyarla(Tday.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
                    {
                        strDate = Tday.AddDays(-1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
                    {
                        strDate = Tday.AddDays(-2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
                    {
                        strDate = Tday.AddDays(-3);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
                    {
                        strDate = Tday.AddDays(-4);
                        str = TarihiAyarla(strDate.Date);
                    }
                }
                else if (sDay == "Thurs")
                {
                    if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
                    {
                        strDate = Tday.AddDays(3);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
                    {
                        strDate = Tday.AddDays(2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
                    {
                        strDate = Tday.AddDays(1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
                    {
                        str = TarihiAyarla(Tday.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
                    {
                        strDate = Tday.AddDays(-1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
                    {
                        strDate = Tday.AddDays(-2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
                    {
                        strDate = Tday.AddDays(-3);
                        str = TarihiAyarla(strDate.Date);
                    }
                }
                else if (sDay == "Fri")
                {
                    if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
                    {
                        strDate = Tday.AddDays(4);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
                    {
                        strDate = Tday.AddDays(3);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
                    {
                        strDate = Tday.AddDays(2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
                    {
                        strDate = Tday.AddDays(1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
                    {
                        str = TarihiAyarla(Tday.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
                    {
                        strDate = Tday.AddDays(-1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
                    {
                        strDate = Tday.AddDays(-2);
                        str = TarihiAyarla(strDate.Date);
                    }
                }
                else if (sDay == "Sat")
                {
                    if (Tday.DayOfWeek.ToString() == Day.Monday.ToString())
                    {
                        strDate = Tday.AddDays(5);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Tuesday.ToString())
                    {
                        strDate = Tday.AddDays(4);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Wednesday.ToString())
                    {
                        strDate = Tday.AddDays(3);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Thursday.ToString())
                    {
                        strDate = Tday.AddDays(2);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Friday.ToString())
                    {
                        strDate = Tday.AddDays(1);
                        str = TarihiAyarla(strDate.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Saturday.ToString())
                    {
                        str = TarihiAyarla(Tday.Date);
                    }
                    else if (Tday.DayOfWeek.ToString() == Day.Sunday.ToString())
                    {
                        strDate = Tday.AddDays(-1);
                        str = TarihiAyarla(strDate.Date);
                    }
                }
                return str;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void txtMonM_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtMonM.Text.Trim() + " * " + txtMonA.Text.Trim();
            geriKey = getDate("Mon");
        }

        private void txtMonA_Leave(object sender, EventArgs e)
        {
            if (txtMonA.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtMonM.Text.Trim() + " * " + txtMonA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtTuesM_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtTuesM.Text.Trim() + " * " + txtTuesA.Text.Trim();
            geriKey = getDate("Tues");
        }

        private void txtTuesM_Leave(object sender, EventArgs e)
        {
            if (txtTuesM.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtTuesM.Text.Trim() + " * " + txtTuesA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtTuesA_Leave(object sender, EventArgs e)
        {
            if (txtTuesA.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtTuesM.Text.Trim() + " * " + txtTuesA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtTuesA_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtTuesM.Text.Trim() + " * " + txtTuesA.Text.Trim();
            geriKey = getDate("Tues");
        }

        private void txtWedM_Leave(object sender, EventArgs e)
        {
            if (txtWedM.Text.Trim() == "" && geriDegeri.Trim() == " * ") return;
            ajandHashTable[geriKey] = txtWedM.Text.Trim() + " * " + txtWedA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtWedM_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtWedM.Text.Trim() + " * " + txtWedA.Text.Trim();
            geriKey = getDate("Wed");
        }

        private void txtWedA_Leave(object sender, EventArgs e)
        {
            if (txtWedA.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtWedM.Text.Trim() + " * " + txtWedA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtWedA_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtWedM.Text.Trim() + " * " + txtWedA.Text.Trim();
            geriKey = getDate("Wed");
        }

        private void txtThursM_Leave(object sender, EventArgs e)
        {
            if (txtThursM.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtThursM.Text.Trim() + " * " + txtThursA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtThursM_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtThursM.Text.Trim() + " * " + txtThursA.Text.Trim();
            geriKey = getDate("Thurs");
        }

        private void txtThursA_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtThursM.Text.Trim() + " * " + txtThursA.Text.Trim();
            geriKey = getDate("Thurs");
        }

        private void txtThursA_Leave(object sender, EventArgs e)
        {
            if (txtThursA.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtThursM.Text.Trim() + " * " + txtThursA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtFriM_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtFriM.Text.Trim() + " * " + txtFriA.Text.Trim();
            geriKey = getDate("Fri");
        }

        private void txtFriM_Leave(object sender, EventArgs e)
        {
            if (txtFriM.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtFriM.Text.Trim() + " * " + txtFriA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtFriA_Leave(object sender, EventArgs e)
        {
            if (txtFriA.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtFriM.Text.Trim() + " * " + txtFriA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtFriA_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtFriM.Text.Trim() + " * " + txtFriA.Text.Trim();
            geriKey = getDate("Fri");
        }

        private void txtSatM_Leave(object sender, EventArgs e)
        {
            if (txtSatM.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtSatM.Text.Trim() + " * " + txtSatA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtSatM_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtSatM.Text.Trim() + " * " + txtSatA.Text.Trim();
            geriKey = getDate("Sat");
        }

        private void txtSatA_Leave(object sender, EventArgs e)
        {
            if (txtSatA.Text.Trim() == "" && geriDegeri.Trim() == "*") return;
            ajandHashTable[geriKey] = txtSatM.Text.Trim() + " * " + txtSatA.Text.Trim();
            geriDegeri = ""; geriKey = "";
        }

        private void txtSatA_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtSatM.Text.Trim() + " * " + txtSatA.Text.Trim();
            geriKey = getDate("Sat");
        }

        private void txtMonA_Enter(object sender, EventArgs e)
        {
            geriDegeri = txtMonM.Text.Trim() + " * " + txtMonA.Text.Trim();
            geriKey = getDate("Mon");
        }

        private void takvim_DateChanged(object sender, DateRangeEventArgs e)
        {

            alanlarıTemizle();
            if (e.Start.Date == DateTime.Today) takvim.ShowTodayCircle = true;
            Haftalar(Convert.ToDateTime(e.Start.ToShortDateString()));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = Application.StartupPath + "\\ajand.txt";
            try
            {
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch
            {
                MetroMessageBox.Show(this, "Şu anda bir dosya bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
