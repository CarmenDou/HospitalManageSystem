// JavaScript Document
//获取今天的时间
function GetTheDay()
{
	today=new Date();var day=""
	var date1=""
	if(today.getDay()==0)day="星期日"
	else if(today.getDay()==1)day="星期一"
	else if(today.getDay()==2)day="星期二"
	else if(today.getDay()==3)day="星期三"
	else if(today.getDay()==4)day="星期四"
	else if(today.getDay()==5)day="星期五"
	else if(today.getDay()==6)day="星期六";if(today.getYear()>=2000)
	date1=(today.getYear())+"年"+(today.getMonth()+1)+"月"+today.getDate()+"日 ";else
	date1=(1900+today.getYear())+"年"+(today.getMonth()+1)+"月"+today.getDate()+"日 ";document.writeln(date1+day)
}
	//Download by http://www.codefans.net
//左侧目录点击事件
function ClickLeftFrm(n)
{
	var old_pic_Str=document.getElementById("SavePic").value; 
	var old_List_Str=document.getElementById("SaveList").value;
	
	var now_pic=document.getElementById('picbar'+n); 
	var now_List=document.getElementById('submenu'+n);
	
	if(old_List_Str!="submenu"+n)
	{
		if(old_List_Str!="")
		{
			document.getElementById(old_List_Str).style.display="none";
			document.getElementById(old_pic_Str).src="../images/left.gif";
		}
		now_List.style.display="block";
		now_pic.src="../images/left1.gif";
		document.getElementById("SavePic").value="picbar"+n;
		document.getElementById("SaveList").value="submenu"+n;
	}
	else
	{
		now_List.style.display="none";
		now_pic.src="../images/left.gif";
		document.getElementById("SavePic").value="";
		document.getElementById("SaveList").value="";
	}
	
}
//翻页的跳转
function GoToTheUrl(TheSelect)
{
	window.open(TheSelect.value,"_self");
}

//全选
function SelectAll(name)
{
	var n;
	n=document.getElementsByName(name).length;
	for (var i = 0; i < n; i++)
	{
	document.getElementsByName(name)[i].checked = true;
	}
}
//全不选
function UnSelectAll(name)
{
	var n;
	n=document.getElementsByName(name).length;
	for (var i = 0; i < n; i++)
	{
		document.getElementsByName(name)[i].checked = false;
	}
}
//反选
function AntiSelectAll(name)
{
	var n;
	n=document.getElementsByName(name).length;
	for (var i = 0; i < n; i++) {
        var e = document.getElementsByName(name)[i];
        if (e.checked) {
            e.checked = false;
        }
        else {
            e.checked = true;
        }
    }
}
//处理选中的项
function HandleSelect(name,TheUrl,Target)
{
	var TheList=ifChecked(name);
	if(TheList!=false)
	{
		if(TheUrl.indexOf("?")!=-1)
		{TheUrl=TheUrl+"&TheList="+TheList}
		else
		{TheUrl=TheUrl+"?TheList="+TheList}
		window.open(TheUrl,Target);
	}
}
//设置复选框
function SetZhiFxk(name,ValueStr)
{
	var n;
	n=document.getElementsByName(name).length;
	for (var i = 0; i < n; i++) {
        var e = document.getElementsByName(name)[i];
		
        if(ValueStr.indexOf(","+e.value+",")!=-1)
		{
			 e.checked = true;
		}
		else
		{
			e.checked = false;
		}
    }
}
//设置单选框
function SetZhiDxk(name,ValueStr)
{
	var n;
	n=document.getElementsByName(name).length;
	for (var i = 0; i < n; i++) {
        var e = document.getElementsByName(name)[i];
		
        if(ValueStr.indexOf(","+e.value+",")!=-1)
		{
			 e.checked = true;
		}
		else
		{
			e.checked = false;
		}
    }
}
//判读是否有选中的复选框（一个都没有选中返回False,有则返回用"-"分割的值的字符串）
function ifChecked(chkboxname)
{
    var AC = false;
    var myValue = "";
    var myCount = 0;
    for (var i = 0; i < document.getElementsByName(chkboxname).length; i++)
	{
        var e = document.getElementsByName(chkboxname)[i];
        if (e.checked) 
		{
			if (myValue=="")
			{myValue = e.value;}
			else
			{myValue = myValue + "-" + e.value;}
            myCount = myCount + 1;
        }
    }
    if (myCount != 0)
	{
        AC = true;
    }
    else 
	{
        AC = false;
    }
    if (!AC) 
	{
        alert("请先选定后再操作！");
        return false;
    }
    else
	{
        return myValue;
    } 
}
//验证字符串是否只含数字，字母和下划线 是则返回True 否则返回False
function IsHf(str)
{ 
	var reg=/[^A-Za-z0-9_]/g 
    if (reg.test(str))
	{return (false);}
	else
	{return(true);} 
}

