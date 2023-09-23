<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecordAdd.aspx.cs" Inherits="RecordAdd" %>

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


     if (document.getElementById("txtRoom").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtRoom").focus();
         return false;
     }
     if (document.getElementById("txtBed").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtBed").focus();
         return false;
     }
     if (document.getElementById("txtEnter").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtEnter").focus();
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
      住院编号
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
    <asp:DropDownList ID="ddlName" runat="server">
    </asp:DropDownList>
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>病房号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtRoom" runat="server" type="text"  onkeyup="if(this.value.length==1){this.value=this.value.replace(/[^0-9]/g,'')}else{this.value=this.value.replace(/\D/g,'')}"
                    onafterpaste="if(this.value.length==1){this.value=this.value.replace(/[^0-9]/g,'0')}else{this.value=this.value.replace(/\D/g,'')}" />
      </td>
      
      </tr>
      
       <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
 <span style="color:Red;">*</span>床位号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtBed" runat="server" type="text" onkeyup="if(this.value.length==1){this.value=this.value.replace(/[^0-9]/g,'')}else{this.value=this.value.replace(/\D/g,'')}"
                    onafterpaste="if(this.value.length==1){this.value=this.value.replace(/[^0-9]/g,'0')}else{this.value=this.value.replace(/\D/g,'')}" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
<span style="color:Red;">*</span>入院日期
      </td>
       <td align="left" class="td_bg" >
            <input id="txtEnter" runat="server" type="text"  onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})"/>
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
                value="返回" onclick="window.location.replace('RecordManage.aspx');" />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
