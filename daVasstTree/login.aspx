<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="daVasstTrees.daVasst.login" %>
<%@ Register Src="~/daVasst_Store/login/loginControl.ascx"  TagPrefix="daVasst" TagName="login"%>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link href="../daVasst_Store/login/login.css" rel="stylesheet" />
</head>
<body class="bodySignIn">
    <daVasst:header runat="server" />
    <form action="../../daVasstTree/login.aspx" method="post" class="formLogin" runat="server" id="formDN">
    <h1>Đăng nhập</h1>
    <div class="formLogin__taikhoan">
        <input type="text" name="taikhoan"  class="formLogin__taikhoan__inp" value="" runat="server" id="inptk" autocomplete="off"/>
        <span class="formLogin__taikhoan__label" runat="server" id="labeltk">Email đăng nhập</span>
    </div>
    <div class="formLogin__password">
        <input type="password" name="password"  class="formLogin__password__inp" value=""  runat="server" id="inpmk" autocomplete="off" />
        <span class="formLogin__password__label"  runat="server" id="labelmk">Mật khẩu</span>
    </div>
    <p class="formLogin-labelError" runat="server" id="labelError">Sai email đăng nhập hoặc mật khẩu</p>
    <input type="submit" value="Đăng nhập" class="btnAll formLogin__btn"/>
    <div class="formLogin__redirect">
        <a href="#" class="formLogin__redirect__password">Quên mật khẩu</a>
        <a href="../../daVasstTree/signup.aspx" class="formLogin__redirect__signup">Đăng ký tài khoản</a>
    </div>
</form>
    
    <script src="../daVasst_Store/login/login.js"></script>
</body>
</html>
