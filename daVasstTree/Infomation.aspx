<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Infomation.aspx.cs" Inherits="daVasstTrees.daVasstTree.Infomation" %>
<%@ Register TagPrefix="daVasst" TagName="infomation" Src="~/daVasst_Store/Infomation/Infomation.ascx" %>
<%@ Register Src="~/daVasst_Store/header/header.ascx" TagPrefix="daVasst" TagName="header" %>
<%@ Register Src="~/daVasst_Store/footer/footer.ascx" TagPrefix="daVasst" TagName="footer" %>
<%@ Register Src="~/daVasst_Store/SearchBox/search.ascx" TagPrefix="daVasst" TagName="search" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông tin cá nhân</title>
    
</head>
<body>
    <daVasst:header runat="server"/>
    <daVasst:search runat="server" />
    <div class="container-fluid">
        <div class="container">
            <daVasst:infomation runat="server"/>
        </div>
    </div>
    <div class="overlay" id="overlay" runat="server">
        <div class="overlay-notify">
            <p class="overlay-notify__title">Bạn đã cập nhật thông tin cá nhân thành công</p>
            <button class="btnAll overlay-notify__btn">OK</button>
        </div>
    </div>
    <daVasst:footer  runat="server"/>
    <script src="../daVasst_Store/LinkJS/infomation.js"></script>
</body>
</html>
