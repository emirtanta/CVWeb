using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //id değerini diğer formdan aldık
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            txtEgitimId.Enabled = false;
            txtEgitimId.Text = x.ToString();

            if (Page.IsPostBack == false)
            {
                //güncelleme formunda nesneleri verileri getirme

                DataSet1TableAdapters.TblEgitimTableAdapter dt = new DataSet1TableAdapters.TblEgitimTableAdapter();
                txtEgitimBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                txtEgitimAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                txtEgitimAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                txtEgitimGenelNot.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
                txtEgitimTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH.ToShortDateString();

                //güncelleme formunda nesneleri verileri getirme bitti
            }
        }

        protected void btnEgitimGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblEgitimTableAdapter dt = new DataSet1TableAdapters.TblEgitimTableAdapter();
            dt.EgitimGuncelle(txtEgitimBaslik.Text, txtEgitimAltBaslik.Text, txtEgitimAciklama.Text,txtEgitimGenelNot.Text, txtEgitimTarih.Text, Convert.ToInt16(txtEgitimId.Text));

            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}