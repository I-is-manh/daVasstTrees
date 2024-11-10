<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="daVasstTrees.daVasst_Store.header.header" %>
<link href="../daVasst_Store/header/header.css" rel="stylesheet" />
<header class="headerNav">
    <p class="headerNav__logo"><a href="../../daVasstTree/Home.aspx">daVasst</a></p>
    <ul class="headerNav-list">
        <li class="headerNav-list__item"><a href="Home.aspx">Trang chủ</a></li>
        <li class="headerNav-list__item sanpham">Sản phẩm
                <ul class="headerNav-list__sub">
                    <li class="headerNav-list__sub-item">Cây cảnh <span class="right">></span>
                        <ul class="treeDetail">
                            <li class="treeDetail-item"><a href="productList.aspx?id=1&page=1">Cây cảnh để bàn</a></li>
                            <li class="treeDetail-item"><a href="productList.aspx?id=2&page=1">Cây thủy sinh</a></li>
                            <li class="treeDetail-item"><a href="productList.aspx?id=3&page=1">Sen đá và xương rồng</a></li>
                            <li class="treeDetail-item"><a href="productList.aspx?id=4&page=1">Cây chậu treo</a></li>
                            <li class="treeDetail-item"><a href="productList.aspx?id=5&page=1">Cây ăn trái</a></li>
                        </ul>
                    </li>

                    <li class="headerNav-list__sub-item"><a href="productList.aspx?id=6&page=1">Chậu cây cảnh</a></li>
                </ul>
        </li>
        <li class="headerNav-list__item"><a href="cart.aspx">Giỏ hàng</a>
        <li class="headerNav-list__item" runat="server" id="tkButton"><a href="../../daVasstTree/Infomation.aspx" >Tài khoản</a></li>
        <li class="headerNav-list__item" runat="server" id="dnButton"><a href="../../daVasstTree/Login.aspx" >Đăng nhập</a></li>
        <li class="headerNav-list__item" runat="server" id="dkButton"><a href="../../daVasstTree/signup.aspx" >Đăng ký</a></li>
    </ul>
    <div class="headerNav__logobar">
        <span class="headerNav__logobar-item"></span>
        <span class="headerNav__logobar-item"></span>
        <span class="headerNav__logobar-item"></span>
    </div>
</header>
<script src="../daVasst_Store/header/index.js">
</script>