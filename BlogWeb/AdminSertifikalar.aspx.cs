using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminSertifikalar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TblSertifikaTableAdapter dt = new DataSet1TableAdapters.TblSertifikaTableAdapter();

                Repeater1.DataSource = dt.SertifikaListesi();
                Repeater1.DataBind();
            }
        }
    }
}