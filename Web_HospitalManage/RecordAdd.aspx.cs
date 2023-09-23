using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class RecordAdd : System.Web.UI.Page
{
    public string strNav = "住院登记";
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
            txtNo.Value = "ZY" + DateTime.Now.ToString("yyMMddHHmmss");
            BindsTypes();
            txtU_Id.Value = users.U_No + "(" + users.U_Name + ")";
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
                    txtU_Id.Value = UsersBLL.GetIdByUsers(model.U_Id).U_No + "(" + UsersBLL.GetIdByUsers(model.U_Id).U_Name + ")";
                }
                strNav = "住院修改";
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

            Record model = new Record();
            model.P_Id = Convert.ToInt32(ddlName.SelectedValue.Trim());
            model.R_Bed =Convert.ToInt32( txtBed.Value.Trim());
            model.R_Enter = Convert.ToDateTime(txtEnter.Value);
            model.R_No=txtNo.Value.Trim();
            model.R_Out = Convert.ToDateTime("1900-01-01");
            model.R_Room = Convert.ToInt32(txtRoom.Value.Trim());
            model.R_State = "入住中";
            model.U_Id = users.U_Id;



            if (RecordBLL.AddRecord(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('RecordManage.aspx');</script>");
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

            Record model = RecordBLL.GetIdByRecord(Convert.ToInt32(Request.QueryString["id"]));
            model.P_Id = Convert.ToInt32(ddlName.SelectedValue.Trim());
            model.R_Bed = Convert.ToInt32(txtBed.Value.Trim());
            model.R_Enter = Convert.ToDateTime(txtEnter.Value);
            model.R_No = txtNo.Value.Trim();
            model.R_Room = Convert.ToInt32(txtRoom.Value.Trim());
            

            if (RecordBLL.UpdateRecord(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('RecordManage.aspx');</script>");
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
