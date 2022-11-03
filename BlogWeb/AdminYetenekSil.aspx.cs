using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.TblYetenekTableAdapter dt = new DataSet1TableAdapters.TblYetenekTableAdapter();
            dt.YetenekSil(Convert.ToInt16(id));

            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}