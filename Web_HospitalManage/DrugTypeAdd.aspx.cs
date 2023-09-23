using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class DrugTypeAdd : System.Web.UI.Page
{
    public string strNav = "添加药品分类";
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

            if (Request.QueryString["id"] != null)
            {

                DrugType model = DrugTypeBLL.GetIdByDrugType(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.Dt_Id != 0)
                {
                    txtName.Value = model.Dt_Name.Trim();
                }
                strNav = "修改药品分类";
                btnAdd.Text = "修改";
                
            }

        }
    }






    /// <summary>
    /// 添加，修改
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (btnAdd.Text == "添加")
        {

            DrugType model = new DrugType();
            model.Dt_Name = txtName.Value.Trim();

            if (DrugTypeBLL.AddDrugType(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('DrugTypeManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加失败！');</script>");
                return;
            }


        }
        else
        {

            DrugType model = DrugTypeBLL.GetIdByDrugType(Convert.ToInt32(Request.QueryString["id"]));
            model.Dt_Name = txtName.Value.Trim();


            if (DrugTypeBLL.UpdateDrugType(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('DrugTypeManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                return;
            }

        }
    }
}
