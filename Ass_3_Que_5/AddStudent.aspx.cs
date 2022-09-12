using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
{
    studDataClassesDataContext dbStud;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            load_ddlCourse();
        }
    }
    protected void load_ddlCourse()
    {
        dbStud = new studDataClassesDataContext();
        var c = from course in dbStud.TblCourses
                select course; 
        ddlCourse.DataSource = c;
        ddlCourse.DataTextField = "Cname";
        ddlCourse.DataValueField = "Course_Id";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("--Select Class--", "0"));
    }

    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbStud = new studDataClassesDataContext();
        var cl = from classes in dbStud.TblCourses
                 where classes.Course_Id == ddlCourse.SelectedValue
                 select classes;
        ddlClass.DataSource = cl;
        ddlClass.DataTextField = "Class_name";
        ddlClass.DataValueField = "Class_id";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0,new ListItem( "--Select Class--","0"));
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        dbStud = new studDataClassesDataContext();
        TblStudent s = new TblStudent();
        DateTime dobt = Convert.ToDateTime(txtDOB.Text);
        s.RollNo =txtRno.Text;
        s.Name = txtName.Text;
        s.Course = ddlCourse.SelectedValue;
        s.Class = ddlClass.SelectedValue;
        s.Email = txtEmail.Text;
        s.Mobile = txtMono.Text;
        s.DOB = dobt.ToShortDateString();

        dbStud.TblStudents.InsertOnSubmit(s);
        dbStud.SubmitChanges();

        txtRno.Text = " ";
        txtDOB.Text = "";
        txtEmail.Text = "";
        txtMono.Text = "";
        txtName.Text = "";
        ddlClass.SelectedIndex = 0;
        ddlCourse.SelectedIndex = 0;
    }
}