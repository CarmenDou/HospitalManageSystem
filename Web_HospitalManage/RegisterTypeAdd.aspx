<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterTypeAdd.aspx.cs" Inherits="RegisterTypeAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

  
    <script language="javascript" type="text/javascript">

        //只能输入浮点类型
        function clearNoNum(obj) {
            //先把非数字的都替换掉，除了数字和.
            obj.value = obj.value.replace(/[^\d.]/g, "");
            //必须保证第一个为数字而不是.
            obj.value = obj.value.replace(/^\./g, "");
            //保证只有出现一个.而没有多个.
            obj.value = obj.value.replace(/\.{2,}/g, ".");
            //保证.只出现一次，而不能出现两次以上
            obj.value = obj.value.replace(".", "$#$").replace(/\./g, "").replace("$#$", ".");
        }
     
     
     function check()
    {



        if (document.getElementById("txtName").value == "")
       {
         alert("带红色星号不能为空！");
         document.getElementById("txtName").focus();
         return false;
     }
     if (document.getElementById("txtCost").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtCost").focus();
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
      <span style="color:Red;">*</span>号位名称
      </td>
       <td align="left" class="td_bg" >
            <input id="txtName" runat="server" type="text"  />
      </td>
      
      </tr>
     <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>号位费用
      </td>
       <td align="left" class="td_bg" >
            <input id="txtCost" runat="server" type="text"  onkeyup="clearNoNum(this)" />
      </td>
      
      </tr>
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="添加" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /> &nbsp;&nbsp;<input  type="button"
                value="返回" onclick="window.location.replace('RegisterTypeManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