//管理员登录验证
function CkLogin(TheForm)
{
	if(TheForm.User.value.length<4 || TheForm.User.value.length>20)
	{
		alert("用户名长度在4位-20位之间");
		TheForm.User.focus();
		return false;
	}
	if(!IsHf(TheForm.User.value))
	{
		alert("用户名只能为数字，字母或下划线");
		TheForm.User.focus();
		return false;
	}
	if(TheForm.Pass.value.length<4 || TheForm.Pass.value.length>20)
	{
		alert("密码长度在4位-20位0之间");
		TheForm.Pass.focus();
		return false;
	}
	if(!IsHf(TheForm.Pass.value))
	{
		alert("密码只能为数字，字母或下划线");
		TheForm.Pass.focus();
		return false;
	}
	if(TheForm.Checked.value.length!=4)
	{
		alert("验证码由四位组成");
		TheForm.Checked.focus();
		return false;
	}
}

//管理员添加与修改的验证
function CkAdmin_Handle(TheForm,Type)
{
	if(TheForm.User.value.length<4 || TheForm.User.value.length>20)
	{
		alert("用户名长度在4位-20位之间");
		TheForm.User.focus();
		return false;
	}
	if(!IsHf(TheForm.User.value))
	{
		alert("用户名只能为数字，字母或下划线");
		TheForm.User.focus();
		return false;
	}
	if (Type=="Add")
	{
		if(TheForm.Pass1.value.length<4 || TheForm.Pass1.value.length>20)
		{
			alert("密码长度在4位-20位之间");
			TheForm.Pass1.focus();
			return false;
		}
		if(TheForm.Pass1.value!=TheForm.Pass2.value)
		{
			alert("两次输入密码不一致");
			TheForm.Pass1.focus();
			return false;
		}
		if(!IsHf(TheForm.Pass1.value))
		{
			alert("密码只能为数字，字母或下划线");
			TheForm.Pass1.focus();
			return false;
		}
	}
	if (Type=="Edit")
	{
		if (TheForm.Pass1.value.length!=0 || TheForm.Pass2.value.length!=0)
		{
			if(TheForm.Pass1.value.length==0 || TheForm.Pass2.value.length==0)
			{
				alert("两次输入新密码不一致");
				TheForm.Pass1.focus();
				return false;
			}
			if(TheForm.Pass1.value.length<4 || TheForm.Pass1.value.length>20)
			{
				alert("密码长度在4位-20位之间");
				TheForm.Pass1.focus();
				return false;
			}
			if(TheForm.Pass1.value!=TheForm.Pass2.value)
			{
				alert("两次输入密码不一致");
				TheForm.Pass1.focus();
				return false;
			}
			if(!IsHf(TheForm.Pass1.value))
			{
				alert("密码只能为数字，字母或下划线");
				TheForm.Pass1.focus();
				return false;
			}
		}
	}
	if(TheForm.WebName.value=="")
	{
		alert("请输入前台名称");
		TheForm.WebName.focus();
		return false;
	}
}
//单页的添加与修改
function CkOnePage_Handle(TheForm,Type)
{
	if(TheForm.Title.value=="")
	{
		alert("请输入标题");
		TheForm.Title.focus();
		return false;
	}
}

//文件名,取得文件的扩展名
function getFileExp(str)
{
	var reg=/([^.]+)$/.exec(str);
	return RegExp.$1;
}

//图片扩展名
function doChange(objText, objUrl, objDrop){
 	if (!objDrop){return;}
 	var aExt = "gif|jpg|jpeg|bmp|png";
 	var arr = objText.value.split("|");
 	var vrr = objUrl.value.split("|");
 	var nIndex = objDrop.selectedIndex;

 	aExt=aExt.split("|");
 	objDrop.length=1;
 	for (var i=0; i<arr.length; i++){
 		checbool=false;
 		for(var j=0; j<aExt.length; j++){
			if (getFileExp(vrr[i])==aExt[j]) checbool=true;
		}
 		if (checbool) objDrop.options[objDrop.length] = new Option(arr[i], vrr[i]);
 	}
 	objDrop.selectedIndex = nIndex;
}
//设置封面图
function SetFmt(UrlStr, objDropStr)
{
 	var objDrop=document.getElementById(objDropStr);
	if(UrlStr=="" || UrlStr==null)
	{
		objDrop.src="../images/nopic.gif";
	}
 	else
	{
		objDrop.src="../../"+UrlStr;
	}
}
//附件扩展名
function doChange2(objText, objUrl, objDrop){
 	if (!objDrop){return;}
 	var aExt = "rar|zip|pdf|doc|docx|swf|mid|mp3|mpg|avi|wmv";
 	var arr = objText.value.split("|");
 	var vrr = objUrl.value.split("|");
 	var nIndex = objDrop.selectedIndex;

 	aExt=aExt.split("|");
 	objDrop.length=1;
 	for (var i=0; i<arr.length; i++){
 		checbool=false;
 		for(var j=0; j<aExt.length; j++){
			if (getFileExp(vrr[i])==aExt[j]) checbool=true;
		}
 		if (checbool) objDrop.options[objDrop.length] = new Option(arr[i], vrr[i]);
 	}
 	objDrop.selectedIndex = nIndex;
}
//设置文件
function SetFmt2(UrlStr, objDropStr)
{
 	var objDrop=document.getElementById(objDropStr);
	if(UrlStr=="" || UrlStr==null)
	{
		objDrop.style.display='';
		objDrop.src="../images/nopic.gif";
	}
 	else
	{
		objDrop.style.display='none';
	}
}

