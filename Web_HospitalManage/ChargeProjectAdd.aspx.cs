using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class ChargeProjectAdd : System.Web.UI.Page
{
    public string strNav = "添加收费项目";
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
            txtCp_No.Value = "XM" + DateTime.Now.ToString("yyMMddHHmmss");
            if (Request.QueryString["id"] != null)
            {
                ChargeProject model = ChargeProjectBLL.GetIdByChargeProject(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.Cp_Id != 0)
                {
                    txtCp_Cost.Value = model.Cp_Cost.ToString();
                    txtCp_Name.Value = model.Cp_Name.ToString();
                    txtCp_No.Value = model.Cp_No.ToString();
                    txtCp_Note.Value = model.Cp_Note.ToString();
                    ddlCt_Id.SelectedValue = model.Ct_Id.ToString();
                }
                strNav = "修改收费项目";
                btnAdd.Text = "修改";
                
            }

        }
    }


    private void BindsTypes()
    {
        ddlCt_Id.DataSource = CostTypeBLL.AllData("");
        ddlCt_Id.DataTextField = "Ct_Name";
        ddlCt_Id.DataValueField = "Ct_Id";
        ddlCt_Id.DataBind();
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

            ChargeProject model = new ChargeProject();
            model.Cp_Cost = Convert.ToDecimal(txtCp_Cost.Value.Trim());
            model.Cp_Name = txtCp_Name.Value.Trim();
            model.Cp_No = txtCp_No.Value.Trim();
            model.Cp_Note = txtCp_Note.Value.Trim();
            model.Ct_Id = Convert.ToInt32(ddlCt_Id.SelectedValue.Trim());

            if (ChargeProjectBLL.AddChargeProject(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('ChargeProjectManage.aspx');</script>");
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

            ChargeProject model = ChargeProjectBLL.GetIdByChargeProject(Convert.ToInt32(Request.QueryString["id"]));
            model.Cp_Cost = Convert.ToDecimal(txtCp_Cost.Value.Trim());
            model.Cp_Name = txtCp_Name.Value.Trim();
            model.Cp_No = txtCp_No.Value.Trim();
            model.Cp_Note = txtCp_Note.Value.Trim();
            model.Ct_Id = Convert.ToInt32(ddlCt_Id.SelectedValue.Trim());

            if (ChargeProjectBLL.UpdateChargeProject(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('ChargeProjectManage.aspx');</script>");
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
