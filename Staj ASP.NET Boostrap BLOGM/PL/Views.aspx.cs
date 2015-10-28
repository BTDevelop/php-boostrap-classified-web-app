using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using System.Text;

public partial class Views : System.Web.UI.Page
{
    YorumBLL _yorum = new YorumBLL();
    MakaleBLL _makale = new MakaleBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            KategoriGetir();
            DataYukle();
        }
        if (Session["Uye"] != null)
        {
            alertSign.Visible = false;
        }
        else
        {
            commentForm.Visible = false;
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
        string[] partialQuery = Request.QueryString["MakaleId"].Split('-');
        SayfadakiVeri = new PagedDataSource()
        {

            DataSource = _yorum.List(Convert.ToInt32(partialQuery[1])),
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


    //public  void EtiketBul(string _income)
    //{
    //     StringBuilder sb = new StringBuilder();
    //    if (_income.Length > 0)
    //    {
    //        for (int i = 0; i < _income.Length; i++)
    //        {
    //            sb.Append(_income[i] + " ");
    //        }
    //    }

    //    string[] dizi = sb.ToString().ToLower().Split(' ');
    //    var frekans = dizi.GroupBy(tt => tt).Select(tt => new { kelime = tt.Key, adet = tt.Count() }).OrderByDescending(tt => tt.adet);

    //    foreach (var item in frekans)
    //    {
    //       textArticle.InnerHtml=string.Format("{0} {1} adet mevcut", item.kelime, item.adet);
    //    }
    //}

    private void KategoriGetir()
    {
        if (Request.QueryString["MakaleId"] != null)
        {
            string[] partialQuery = Request.QueryString["MakaleId"].Split('-');

            try
            {
                int _incomeId = Convert.ToInt32(partialQuery[partialQuery.Length - 1]);
                Makale _mkl = _makale.Bul(_incomeId);
                if (_mkl != null)
                {
                    Label1.Text = _mkl.Baslik;
                    textArticle.InnerHtml = _mkl.MakaleYazi;

                    string[] patialDate = _mkl.Tarih.ToString().Split(' ');
                    Label2.Text = patialDate[0];
                }

            }
            catch (Exception)
            {

                Response.Redirect("~/Management/Hata.aspx");
            }
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }


    protected void AddComment_Click(object sender, EventArgs e)
    {
        Kullanici _uye = (Kullanici)Session["Uye"];

        string[] partialQuery = Request.QueryString["MakaleId"].Split('-');
        _yorum.Insert(CKEditorControl1.Text, Convert.ToInt32(partialQuery[1]), _uye.KullaniciId);
        
        DataYukle();

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