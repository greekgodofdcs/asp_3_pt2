using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCourse : System.Web.UI.Page
{
    studDataClassesDataContext dbstud;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtClass.Text != " ")
        {
            dbstud = new studDataClassesDataContext();
            TblCourse course = new TblCourse();

            course.Cname = txtClass.Text;

            dbstud.TblCourses.InsertOnSubmit(course);
            dbstud.SubmitChanges();

            txtClass.Text = " ";
        }
        else
        {
            lblmsg.Text = "Please Enter Class Name";
            lblmsg.CssClass = "text-danger";
        }
    }
}