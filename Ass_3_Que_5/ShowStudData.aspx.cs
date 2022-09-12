using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowStudData : System.Web.UI.Page
{
    studDataClassesDataContext DBStud;
    protected void Page_Load(object sender, EventArgs e)
    {
        load_gvStudDetail();
    }
    protected void load_gvStudDetail()
    {
        DBStud = new studDataClassesDataContext();
        var rec = from course in DBStud.TblCourses
                  join c in DBStud.TblClasses
                          on course.Course_Id equals c.Course_Id into courseclass
                  from cc in courseclass
                  join stud in DBStud.TblStudents
                          on cc.Course_Id equals stud.Course
                  select stud;
        gvStudDetail.DataSource = rec;
        gvStudDetail.DataBind();
    }
    
    protected void gvStudDetail_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var ernollno = gvStudDetail.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("~/updateStud.aspx?ernollno=" + ernollno);
    }

    protected void gvStudDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        var ernollno = gvStudDetail.DataKeys[e.RowIndex].Value.ToString();
        var s = from stud in DBStud.TblStudents
                where stud.EnRollNo == ernollno
                select stud;
        foreach(var i in s)
        {
            Response.Write(i);
            DBStud.TblStudents.DeleteOnSubmit(i);
        }
        DBStud.SubmitChanges();
        load_gvStudDetail();
    }
}