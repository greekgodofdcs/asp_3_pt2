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
    public partial class AddEmployee : System.Web.UI.Page
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

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    string strname = FileUpload1.FileName.ToString();
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);
                    string path = "~/upload/" + strname;
                    lblfile.Visible = true;
                    lblfile.Text = "Image Uploaded successfully";

                
                da = new SqlDataAdapter("select * from Emp", cn);
                ds = new DataSet();
                da.Fill(ds);
                DataRow dr = ds.Tables[0].NewRow();
                dr[1] = txtname.Text;
                dr[2] = Convert.ToDateTime(txtdob.Text);
                dr[3] = dldesig.SelectedItem;
                dr[4] = dldept.SelectedItem;
                dr[5] = txtsalary.Text;
                dr[6] = path;
                ds.Tables[0].Rows.Add(dr);
                cb = new SqlCommandBuilder(da);
                da.UpdateCommand = cb.GetInsertCommand();
                da.Update(ds);
                lblmsg.Text = "Employee Details Add Successfully";
                    // clear_field();
                }
                else
                {
                    lblfile.Visible = true;
                    lblfile.Text = "Please upload the pdf";
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

    }
}