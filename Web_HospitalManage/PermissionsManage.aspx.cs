using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class PermissionsManage : System.Web.UI.Page
{
    public string strRoleName = "";
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
            BindType();
        }
    }

    /// <summary>
    /// 自定义方法
    /// </summary>
    private void BindType()
    {
        RpView.DataSource = RolesBLL.AllData("");
        RpView.DataBind();
        if (Request.QueryString["id"] != null)
        {
            strRoleName = RolesBLL.GetIdByRoles(Convert.ToInt32(Request.QueryString["id"])).R_Name;
            btnSave.Enabled = true;
            
        }

        RpGrant.DataSource = ModulesBLL.AllData(" and M_ParentId=0");
        RpGrant.DataBind();

    }

    protected void RpGrant_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            CheckBoxList chklFunctionName = e.Item.FindControl("chklFunctionName") as CheckBoxList;

            Label lblModuleId = e.Item.FindControl("lblModuleId") as Label;
            List<Modules> listMF = ModulesBLL.AllData(" and M_ParentId=" + lblModuleId.Text);
            if (listMF.Count != 0)
            {
                for (int i = 0; i < listMF.Count; i++)
                {
                    chklFunctionName.Items.Add(new ListItem(listMF[i].M_SubName, listMF[i].M_Id.ToString()));
                }
            }

            for (int i = 0; i < ModulesBLL.AllData(" and M_ParentId=" + lblModuleId.Text).Count; i++)
            {

                if (AuthorityBLL.RoleIsExistModuleId(Convert.ToInt32(Request.QueryString["id"]), Convert.ToInt32(chklFunctionName.Items[i].Value)))
                {
                    chklFunctionName.Items[i].Selected = true;
                }
                else
                {
                    chklFunctionName.Items[i].Selected = false;
                }
            }


        }
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            AuthorityBLL.DeleteAuthorityByRoleId(Convert.ToInt32(Request.QueryString["id"]));

            for (int i = 0; i < RpGrant.Items.Count; i++)
            {
                CheckBoxList chklFunctionName = (CheckBoxList)RpGrant.Items[i].FindControl("chklFunctionName");

                Authority rr = new Authority();

                for (int j = 0; j < chklFunctionName.Items.Count; j++)
                {
                    if (chklFunctionName.Items[j].Selected)
                    {
                        rr.R_Id = Convert.ToInt32(Request.QueryString["id"]);
                        rr.M_Id = Convert.ToInt32(chklFunctionName.Items[j].Value);
                        AuthorityBLL.AddAuthority(rr);
                    }
                }

            }
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "failure", "<script>alert('角色权限保存成功！');window.location.replace('PermissionsManage.aspx?id=" + Request.QueryString["id"] + "');</script>");

        }
        catch
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作失败，请与技术员联系！');</script>");
            return;
        }
    }
    protected void RpGrant_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}
