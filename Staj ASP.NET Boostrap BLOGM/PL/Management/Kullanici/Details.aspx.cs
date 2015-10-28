using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Management_Kullanici_Details : System.Web.UI.Page
{
    KullaniciBLL _kullanici = new KullaniciBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            KullaniciGetir();

        }
    }
    private void KullaniciGetir()
    {
        if (Request.QueryString["KullaniciId"] != null)
        {
            string[] partialQuery = Request.QueryString["KullaniciId"].Split('-');

            try
            {
                int _incomeId = Convert.ToInt32(partialQuery[partialQuery.Length - 1]);
                Kullanici _kll = _kullanici.Search(_incomeId);
                if (_kll != null)
                {
                    Label1.Text = _kll.Ad + " " + _kll.Soyad;
                    Label2.Text = _kll.EPosta;
                    Label3.Text = _kll.Sifre;
                    Label4.Text = _kll.SonGirisTarihi.ToString();
                    Label5.Text = _kll.SonIP;
                    Label6.Text = _kll.SonTarayici;
                }

            }
            catch (Exception)
            {

                Response.Redirect("~/Management/Hata.aspx");
            }
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}