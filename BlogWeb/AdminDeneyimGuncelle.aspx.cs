using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //id değerini diğer formdan aldık
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            txtId.Enabled = false;
            txtId.Text = x.ToString();

            if (Page.IsPostBack==false)
            {
                //güncelleme formunda nesneleri verileri getirme

                DataSet1TableAdapters.TblDeneyimTableAdapter dt = new DataSet1TableAdapters.TblDeneyimTableAdapter();
                txtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                txtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                txtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                txtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH.ToShortDateString();

                //güncelleme formunda nesneleri verileri getirme bitti
            }


        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblDeneyimTableAdapter dt = new DataSet1TableAdapters.TblDeneyimTableAdapter();
            dt.DeneyimGucelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtTarih.Text, Convert.ToInt16(txtId.Text));

            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}