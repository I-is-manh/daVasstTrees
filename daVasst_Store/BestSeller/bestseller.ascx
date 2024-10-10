<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="bestseller.ascx.cs" Inherits="daVasstTrees.daVasst_Store.BestSeller.bestseller" %>
<link href="../daVasst_Store/BestSeller/bestseller.css" rel="stylesheet" type="text/css"/>
<div class="container-fluid">
    <div class="container">
        <p class="container__title">Sản phẩm bán chạy</p>
        <div class="listProduct" runat="server" id="listProduct">
            <div class="listProduct__item">
                <div class="listProduct__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listProduct__item-imgSuro-img" />
                </div>
                <div class="listProduct-item-info">
                    <p class="listProduct-item-info__name">Sen đá ngọc</p>
                    <p class="listProduct-item-info__price">100.000 đ</p>
                    <button class="listProduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <%--<div class="listProduct__item">
                <div class="listProduct__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listProduct__item-imgSuro-img" />
                </div>
                <div class="listProduct-item-info">
                    <p class="listProduct-item-info__name">Sen đá ngọc</p>
                    <p class="listProduct-item-info__price">100.000 đ</p>
                    <button class="listProduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listProduct__item">
                <div class="listProduct__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listProduct__item-imgSuro-img" />
                </div>
                <div class="listProduct-item-info">
                    <p class="listProduct-item-info__name">Sen đá ngọc</p>
                    <p class="listProduct-item-info__price">100.000 đ</p>
                    <button class="listProduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listProduct__item">
                <div class="listProduct__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listProduct__item-imgSuro-img" />
                </div>
                <div class="listProduct-item-info">
                    <p class="listProduct-item-info__name">Sen đá ngọc</p>
                    <p class="listProduct-item-info__price">100.000 đ</p>
                    <button class="listProduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listProduct__item">
                <div class="listProduct__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listProduct__item-imgSuro-img" />
                </div>
                <div class="listProduct-item-info">
                    <p class="listProduct-item-info__name">Sen đá ngọc</p>
                    <span class="listProduct-item-info__dash">150.000 đ</span>
                    <span class="listProduct-item-info__price">100.000 đ</span>
                    <button class="listProduct-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>--%>
        </div>
    </div>
</div>

