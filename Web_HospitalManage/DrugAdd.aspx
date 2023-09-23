<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DrugAdd.aspx.cs" Inherits="DrugAdd" %>

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
        //只能输入大于等于0的整数类型
        function clearNoNum1(obj) {
            //先把非数字的都替换掉，除了数字和.
            obj.value = obj.value.replace(/[^\d]/g, "");

        }
     
     function check()
    {



        if (document.getElementById("txtD_Name").value == "")
       {
         alert("带红色星号不能为空！");
         document.getElementById("txtD_Name").focus();
         return false;
     }
     if (document.getElementById("txtD_Price").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtD_Price").focus();
         return false;
     }
     if (document.getElementById("txtD_Num").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtD_Num").focus();
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
      药品编号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtD_No" runat="server" type="text"  disabled="disabled" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
药品分类
      </td>
      
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlDt_Id" runat="server">
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>药品名称
      </td>
       <td align="left" class="td_bg" >
            <input id="txtD_Name" runat="server" type="text"  />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>药品价格
      </td>
       <td align="left" class="td_bg" >
            <input id="txtD_Price" runat="server" type="text" onkeyup="clearNoNum(this)" />
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      计量单位
      </td>
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlU_Id" runat="server">
             
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
批准文号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtD_Approval" runat="server" type="text"  />
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>库存量(>=0)
      </td>
       <td align="left" class="td_bg" >
            <input id="txtD_Num" runat="server" type="text" onkeyup="clearNoNum1(this)" />
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      药物成分
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtD_Composition" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      药品功效
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtD_Efficacy" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      使用方法
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtD_Methods" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="添加" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /> &nbsp;&nbsp;<input  type="button"
                value="返回" onclick="window.location.replace('DrugManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
