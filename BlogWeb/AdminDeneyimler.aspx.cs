using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack==false)
            {
                DataSet1TableAdapters.TblDeneyimTableAdapter dt = new DataSet1TableAdapters.TblDeneyimTableAdapter();

                Repeater1.DataSource = dt.DeneyimListesi();
                Repeater1.DataBind();
            }
        }
    }
}