using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHakkimdaTableAdapter dt = new DataSet1TableAdapters.TblHakkimdaTableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();

            //deneyimleri yükler
            DataSet1TableAdapters.TblDeneyimTableAdapter dt2 = new DataSet1TableAdapters.TblDeneyimTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            //eğitimleri yükler
            DataSet1TableAdapters.TblEgitimTableAdapter dt3 = new DataSet1TableAdapters.TblEgitimTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            //yetenekleri yükler
            DataSet1TableAdapters.TblYetenekTableAdapter dt4 = new DataSet1TableAdapters.TblYetenekTableAdapter();
            Repeater4.DataSource = dt4.YetenekListesi();
            Repeater4.DataBind();

            //hobileri yükler
            DataSet1TableAdapters.TblHobiTableAdapter dt5 = new DataSet1TableAdapters.TblHobiTableAdapter();
            Repeater5.DataSource = dt5.HobiListesi();
            Repeater5.DataBind();

            //sertifikaları yükler
            DataSet1TableAdapters.TblSertifikaTableAdapter dt6 = new DataSet1TableAdapters.TblSertifikaTableAdapter();
            Repeater6.DataSource = dt6.SertifikaListesi();
            Repeater6.DataBind();
        }
    }
}