using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminSertifikaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSertifikaEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblSertifikaTableAdapter dt = new DataSet1TableAdapters.TblSertifikaTableAdapter();


            dt.SertifikaEkle(txtSertifikaKurumAdi.Text,txtSertifikaAdi.Text,txtSertifikaTarih.Text,txtSertifikaAciklama.Text);

            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}