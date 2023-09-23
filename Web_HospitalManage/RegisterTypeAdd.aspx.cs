using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class RegisterTypeAdd : System.Web.UI.Page
{
    public string strNav = "添加挂号类型";
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

            if (Request.QueryString["id"] != null)
            {

                RegisterType model = RegisterTypeBLL.GetIdByRegisterType(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.Rt_Id != 0)
                {
                    txtName.Value = model.Rt_Name.Trim();
                    txtCost.Value=model.Rt_Cost.ToString().Trim();
                }
                strNav = "修改挂号类型";
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

            RegisterType model = new RegisterType();
            model.Rt_Name = txtName.Value.Trim();
            model.Rt_Cost = Convert.ToDecimal(txtCost.Value.Trim());

            if (RegisterTypeBLL.AddRegisterType(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('RegisterTypeManage.aspx');</script>");
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

            RegisterType model = RegisterTypeBLL.GetIdByRegisterType(Convert.ToInt32(Request.QueryString["id"]));
            model.Rt_Name = txtName.Value.Trim();
            model.Rt_Cost = Convert.ToDecimal(txtCost.Value.Trim());

            if (RegisterTypeBLL.UpdateRegisterType(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('RegisterTypeManage.aspx');</script>");
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
