﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class UpdatePwd : System.Web.UI.Page
{
    public string strNav = "修改密码";
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
       
    }






    /// <summary>
    /// 添加，修改
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            Users users = (Users)Session["Users"];
            if (users.U_Pwd != txtOldPwd.Value.Trim())
            {
                txtOldPwd.Focus();
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('旧密码错误！');</script>");
                return;

            }
            else
            {
                users.U_Pwd = txtNewPwd.Value.Trim();
                if (UsersBLL.UpdateUsers(users) > 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码成功！\\n新密码为：" + txtNewPwd.Value.Trim() + "');location=location;</script>");
                    return;
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码失败！');</script>");
                    return;
                }
            }
        }
    }
}
