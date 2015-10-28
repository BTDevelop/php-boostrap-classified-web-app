using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Web.Security;
using System.Net;
using System.Globalization;
using System.IO;
using System.Text;

public partial class MainMaster : System.Web.UI.MasterPage
{
    KullaniciBLL _kullanici = new KullaniciBLL();
    KategoriBLL _kategori = new KategoriBLL();
    MakaleBLL _makale = new MakaleBLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Uye"] != null)
        {
          
            register.Visible = false;
            Kullanici _uye = (Kullanici)Session["Uye"];
            HttpRequest _request = base.Request;

            if ((_uye.Ad != " " || _uye.Soyad != " ") && _uye.Rol != null)
            {
                Label1.Text = _uye.Ad + " " + _uye.Soyad;
                Label5.Text = _uye.Ad + " " + _uye.Soyad;
            }
            else if (_uye.Rol == null)
            {
                Label1.Text = "Aktifleşmemiş Hesap";
                Label5.Text = "Aktifleşmemiş Hesap";
             
                
            }
            else
            {
                Label1.Text = _uye.EPosta;
                Label5.Text = _uye.EPosta;
            }

            Label2.Text = _request.Browser.Browser + " " + "Tarayıcı";
            Label3.Text = _request.UserHostAddress;
            Label4.Text = _uye.SonGirisTarihi.ToString();

            _kullanici.Update(_uye.KullaniciId, _request.Browser.Browser, _request.UserHostAddress);
        }
        else
        {
            login.Visible = false;
            envelope.Visible = false;
            information.Visible = false;
            Label5.Text = "Merhaba Ziyaretçi Üye Olmak İster Misiniz?";
        }

        if (!IsPostBack)
        {
            KategoriListele();
            HaberListele();
        }



    }
    public void Logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        FormsAuthentication.SignOut();
        Response.Redirect("~/Default.aspx");

    }
    public void KategoriListele()
    {
        Repeater1.DataSource = _kategori.Listele();
        Repeater1.DataBind();
    }

    public void HaberListele()
    {
        Repeater2.DataSource = _makale.Listele(false);
        Repeater2.DataBind();
    }

    public void Ara_Click(Object sender, EventArgs e)
    {
        Response.Redirect("~/Search.aspx?Ara=" + txtAra.Value + "");


    }


}
