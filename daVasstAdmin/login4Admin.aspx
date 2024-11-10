<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login4Admin.aspx.cs" Inherits="daVasstTrees.daVasstAdmin.login4Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link href="../daVasst_Store/LinkCss/loginAdmin.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form action="login4Admin.aspx" method="post" class="formLogin" runat="server" id="formDN">
        <h1>Đăng nhập</h1>
        <div class="formLogin__taikhoan">
            <input type="text" name="taikhoan" class="formLogin__taikhoan__inp" value="" runat="server" id="inptk" autocomplete="off" />
            <span class="formLogin__taikhoan__label" runat="server" id="labeltk">Email đăng nhập</span>
        </div>
        <div class="formLogin__password">
            <input type="password" name="password" class="formLogin__password__inp" value="" runat="server" id="inpmk" autocomplete="off" />
            <span class="formLogin__password__label" runat="server" id="labelmk">Mật khẩu</span>
        </div>
        <p class="formLogin-labelError" runat="server" id="labelError">Sai email đăng nhập hoặc mật khẩu</p>
        <input type="submit" value="Đăng nhập" class="btnAll formLogin__btn" />
    </form>
</body>
</html>
