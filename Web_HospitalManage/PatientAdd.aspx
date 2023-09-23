<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientAdd.aspx.cs" Inherits="UsersAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

 
    <script language="javascript" type="text/javascript">
     function check()
    {



        if (document.getElementById("txtName").value == "")
       {
         alert("带红色星号不能为空！");
         document.getElementById("txtName").focus();
         return false;
     }


     if (document.getElementById("txtAge").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtAge").focus();
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
      病人编号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtNo" runat="server" type="text"  disabled="disabled" />
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>姓名
      </td>
       <td align="left" class="td_bg" >
            <input id="txtName" runat="server" type="text"  />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      性别
      </td>
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlSex" runat="server">
               <asp:ListItem>男</asp:ListItem>
               <asp:ListItem>女</asp:ListItem>
           </asp:DropDownList>
      </td>
      
      </tr>
       <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
 <span style="color:Red;">*</span>年龄
      </td>
       <td align="left" class="td_bg" >
            <input id="txtAge" runat="server" type="text" onkeyup="if(this.value.length==1){this.value=this.value.replace(/[^1-9]/g,'')}else{this.value=this.value.replace(/\D/g,'')}"
                    onafterpaste="if(this.value.length==1){this.value=this.value.replace(/[^1-9]/g,'0')}else{this.value=this.value.replace(/\D/g,'')}" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
联系手机
      </td>
       <td align="left" class="td_bg" >
            <input id="txtPhone" runat="server" type="text"  />
      </td>
      
      </tr>
      
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="添加" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /> &nbsp;&nbsp;<input  type="button"
                value="返回" onclick="window.location.replace('PatientManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
