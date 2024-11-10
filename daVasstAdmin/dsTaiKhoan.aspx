<%@ Page Title="" Language="C#" MasterPageFile="~/daVasstAdmin/daVasstAdmin.Master" AutoEventWireup="true" CodeBehind="dsTaiKhoan.aspx.cs" Inherits="daVasstTrees.daVasstAdmin.dsTaiKhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../daVasst_Store/LinkCss/dstk.css" rel="stylesheet" type="text/css"/>
    <div class="dstk container" runat="server" id="dstk">
        <h2>Danh sách tài khoản người dùng</h2>
        <table>
            <thead>
                <tr>
                    <th>STT</th>
                    <th>Email</th>
                    <th>Mật khẩu</th>
                </tr>

            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>vanmanhn868@gmail.com</td>
                    <td>123445</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
