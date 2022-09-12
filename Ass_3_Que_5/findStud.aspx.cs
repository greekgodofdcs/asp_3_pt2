using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class findStud : System.Web.UI.Page
{
    studDataClassesDataContext dbStud;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void load_ddlCourse()
    {
        dbStud = new studDataClassesDataContext();
        var c = from course in dbStud.TblCourses
                select course;
        ddlCourse.DataSource = c;
        ddlCourse.DataTextField = "course_name";
        ddlCourse.DataValueField = "course_id";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("--Select Class--", "0"));
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        dbStud=new studDataClassesDataContext();
        if (ddlCourse.Visible)
        {
            var c = from stud in dbStud.TblStudents
                    where stud.Name == txtName.Text && stud.Course==ddlCourse.SelectedValue
                    select stud;
            gvstud.DataSource = c;
            gvstud.DataBind();
        }
        else
        {
            var c = from stud in dbStud.TblStudents
                    where stud.Name==txtName.Text
                    select stud;
            if (c.Count() > 1)
            {
                ddlCourse.Visible = true;
                lblCourse.Visible = true;
                load_ddlCourse();
            }
            else
            {
                gvstud.DataSource = c;
                gvstud.DataBind();
            }
        }
    }
}