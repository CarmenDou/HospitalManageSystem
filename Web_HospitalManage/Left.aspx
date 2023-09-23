<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Left" %>
<%@ Import Namespace="Model"%>
<%@ Import Namespace="BLL"%>
<%@ Import Namespace="System.Collections.Generic"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="images/css1/left_css.css" rel="stylesheet" type="text/css" />

    <script language="javascript">
        function showsubmenu(sid) {
            whichEl = eval("submenu" + sid);
            if (whichEl.style.display == "none") {
                eval("submenu" + sid + ".style.display=\"\";");
            }
            else {
                eval("submenu" + sid + ".style.display=\"none\";");
            }
        }





    </script>

</head>
<body bgcolor="16ACFF">
    <form id="form1" runat="server">
    <table width="98%" border="0" cellpadding="0" cellspacing="0" background="Images/tablemde.jpg">
        <tr>
            <td height="5" background="Images/tableline_top.jpg" bgcolor="#9BC2ED">
            </td>
        </tr>
        <%if(listModeuleBig.Count>0)
              for (int i = 0; i < listModeuleBig.Count; i++)
              { 
              %>
               <tr>
            <td>
                <table class="leftframetable" cellspacing="0" cellpadding="0" width="97%" align="right"
                    border="0">
                    <tbody>
                        <tr>
                            <td height="25" style="background: url(Images/left_tt.gif) no-repeat">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td width="20">
                                        </td>
                                        <td height="25" class="titledaohang" style="cursor: hand" onclick="showsubmenu(<%=i+1%>);">
                                            <span class="STYLE1"><%=listModeuleBig[i].M_SubName%></span>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table id="submenu<%=i+1%>" cellspacing="0" cellpadding="0" width="100%" border="0">
                                    <tbody>
                                     <%
                                         List<Modules> listModeuleSmall = ModulesBLL.AllData(" and M_Id in (SELECT M_Id FROM Authority WHERE R_Id=" + users.R_Id + ") and M_ParentId=" + listModeuleBig[i].M_Id);
                                if (listModeuleSmall.Count > 0)
                                {
                                    for (int j = 0; j < listModeuleSmall.Count; j++)
                                    { 
                                    %>
                                    <tr>
                                            <td width="2%">
                                            </td>
                                            <td height="23">
                                                <a href="<%=listModeuleSmall[j].M_Url%>" target="main"><%=listModeuleSmall[j].M_SubName%></a>
                                            </td>
                                        </tr>
                                    <%
                                         }
                                } %>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
        <tr>
            <td height="5" background="Images/tableline_top.jpg" bgcolor="#9BC2ED">
            </td>
        </tr>
              <%
              }
               %>
    </table>
    </form>
</body>
</html>
