<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="daVasstTrees.daVasstTree.Home" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<%@ Register Src="~/daVasst_Store/banner/bannerControl.ascx" TagPrefix="daVasst" TagName="banner" %>
<%@ Register Src="~/daVasst_Store/BreadCrumbs/breadcrumb.ascx" TagPrefix="daVasst" TagName="breadcrumb" %>
<%@ Register Src="~/daVasst_Store/BestSeller/bestseller.ascx" TagPrefix="daVasst" TagName="bestseller" %>
<%@ Register Src="~/daVasst_Store/CayDeBan/caydeban.ascx"  TagPrefix="daVasst" TagName="deban"%>
<%@ Register Src="~/daVasst_Store/CayThuySinh/CayThuySinh.ascx" TagPrefix="daVasst" TagName="thuysinh" %>
<%@ Register Src="~/daVasst_Store/CaySenDa/senda.ascx" TagPrefix="daVasst" TagName="senda" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<%@ Register Src="~/daVasst_Store/ChauCay/chaucay.ascx" TagPrefix="daVasst" TagName="chaucay" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>daVasst's Trees</title>
    <link href="../daVasst_Store/CayDeBan/caydeban.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <daVasst:header runat="server"/>
    <daVasst:search runat="server" />
    <daVasst:banner runat="server"/>
    <daVasst:bestseller runat="server"/>
    <daVasst:deban runat="server"/>
    <daVasst:thuysinh runat="server"/>
    <daVasst:senda runat="server"/>
    <daVasst:chaucay runat="server"/>
    <daVasst:footer  runat="server"/>
</body>
</html>
