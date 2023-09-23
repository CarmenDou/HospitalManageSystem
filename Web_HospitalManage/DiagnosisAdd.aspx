<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiagnosisAdd.aspx.cs" Inherits="DiagnosisAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

    <script src="js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    <script language="javascript" type="text/javascript">

      
    
    
    
     function check()
    {



        if (document.getElementById("ddlName").value == "0")
       {
         alert("请选择病人！");
         document.getElementById("ddlName").focus();
         return false;
     }


     if (document.getElementById("txtDescribe").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtDescribe").focus();
         return false;
     }
     if (document.getElementById("txtPrescription").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtPrescription").focus();
         return false;
     }
     if (document.getElementById("txtResults").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtResults").focus();
         return false;
     }
     if (document.getElementById("txtTime").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtTime").focus();
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
      诊断编号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtNo" runat="server" type="text"  disabled="disabled" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>病人
      </td>
       <td align="left" class="td_bg" >
    <asp:DropDownList ID="ddlName" runat="server" OnSelectedIndexChanged="ddlName_SelectedIndexChanged">
    </asp:DropDownList>
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>病情描述
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtDescribe" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
      
       <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
 <span style="color:Red;">*</span>现病史
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtPrescription" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
<span style="color:Red;">*</span>诊断结果
      </td>
       <td align="left" class="td_bg" >
           <textarea id="txtResults" runat="server" style="width:300px; height:100px;" cols="20" rows="2"></textarea>
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
<span style="color:Red;">*</span>诊断时间
      </td>
       <td align="left" class="td_bg" >
            <input id="txtTime" runat="server" type="text"  onfocus="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm'})"/>
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
                value="返回" onclick="window.location.replace('DiagnosisManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
