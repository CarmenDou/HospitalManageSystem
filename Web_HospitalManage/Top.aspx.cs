using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class Top : System.Web.UI.Page
{
    public Users users = new Users();
    public string strUserName = "";
    public string strRoleName = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
            strUserName = users.U_No;
            strRoleName = RolesBLL.GetIdByRoles(users.R_Id).R_Name;
        }
        else
        {
            users = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }

    }


    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        Session["Users"] = null;
        Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
    }
}
