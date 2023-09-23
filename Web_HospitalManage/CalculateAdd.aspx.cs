using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class CalculateAdd : System.Web.UI.Page
{
    public string strNav = "药品划价";
    public Users users = new Users();
    public List<CalculateDetail> listCD = new List<CalculateDetail>();
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
            txtU_Id.Value = users.U_No + "(" + users.U_Name + ")";
            txtNo.Value = "HJ" + DateTime.Now.ToString("yyMMddHHmmss");
        }
    }


    private void BindsTypes()
    {
        
         
        ddlDt_Id.DataSource = DrugTypeBLL.AllData("");
        ddlDt_Id.DataTextField = "Dt_Name";
        ddlDt_Id.DataValueField = "Dt_Id";
        ddlDt_Id.DataBind();

        ddlD_Id.DataSource = DrugBLL.AllData(" and Dt_Id="+ddlDt_Id.SelectedValue);
        ddlD_Id.DataTextField = "D_Name";
        ddlD_Id.DataValueField = "D_Id";
        ddlD_Id.DataBind();

        txtCd_Price.Value = DrugBLL.GetIdByDrug(Convert.ToInt32(ddlD_Id.SelectedValue)).D_Price.ToString();

        List<Patient> listPat = PatientBLL.AllData("");
        if (listPat.Count > 0)
        {
            for (int i = 0; i < listPat.Count; i++)
            {
                ddlName.Items.Add(new ListItem("(" + listPat[i].P_No + ")" + listPat[i].P_Name, listPat[i].P_Id.ToString()));
            }
            ddlName.Items.Insert(0, new ListItem("--请选择--", "0"));
        }
    
    }






    /// <summary>
    /// 添加，修改
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
     

        for (int i = 0; i < RpView.Items.Count; i++)
        {
            HiddenField hfD_Id = this.RpView.Items[i].FindControl("hfD_Id") as HiddenField;
            HiddenField hfCd_Price = this.RpView.Items[i].FindControl("hfCd_Price") as HiddenField;
            HiddenField hfCd_Count = this.RpView.Items[i].FindControl("hfCd_Count") as HiddenField;
         
            CalculateDetail cd = new CalculateDetail();
            cd.D_Id = Convert.ToInt32(hfD_Id.Value.Trim());
            cd.Cd_Price = Convert.ToDecimal(hfCd_Price.Value.Trim());
            cd.Cd_Count = Convert.ToInt32(hfCd_Count.Value.Trim());
            cd.Cd_Amount =  cd.Cd_Price*cd.Cd_Count ;
            listCD.Add(cd);
        }
        CalculateDetail cld = new CalculateDetail();
        cld.Cd_Count = Convert.ToInt32(txtCd_Count.Value.Trim());
        cld.Cd_Price = Convert.ToDecimal(txtCd_Price.Value.Trim());
        cld.D_Id = Convert.ToInt32(ddlD_Id.SelectedValue);
        cld.Cd_Amount = cld.Cd_Count * cld.Cd_Price;
        listCD.Add(cld);
        RpView.DataSource = listCD;
        RpView.DataBind();

        if (listCD.Count != 0)
        {
            tabHJ.Visible = true;
            RpView.Visible = true;
        }
        else
        {
            tabHJ.Visible = false;
            RpView.Visible = false;
        }

    }
    protected void ddlDt_Id_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlD_Id.DataSource = DrugBLL.AllData(" and Dt_Id=" + ddlDt_Id.SelectedValue);
        ddlD_Id.DataTextField = "D_Name";
        ddlD_Id.DataValueField = "D_Id";
        ddlD_Id.DataBind();

        txtCd_Price.Value = DrugBLL.GetIdByDrug(Convert.ToInt32(ddlD_Id.SelectedValue)).D_Price.ToString();
        txtCd_Count.Value = "";

    }
    protected void ddlD_Id_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCd_Price.Value = DrugBLL.GetIdByDrug(Convert.ToInt32(ddlD_Id.SelectedValue)).D_Price.ToString();
        txtCd_Count.Value = "";
    }



    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbDelImg_Click(object sender, EventArgs e)
    {
        LinkButton lb = (LinkButton)sender;
        string strNo = lb.CommandArgument;

        for (int i = 0; i < RpView.Items.Count; i++)
        {
          
            HiddenField hfNo = this.RpView.Items[i].FindControl("hfNo") as HiddenField;
            if (hfNo.Value != strNo)
            {
                HiddenField hfD_Id = this.RpView.Items[i].FindControl("hfD_Id") as HiddenField;
                HiddenField hfCd_Price = this.RpView.Items[i].FindControl("hfCd_Price") as HiddenField;
                HiddenField hfCd_Count = this.RpView.Items[i].FindControl("hfCd_Count") as HiddenField;

                CalculateDetail cd = new CalculateDetail();
                cd.D_Id = Convert.ToInt32(hfD_Id.Value.Trim());
                cd.Cd_Price = Convert.ToDecimal(hfCd_Price.Value.Trim());
                cd.Cd_Count = Convert.ToInt32(hfCd_Count.Value.Trim());
                cd.Cd_Amount = cd.Cd_Price * cd.Cd_Count;
                listCD.Add(cd);
            }
        }
        RpView.DataSource = listCD;
        RpView.DataBind();
        if (listCD.Count != 0)
        {
            tabHJ.Visible = true;
            RpView.Visible = true;
        }
        else
        {
            tabHJ.Visible = false;
            RpView.Visible = false;
        }
    }
    //划价结算
    protected void btnSettlement_Click(object sender, EventArgs e)
    {
        Calculate model = new Calculate();
        model.C_No = txtNo.Value.Trim();
        model.C_Time = DateTime.Now;
        model.P_Id = Convert.ToInt32(ddlName.SelectedValue.Trim());
        model.U_Id = users.U_Id;
        model.C_Amount = 0;
       int id = CalculateBLL.AddCalculate(model);
        if (id > 0)
        {
            decimal decAmount = 0;
            for (int i = 0; i < RpView.Items.Count; i++)
            {
                HiddenField hfD_Id = this.RpView.Items[i].FindControl("hfD_Id") as HiddenField;
                HiddenField hfCd_Price = this.RpView.Items[i].FindControl("hfCd_Price") as HiddenField;
                HiddenField hfCd_Count = this.RpView.Items[i].FindControl("hfCd_Count") as HiddenField;

                CalculateDetail cd = new CalculateDetail();
                cd.D_Id = Convert.ToInt32(hfD_Id.Value.Trim());
                cd.Cd_Price = Convert.ToDecimal(hfCd_Price.Value.Trim());
                cd.Cd_Count = Convert.ToInt32(hfCd_Count.Value.Trim());
                cd.Cd_Amount = cd.Cd_Price * cd.Cd_Count;
                cd.C_Id = id;
                decAmount += cd.Cd_Amount;
                CalculateDetailBLL.AddCalculateDetail(cd);
            }
            Calculate cal = CalculateBLL.GetIdByCalculate(id);
            cal.C_Amount = decAmount;
            CalculateBLL.UpdateCalculate(cal);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('划价结算成功！');window.location.replace('CalculateManage.aspx');</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('划价结算失败！');</script>");
            return;
        } 
    }
}
