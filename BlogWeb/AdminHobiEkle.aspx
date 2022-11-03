<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiEkle.aspx.cs" Inherits="BlogWeb.AdminHobiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="txtHobiAdi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="btnHobiEkle" runat="server" CssClass="btn btn-primary" Text="Ekle" OnClick="btnHobiEkle_Click"     />

        </div>
    </form>
</asp:Content>
