using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class UsersAdd : System.Web.UI.Page
{
    public string strNav = "添加职工";
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
            BindsTypes();
            if (Request.QueryString["id"] != null)
            {

                Users model = UsersBLL.GetIdByUsers(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.R_Id != 0)
                {
                    txtU_Name.Value = model.U_Name.Trim();
                    txtU_No.Value = model.U_No.Trim();
                    txtU_Note.Value = model.U_Note.Trim();
                    txtU_Phone.Value = model.U_Phone.Trim();
                    txtU_Pwd.Value = model.U_Pwd.Trim();
                    ddlD_Id.SelectedValue = model.D_Id.ToString().Trim();
                    ddlR_Id.SelectedValue = model.R_Id.ToString().Trim();
                    ddlU_Sex.SelectedValue = model.U_Sex.Trim();
                }
                strNav = "修改职工";
                btnAdd.Text = "修改";
                
            }

        }
    }


    private void BindsTypes()
    {
        ddlD_Id.DataSource = DepartmentBLL.AllData("");
        ddlD_Id.DataTextField = "D_Name";
        ddlD_Id.DataValueField = "D_Id";
        ddlD_Id.DataBind();

        ddlR_Id.DataSource = RolesBLL.AllData("");
        ddlR_Id.DataTextField = "R_Name";
        ddlR_Id.DataValueField = "R_Id";
        ddlR_Id.DataBind();

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

            Users model = new Users();
            model.D_Id = Convert.ToInt32(ddlD_Id.SelectedValue);
            model.R_Id = Convert.ToInt32(ddlR_Id.SelectedValue);
            model.U_Name = txtU_Name.Value.Trim();
            model.U_No = txtU_No.Value.Trim();
            model.U_Note = txtU_Note.Value.Trim();
            model.U_Phone = txtU_Phone.Value.Trim();
            model.U_Pwd = txtU_Pwd.Value.Trim();
            model.U_Sex = ddlU_Sex.SelectedValue;

            if (!UsersBLL.IsTrue(model.U_No))
            {
                if (UsersBLL.AddUsers(model) > 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('UsersManage.aspx');</script>");
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
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该职工号已存在，请用别个！');</script>");
                return;
            }


        }
        else
        {

            Users model = UsersBLL.GetIdByUsers(Convert.ToInt32(Request.QueryString["id"]));
            model.D_Id = Convert.ToInt32(ddlD_Id.SelectedValue);
            model.R_Id = Convert.ToInt32(ddlR_Id.SelectedValue);
            model.U_Name = txtU_Name.Value.Trim();
            model.U_No = txtU_No.Value.Trim();
            model.U_Note = txtU_Note.Value.Trim();
            model.U_Phone = txtU_Phone.Value.Trim();
            model.U_Pwd = txtU_Pwd.Value.Trim();
            model.U_Sex = ddlU_Sex.SelectedValue;

            if (!UsersBLL.IsTrue(model.U_No,model.U_Id))
            {
                if (UsersBLL.UpdateUsers(model) > 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('UsersManage.aspx');</script>");
                    return;
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                    return;
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该职工号已存在，请用别个！');</script>");
                return;
            }

        }
    }
    protected void ddlR_Id_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
