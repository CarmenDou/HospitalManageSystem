<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalculateAdd.aspx.cs" Inherits="CalculateAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="Images/css1/css.css" rel="stylesheet" type="text/css" />

    <script src="../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
     function check()
    {



        if (document.getElementById("txtCd_Price").value == "")
       {
         alert("带红色星号不能为空！");
         document.getElementById("txtCd_Price").focus();
         return false;
     }
     if (document.getElementById("txtCd_Count").value == "") {
         alert("带红色星号不能为空！");
         document.getElementById("txtCd_Count").focus();
         return false;
     }

 }


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


 function check2() {



     if (document.getElementById("ddlName").value == "0") {
         alert("请选择病人！");
         document.getElementById("ddlName").focus();
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
      <th class="bg_tr" align="center" colspan="2" height="25">处方</th>
    </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
药品分类
      </td>
      
       <td align="left" class="td_bg" >
           <asp:DropDownList ID="ddlDt_Id" runat="server" AutoPostBack="True" 
               onselectedindexchanged="ddlDt_Id_SelectedIndexChanged">
           </asp:DropDownList>
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>药品名称
      </td>
       <td align="left" class="td_bg" >
<asp:DropDownList ID="ddlD_Id" runat="server" AutoPostBack="True" 
               onselectedindexchanged="ddlD_Id_SelectedIndexChanged">
           </asp:DropDownList>
      </td>
      </tr>
      
      
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>单价
      </td>
       <td align="left" class="td_bg" >
            <input id="txtCd_Price" runat="server" type="text" onkeyup="clearNoNum(this)" />
      </td>
      
      </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
      <span style="color:Red;">*</span>数量
      </td>
       <td align="left" class="td_bg" >
            <input id="txtCd_Count" runat="server" type="text"   onkeyup="if(this.value.length==1){this.value=this.value.replace(/[^1-9]/g,'')}else{this.value=this.value.replace(/\D/g,'')}"
                    onafterpaste="if(this.value.length==1){this.value=this.value.replace(/[^1-9]/g,'0')}else{this.value=this.value.replace(/\D/g,'')}"/>
      </td>
      
      </tr>
     
    <tr>
      <td align="center"  class="td_bg"  colspan="2">
         <asp:Button ID="btnAdd" 
            runat="server" Text="添加" OnClientClick="return check()" 
              onclick="btnAdd_Click"   /><span style="color:Red;">可添加多个</span>
      </td>
    </tr>
    </tbody>
    </table>
    <asp:Repeater ID="RpView" runat="server" Visible="false">
                <HeaderTemplate>
    <table class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
  <tbody>
   
    <tr>
   

        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">序号</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">药品名称</td>
        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">单价</td>
                        <td style="font-weight:bold"  align="center" class="td_bg"  height="23">数量</td>
                <td style="font-weight:bold"  align="center" class="td_bg"  height="23">总额</td>

        
        
            <td style="font-weight:bold"  align="center" class="td_bg"  height="23">操作</td>
    </tr>
       </HeaderTemplate>
                <ItemTemplate>
    <tr>
      <asp:HiddenField ID="hfNo" runat="server" Value='<%#Container.ItemIndex + 1%>' />
        <td align="center" class="td_bg" height="23"><%#Container.ItemIndex + 1%></td>
        <td align="center" class="td_bg" height="23">
            <asp:HiddenField ID="hfD_Id" runat="server" Value='<%#Eval("D_Id")%>' />
            <%#BLL.DrugBLL.GetIdByDrug(Convert.ToInt32(Eval("D_Id"))).D_Name%></td>
                    <asp:HiddenField ID="hfCd_Price" runat="server" Value='<%#Eval("Cd_Price")%>' />
        <td align="center" class="td_bg" height="23"><%#Eval("Cd_Price")%></td>
                    <asp:HiddenField ID="hfCd_Count" runat="server" Value='<%#Eval("Cd_Count")%>' />
        <td align="center" class="td_bg" height="23"><%#Eval("Cd_Count")%></td>
        <td align="center" class="td_bg" height="23"><%#Eval("Cd_Amount")%></td>
        <td align="center" class="td_bg" height="23">
         <asp:LinkButton ID="lbDelImg" CommandArgument='<%#Container.ItemIndex + 1%>' runat="server" onclick="lbDelImg_Click">删除</asp:LinkButton></td>
    </tr>
  </tbody>

</ItemTemplate>
                <FooterTemplate>
                    </table></FooterTemplate>
            </asp:Repeater>
     <table id="tabHJ" visible="false" runat="server" class="table" cellspacing="1" cellpadding="2" width="99%" align="center" 
border="0">
  <tbody>
    <tr>
      <th class="bg_tr" align="center" colspan="2" height="25">划价结算</th>
    </tr>
      <tr>
      <td align="center"  class="td_bg" style="font-weight:bold" >
划价编号
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
<asp:DropDownList ID="ddlName" runat="server" >
           </asp:DropDownList>
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
         <asp:Button ID="btnSettlement" 
            runat="server" Text="划价结算" OnClientClick="return check2()" 
              onclick="btnSettlement_Click" style="height: 26px" 
              />
      </td>
    </tr>
    </tbody>
    </table>
    </form>
</body>
</html>
