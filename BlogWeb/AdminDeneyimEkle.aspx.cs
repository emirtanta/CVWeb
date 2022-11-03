using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblDeneyimTableAdapter dt = new DataSet1TableAdapters.TblDeneyimTableAdapter();

           

            dt.DeneyimEkle(TextBox1.Text, TextBox2.Text,"", TextBox4.Text);

            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}