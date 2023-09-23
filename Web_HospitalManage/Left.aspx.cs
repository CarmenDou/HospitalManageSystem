using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class Left : System.Web.UI.Page
{
    public Users users = new Users();
    public List<Modules> listModeuleBig = new List<Modules>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
            listModeuleBig = ModulesBLL.AllData(" and M_Id in ( select M_ParentId From Modules where M_Id in (SELECT M_Id FROM Authority WHERE R_Id=" + users.R_Id + ") group by M_ParentId)");
        }
        else
        {
            users = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }

    }
}
