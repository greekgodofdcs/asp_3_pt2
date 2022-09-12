using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class delStud : System.Web.UI.Page
{
    studDataClassesDataContext dbstud;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            load_ddlCourse();
        }
    }
    protected void load_ddlCourse()
    {
        dbstud = new studDataClassesDataContext();
        var c = from course in dbstud.TblCourses
                select course;
        ddlCourse.DataSource = c;
        ddlCourse.DataTextField = "course_name";
        ddlCourse.DataValueField = "Course";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("--Select Class--", "0"));
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        dbstud = new studDataClassesDataContext();
        var s = from stud in dbstud.TblStudents
                where stud.Course == ddlCourse.SelectedValue && stud.RollNo ==txtRno.Text
                select stud;
        foreach(var stud in s)
        {
            dbstud.TblStudents.DeleteOnSubmit(stud);
        }
        dbstud.SubmitChanges();
    }
}