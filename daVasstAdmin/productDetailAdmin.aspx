<%@ Page Title="" Language="C#" MasterPageFile="~/daVasstAdmin/daVasstAdmin.Master" AutoEventWireup="true" CodeBehind="productDetailAdmin.aspx.cs" Inherits="daVasstTrees.daVasstAdmin.productDetailAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../daVasst_Store/LinkCss/updateProductAdmin.css" rel="stylesheet" type="text/css" />
    <div class="container-fluid productAdminparent">
        <button class="btnAll back"><a href="ListProduct.aspx">Quay lai</a></button>
        <form class="container productAdmin" id="productAdmin" runat="server"  method="post" action="productDetailAdmin.aspx" enctype="multipart/form-data">
            <%--<div class="productAdmin-detail-updateimg">
                <div class="productAdmin-detail-updateimg__img">
                    <img src="../../Image/chupin.jpg" alt="Alternate Text" id="imgavt" />
                    <div class="productAdmin-detail-updateimg__camera">
                        <img src="../../Image/camera.jpg" alt="Alternate Text" />
                        <input type="file" name="uploadfile" value="" id="inputfile" />
                    </div>
                </div>
                <p>FullName</p>
            </div>
            <div class="productAdmin-info">
                <div class="productAdmin-info-item">
                    <label>Tên sản phẩm</label>
                    <input type="text" name="name" value="" id="nameproduct"/>
                </div>
                <div class="productAdmin-info-item">
                    <label>Giá</label>
                    <input type="text" name="price" value="" id="priceproduct"/>
                </div>
                <div class="productAdmin-info-item">
                    <label>Phần trăm giảm giá tính theo số nguyên</label>
                    <input type="text" name="discount" value="" id="discountproduct"/>
                </div>
                <div class="productAdmin-info-item">
                    <label>Số lượng</label>
                    <input type="text" name="quantity" value="" id="quantityproduct"/>
                </div>
                <div class="productAdmin-info-item">
                    <label>Mô tả sản phẩm</label>
                    <input type="text" name="desc" value="" id="descproduct"/>
                </div>
            </div>
            <button class="btnAll">Cập nhật</button>--%>
        </form>
        <div class="overlay" runat="server" id="overlay">
            <div class="confirmbox">
                <p>Bạn đã cập nhật thành công</p>
                <button class="btnAll" id="btnOk">Thoát</button>
            </div>
        </div>
    </div>
    <script src="../daVasst_Store/LinkJS/productAdmin.js"></script>
</asp:Content>
