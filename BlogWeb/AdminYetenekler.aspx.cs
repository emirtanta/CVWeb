using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TblYetenekTableAdapter dt = new DataSet1TableAdapters.TblYetenekTableAdapter();

                Repeater1.DataSource = dt.YetenekListesi();
                Repeater1.DataBind();
            }
        }
    }
}