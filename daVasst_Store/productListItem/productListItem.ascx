<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="productListItem.ascx.cs" Inherits="daVasstTrees.daVasst_Store.productListItem.productListItem" %>
<link href="../daVasst_Store/productListItem/productListItem.css" rel="stylesheet" type="text/css" />

<div class="lisstressparent">
    <h1 class="lisstressparent__title" runat="server" id="listTreeTitle"></h1>
    <div class="listTrees" id="listTrees" runat="server">
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <p class="listTrees-item-info__price">100.000 đ</p>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
        <div class="listTrees-item">
            <div class="listTrees-item__surro">
                <img src="../../Image/caydeban.jpg" alt="Alternate Text" class="listTrees-item__surro-img" />
            </div>
            <div class="listTrees-item-info">
                <p class="listTrees-item-info__name">Sen đá ngọc</p>
                <span class="listTrees-item-info__dash">150.000 đ</span>
                <span class="listTrees-item-info__price">100.000 đ</span>
                <button class="listTrees-item-info__btn"><a href="#">Thêm vào giỏ hàng</a></button>
            </div>
        </div>
    </div>
    <div class="lisstressparent-pagination">
        <div class="lisstressparent-pagination__list" id="pageList" runat="server">
            <%--<img src="../../Image/arrow-left-line.png" alt="Alternate Text" class="lisstressparent-pagination__list-img"/>
            <span  class="lisstressparent-pagination__list-item"><a href="#">1</a></span>
            <span  class="lisstressparent-pagination__list-item"><a href="#">2</a></span>
            <span  class="lisstressparent-pagination__list-item"><a href="#">3</a></span>
            <span  class="lisstressparent-pagination__list-item"><a href="#">4</a></span>
            <span  class="lisstressparent-pagination__list-item"><a href="#">5</a></span>
            <img src="../../Image/arrow-right-line.png" alt="Alternate Text" class="lisstressparent-pagination__list-img"/>--%>
        </div>
    </div>
</div>
 <script src="../daVasst_Store/productListItem/productListItem.js"></script>
