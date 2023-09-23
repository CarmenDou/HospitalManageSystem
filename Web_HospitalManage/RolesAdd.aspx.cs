﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class RolesAdd : System.Web.UI.Page
{
    public string strNav = "添加角色";
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

                Roles model = RolesBLL.GetIdByRoles(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.R_Id != 0)
                {
                    txtName.Value = model.R_Name.Trim();
                }
                strNav = "修改角色";
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

            Roles model = new Roles();
            model.R_Name = txtName.Value.Trim();

            if (RolesBLL.AddRoles(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('RolesManage.aspx');</script>");
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

            Roles model = RolesBLL.GetIdByRoles(Convert.ToInt32(Request.QueryString["id"]));
            model.R_Name = txtName.Value.Trim();


            if (RolesBLL.UpdateRoles(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('RolesManage.aspx');</script>");
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
