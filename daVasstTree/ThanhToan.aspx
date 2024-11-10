<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="daVasstTrees.daVasstTree.ThanhToan" %>

<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thanh toán</title>
    <link href="../daVasst_Store/LinkCss/Pay.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <daVasst:header runat="server" />
    <daVasst:search runat="server" />
    <div class="container-fluid">
        <form id="form1" runat="server" class="pay container">
            <div class="pay-info" runat="server" id="payInfo">
                <%--<h1 class="pay-info__title">Thông tin thanh toán</h1>--%>
                <%--<div class="pay-info-fullname pay-info-item">
                    <label class="pay-info-fullname__label">
                        Họ và tên* :
                    </label>
                    <input type="text" name="fullname" value="" class="pay-info-fullname__inp" required />
                </div>
                <div class="pay-info-address pay-info-item">
                    <label class="pay-info-address__label">Địa chỉ giao hàng</label>
                    <input type="text" name="address" value="" class="pay-info-address__inp" required />
                </div>
                <div class="pay-info-numberphone pay-info-item">
                    <label class="pay-info-numberphone__label">Số điện thoại</label>
                    <input type="text" name="numberphone" value="" class="pay-info-numberphone__inp" required />
                    <label id="errorNumberphone" style="color: red;"></label>
                </div>
                <div class="pay-info-email pay-info-item">
                    <label class="pay-info-email__label">Email*</label>
                    <input type="text" name="email" value="" class="pay-info-email__inp" required />
                    <label id="errorEmail" style="color: red;"></label>
                </div>
                <div class="pay-info-more pay-info-item">
                    <label class="pay-info-more__label">Thông tin bổ sung</label>
                    <textarea name="more" value="" class="pay-info-more__inp" rows="5" placeholder="Ghi chú thêm về thông tin cho đơn hàng"></textarea>
                </div>--%>
            </div>
            <div class="pay-detail">
                <h1 class="pay-detail__title">Chi tiết đơn hàng</h1>
                <div class="pay-detail-product" runat="server" id="payDetail">
                    <%--<p class="pay-detail-product__item"><span>Sản phẩm</span><span>Tạm tính</span></p>
                    <hr />--%>
                    <%--<p class="pay-detail-product__item"><span>Cây lan chi x 1</span><span>500.000 đ</span></p>
                    <hr />
                    <p class="pay-detail-product__item"><span>Cây trái tim x 2</span><span>500.000 đ</span></p>
                    <hr />
                    <p class="pay-detail-product__item"><span>Cây lan chi x 1</span><span>500.000 đ</span></p>
                    <hr />--%>
                </div>
                <p class="pay-detail-product__item" runat="server" id="total"><span>Tổng</span><span>1.000.000 đ</span></p>
                <hr />
                <input type="radio" name="pttt"  value="nh" id="nh"/> <label for="nh">Chuyển khoản ngân hàng</label>
                <br />
                <input type="radio" name="pttt" value="tt" id="tt" /> <label for="tt">Thanh toán khi nhận hàng</label>
                <br />
                <label style="color:red;" id="errorPTTT"></label>
                <button class="btnAll">Đặt hàng</button>
            </div>
        </form>
    </div>
    <script src="../daVasst_Store/LinkJS/Pay.js"></script>
    <daVasst:footer runat="server" />
</body>
</html>
