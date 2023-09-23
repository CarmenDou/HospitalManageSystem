<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DrugSearch.aspx.cs" Inherits="DrugSearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
      <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />
   
</head>
<body>
    <form id="form1" runat="server">
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
    <tr>
      <td class="bg_tr" style="height:25px; line-height:25px;"><span style="float:left; padding-left:2px;">药品查询</span><span style="float:right;"></td>   
    </tr>
    <tr>
      <td  align="center"  class="td_bg">
      药品编号：<asp:TextBox ID="txtNo" runat="server" ></asp:TextBox>&nbsp;药品名称：<asp:TextBox ID="txtName" runat="server" ></asp:TextBox>&nbsp;<asp:Button ID="btnSearch"
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
   
       
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">序号</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">药品编号</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">药品名称</td>
        
         <td style="font-weight:bold"  align="center" class="td_bg"  height="23">药品价格</td>
                     <td style="font-weight:bold"  align="center" class="td_bg"  height="23">库存量</td>
          <td style="font-weight:bold"  align="center" class="td_bg"  height="23">计量单位</td>
            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">批准文号</td>
             <td style="font-weight:bold"  align="center" class="td_bg"  height="23">药品分类</td>

           
    </tr>
       </HeaderTemplate>
                <ItemTemplate>
    <tr>
     
      
      
        <td align="center" class="td_bg" height="23"><%#Container.ItemIndex + 1 + (currentPageIndex - 1) * pageSize%></td>
       
        <td align="center" class="td_bg" height="23"><%#Eval("D_No")%></td>
       <td align="center" class="td_bg" height="23"><%#Eval("D_Name")%></td>

       <td align="center" class="td_bg" height="23"><%#Eval("D_Price")%></td>
                <td align="center" class="td_bg" height="23"><%#Eval("D_Num")%></td>
       <td align="center" class="td_bg" height="23"><%#BLL.UnitsBLL.GetIdByUnits(Convert.ToInt32(Eval("U_Id"))).U_Name%></td>
                   <td align="center" class="td_bg" height="23"><%#Eval("D_Approval")%></td>
             <td align="center" class="td_bg" height="23"><%#BLL.DrugTypeBLL.GetIdByDrugType(Convert.ToInt32(Eval("Dt_Id"))).Dt_Name%></td>
      
    </tr>
  </tbody>

</ItemTemplate>
                <FooterTemplate>
                    </table></FooterTemplate>
            </asp:Repeater>
 
    
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
    <tr>
      <td class="bg_tr" style="height:25px; line-height:25px;"><span style="float:left;"></span><span style="float:right;"><a href="<%=strUrlPage%>?currentPageIndex=1">首页</a>&nbsp;&nbsp;<a href="<%=strUrlPage%>?currentPageIndex=<%=currentPageIndex-1%>">上页</a>&nbsp;&nbsp;总共<%=count%>条&nbsp;&nbsp;<%=currentPageIndex%> / <%=ye%>&nbsp;&nbsp;<a href="<%=strUrlPage%>?currentPageIndex=<%=currentPageIndex+1%>">下页</a>&nbsp;&nbsp;<a href="<%=strUrlPage%>?currentPageIndex=<%=ye%>">尾页</a></span></td>   
    </tr>
   
    </table>
    <asp:HiddenField ID="HSelectID" runat="server" />
    
    </form>
</body>
</html>