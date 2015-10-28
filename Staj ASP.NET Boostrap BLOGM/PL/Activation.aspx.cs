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
        if (Request.QueryString["UserID"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            string _GUID = Request.QueryString["UserID"];
            if (_kullanici.MemberActivation(_GUID))
            {
                signAct.Visible = true;
            }
            else
            {
                signAct.Visible = false;
            }
        }
    }


    public void RegisterCom_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User_Login/User_Login.aspx");

    }
}