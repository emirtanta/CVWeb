using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //id değerini diğer formdan aldık
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            txtYetenekId.Enabled = false;
            txtYetenekId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                //güncelleme formunda nesneleri verileri getirme

                DataSet1TableAdapters.TblYetenekTableAdapter dt = new DataSet1TableAdapters.TblYetenekTableAdapter();
                txtYetenekAdi.Text = dt.YetenekGetir(Convert.ToInt16(id))[0].YETENEK;

                //güncelleme formunda nesneleri verileri getirme bitti
            }
        }

        protected void btnYetenekGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblYetenekTableAdapter dt = new DataSet1TableAdapters.TblYetenekTableAdapter();
            dt.YetenekGuncelle(txtYetenekAdi.Text, Convert.ToInt16(txtYetenekId.Text));

            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}