<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="relateproduct.ascx.cs" Inherits="daVasstTrees.daVasst_Store.RelateProduct.relateproduct" %>
<link href="../daVasst_Store/RelateProduct/relateproduct.css" rel="stylesheet" type="text/css" />
<div class="container-fluid">
    <div class="container relateproduct" >
        <p class="relateproduct__title">Các sản phẩm liên quan</p>
        <div class="relateproduct-list" id="relateProduct" runat="server">
            <div class="relateproduct-item">
                <div class="relateproduct-item__surro">
                    <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="relateproduct-item__surro-img" />
                </div>
                <div class="relateproduct-item-info">
                    <p class="relateproduct-item-info__name">Sen đá ngọc</p>
                    <p class="relateproduct-item-info__price">100.000 đ</p>
                    <button class="relateproduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="relateproduct-item">
                <div class="relateproduct-item__surro">
                    <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="relateproduct-item__surro-img" />
                </div>
                <div class="relateproduct-item-info">
                    <p class="relateproduct-item-info__name">Sen đá ngọc</p>
                    <p class="relateproduct-item-info__dash">150.000 đ</p>
                    <p class="relateproduct-item-info__price">100.000 đ</p>
                    <button class="relateproduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
        </div>
    </div>
</div>
<script src="../daVasst_Store/RelateProduct/relateproduct.js"></script>
