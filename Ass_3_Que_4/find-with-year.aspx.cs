using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class find_with_year : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string q = "select * from student where dob='" + txtyear.Text + "'";
                cmd = new SqlCommand(q, cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    lblmsg.Text = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                cn.Close();
            }
        }
    }
}