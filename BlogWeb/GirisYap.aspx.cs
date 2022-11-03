using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class GirisYap : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LENEVO-PC\LENEVOSERVER;Initial Catalog=WebFormCVDB;User ID=sa;Password=123");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //giriş yap butonu
        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from TblAdmin where KULLANICI=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Response.Redirect("AdminDeneyimler.aspx");
            }

            else
            {
                Response.Write("Hatalı kullanıcı ya da şifre");
            }

            baglanti.Close();
        }
    }
}