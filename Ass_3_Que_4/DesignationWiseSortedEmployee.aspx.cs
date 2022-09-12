using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1
{
    public partial class DesignationWiseSortedEmployee : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Emp ORDER BY designation", cn);
            ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            ds.Dispose();
            da.Dispose();
        }
    }
}