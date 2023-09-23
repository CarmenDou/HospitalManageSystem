<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PermissionsManage.aspx.cs" Inherits="PermissionsManage" %>

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
      <td class="bg_tr" style="height:25px; line-height:25px;"><span style="float:left; padding-left:2px;">权限管理</span><span style="float:right;"></span></td>   
    </tr>
    <tr>
      <td  align="center"  class="td_bg">
角色名称：<span style=" color:Red; font-weight:bold;"><%=strRoleName%></span>
          <asp:Button ID="btnSave" runat="server" Enabled="false" Text=" 保存 " onclick="btnSave_Click" />
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

            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">角色名称</td>
          
            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">操作</td>
    </tr>
       </HeaderTemplate>
                <ItemTemplate>
    <tr>
     

        <td align="center" class="td_bg" height="23"><%#Container.ItemIndex + 1 %></td>
       
        
       <td align="center" class="td_bg" height="23"><%#Eval("R_Name")%></td>

       <td align="center" class="td_bg" height="23"><a href='PermissionsManage.aspx?id=<%#Eval("R_Id")%>'>角色授权</a></td>
    </tr>
  </tbody>

</ItemTemplate>
                <FooterTemplate>
                    </table></FooterTemplate>
            </asp:Repeater>
      <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
    <tr>
      <td class="bg_tr" style="height:25px; line-height:25px;"><span style="float:left;">模块功能</span><span style="float:right;"></span></td>   
    </tr>
    </table>
      <asp:Repeater ID="RpGrant" runat="server" OnItemDataBound="RpGrant_ItemDataBound" OnItemCommand="RpGrant_ItemCommand">
                <HeaderTemplate>
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
  <tbody>
   
    <tr>

            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">权限模块</td>
          
            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">功能操作</td>
    </tr>
       </HeaderTemplate>
                <ItemTemplate>
    <tr>
     
       <td align="center" class="td_bg" style="width:40%;" height="23"><%#Eval("M_SubName")%></td>
       <td align="left" class="td_bg" style="width:60%;" height="23">
       <asp:Label ID="lblModuleId" Visible="false" runat="server" Text='<%# Eval("M_Id").ToString()%>' />
       <asp:CheckBoxList ID="chklFunctionName" runat="server" RepeatDirection="Horizontal"></asp:CheckBoxList>
       </td>
    </tr>
  </tbody>

</ItemTemplate>
                <FooterTemplate>
                    </table></FooterTemplate>
            </asp:Repeater>
    </form>
</body>
</html>
