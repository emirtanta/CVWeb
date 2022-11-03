<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiGuncelle.aspx.cs" Inherits="BlogWeb.AdminHobiGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
                <asp:TextBox ID="txtHobiId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="txtHobiAdi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="btnHobiGuncelle" runat="server" CssClass="btn btn-info" Text="Güncelle" OnClick="btnHobiGuncelle_Click"     />

        </div>
    </form>
</asp:Content>
