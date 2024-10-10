<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="daVasstTrees.daVasstTree.signup" %>
<%@ Register Src="~/daVasst_Store/signupControl/signupControl.ascx" TagPrefix="daVasst" TagName="signup" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký</title>
    <link href="../daVasst_Store/signupControl/signup.css" rel="stylesheet" />
    <link href="../daVasst_Store/header/header.css" rel="stylesheet" />
</head>
<body class="bodySignUp">
    <daVasst:header runat="server"/>
    <form action="../../daVasstTree/signup.aspx" method="post" class="formSignUp" runat="server">
    <h1>Đăng ký</h1>
    <div class="formSignUp__taikhoan">
        <input type="text" name="taikhoan" value="" class="formSignUp__taikhoan__inp" autocomplete="off"/>
        <span class="formSignUp__taikhoan__label">Email</span>
        <label class="formSignUp__taikhoan__error"></label>
    </div>
    <div class="formSignUp__password">
        <input type="password" name="password" value="" class="formSignUp__password__inp" />
        <span class="formSignUp__password__label">Mật khẩu</span>
        <label class="formSignUp__password__error"></label>
    </div>
    <div class="formSignUp__repassword">
        <input type="password" name="repassword" value="" class="formSignUp__repassword__inp" />
        <span class="formSignUp__repassword__label">Xác minh mật khẩu</span>
        <label class="formSignUp__repassword__error"></label>
    </div>
    <input type="submit" value="Đăng ký tài khoản" class="btnAll" />
    <div class="formSignUp__redirect">
        <a href="../../daVasstTree/login.aspx">Đăng nhập</a>
    </div>
    <asp:HiddenField id="hidden" runat="server"/>
</form>
    <script src="../daVasst_Store/signupControl/signup.js"></script>
</body>
</html>
