using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class RegisterManage : System.Web.UI.Page
{
    public int currentPageIndex = 1;//当前页数
    public int count = 0;//总数据条数
    public int ye = 1;//一共有多少页
    public int pageSize = 20;//每页几条
    public string strWhere = "";//查询条件
    public string strUrlPage = "RegisterManage.aspx";//跳转的页
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
        if (txtR_No.Text.Length != 0)
        {
            strWhere += " and R_No like '%" + txtR_No.Text.Trim() + "%'";
        }
        if (txtR_Name.Text.Length != 0)
        {
            strWhere += " and R_Name like '%" + txtR_Name.Text.Trim() + "%'";
        }
        if (txtKey.Text.Length != 0)
        {
            strWhere += " and (U_No like '%" + txtKey.Text.Trim() + "%' or U_Name like '%" + txtKey.Text.Trim() + "%')";
        }
        count = RegisterBLL.CountNumber2(strWhere);
        FenYe();
        RpView.DataSource = RegisterBLL.PageSelectRegister2(pageSize, currentPageIndex, strWhere, "Register.R_Id", "desc");
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
                    RegisterBLL.DeleteRegister(Convert.ToInt32(c));
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
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Binds();
    }
    protected void RpView_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}
