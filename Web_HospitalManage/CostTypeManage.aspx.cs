using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class CostTypeManage : System.Web.UI.Page
{
    public int currentPageIndex = 1;//当前页数
    public int count = 0;//总数据条数
    public int ye = 1;//一共有多少页
    public int pageSize = 20;//每页几条
    public string strWhere = "";//查询条件
    public string strUrlPage = "CostTypeManage.aspx";//跳转的页
    public Users users = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
        }
        else
        {
            users = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }
        if (!IsPostBack)
        {
            Binds();
        }
    }


    /// <summary>
    /// 加载默认绑定
    /// </summary>
    private void Binds()
    {

        count = CostTypeBLL.CountNumber(strWhere);
        FenYe();
        RpView.DataSource = CostTypeBLL.PageSelectCostType(pageSize, currentPageIndex, strWhere, "Ct_Id", "asc");
        RpView.DataBind();

    }


    /// <summary>
    /// 分页
    /// </summary>
    private void FenYe()
    {
        if (count % pageSize != 0)
        {
            ye = count / pageSize + 1;
        }
        else
        {
            ye = count / pageSize;
        }
        if (Request.QueryString["currentPageIndex"] != null)
        {
            currentPageIndex = Convert.ToInt32(Request.QueryString["currentPageIndex"]);
        }
        if (currentPageIndex > ye)
        {
            currentPageIndex = ye;
        }
        if (currentPageIndex < 1)
        {
            currentPageIndex = 1;
        }
    }





    protected void BtnAllDel_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(HSelectID.Value.Trim()))
        {
            try
            {
                string a = HSelectID.Value.Trim();
                string[] b = a.Split(new char[] { ',' });
                int j = 0;
                foreach (string c in b)
                {
                    j++;
                    CostTypeBLL.DeleteCostType(Convert.ToInt32(c));
                }
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功！已成功删除" + j + "条记录。');location=location;</script>");
                return;
            }
            catch
            {

                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除失败！');</script>");
                return;
            }
        }
    }
}
