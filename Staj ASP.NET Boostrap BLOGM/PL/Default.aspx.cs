using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
public partial class _Default : System.Web.UI.Page
{
    MakaleBLL _makale = new MakaleBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["KategoriId"] != null)
        {
            int _incomeId = Convert.ToInt32(Request.QueryString["KategoriId"]);
            if (!IsPostBack)
            {
                DataYukle_2();
            }

        }
        else
        {

            if (!IsPostBack)
            {
                DataYukle();
            }
        }
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

            DataSource = _makale.Listele(true),
            AllowPaging = true,
            PageSize = 5,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

        previous.Visible = !SayfadakiVeri.IsFirstPage;
        next.Visible = !SayfadakiVeri.IsLastPage;

    }

    private void DataYukle_2()
    {
        SayfadakiVeri = new PagedDataSource()
        {

            DataSource = _makale.Listele(Convert.ToInt32(Request.QueryString["KategoriId"])),
            AllowPaging = true,
            PageSize = 5,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

        previous.Visible = !SayfadakiVeri.IsFirstPage;
        next.Visible = !SayfadakiVeri.IsLastPage;

    }

    protected void btGeri_Click(object sender, EventArgs e)
    {
        PageNumber -= 1;
        DataYukle();
    }

    protected void btIleri_Click(object sender, EventArgs e)
    {
        PageNumber += 1;
        DataYukle();
    }


}