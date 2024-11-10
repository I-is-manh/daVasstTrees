<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderStatus.aspx.cs" Inherits="daVasstTrees.daVasstTree.OrderStatus" %>

<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trạng thái đơn hàng</title>
    <link href="../daVasst_Store/LinkCss/orderstatus.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <daVasst:header runat="server" />
    <daVasst:search runat="server" />
    <div class="container-fluid">
        <div class="container orderStatus" >
            <div class="orderStatus-product" id="orderStatus" runat="server">
                <%--<h1 class="orderStatus-product__title">Chi tiết đơn hàng của bạn</h1>
                <div class="orderStatus-product__item"><span>Sản phẩm</span><span>Tổng</span></div>
                <div class="orderStatus-product__item"><span>Cây hạnh phúc x 1</span><span>450.000 đ</span></div>
                <div class="orderStatus-product__item"><span>Cây hạnh phúc x 1</span><span>450.000 đ</span></div>
                <div class="orderStatus-product__item"><span>Cây hạnh phúc x 1</span><span>450.000 đ</span></div>
                <div class="orderStatus-product__item"><span>Ngay</span><span>30/10/2024</span></div>
                <div class="orderStatus-product__item"><span>Phương thức thanh toán</span><span>Chuyển khoản ngân hàng</span></div>
                <div class="orderStatus-product__item"><span>Tổng</span><span>450.000 đ</span></div>
                <button class="btnAll"><a href="Home.aspx"><img src="../Image/arrow-left-line.png" alt="Alternate Text" /> Quay về trang chủ</a></button>--%>
            </div>
        </div>
    </div>
    <daVasst:footer runat="server" />
</body>
</html>
