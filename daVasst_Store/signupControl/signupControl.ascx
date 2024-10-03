<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="signupControl.ascx.cs" Inherits="daVasstTrees.daVasst_Store.signupControl.signupControl" %>
<form action="../../daVasstTree/signup.aspx" method="post" class="formSignUp">
    <h1>Đăng ký</h1>
    <div class="formSignUp__taikhoan">
        <input type="type" name="taikhoan" value="" class="formSignUp__taikhoan__inp" />
        <span class="formSignUp__taikhoan__label">Tài khoản</span>
    </div>
    <div class="formSignUp__password">
        <input type="type" name="password" value="" class="formSignUp__password__inp" />
        <span class="formSignUp__password__label">Mật khẩu</span>
    </div>
    <div class="formSignUp__repassword">
        <input type="type" name="password" value="" class="formSignUp__repassword__inp" />
        <span class="formSignUp__repassword__label">Xác minh mật khẩu</span>
    </div>
    <input type="submit" value="Đăng ký tài khoản" class="btnAll" />
    <div class="formSignUp__redirect">
        <a href="../../daVasstTree/login.aspx">Đăng nhập</a>
    </div>
</form>
