using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MusicLogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection sql = new SqlConnection(@"data source=DESKTOP-BQFV1CO\SQLEXPRESS;initial catalog=WebMvcDB;integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from TBLLOGIN where KULLANICI=@P1 AND SIFRE=@P2",sql);
            cmd.Parameters.AddWithValue("@P1",TextBox1.Text);
            cmd.Parameters.AddWithValue("@P2",TextBox2.Text);
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("https://www.youtube.com/watch?v=jfKfPfyJRdk");
            }
            else
            {
                Response.Write("Hatalı Giriş Yaptınız. Tekrar deneyiniz.");
            }
            sql.Close();
        }
    }
}