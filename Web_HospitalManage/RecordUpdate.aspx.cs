using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class RecordUpdate : System.Web.UI.Page
{
    public string strNav = "办理出院";
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

                Record model = RecordBLL.GetIdByRecord(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.P_Id != 0)
                {
                    txtBed.Value = model.R_Bed.ToString().Trim();
                    txtNo.Value = model.R_No.Trim();
                    txtEnter.Value = model.R_Enter.ToString("yyyy-MM-dd");
                    txtRoom.Value = model.R_Room.ToString().Trim();
                    ddlName.SelectedValue = model.P_Id.ToString().Trim();
                }
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
            Record model = RecordBLL.GetIdByRecord(Convert.ToInt32(Request.QueryString["id"]));

            model.R_Out = Convert.ToDateTime(txtOut.Value);
            model.R_State = "已出院";

            if (RecordBLL.UpdateRecord(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.close();</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');window.close();</script>");
                return;
            }

        
    }
}
