using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Search : System.Web.UI.Page
{
    MakaleBLL _makale = new MakaleBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Ara"]!=null)
            {
                   AramaSonuclariniGetir();
            }
         
        }

    }

    private void AramaSonuclariniGetir()
    {
        string gelen = Request.QueryString["Ara"];
        rptAramaSonuclari.DataSource = _makale.Arama(gelen);
        rptAramaSonuclari.DataBind();
    }
}