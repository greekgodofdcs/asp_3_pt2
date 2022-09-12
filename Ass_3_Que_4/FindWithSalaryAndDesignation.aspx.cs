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
    public partial class FindWithSalaryAndDesignation : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                da = new SqlDataAdapter("select * from Designation", cn);
                ds = new DataSet();
                da.Fill(ds);
                dldesig.DataSource = ds;
                dldesig.DataBind();
                dldesig.DataTextField = "desg_name";
                dldesig.DataValueField = "desg_id";
                dldesig.DataBind();
                ds.Dispose();
                da.Dispose();
            }
        }

        protected void btnfind_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Emp where salary>'" + txtsalary.Text + "' and designation= '" + dldesig.SelectedItem + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmsg.Text = "No Data Found.";
            }
            if (ds.Tables[0].Rows.Count > 0)
            {

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}