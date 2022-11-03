using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //id değerini diğer formdan aldık
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            txtHobiId.Enabled = false;
            txtHobiId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                //güncelleme formunda nesneleri verileri getirme

                DataSet1TableAdapters.TblHobiTableAdapter dt = new DataSet1TableAdapters.TblHobiTableAdapter();
                txtHobiAdi.Text = dt.HobiGetir(Convert.ToInt16(id))[0].Hobi;

                //güncelleme formunda nesneleri verileri getirme bitti
            }
        }

        protected void btnHobiGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHobiTableAdapter dt = new DataSet1TableAdapters.TblHobiTableAdapter();
            dt.HobiGuncelle(txtHobiAdi.Text, Convert.ToInt16(txtHobiId.Text));

            Response.Redirect("AdminHobiler.aspx");
        }
    }
}