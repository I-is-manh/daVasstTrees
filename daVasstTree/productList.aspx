<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productList.aspx.cs" Inherits="daVasstTrees.daVasstTree.category" %>
<%@ Register Src="~/daVasst_Store/Category/category.ascx" TagName="category" TagPrefix="daVasst" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagName="header" TagPrefix="daVasst" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagName="search" TagPrefix="daVasst" %>
<%@ Register Src="~/daVasst_Store/productListItem/productListItem.ascx" TagName="listitem" TagPrefix="daVasst" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Danh sách sản phẩm</title>
    <link href="../daVasst_Store/LinkCss/productList.css" rel="stylesheet" type="text/css"/>
    
</head>
<body>
    <daVasst:header runat="server" />
    <daVasst:search runat="server" />
    <div class="container-fluid productList">
        <div class="detailmain">
            <daVasst:category runat="server"/>
            <daVasst:listitem runat="server"/>
        </div>
    </div>
</body>
</html>
