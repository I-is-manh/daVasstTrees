<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="search.ascx.cs" Inherits="daVasstTrees.daVasst_Store.SearchBox.search" %>
<link href="../daVasst_Store/SearchBox/search.css" rel="stylesheet" type="text/css"/>
<div class="searchBox">
    <form action="productList.aspx" method="get" class="searchBox-item">
        <input type="text" name="key" value="" class="searchBox-item__inp" placeholder="Tìm kiếm"/>
        <input type="hidden" name="page" value="1" />
        <img src="../../Image/search-line.png" alt="Alternate Text" class="searchBox-item__icon"/>
    </form>
</div>
