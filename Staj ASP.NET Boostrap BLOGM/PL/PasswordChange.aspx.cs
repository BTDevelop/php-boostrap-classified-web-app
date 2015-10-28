using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class PasswordChange : System.Web.UI.Page
{
    KullaniciBLL _kullanici = new KullaniciBLL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void OK_Click(Object sender, EventArgs e)
    {
        Kullanici _uye = (Kullanici)Session["Uye"];
        if (_uye.Sifre==password.Value)
        {
            _kullanici.PasswordChange(_uye.KullaniciId, newpassword.Value);
            Toolkit.MailGonder(_uye.EPosta, "Şifreniz değiştirilmiştir yeni şifreniz:" + newpassword.Value, "Şifre Değişimi");
        }
    }
}