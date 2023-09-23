using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Model;
using BLL;

public partial class RegisterAdd : System.Web.UI.Page
{
    public string strNav = "挂号登记";
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
            txtR_No.Value ="GH"+DateTime.Now.ToString("yyMMddHHmmss");
            txtU_Id.Value = users.U_No + "(" + users.U_Name + ")";
            if (Request.QueryString["id"] != null)
            {

                Register model = RegisterBLL.GetIdByRegister(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.R_Id != 0)
                {
                    txtR_Cost.Value = model.R_Cost.ToString().Trim();
                    txtR_Name.Value = model.R_Name.Trim();
                    txtR_No.Value = model.R_No.Trim();
                    ddlD_Id.SelectedValue = model.D_Id.ToString().Trim();
                    ddlRt_Id.SelectedValue = model.Rt_Id.ToString().Trim();
                    txtU_Id.Value = UsersBLL.GetIdByUsers(model.U_Id).U_No + "(" + UsersBLL.GetIdByUsers(model.U_Id).U_Name + ")";
                }
                strNav = "挂号修改";
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
        ddlD_Id.Items.Insert(0, new ListItem("--请选择--", "0"));

        ddlRt_Id.DataSource = RegisterTypeBLL.AllData("");
        ddlRt_Id.DataTextField = "Rt_Name";
        ddlRt_Id.DataValueField = "Rt_Id";
        ddlRt_Id.DataBind();

        txtR_Cost.Value=RegisterTypeBLL.GetIdByRegisterType(Convert.ToInt32(ddlRt_Id.SelectedValue)).Rt_Cost.ToString();


       
    }






    /// <summary>
    /// 添加，修改
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (btnAdd.Text == "登记")
        {

            Register model = new Register();
            model.D_Id = Convert.ToInt32(ddlD_Id.SelectedValue.Trim());
            model.R_Cost = Convert.ToDecimal(txtR_Cost.Value.Trim());
            model.R_Name = txtR_Name.Value.Trim();
            model.R_No = txtR_No.Value.Trim();
            model.Rt_Id = Convert.ToInt32(ddlRt_Id.SelectedValue.Trim());
            model.U_Id = users.U_Id;

            if (RegisterBLL.AddRegister(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登记成功！');window.location.replace('RegisterManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登记失败！');</script>");
                return;
            }
        }
        else
        {

            Register model = RegisterBLL.GetIdByRegister(Convert.ToInt32(Request.QueryString["id"]));
            model.D_Id = Convert.ToInt32(ddlD_Id.SelectedValue.Trim());
            model.R_Cost = Convert.ToDecimal(txtR_Cost.Value.Trim());
            model.R_Name = txtR_Name.Value.Trim();
            model.R_No = txtR_No.Value.Trim();
            model.Rt_Id = Convert.ToInt32(ddlRt_Id.SelectedValue.Trim());
            

            if (RegisterBLL.UpdateRegister(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('RegisterManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                return;
            }
        }
        
    }
    protected void ddlRt_Id_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtR_Cost.Value = RegisterTypeBLL.GetIdByRegisterType(Convert.ToInt32(ddlRt_Id.SelectedValue)).Rt_Cost.ToString();
        if (Request.QueryString["id"] != null)
        {
            strNav = "挂号修改";
        }
    }
    protected void ddlD_Id_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
