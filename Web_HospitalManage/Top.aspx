<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Top.aspx.cs" Inherits="Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="images/css1/top_css.css" rel="stylesheet" type="text/css"/>
</head>
<body  bgcolor="#03A8F6">
    <form id="form1" runat="server">
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="194" height="60" align="center" background="Images/top_logo.jpg"></td>
    <td align="center" style="background:url(Images/top_bg.jpg) no-repeat"><table cellspacing="0" cellpadding="0" border="0" width="100%" height="33">
      <tbody>
        <tr>
          <td width="30" align="left"><img onClick="switchBar(this)" height="15" alt="关闭左边管理菜单" src="images/on-of.gif" width="15" border="0" /></td>
          <td width="320" align="left"><span style="color:#ffffff;">职工号：<span style="font-weight:bold;"><%=strUserName%></span> 角色：<span style="font-weight:bold;"><%=strRoleName%></span></span> <a style="color:Red;" class="top_link" 
            href="UpdatePwd.aspx" target="main">修改密码</a><span class="top_link">&nbsp;&nbsp;|&nbsp;&nbsp;</span><asp:LinkButton ID="lnkbOut"
                runat="server" OnClientClick="return confirm('确定要退出后台管理系统吗？')"  ForeColor="Red"
                  onclick="lnkbOut_Click" >退出系统</asp:LinkButton></td>
         
          <td class="topbar"></td>
        </tr>
      </tbody>
    </table>
    </td>
  </tr>
  <tr height="6">
    <td bgcolor="#1F3A65" background="Images/top_bg.jpg"></td>
  </tr>
</table>
<script language="javascript" type="text/javascript">
var displayBar=true;
function switchBar(obj){
	if (displayBar)
	{
		parent.frame.cols="0,*";
		displayBar=false;
		obj.title="打开左边管理菜单";
	}
	else{
		parent.frame.cols="180,*";
		displayBar=true;
		obj.title="关闭左边管理菜单";
	}
}
</script>
    </form>
</body>
</html>
