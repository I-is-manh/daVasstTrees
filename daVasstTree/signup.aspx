<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="daVasstTrees.daVasstTree.signup" %>
<%@ Register Src="~/daVasst_Store/signupControl/signupControl.ascx" TagPrefix="daVasst" TagName="signup" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../daVasst_Store/signupControl/signup.css" rel="stylesheet" />
    <link href="../daVasst_Store/header/header.css" rel="stylesheet" />
</head>
<body class="bodySignUp">
    <daVasst:header runat="server"/>
   <daVasst:signup runat="server"/>
</body>
</html>
