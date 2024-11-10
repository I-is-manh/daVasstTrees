<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="daVasstTrees.daVasstTree.cart" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<%@ Register Src="~/daVasst_Store/CartDetail/cartDetail.ascx" TagName="cart" TagPrefix="daVasst" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giỏ hàng</title>
    <link href="../daVasst_Store/CartDetail/cartDetail.css" rel="stylesheet" type="text/css"/>
</head>
<body>
     <daVasst:header runat="server"/>
     <daVasst:search runat="server" />
     <daVasst:cart runat="server"/>
     <daVasst:footer  runat="server"/>
    <script src="../daVasst_Store/CartDetail/cartDetail.js"></script>
</body>
</html>
