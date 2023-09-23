<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterAdd.aspx.cs" Inherits="RegisterAdd" %>

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



        if (document.getElementById("txtR_Name").value == "")
       {
         alert("带红色星号不能为空！");
         document.getElementById("txtR_Name").focus();
         return false;
     }
     if (document.getElementById("ddlD_Id").value == "0") {
         alert("请选择所挂科室！");
         document.getElementById("ddlD_Id").focus();
         return false;
     }
     if (document.getElementById("txtR_Cost").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtR_Cost").focus();
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
     挂号编号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtR_No" runat="server" type="text"  disabled="disabled" />
      </td>
      
      </tr>
       <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
           <span style="color:Red;">*</span>姓名
      </td>
       <td align="left" class="td_bg" >
            <input id="txtR_Name" runat="server" type="text" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      挂号类型
      </td>
       <td align="left" class="td_bg" >
<asp:DropDownList ID="ddlRt_Id" runat="server" AutoPostBack="True" 
               onselectedindexchanged="ddlRt_Id_SelectedIndexChanged">
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>所挂科室
      </td>
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlD_Id" runat="server">
           </asp:DropDownList>
      </td>
      
      </tr>
     <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>挂号费用
      </td>
       <td align="left" class="td_bg" >
            <input id="txtR_Cost" runat="server" type="text"  onkeyup="clearNoNum(this)" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
     操作人
      </td>
       <td align="left" class="td_bg" >
            <input id="txtU_Id" runat="server" type="text"  disabled="disabled"  />
      </td>
      
      </tr>
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="登记" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /> &nbsp;&nbsp;<input  type="button"
                value="返回" onclick="window.location.replace('RegisterManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
