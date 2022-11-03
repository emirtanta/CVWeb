using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminHobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHobiEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHobiTableAdapter dt = new DataSet1TableAdapters.TblHobiTableAdapter();


            dt.HobiEkle(txtHobiAdi.Text);

            Response.Redirect("AdminHobiler.aspx");
        }
    }
}