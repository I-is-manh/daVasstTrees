<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="productDetail.ascx.cs" Inherits="daVasstTrees.daVasst_Store.productDetail.productDetail" %>
<link href="../daVasst_Store/productDetail/productItem.css" rel="stylesheet" type="text/css"/>
<div class="container-fluid">
    <div class="productDetail container" runat="server" id="productDetaill">
        <div class="productDetail-item">
            <div class="productDetail-item-imgSurro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="productDetail-item-imgSurro__img"/>
            </div>
            <div class="productDetail-item-infomation">
                <div class="productDetail-item-infomation__breadcrumb">
                    <a href="#">Trang chủ</a>
                    <span>/</span>
                    <a href="#">Cây để bàn</a>
                    <span>/</span>
                    <a href="#">Sen đá để bàn</a>
                </div>
                <p class="productDetail-item-infomation__name">Sen đá để bàn</p>
                <div class="productDetail-item-infomation-price">
                    <p class="productDetail-item-infomation-price__oldPrice">150.000 đ</p>
                    <p class="productDetail-item-infomation-price__currentPrice">125.000 đ</p>
                </div>
                <p class="productDetail-item-infomation__description">Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nisi voluptatem ea odit dolorum? Delectus, fugiat laboriosam numquam laborum, nobis officiis alias molestias saepe doloribus amet unde nam blanditiis magni doloremque!</p>
                <div class="productDetail-item-infomation-btnAdd">
                    <div class="productDetail-item-infomation-btnAdd__Addnumber">
                        <span>-</span>
                        <span>1</span>
                        <span>+</span>
                    </div>
                    <button class="productDetail-item-infomation-btnAdd__btnAddCart btnAll">Thêm vào giỏ hàng</button>
                </div>
                <button class="productDetail-item-infomation__buynow">Mua hàng ngay</button>
            </div>
        </div>
    </div>
</div>
<script src="../daVasst_Store/productDetail/productDetail.js"></script>