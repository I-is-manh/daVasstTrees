<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="loginControl.ascx.cs" Inherits="daVasstTrees.daVasst_Store.login.loginControl" %>
<form action="../../daVasstTree/login.aspx" method="post" class="formLogin">
    <h1>Đăng nhập</h1>
    <div class="formLogin__taikhoan">
        <input type="type" name="taikhoan" value="" class="formLogin__taikhoan__inp"/>
        <span class="formLogin__taikhoan__label">Tài khoản</span>
    </div>
    <div class="formLogin__password">
        
        <input type="type" name="password" value="" class="formLogin__password__inp"/>
        <span class="formLogin__password__label">Mật khẩu</span>
    </div>
    <input type="submit" value="Đăng nhập" class="btnAll"/>
    <div class="formLogin__redirect">
        <a href="#" class="formLogin__redirect__password">Quên mật khẩu</a>
        <a href="../../daVasstTree/signup.aspx" class="formLogin__redirect__signup">Đăng ký tài khoản</a>
    </div>
</form>
