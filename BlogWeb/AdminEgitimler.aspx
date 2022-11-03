<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimler.aspx.cs" Inherits="BlogWeb.AdminEgitimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">

        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/AdminEgitimEkle.aspx" runat="server" CssClass="btn btn-success">Ekle</asp:HyperLink>

        <table class="table table-hover">

        <tr>
            <th>#</th>
            <th>Başlık</th>
            <th>Alt Başlık</th>
            <th>Açıklama</th>
            <th>Genel No</th>
            <th>Tarih</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("BASLIK") %></td>
                        <td><%# Eval("ALTBASLIK") %></td>
                        <td><%# Eval("ACIKLAMA") %></td>
                        <td><%# Eval("GNOT") %></td>
                        <td><%# Eval("TARIH") %></td>
                        <td>
                            <asp:HyperLink ID="hylDeneyimGuncelle" NavigateUrl='<%# "AdminEgitimGuncelle.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-info btn-sm">Güncelle</asp:HyperLink>
                            <asp:HyperLink ID="hylDeneyimSil" NavigateUrl='<%# "AdminEgitimSil.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-danger btn-sm">Sil</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
    </form>
</asp:Content>
