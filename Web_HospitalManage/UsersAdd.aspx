<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersAdd.aspx.cs" Inherits="UsersAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

    <script src="../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
     function check()
    {



        if (document.getElementById("txtU_No").value == "")
       {
         alert("带红色星号不能为空！");
         document.getElementById("txtU_No").focus();
         return false;
     }
     if (document.getElementById("txtU_No").value.length != 5) {
         alert("职工号必须为5位整数！");
         document.getElementById("txtU_No").focus();
         return false;
     }

     if (document.getElementById("txtU_Pwd").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtU_Pwd").focus();
         return false;
     }


     if (document.getElementById("txtU_Name").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtU_Name").focus();
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
所属科室
      </td>
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlD_Id" runat="server">
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>职工号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtU_No" runat="server" type="text" onkeyup="if(this.value.length==1){this.value=this.value.replace(/[^0-9]/g,'')}else{this.value=this.value.replace(/\D/g,'')}"
                    onafterpaste="if(this.value.length==1){this.value=this.value.replace(/[^0-9]/g,'0')}else{this.value=this.value.replace(/\D/g,'')}" /><span style="color:Red;">必须为5位整数</span>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>密码
      </td>
       <td align="left" class="td_bg" >
            <input id="txtU_Pwd" runat="server" type="text"  />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>姓名
      </td>
       <td align="left" class="td_bg" >
            <input id="txtU_Name" runat="server" type="text"  />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      性别
      </td>
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlU_Sex" runat="server">
               <asp:ListItem>男</asp:ListItem>
               <asp:ListItem>女</asp:ListItem>
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
联系手机
      </td>
       <td align="left" class="td_bg" >
            <input id="txtU_Phone" runat="server" type="text"  />
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
     所属角色
      </td>
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlR_Id" runat="server" OnSelectedIndexChanged="ddlR_Id_SelectedIndexChanged">
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      备注
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtU_Note" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="添加" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /> &nbsp;&nbsp;<input  type="button"
                value="返回" onclick="window.location.replace('UsersManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
