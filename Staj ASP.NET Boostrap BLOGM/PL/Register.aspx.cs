using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Register : System.Web.UI.Page
{
    KullaniciBLL _kullanici = new KullaniciBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        mail.Attributes["type"] = "email";
    }


    public void Register_Click(object sender, EventArgs e)
    {
        Guid g = Guid.NewGuid();

        string body = string.Format("Sayın {0} Bloguma Hoşgeldiniz. Üyeliğinizi Aktifleştirmek İçin <a href=http://localhost:60225/Activation.aspx?UserID={1}&TabID=4&Alt=5&Durum=1> Click </a> ", name.Value + " " + surname.Value, g.ToString());
        Toolkit.MailGonder(mail.Value, body, "Aktivation");
        if (_kullanici.GirisYapsinMi(mail.Value) && (password.Value == confirmpassword.Value))
        {
            _kullanici.Insert(name.Value, surname.Value, mail.Value, password.Value,g.ToString());
            Response.Redirect("~/User_Login/User_Login.aspx");
        }
        else
        {

        }

    }
}