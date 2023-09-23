<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecordUpdate.aspx.cs" Inherits="RecordUpdate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

    <script src="js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    <script language="javascript" type="text/javascript">

      
    
    
    
     function check()
    {




        if (document.getElementById("txtOut").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtOut").focus();
         return false;
     }

     if (document.getElementById("txtOut").value < document.getElementById("txtEnter").value) {
         alert("出院日期必须大于或等于入院日期！");
         document.getElementById("txtOut").focus();
         return false;
     }
     if (confirm('确认后不可以恢复，确定要确认吗？')) {
         return true;
     }
     else {
         return false;
     }
       
    }
    
   
    
    
    </script>
    <!--清除弹出模拟窗体缓存-->
 <meta http-equiv="Expires" content="0"/> 
<meta http-equiv="Cache-Control" content="no-cache"/>
 <meta http-equiv="Pragma" content="no-cache"/> 
    <!--清除弹出模拟窗体缓存-->

    
   <!--点击不弹出新窗体-->
<base target="_self"/>
<!--点击不弹出新窗体-->
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
      病人
      </td>
       <td align="left" class="td_bg" >
    <asp:DropDownList ID="ddlName" runat="server" Enabled="false">
    </asp:DropDownList>
      </td>
      
      </tr>
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      病房号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtRoom" runat="server" type="text"   disabled="disabled" />
      </td>
      
      </tr>
      
       <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
床位号
      </td>
       <td align="left" class="td_bg" >
            <input id="txtBed" runat="server" type="text"  disabled="disabled"/>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
入院日期
      </td>
       <td align="left" class="td_bg" >
            <input id="txtEnter" runat="server" type="text"  disabled="disabled" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
<span style="color:Red;">*</span>出院日期
      </td>
       <td align="left" class="td_bg" >
            <input id="txtOut" runat="server" type="text"  onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})"/>
      </td>
      
      </tr>
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="确认" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /> &nbsp;&nbsp;<input  type="button" onclick="window.close();"
                value="关闭"/>
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
