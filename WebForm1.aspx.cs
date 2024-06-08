using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBaseCommunication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            /*  SqlConnection sc = new SqlConnection("data source" +
                  "=DESKTOP-KVGH71D;database=[ADO.NET Connection];integrated security=true");
              SqlCommand cmd = new SqlCommand("select * from student", sc);
              sc.Open();
              SqlDataReader dr = cmd.ExecuteReader();
              Gvstudent.DataSource = dr;
              Gvstudent.DataBind();
              sc.Close();*/

            using (SqlConnection sc = new SqlConnection("data source=DESKTOP-KVGH71D;database=[ADO.NET Connection];integrated security=true"))
            {
                SqlCommand cmd = new SqlCommand("select * from student", sc);
                sc.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Gvstudent.DataSource = dr;
                Gvstudent.DataBind();
               // when we use using there will not need to close connection.
            }
        }
    }
}