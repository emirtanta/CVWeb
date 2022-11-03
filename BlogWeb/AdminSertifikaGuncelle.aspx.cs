using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminSertifikaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //id değerini diğer formdan aldık
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            txtSertifikaId.Enabled = false;
            txtSertifikaId.Text = x.ToString();

            if (Page.IsPostBack == false)
            {
                //güncelleme formunda nesneleri verileri getirme

                DataSet1TableAdapters.TblSertifikaTableAdapter dt = new DataSet1TableAdapters.TblSertifikaTableAdapter();

                txtSertifikaKurumAdi.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].KURUM;
                txtSertifikaAdi.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].AD;
                txtSertifikaTarih.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].TARIH.ToShortDateString(); 
                txtSertifikaAciklama.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].ACIKLAMA;

                //güncelleme formunda nesneleri verileri getirme bitti
            }
        }

        protected void btnSertifikaGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblSertifikaTableAdapter dt = new DataSet1TableAdapters.TblSertifikaTableAdapter();
            dt.SertifikaGuncelle(txtSertifikaKurumAdi.Text, txtSertifikaAdi.Text, txtSertifikaTarih.Text, txtSertifikaAciklama.Text, Convert.ToInt16(txtSertifikaId.Text));

            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}