// 参数说明
// s_Type : 文件类型，可用值为"image","flash","media","file"
// s_Link : 文件上传后，用于接收上传文件路径文件名的表单名
// s_Thumbnail : 文件上传后，用于接收上传图片时所产生的缩略图文件的路径文件名的表单名，当未生成缩略图时，返回空值，原图用s_Link参数接收，此参数专用于缩略图
function showUploadDialog(s_Type, s_Link, s_Thumbnail)
{
	//以下style=standard650,值可以依据实际需要修改为您的样式名,通过此样式的后台设置来达到控制允许上传文件类型及文件大小
	var DiZhi="../../BianJi/dialog/i_upload.htm?style=standard650&type="+s_Type+"&link="+s_Link+"&thumbnail="+s_Thumbnail+"&rnd="+Math.random()
	var arr = showModalDialog(DiZhi, window, "dialogWidth:0px;dialogHeight:0px;help:no;scroll:no;status:no");
}
//新闻类别添加与修改验证
function CkNewsSort_Handle(TheForm)
{
	if(TheForm.SortName.value=="")
	{
		alert("请输入类别名称");
		TheForm.SortName.focus();
		return false;
	}
}
//新闻的添加与修改
function CkNews_Handle(TheForm)
{
	if(TheForm.Title.value=="")
	{
		alert("请输入标题");
		TheForm.Title.focus();
		return false;
	}
}
//链接类别添加与修改验证
function CkLinkSort_Handle(TheForm)
{
	if(TheForm.SortName.value=="")
	{
		alert("请输入类别名称");
		TheForm.SortName.focus();
		return false;
	}
}

//会员添加与修改验证
function CkMember_Handle(TheForm,Type)
{
	if(TheForm.User.value.length<4 || TheForm.User.value.length>20)
	{
		alert("用户名长度在4位-20位之间");
		TheForm.User.focus();
		return false;
	}
	if(!IsHf(TheForm.User.value))
	{
		alert("用户名只能为数字，字母或下划线");
		TheForm.User.focus();
		return false;
	}
	if (Type=="Add")
	{
		if(TheForm.Pass1.value.length<4 || TheForm.Pass1.value.length>20)
		{
			alert("密码长度在4位-20位之间");
			TheForm.Pass1.focus();
			return false;
		}
		if(TheForm.Pass1.value!=TheForm.Pass2.value)
		{
			alert("两次输入密码不一致");
			TheForm.Pass1.focus();
			return false;
		}
		if(!IsHf(TheForm.Pass1.value))
		{
			alert("密码只能为数字，字母或下划线");
			TheForm.Pass1.focus();
			return false;
		}
	}
	if (Type=="Edit")
	{
		if (TheForm.Pass1.value.length!=0 || TheForm.Pass2.value.length!=0)
		{
			if(TheForm.Pass1.value.length==0 || TheForm.Pass2.value.length==0)
			{
				alert("两次输入新密码不一致");
				TheForm.Pass1.focus();
				return false;
			}
			if(TheForm.Pass1.value.length<4 || TheForm.Pass1.value.length>20)
			{
				alert("密码长度在4位-20位之间");
				TheForm.Pass1.focus();
				return false;
			}
			if(TheForm.Pass1.value!=TheForm.Pass2.value)
			{
				alert("两次输入密码不一致");
				TheForm.Pass1.focus();
				return false;
			}
			if(!IsHf(TheForm.Pass1.value))
			{
				alert("密码只能为数字，字母或下划线");
				TheForm.Pass1.focus();
				return false;
			}
		}
	}
}
//
function UpdateTime()
{	
	if (window.XMLHttpRequest) { // Mozilla, Safari, ...
		http_request = new XMLHttpRequest();
	} else if (window.ActiveXObject) { // IE
		http_request = new ActiveXObject("Microsoft.XMLHTTP");
	}	
	var linkurl="Module_Action.asp?Action=UpdateTime&rnd="+Math.random();
	http_request.open("GET",linkurl,false);
	http_request.send(null);
}

