using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Management_Kategori_Listelem : System.Web.UI.UserControl
{
    KategoriBLL _kategori = new KategoriBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataYukle();
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_income"></param>
    private void DataYukle(string _income = "")
    {

        SayfadakiVeri = new PagedDataSource()
        {
            DataSource = _kategori.Listele(ref _income),
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

    /// <summary>
    /// 
    /// </summary>
    private void DataYukle()
    {
        SayfadakiVeri = new PagedDataSource()
        {
            DataSource = _kategori.Listele(),
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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btGeri_Click(object sender, EventArgs e)
    {
        PageNumber -= 1;
        DataYukle();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btIleri_Click(object sender, EventArgs e)
    {
        PageNumber += 1;
        DataYukle();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnKayitSil_Click(object sender, EventArgs e)
    {

        foreach (RepeaterItem kategpriItem in Repeater1.Items)
        {
            CheckBox chc = (CheckBox)kategpriItem.FindControl("CheckBox1");
            if (chc.Checked)
            {
                HiddenField gelenData = (HiddenField)kategpriItem.FindControl("hfGizli");
                _kategori.Sil(Convert.ToInt32(gelenData.Value));
            }
        }
        DataYukle();

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void search_Click(object sender, EventArgs e)
    {
        DataYukle(search_table.Value);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cbTumu_CheckedChanged(object sender, EventArgs e)
    {


        //Repeater1.Items.OfType<RepeaterItem>().ToList().ForEach(a => ((CheckBox)a.FindControl("CheckBox2")).Checked = true);
        //Repeater1.Items.OfType<RepeaterItem>().ToList().ForEach(a => ((CheckBox)a.FindControl("CheckBox2")).Checked = false);

        //foreach (RepeaterItem kategoriItem in Repeater1.Items)
        //{
        //    CheckBox chc = (CheckBox)kategoriItem.FindControl("CheckBox1");
        //    if (chc != null)
        //    {
        //        chc.Checked = true;
        //    }
        //}

       


        DataYukle();

    }


}


