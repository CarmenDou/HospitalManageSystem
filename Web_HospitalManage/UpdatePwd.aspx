<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePwd.aspx.cs" Inherits="UpdatePwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

   
      <script language="javascript" type="text/javascript">

          function check() {
              var txtOldPwd = document.getElementById("txtOldPwd");
              var txtNewPwd = document.getElementById("txtNewPwd");
              var txtSureNewPwd = document.getElementById("txtSureNewPwd");
              if (txtOldPwd.value == "") {

                  alert("带红色星项不能空！");
                  txtOldPwd.focus();
                  return false;
              }
              if (txtNewPwd.value == "") {

                  alert("带红色星项不能空！");
                  txtNewPwd.focus();
                  return false;
              }

              if (txtSureNewPwd.value == "") {

                  alert("带红色星项不能空！");
                  txtSureNewPwd.focus();
                  return false;
              }
              if (txtNewPwd.value != txtSureNewPwd.value) {

                  alert("两次密码不一致！");
                  txtSureNewPwd.focus();
                  return false;
              }
          }
    </script>
</head>
<body>
    <form id="form1" runat="server">
  <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
  <tbody>
    <tr>
      <th class="bg_tr" align="center" colspan="2" height="25"><%=strNav%></th>
    </tr>
     
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>旧密码
      </td>
       <td align="left" class="td_bg" >
            <input id="txtOldPwd" runat="server" type="password"  />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>新密码
      </td>
       <td align="left" class="td_bg" >
            <input id="txtNewPwd" runat="server" type="password"  />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>确认新密码
      </td>
       <td align="left" class="td_bg" >
            <input id="txtSureNewPwd" runat="server" type="password"  />
      </td>
      
      </tr>
     
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="修改" OnClientClick="return check()" 
              onclick="btnAdd_Click"   />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
