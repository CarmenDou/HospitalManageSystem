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
    public string strNav = "病人资料录入";
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
            txtNo.Value = "BR" + DateTime.Now.ToString("yyMMddHHmmss");
            if (Request.QueryString["id"] != null)
            {

                Patient model = PatientBLL.GetIdByPatient(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.P_Id != 0)
                {
                    txtAge.Value = model.P_Age.ToString().Trim();
                    txtName.Value = model.P_Name.Trim();
                    txtNo.Value = model.P_No.Trim();
                    txtPhone.Value = model.P_Phone.Trim();
                    ddlSex.SelectedValue = model.P_Sex.Trim();
                }
                strNav = "病人资料修改";
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

            Patient model = new Patient();
            model.P_Age = Convert.ToInt32(txtAge.Value.Trim());
            model.P_Name = txtName.Value.Trim();
            model.P_No = txtNo.Value.Trim();
            model.P_Phone = txtPhone.Value.Trim();
            model.P_Sex = ddlSex.SelectedValue;

            if (PatientBLL.AddPatient(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('PatientManage.aspx');</script>");
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

            Patient model = PatientBLL.GetIdByPatient(Convert.ToInt32(Request.QueryString["id"]));
            model.P_Age = Convert.ToInt32(txtAge.Value.Trim());
            model.P_Name = txtName.Value.Trim();
            model.P_No = txtNo.Value.Trim();
            model.P_Phone = txtPhone.Value.Trim();
            model.P_Sex = ddlSex.SelectedValue;

            if (PatientBLL.UpdatePatient(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('PatientManage.aspx');</script>");
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
