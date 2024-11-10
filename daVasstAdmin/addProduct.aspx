<%@ Page Title="" Language="C#" MasterPageFile="~/daVasstAdmin/daVasstAdmin.Master" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="daVasstTrees.daVasstAdmin.addProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../daVasst_Store/LinkCss/addproductAdmin.css" rel="stylesheet" type="text/css" />
    <div class="container-fluid addproductparent">
        <form class="container addproduct" id="formaddproduct" method="post" action="addProduct.aspx" runat="server" enctype="multipart/form-data">
            <div class="addproduct-detail-updateimg">
                <div class="addproduct-detail-updateimg__img">
                    <div class="img-surro">
                        <img id="imgavt" />
                    </div>
                    <div class="addproduct-detail-updateimg__camera">
                        <img src="../../Image/camera.jpg" alt="Alternate Text" />
                        <input type="file" name="uploadfile" value="" id="inputfile" />
                    </div>
                </div>
                <p id="errorImg">Hình ảnh sản phẩm</p>
            </div>
            <div class="addproduct-info">
                <div class="addproduct-info-item">
                    <label>Loại sản phẩm</label>
                    <select name="category" value="">
                        <option value="1">Cây để bàn</option>
                        <option value="2">Cây thủy sinh</option>
                        <option value="3">Sen đá và xương rồng</option>
                        <option value="4">Cây chậu treo</option>
                        <option value="5">Cây ăn trái</option>
                        <option value="6">Chậu cây cảnh</option>
                    </select>
                </div>
                <div class="addproduct-info-item">
                    <label>Tên sản phẩm</label>
                    <input type="text" name="name" value="" id="nameproduct" />
                    <label id="errorName" style="color: red;"></label>
                </div>
                <div class="addproduct-info-item">
                    <label>Giá</label>
                    <input type="text" name="price" value="" id="priceproduct" oninput="formatCurrency(this)" />
                    <label id="errorPrice" style="color: red;"></label>
                </div>
                <div class="addproduct-info-item">
                    <label>Phần trăm giảm giá tính theo số nguyên</label>
                    <input type="text" name="discount" value="" id="discountproduct" />
                    <label id="errorDiscount" style="color: red;"></label>
                </div>
                <div class="addproduct-info-item">
                    <label>Số lượng</label>
                    <input type="text" name="quantity" value="" id="quantityproduct" />
                    <label id="errorQuantity" style="color: red;"></label>
                </div>
                <div class="addproduct-info-item">
                    <label>Mô tả sản phẩm</label>
                    <input type="text" name="desc" value="" id="descproduct" />
                    <label id="errorDesc" style="color: red;"></label>
                </div>
            </div>
            <button class="btnAll">Thêm sản phẩm</button>
        </form>
        <div class="overlayaddproduct" runat="server" id="overlayaddproduct">
            <div class="confirmbox">
                <p>Bạn đã thêm sản phẩm thành công</p>
                <button class="btnAll" id="btnOk">Thoát</button>
            </div>
        </div>
    </div>
    <script src="../daVasst_Store/LinkJS/addProduct.js"></script>
</asp:Content>
