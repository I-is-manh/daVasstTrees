<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="category.ascx.cs" Inherits="daVasstTrees.daVasst_Store.Category.category" %>
<link href="../daVasst_Store/Category/category.css" rel="stylesheet" type="text/css" />
<div class="category">
    <div class="category-surro">
        <p class="category-surro__title">
            <img src="../../Image/menu-2-line.png" alt="" />Danh mục sản phẩm</p>
        <ul class="category-surro-list" id="listCategory" runat="server" >
            <%--<li class="category-surro-list__item"><a href="#">Cây sen đá và xương rồng</a>
            </li>
            <li class="category-surro-list__item"><a href="#">Cây để bàn</a>
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
    <form class="category-filter">
        <div class="category-filter__surro">
            <label for="thapdencao">Giá thấp đến cao</label>
            <input type="radio" name="gia" value="thapdencao" id="thapdencao" />
        </div>
        <div class="category-filter__surro">
            <label for="caodenthap">Giá cao đến thấp</label>
            <input type="radio" name="gia" value="caodenthap" id="caodenthap" />
        </div>
        <div class="category-filter__surro">
            <label for="muanhieu">Lượt mua nhiều nhất</label>
            <input type="checkbox" name="check" value="muanhieu" id="muanhieu" />
        </div>
        <div class="category-filter__surro">
            <label for="giamgianhieu">Giam giá nhiều nhất</label>
            <input type="checkbox" name="check" value="" id="giamgianhieu" />
        </div>
    </form>
</div>
