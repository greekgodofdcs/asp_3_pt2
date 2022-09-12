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
    public partial class editEmployee : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_data();
                load_dropdown();
            }
        }

        protected void load_data()
        {
            da = new SqlDataAdapter("select * from Emp", cn);
            ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            ds.Dispose();
            da.Dispose();
        }

        protected void load_dropdown()
        {
            da = new SqlDataAdapter("select * from Department", cn);
            ds = new DataSet();
            da.Fill(ds);
            dldept.DataSource = ds;
            dldept.DataBind();
            dldept.DataTextField = "dept_name";
            dldept.DataValueField = "dept_id";
            dldept.DataBind();
            ds.Dispose();
            da.Dispose();

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


        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select * from Emp where eno='" + txtempno.Text + "'", cn);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    dr[3] = dldesig.SelectedItem;
                    dr[4] = dldept.SelectedItem;
                    dr[5] = txtsalary.Text;

                    cb = new SqlCommandBuilder(da);
                    da.UpdateCommand = cb.GetUpdateCommand();
                    da.Update(ds);
                    lblmsg.Text = "Update Details Successfully";

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
                load_data();
                cb.Dispose();
                ds.Dispose();
                da.Dispose();
            }
        }

        protected void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select * from Emp where eno ='" + txtempno.Text + "'", cn);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtsalary.Text = dr[5].ToString();
                    lbldept.Text = dr[4].ToString();
                    lbldesig.Text = dr[3].ToString();
                }
                else
                {
                    lblmsg.Text = "No Data Found";
                }
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                ds.Dispose();
                da.Dispose();
                txtempno.Text = null;
                txtsalary.Text = null;
                lbldesig.Text = null;
                lbldept.Text = null;
            }
        }
    }
}