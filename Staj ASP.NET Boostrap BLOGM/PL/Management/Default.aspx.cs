using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


public partial class Management_Default : System.Web.UI.Page
{
    IletisimBLL _iletisim = new IletisimBLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        DataYukle();
    }

    private int PageNumber
    {
        get
        {
            if (ViewState["PageNumber"] != null)
                return Convert.ToInt32(ViewState["PageNumber"]);
            return 0;
        }
        set
        {
            ViewState["PageNumber"] = value;
        }
    }
    private int PageCount
    {
        get
        {
            if (ViewState["PageCount"] != null)
                return Convert.ToInt32(ViewState["PageCount"]);
            return 0;
        }
        set { ViewState["PageCount"] = value; }
    }
    public PagedDataSource SayfadakiVeri { get; set; }

    private void DataYukle()
    {

        SayfadakiVeri = new PagedDataSource()
        {

            DataSource = _iletisim.List(),
            AllowPaging = true,
            PageSize = 5,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

    }
}