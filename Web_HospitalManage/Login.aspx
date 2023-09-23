<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>医院管理系统</title>
    <link href="css/Login.css" rel="stylesheet" type="text/css" />
    <script>
        function check() {



            if (document.getElementById("txtUserName").value == "") {
                alert("职工号不能为空！");
                document.getElementById("txtUserName").focus();
                return false;
            }
            if (document.getElementById("txtPwd").value == "") {
                alert("密码不能为空！");
                document.getElementById("txtPwd").focus();
                return false;
            }

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">

<DIV class="Sizer">
<TABLE border=0 cellSpacing=0 cellPadding=0>
  <THEAD>
  <TR style=" height:60px;font-size:30px; line-height:30px; color:#0099FF;">
    <TD colspan=2>医院管理系统</TD></TR></THEAD>
  <TBODY>
  <TR>
    <TH>职工号：</TH>
    <TD><input id="txtUserName" type="text" runat="server" style="width:150px;" /></TD></TR>
  <TR>
    <TH>密码：</TH>
    <TD><input id="txtPwd" type="password" runat="server" style="width:150px;"/></TD></TR>
 
  <TR>
    <TH></TH>
    <TD><asp:Button ID="btnLogin" runat="server" Text="登录" OnClientClick="return check()" onclick="btnLogin_Click" /> 
        <input id="Reset1" type="reset" value="重置" /> 
</TD></TR></TBODY></TABLE></DIV>
    </form>
</body>
</html>
