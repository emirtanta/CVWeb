<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimEkle.aspx.cs" Inherits="BlogWeb.AdminEgitimEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="txtEgitimBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label2" runat="server" Text="Alt Başlık" ></asp:Label>
                <asp:TextBox ID="txtEgitimAltBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label3" runat="server" Text="Tarih" ></asp:Label>
                <asp:TextBox ID="txtEgitimTarih" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>

            </div>

            <br />

            <div>
                <asp:Label ID="Label4" runat="server" Text="Açıklama" ></asp:Label>
                <asp:TextBox ID="txtEgitimAciklama" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label5" runat="server" Text="Genel Not" ></asp:Label>
                <asp:TextBox ID="txtEgitimGenelNot" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="btnEgitimKaydet" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="btnEgitimKaydet_Click"   />

        </div>
    </form>
</asp:Content>
