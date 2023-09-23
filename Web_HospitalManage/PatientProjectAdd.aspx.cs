using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class PatientProjectAdd : System.Web.UI.Page
{
    public string strNav = "项目消费记录添加";
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
            txtU_Id.Value = users.U_No + "(" + users.U_Name + ")";
            BindsTypes();
            if (Request.QueryString["id"] != null)
            {

                PatientProject model = PatientProjectBLL.GetIdByPatientProject(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.Pp_Id != 0)
                {
                    txtCount.Value = model.Pp_Count.ToString().Trim();
                    txtPrice.Value = model.Pp_Price.ToString().Trim();
                    txtTime.Value = model.Pp_Time.ToString("yyyy-MM-dd HH:mm");
                    ddlName.SelectedValue = model.P_Id.ToString().Trim();
                    ddlCp_Id.SelectedValue = model.Cp_Id.ToString().Trim();
                    txtU_Id.Value = UsersBLL.GetIdByUsers(model.U_Id).U_No + "(" + UsersBLL.GetIdByUsers(model.U_Id).U_Name + ")";
                }
                strNav = "项目消费记录修改";
                btnAdd.Text = "修改";
            }

        }
    }

    private void BindsTypes()
    {
        List<Patient> listPat = PatientBLL.AllData("");
        if (listPat.Count > 0)
        {
            for (int i = 0; i < listPat.Count; i++)
            {
                ddlName.Items.Add(new ListItem("("+listPat[i].P_No+")"+listPat[i].P_Name,listPat[i].P_Id.ToString()));
            }
            ddlName.Items.Insert(0, new ListItem("--请选择--","0"));
        }

        List<ChargeProject> listPro = ChargeProjectBLL.AllData("");
        if (listPat.Count > 0)
        {
            for (int i = 0; i < listPro.Count; i++)
            {
                ddlCp_Id.Items.Add(new ListItem("(" + listPro[i].Cp_No + ")" + listPro[i].Cp_Name, listPro[i].Cp_Id.ToString()));
            }
            ddlCp_Id.Items.Insert(0, new ListItem("--请选择--", "0"));
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

            PatientProject model = new PatientProject();
            model.Cp_Id = Convert.ToInt32(ddlCp_Id.SelectedValue.Trim());
            model.P_Id = Convert.ToInt32(ddlName.SelectedValue.Trim());
            model.Pp_Count = Convert.ToInt32(txtCount.Value.Trim());
            model.Pp_Price = Convert.ToDecimal(txtPrice.Value.Trim());
            model.Pp_Amount = model.Pp_Price * model.Pp_Count;
            model.Pp_Time = Convert.ToDateTime(txtTime.Value.Trim());
            model.U_Id = users.U_Id;





            if (PatientProjectBLL.AddPatientProject(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('PatientProjectManage.aspx');</script>");
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

            PatientProject model = PatientProjectBLL.GetIdByPatientProject(Convert.ToInt32(Request.QueryString["id"]));

            model.Cp_Id = Convert.ToInt32(ddlCp_Id.SelectedValue.Trim());
            model.P_Id = Convert.ToInt32(ddlName.SelectedValue.Trim());
            model.Pp_Count = Convert.ToInt32(txtCount.Value.Trim());
            model.Pp_Price = Convert.ToDecimal(txtPrice.Value.Trim());
            model.Pp_Amount = model.Pp_Price * model.Pp_Count;
            model.Pp_Time = Convert.ToDateTime(txtTime.Value.Trim());

            if (PatientProjectBLL.UpdatePatientProject(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('PatientProjectManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                return;
            }

        }
    }
    protected void ddlCp_Id_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtPrice.Value = ChargeProjectBLL.GetIdByChargeProject(Convert.ToInt32(ddlCp_Id.SelectedValue.Trim())).Cp_Cost.ToString();
        if (Request.QueryString["id"] != null)
        {
            strNav = "项目消费记录修改";
        }
    }
}
