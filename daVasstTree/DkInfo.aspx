<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DkInfo.aspx.cs" Inherits="daVasstTrees.daVasstTree.DkInfo" %>

<%@ Register Src="~/daVasst_Store/signupControl/signupControl.ascx" TagPrefix="daVasst" TagName="signup" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang đăng ký thông tin</title>
    <%--<link href="../daVasst_Store/signupControl/signup.css" rel="stylesheet" />--%>
    <link href="../daVasst_Store/header/header.css" rel="stylesheet" />
    <link href="../daVasst_Store/LinkCss/dkinfo.css" rel="stylesheet" />
</head>
<body>
    <daVasst:header runat="server" />
    <form action="DkInfo.aspx" method="post" class="formSignUp" runat="server">
        <%-- <h1>Đăng ký</h1>
        <div class="formSignUp__taikhoan">
            <input type="text" name="taikhoan" value="" class="formSignUp__taikhoan__inp" autocomplete="off" />
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
        <asp:HiddenField ID="hidden" runat="server" />--%>
        <label>Họ và tên : </label>
        <input type="text" name="name" value="" />
        <br />
        <label id="errorname" style="color:red;"></label>
        <br />
        <label for="date">Ngày sinh</label>
        <input type="text" name="date" value="" id="date"/>
        <br />
         <label id="errordate" style="color:red;"></label>
        <br />
        <div class="gt">
            <label>Giới tính</label>
            <label for="gtnam">Nam</label>
            <input type="radio" name="gt" value="Nam" id="gtnam" />
            <label for="gtnu">Nữ</label>
            <input type="radio" name="gt" value="Nu" id="gtnu"/>
        </div>
        <br />
        <label for="lop">Lớp</label>
        <select name="lop" id="lop">
            <option value="2210A01">2210A01</option>
            <option value="2210A01">2210A02</option>
            <option value="2210A01">2210A03</option>
            <option value="2210A01">2210A04</option>
            <option value="2210A01">2210A05</option>
            <option value="2210A01">2210A06</option>
            <option value="2210A01">2210A07</option>
            <option value="2210A01">2210A08</option>
            <option value="2210A01">2210A09</option>
        </select>
        <br />
        <input type="submit" name="btn" value="Submit" />
    </form>
    <div runat="server" id="listtk"></div>
    <script src="../daVasst_Store/LinkJS/dkinfo.js"></script>
</body>
</html>
