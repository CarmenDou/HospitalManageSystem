using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class DrugAdd : System.Web.UI.Page
{
    public string strNav = "添加药品";
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
            txtD_No.Value = "YP" + DateTime.Now.ToString("yyMMddHHmmss");
            if (Request.QueryString["id"] != null)
            {

                Drug model = DrugBLL.GetIdByDrug(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.D_Id != 0)
                {
                    txtD_Approval.Value = model.D_Approval.Trim();
                    txtD_Composition.Value = model.D_Composition.Trim();
                    txtD_Efficacy.Value = model.D_Efficacy.Trim();
                    txtD_Methods.Value = model.D_Methods.Trim();
                    txtD_Name.Value = model.D_Name.Trim();
                    txtD_Price.Value = model.D_Price.ToString();
                    ddlU_Id.SelectedValue = model.U_Id.ToString().Trim();
                    ddlDt_Id.SelectedValue = model.Dt_Id.ToString().Trim();
                    txtD_No.Value = model.D_No.Trim();
                    txtD_Num.Value = model.D_Num.ToString();
                }
                strNav = "修改药品";
                btnAdd.Text = "修改";
                
            }

        }
    }


    private void BindsTypes()
    {
        ddlU_Id.DataSource = UnitsBLL.AllData("");
        ddlU_Id.DataTextField = "U_Name";
        ddlU_Id.DataValueField = "U_Id";
        ddlU_Id.DataBind();
         
        ddlDt_Id.DataSource = DrugTypeBLL.AllData("");
        ddlDt_Id.DataTextField = "Dt_Name";
        ddlDt_Id.DataValueField = "Dt_Id";
        ddlDt_Id.DataBind();
      

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

            Drug model = new Drug();
            model.D_Approval = txtD_Approval.Value.Trim();
            model.D_Composition = txtD_Composition.Value.Trim();
            model.D_Efficacy = txtD_Efficacy.Value.Trim();
            model.D_Methods = txtD_Methods.Value.Trim();
            model.D_Name = txtD_Name.Value.Trim();
            model.D_Price = Convert.ToDecimal( txtD_Price.Value.Trim());
            model.Dt_Id = Convert.ToInt32(ddlDt_Id.SelectedValue);
            model.U_Id = Convert.ToInt32(ddlU_Id.SelectedValue);
            model.D_No = txtD_No.Value.Trim();
            model.D_Num = Convert.ToInt32(txtD_Num.Value.Trim());

            if (DrugBLL.AddDrug(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('DrugManage.aspx');</script>");
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

            Drug model = DrugBLL.GetIdByDrug(Convert.ToInt32(Request.QueryString["id"]));
            model.D_Approval = txtD_Approval.Value.Trim();
            model.D_Composition = txtD_Composition.Value.Trim();
            model.D_Efficacy = txtD_Efficacy.Value.Trim();
            model.D_Methods = txtD_Methods.Value.Trim();
            model.D_Name = txtD_Name.Value.Trim();
            model.D_Price = Convert.ToDecimal(txtD_Price.Value.Trim());
            model.Dt_Id = Convert.ToInt32(ddlDt_Id.SelectedValue);
            model.U_Id = Convert.ToInt32(ddlU_Id.SelectedValue);
            model.D_No = txtD_No.Value.Trim();
            model.D_Num = Convert.ToInt32(txtD_Num.Value.Trim());
            if (DrugBLL.UpdateDrug(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('DrugManage.aspx');</script>");
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
