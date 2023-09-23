using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class DepartmentAdd : System.Web.UI.Page
{
    public string strNav = "添加科室";
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

                Department model = DepartmentBLL.GetIdByDepartment(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.D_Id != 0)
                {
                    txtName.Value = model.D_Name.Trim();
                }
                strNav = "修改科室";
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

            Department model = new Department();
            model.D_Name = txtName.Value.Trim();

            if (DepartmentBLL.AddDepartment(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('DepartmentManage.aspx');</script>");
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

            Department model = DepartmentBLL.GetIdByDepartment(Convert.ToInt32(Request.QueryString["id"]));
            model.D_Name = txtName.Value.Trim();


            if (DepartmentBLL.UpdateDepartment(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('DepartmentManage.aspx');</script>");
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
