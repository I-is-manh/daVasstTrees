﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CayThuySinh.ascx.cs" Inherits="daVasstTrees.daVasst_Store.CayThuySinh.CayThuySinh" %>
<link href="../daVasst_Store/CayThuySinh/caythuysinh.css" rel="stylesheet" type="text/css"/>
<div class="container-fluid listcaythuysinh-parent">
    <div class="container listcaythuysinh-child">
        <div class="listcaythuysinh-child-header">
            <p class="listcaythuysinh-child-header__title">Cây thủy sinh</p>
            <button class="listcaythuysinh-child-header__btn"><a href="productList.aspx?id=2&page=1">Xem tất cả</a> <span>></span></button>
        </div>
        <div class="listcaythuysinh-child__hr"></div>
        <div class="listCayThuySinh" runat="server" id="listCayThuySinh">
           <%-- <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <p class="listCayDeBan-item-info__price">100.000 đ</p>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
            </div>
            <div class="listCayDeBan__item">
                <div class="listCayDeBan__item-imgSuro">
                    <img src="../../Image/sendangoc.jpg" alt="Sen đá ngọc" class="listCayDeBan__item-imgSuro-img" />
                </div>
                <div class="listCayDeBan-item-info">
                    <p class="listCayDeBan-item-info__name">Sen đá ngọc</p>
                    <span class="listCayDeBan-item-info__dash">150.000 đ</span>
                    <span class="listCayDeBan-item-info__price">100.000 đ</span>
                    <button class="listCayDeBan-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
                </div>
                <span class="listCayDeBan__item-discount">15%</span>
            </div>--%>
        </div>
    </div>
</div>
