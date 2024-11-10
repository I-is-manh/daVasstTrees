<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productDetail.aspx.cs" Inherits="daVasstTrees.daVasstTree.productDetail" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/banner/bannerControl.ascx" TagPrefix="daVasst" TagName="banner" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<%@ Register Src="~/daVasst_Store/productDetail/productDetail.ascx" TagPrefix="daVasst" TagName="productDetail"  %>
<%@ Register Src="~/daVasst_Store/RelateProduct/relateproduct.ascx" TagPrefix="daVasst" TagName="realteproduct" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chi tiết sản phẩm</title>
    <link href="../daVasst_Store/productDetail/productItem.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <daVasst:header runat="server"/>
    <daVasst:search runat="server" />
    <daVasst:productDetail runat="server" />
    <daVasst:realteproduct  runat="server"/>
    <daVasst:footer  runat="server"/>
</body>
</html>
