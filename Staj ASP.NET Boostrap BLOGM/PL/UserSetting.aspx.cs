using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class UserSetting : System.Web.UI.Page
{
    KullaniciBLL _kullanici = new KullaniciBLL();

    protected void Page_Load(object sender, EventArgs e)
    {

        Kullanici _uye = (Kullanici)Session["Uye"];
        name.Value = _uye.Ad;
        surname.Value = _uye.Soyad;
    }

    public void OK_Click(object sender, EventArgs e)
    { 
     Kullanici _uye = (Kullanici)Session["Uye"];
     _kullanici.UserUpdate(_uye.KullaniciId, name.Value, surname.Value);
    }

    public void Dondur_Click(object sender, EventArgs e)
    {
        
        Kullanici _uye = (Kullanici)Session["Uye"];
        _kullanici.UserDeactive(_uye.KullaniciId,false);
      
        
    }
    public void Aktif_Click(object sender, EventArgs e)
    {

        Kullanici _uye = (Kullanici)Session["Uye"];
        _kullanici.UserDeactive(_uye.KullaniciId,true);


    }
    
}