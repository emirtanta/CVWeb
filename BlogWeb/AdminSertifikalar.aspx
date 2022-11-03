<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSertifikalar.aspx.cs" Inherits="BlogWeb.AdminSertifikalar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">

        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/AdminSertifikaEkle.aspx" runat="server" CssClass="btn btn-success">Ekle</asp:HyperLink>

        <table class="table table-hover">

        <tr>
            <th>#</th>
            <th>Kurum</th>
            <th>Sertifika Adı</th>
            <th>Tarih</th>
            <th>Açıklama</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("KURUM") %></td>
                        <td><%# Eval("AD") %></td>
                        <td><%# Eval("TARIH") %></td>
                        <td><%# Eval("ACIKLAMA") %></td>
                        <td>
                            <asp:HyperLink ID="hylSertifikaGuncelle" NavigateUrl='<%# "AdminSertifikaGuncelle.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-info btn-sm">Güncelle</asp:HyperLink>
                            <asp:HyperLink ID="hylSertifikaSil" NavigateUrl='<%# "AdminSertifikaSil.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-danger btn-sm">Sil</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
    </form>
</asp:Content>
