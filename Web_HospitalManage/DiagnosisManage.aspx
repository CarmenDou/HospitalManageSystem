<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiagnosisManage.aspx.cs" Inherits="RecordManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
      <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery.js" type="text/javascript"></script>
   
    <script language="javascript" type="text/javascript">
    
      $(function() {
    $("#BtnAllSelect").click(function() {
        if ($("#BtnAllSelect").val() == "全选") {
            $("#BtnAllSelect").val("反选");
            $("[name=CheckMes]:checkbox").attr("checked", true);
        }
        else {
            $("#BtnAllSelect").val("全选");
            $("[name=CheckMes]:checkbox").each(function() {
                //$(this).attr("checked", !$(this).attr("checked"));
                this.checked = !this.checked;
            })
        }
    })
    $("#BtnAllDel").click(function() {
        if (confirm("确认要删除选中的信息？")) {
            var checkValue = "";
            $("[name=CheckMes]:checkbox:checked").each(function() {
                if ($.trim($(this).val()).length > 0) {
                    checkValue += "," + $.trim($(this).val());
                }
            })
            if (checkValue.length == 0) {
                alert("你没有选择任何信息，请先选中要删除的信息！");
                return false;
            }
            else {
                $("#HSelectID").val(checkValue.substr(1));
            }
            return true;
        }
        else {
            return false;
        }
    })
    });
    
   
    
    
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
    <tr>
      <td class="bg_tr" style="height:25px; line-height:25px;"><span style="float:left; padding-left:2px;">诊断查询</span><span style="float:right;"></span></td>   
    </tr>
    <tr>
      <td  align="center"  class="td_bg">
      病人编号：<asp:TextBox ID="txtNo" runat="server" ></asp:TextBox>&nbsp;姓名：<asp:TextBox ID="txtName" runat="server" ></asp:TextBox>&nbsp;<asp:Button ID="btnSearch"
        runat="server" Text=" 查询 " onclick="btnSearch_Click" />
      </td>
    </tr>
    </table>
     <asp:Repeater ID="RpView" runat="server">
                <HeaderTemplate>
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
  <tbody>
   
    <tr>
   
       <td style="font-weight:bold" align="center" class="td_bg"  height="23">选择</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">序号</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">诊断编号</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">病人编号</td>
                        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">姓名</td>
                <td style="font-weight:bold"  align="center" class="td_bg"  height="23">病情描述</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">处方</td>
        
         <td style="font-weight:bold"  align="center" class="td_bg"  height="23">诊断结果</td>
          <td style="font-weight:bold"  align="center" class="td_bg"  height="23">诊断时间</td>
                        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">操作人</td>
            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">操作</td>
    </tr>
       </HeaderTemplate>
                <ItemTemplate>
    <tr>
     
      
       <td align="center" class="td_bg" height="23"><input type="checkbox" value='<%#Eval("D_Id") %>' name="CheckMes" /></td>
        <td align="center" class="td_bg" height="23"><%#Container.ItemIndex + 1 + (currentPageIndex - 1) * pageSize%></td>
               <td align="center" class="td_bg" height="23"><%#Eval("D_No")%></td>
    <td align="center" class="td_bg" height="23"><%#Eval("P_No")%></td>
        <td align="center" class="td_bg" height="23"><%#Eval("P_Name")%></td>

            <td align="center" class="td_bg" height="23"><%#Eval("D_Describe")%></td>
            <td align="center" class="td_bg" height="23"><%#Eval("D_Prescription")%></td>
              <td align="center" class="td_bg" height="23"><%#Eval("D_Results")%></td>
       <td align="center" class="td_bg" height="23"><%#Convert.ToDateTime(Eval("D_Time")).ToString("yyyy-MM-dd HH:mm")%></td>
                    <td align="center" class="td_bg" height="23"><%#BLL.UsersBLL.GetIdByUsers(Convert.ToInt32( Eval("U_Id"))).U_No%>(<%#BLL.UsersBLL.GetIdByUsers(Convert.ToInt32( Eval("U_Id"))).U_Name%>)</td>
       <td align="center" class="td_bg" height="23"><a href='DiagnosisAdd.aspx?id=<%#Eval("D_Id")%>'>修改</a></td>
    </tr>
  </tbody>

</ItemTemplate>
                <FooterTemplate>
                    </table></FooterTemplate>
            </asp:Repeater>
 
    
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
    <tr>
      <td class="bg_tr" style="height:25px; line-height:25px;"><span style="float:left;"><input id="BtnAllSelect" type="button" value="全选" />&nbsp;
            <asp:Button ID="BtnAllDel" runat="server" Text="删除选中" 
                onclick="BtnAllDel_Click" /></span><span style="float:right;"><a href="<%=strUrlPage%>?currentPageIndex=1">首页</a>&nbsp;&nbsp;<a href="<%=strUrlPage%>?currentPageIndex=<%=currentPageIndex-1%>">上页</a>&nbsp;&nbsp;总共<%=count%>条&nbsp;&nbsp;<%=currentPageIndex%> / <%=ye%>&nbsp;&nbsp;<a href="<%=strUrlPage%>?currentPageIndex=<%=currentPageIndex+1%>">下页</a>&nbsp;&nbsp;<a href="<%=strUrlPage%>?currentPageIndex=<%=ye%>">尾页</a></span></td>   
    </tr>
   
    </table>
    <asp:HiddenField ID="HSelectID" runat="server" />
    
    </form>
</body>
</html>