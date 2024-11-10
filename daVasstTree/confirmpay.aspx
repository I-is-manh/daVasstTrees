<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmpay.aspx.cs" Inherits="daVasstTrees.daVasstTree.confirmpay" %>

<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thanh toán</title>
    <link href="../daVasst_Store/LinkCss/ConfirmPay.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <daVasst:header runat="server" />
    <daVasst:search runat="server" />
    <div class="container-fluid">
        <div class="container confirmpay">
            <button class="btnAll"><a href="productList.aspx?page=1">Quay lại trang sản phẩm</a></button>
            <p class="confirmpay-title">Chi tiết đơn hàng</p>
            <div class="confirmpayDetail">
                <div class="confirmpayDetail-product" id="confirmpayProduct" runat="server">
                    <p class="confirmpayDetail-product__item"><span>Sản phẩm</span><span>Tổng</span></p>
                    <p class="confirmpayDetail-product__item"><span>Cây chu pin x 1</span><span>10.000.000 đ</span></p>
                    <p class="confirmpayDetail-product__item"><span>Cây chu pin x 1</span><span>10.000.000 đ</span></p>
                    <p class="confirmpayDetail-product__item"><span>Cây chu pin x 1</span><span>10.000.000 đ</span></p>
                    <p class="confirmpayDetail-product__item"><span>Cây chu pin x 1</span><span>10.000.000 đ</span></p>
                    <p class="confirmpayDetail-product__item"><span>Cây chu pin x 1</span><span>10.000.000 đ</span></p>
                    <p class="confirmpayDetail-product__item"><span>Tổng cộng</span><span>10.000.000 đ</span></p>
                    <p class="confirmpayDetail-product__item"><span>Ghi chú</span><span>Null</span></p>
                </div>
                <div class="confirmpayDetail-info" id="confirmpayInfo" runat="server">
                    <p class="confirmpayDetail-info__title">Cảm ơn bạn chúng tôi đã nhận được đơn hàng</p>
                    <ul class="confirmpayDetail-info-listinfo">
                        <li class="confirmpayDetail-info-listinfo__item">Mã đơn hàng : 16</li>
                        <li class="confirmpayDetail-info-listinfo__item">Ngày tạo : 04/11/2024</li>
                        <li class="confirmpayDetail-info-listinfo__item">Địa chỉ giao hàng : 77 Định Công</li>
                        <li class="confirmpayDetail-info-listinfo__item">Phương thức thanh toán : Chuyển khoản</li>
                        <li class="confirmpayDetail-info-listinfo__item">Tổng cộng : 10.000.000</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <daVasst:footer runat="server" />
</body>
</html>
