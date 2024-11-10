<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Infomation.ascx.cs" Inherits="daVasstTrees.daVasst_Store.Infomation.Infomation" %>
<link href="../daVasst_Store/Infomation/Infomation.css" rel="stylesheet" type="text/css" />
<div class="container-fluid">
    <div class="container infomation">
        <h1 class="infomation-titleheader">Thông tin cá nhân</h1>
        <form class="infomation-detail" action="../../daVasstTree/Infomation.aspx" runat="server" id="infomation" enctype="multipart/form-data">
            <div class="infomation-detail-updateimg">
                <div class="infomation-detail-updateimg__img">
                    <img src="../../Image/chupin.jpg" alt="Alternate Text" id="imgavt" />
                    <div class="infomation-detail-updateimg__camera">
                        <img src="../../Image/camera.jpg" alt="Alternate Text" />
                        <input type="file" name="uploadfile" value="" id="inputfile" />
                    </div>
                </div>
                <p>FullName</p>
            </div>
            <div class="infomation-detail__fullname infomation-detail__item">
                <label>Họ và tên : </label>
                <input type="text" name="fullname" value="" />
            </div>
            <div class="infomation-detail__email infomation-detail__item">
                <label>Email : </label>
                <input type="email" name="email" value="daVasst04@gmail.com" />
            </div>
            <div class="infomation-detail__address infomation-detail__item">
                <label>Địa chỉ giao hàng : </label>
                <input type="text" name="address" value="77 định công" />
            </div>
            <div class="infomation-detail__numberphone infomation-detail__item">
                <label>Số điện thoại : </label>
                <input type="text" name="numberphone" value="0942549465" />
            </div>
            <div class="infomation-detail-btn">
                <button type="submit" class="infomation-detail-btn__update btnAll">Cập nhật</button>
                <button type="submit" class="infomation-detail-btn__signout btnAll" value="signout" name="signout"><a href="signout.aspx">Đăng xuất</a></button>
            </div>
        </form>
    </div>
</div>
<script src="../daVasst_Store/Infomation/Infomation.js"></script>
