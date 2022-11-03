using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEgitimKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblEgitimTableAdapter dt = new DataSet1TableAdapters.TblEgitimTableAdapter();


            dt.EgitimEkle(txtEgitimBaslik.Text, txtEgitimAltBaslik.Text, txtEgitimAciklama.Text, txtEgitimGenelNot.Text, txtEgitimTarih.Text);

            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}