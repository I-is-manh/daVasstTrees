<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="daVasstTrees.daVasst.login" %>
<%@ Register Src="~/daVasst_Store/login/loginControl.ascx"  TagPrefix="daVasst" TagName="login"%>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link href="../daVasst_Store/login/login.css" rel="stylesheet" />
    <link href="../daVasst_Store/header/header.css" rel="stylesheet" />
</head>
<body class="bodySignIn">
    <daVasst:header runat="server"/>
    <daVasst:login  runat="server" />
</body>
</html>
