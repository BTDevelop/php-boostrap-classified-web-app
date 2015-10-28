using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

public partial class MainMaster : System.Web.UI.MasterPage
{
    KullaniciBLL _kullanici = new KullaniciBLL();
    MakaleBLL _makale = new MakaleBLL();
    IletisimBLL _iletisim = new IletisimBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["Yetkili"] != null)
        {
            Kullanici _yetki = (Kullanici)Session["Yetkili"];
            HttpRequest _request = base.Request;
            Label1.Text = _yetki.Ad + " " + _yetki.Soyad;
            Label2.Text = _request.Browser.Browser + " " + "Tarayıcı";
            Label3.Text = _request.UserHostAddress;
            Label4.Text = _yetki.SonGirisTarihi.ToString();
            Label5.Text = _yetki.Ad + " " + _yetki.Soyad;
            Label6.Text = _makale.Listele().Count().ToString();
            Label7.Text = (_kullanici.Listed().Count()).ToString();
            _kullanici.Update(1, _request.Browser.Browser, _request.UserHostAddress);
        }
        else
        {
            Response.Redirect("~/Login/Login.aspx");
        }

    
    }
    
}
