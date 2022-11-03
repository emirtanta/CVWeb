<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiler.aspx.cs" Inherits="BlogWeb.AdminHobiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">

        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/AdminHobiEkle.aspx" runat="server" CssClass="btn btn-success">Ekle</asp:HyperLink>

        <table class="table table-hover">

        <tr>
            <th>#</th>
            <th>Hobi Ad</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("Hobi") %></td>
                        <td>
                            <asp:HyperLink ID="hylHobiGuncelle" NavigateUrl='<%# "AdminHobiGuncelle.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-info btn-sm">Güncelle</asp:HyperLink>
                            <asp:HyperLink ID="hylHobiSil" NavigateUrl='<%# "AdminHobiSil.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-danger btn-sm">Sil</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
    </form>
</asp:Content>
