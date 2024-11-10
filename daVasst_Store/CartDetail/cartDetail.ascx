<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="cartDetail.ascx.cs" Inherits="daVasstTrees.daVasst_Store.CartDetail.cartDetail" %>
<link href="../daVasst_Store/CartDetail/cartDetail.css" rel="stylesheet" type="text/css" />
<form action="cart.aspx" method="post" runat="server">
    <div class="container-fluid">
        <div class="container cartDetail" id="cartDetailList" runat="server">
            <asp:Repeater ID="cartRepeater" runat="server" OnItemDataBound="rptCartItems_ItemDataBound">
                <HeaderTemplate>
                    <table class="cartDetail-list">
                        <tr>
                            <th>Sản phẩm</th>
                            <th>Số lượng</th>
                            <th>Đơn giá</th>
                            <th>Thành tiền</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="product">
                            <button id="remove" runat="server" class="cartDetail-list__remove" onserverclick="remove_Click" name="remove">X</button>
                            <img src='<%# Eval("product.LinkImg") %>' alt="Product Image" />
                            <span><%# Eval("product.Name") %></span>
                        </td>
                        <td class="price"><%# Eval("product.price", "{0:#,##0 đ}") %></td>
                        <td>
                            <button id="btnTru" runat="server" class="btnupdate" onserverclick="btnTru_Click" name="tru">-</button>
                            <label class="number"><%# Eval("quantity") %></label>
                            <button id="btnCong" runat="server" class="btnupdate" onserverclick="btnCong_Click" name="cong">+</button>
                        </td>
                        <td class="price">
                            <asp:Label ID="lblTotal" runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <div class="cartDetail-total">
                <p class="cartDetail-total__title">Tạm tính</p>
                <%--<div>
                    <label class="labelgiamgia">Giam gia</label>
                    <input type="text" name="giamgia" value="" class="giamgia" />
                </div>--%>
                <div class="cartDetail-total__price">
                    <span>Tổng tiền</span>
                    <span id="totalprice" runat="server">100.000 đ</span>
                </div>
                <button class="cartDetail-total__btn"><a href="ThanhToan.aspx">Thanh toán</a></button>
            </div>
        </div>
    </div>

</form>
