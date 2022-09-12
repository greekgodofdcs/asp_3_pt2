using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class AddClass : System.Web.UI.Page
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
        DdlCourse.DataSource = c;
        DdlCourse.DataTextField = "Cname";
        DdlCourse.DataValueField = "Course_Id";
        DdlCourse.DataBind();
        DdlCourse.Items.Insert(0, new ListItem("--Select Class--", "0"));
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        dbstud = new studDataClassesDataContext();
        TblClass c = new TblClass();

        c.Class_Id = DdlCourse.SelectedValue;
        c.Class_Name = TxtClass.Text;

        dbstud.TblClasses.InsertOnSubmit(c);
        dbstud.SubmitChanges();
        TxtClass.Text = " ";
        DdlCourse.SelectedIndex = 0;
    }
}