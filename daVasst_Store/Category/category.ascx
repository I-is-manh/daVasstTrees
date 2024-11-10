<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="category.ascx.cs" Inherits="daVasstTrees.daVasst_Store.Category.category" %>
<link href="../daVasst_Store/Category/category.css" rel="stylesheet" type="text/css" />
<div class="category">
    <div class="category-surro">
        <p class="category-surro__title">
            <img src="../../Image/menu-2-line.png" id="imgnav" alt="" />Danh mục sản phẩm</p>
        <ul class="category-surro-list" id="listCategory" runat="server" >
            <%--<li class="category-surro-list__item"><a href="productList.aspx?page=1">Tất cả sản phẩm</a>
            </li>--%>
            <%--<li class="category-surro-list__item"><a href="#">Cây để bàn</a>
            </li>
            <li class="category-surro-list__item"><a href="#">Cây thủy sinh </a>
            </li>
            <li class="category-surro-list__item"><a href="#">Cây chậu treo</a>
            </li>
            <li class="category-surro-list__item"><a href="#">Cây ăn trái </a>
            </li>
            <li class="category-surro-list__item"><a href="#">Chậu cây cảnh</a>
            </li>--%>
        </ul>
    </div>
    <p class="category-line">Hiển thị theo</p>
    <form action="productList.aspx" method="post" id="formFilter" runat="server" class="category-filter">
        <div class="category-filter__surro">
            <label for="thapdencao">Giá thấp đến cao</label>
            <input type="radio" name="gia" value="thapdencao"  id="thapdencao" runat="server" class="category-filter__radio1"/>
        </div>
        <div class="category-filter__surro">
            <label for="caodenthap">Giá cao đến thấp</label>
            <input type="radio" name="gia" value="caodenthap" id="caodenthap" runat="server" class="category-filter__radio2"/>
            <input type="hidden" name="page" value="1" />
        </div>
    </form>
</div>
<script src="../daVasst_Store/Category/category.js"></script>
