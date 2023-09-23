using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class DiagnosisAdd : System.Web.UI.Page
{
    public string strNav = "诊断登记";
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
            txtNo.Value = "ZD" + DateTime.Now.ToString("yyMMddHHmmss");
            txtU_Id.Value = users.U_No + "(" + users.U_Name + ")";
            BindsTypes();
            if (Request.QueryString["id"] != null)
            {

                Diagnosis model = DiagnosisBLL.GetIdByDiagnosis(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.P_Id != 0)
                {
                    txtDescribe.Value = model.D_Describe.Trim();
                    txtNo.Value = model.D_No.Trim();
                    txtPrescription.Value = model.D_Prescription.Trim();
                    txtResults.Value = model.D_Results.Trim();
                    txtTime.Value = model.D_Time.ToString("yyyy-MM-dd HH:mm");
                    ddlName.SelectedValue = model.P_Id.ToString().Trim();
                    txtU_Id.Value = UsersBLL.GetIdByUsers(model.U_Id).U_No + "(" + UsersBLL.GetIdByUsers(model.U_Id).U_Name + ")";
                }
                strNav = "诊断修改";
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

            Diagnosis model = new Diagnosis();
            model.D_Describe = txtDescribe.Value.Trim();
            model.D_No = txtNo.Value.Trim();
            model.D_Prescription = txtPrescription.Value.Trim();
            model.D_Results = txtResults.Value.Trim();
            model.D_Time = DateTime.Now;
            model.P_Id = Convert.ToInt32(ddlName.SelectedValue);
            model.U_Id = users.U_Id;

            if (DiagnosisBLL.AddDiagnosis(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('DiagnosisManage.aspx');</script>");
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

            Diagnosis model = DiagnosisBLL.GetIdByDiagnosis(Convert.ToInt32(Request.QueryString["id"]));

            model.D_Describe = txtDescribe.Value.Trim();
            model.D_No = txtNo.Value.Trim();
            model.D_Prescription = txtPrescription.Value.Trim();
            model.D_Results = txtResults.Value.Trim();
            model.D_Time = DateTime.Now;
            model.P_Id = Convert.ToInt32(ddlName.SelectedValue);

            if (DiagnosisBLL.UpdateDiagnosis(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('DiagnosisManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                return;
            }

        }
    }
    protected void ddlName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
