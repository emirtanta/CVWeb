<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSertifikaEkle.aspx.cs" Inherits="BlogWeb.AdminSertifikaEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Kurum Adı"></asp:Label>
                <asp:TextBox ID="txtSertifikaKurumAdi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label2" runat="server" Text="Sertifika Adı"></asp:Label>
                <asp:TextBox ID="txtSertifikaAdi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label3" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="txtSertifikaTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label4" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="txtSertifikaAciklama" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="btnSertifikaEkle" runat="server" CssClass="btn btn-primary" Text="Ekle" OnClick="btnSertifikaEkle_Click"  />

        </div>
    </form>
</asp:Content>
