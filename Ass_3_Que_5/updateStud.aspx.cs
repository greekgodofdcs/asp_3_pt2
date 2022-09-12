using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateStud : System.Web.UI.Page
{
    studDataClassesDataContext dbStud;
    protected void Page_Load(object sender, EventArgs e)
    {
        hdnErnollno.Value = Request.QueryString["ernollno"];
        if (!IsPostBack)
        {
            load_data();
        }
    }
    protected void load_data()
    {
        Int64 Ernollno = Convert.ToInt64(Request.QueryString["ernollno"]);
        dbStud = new studDataClassesDataContext();
        var s = from stud in dbStud.TblStudents
                where stud.EnRollNo ==Convert.ToString( Ernollno)
                select stud;
        foreach(var stud in s) { 
            txtMono.Text = stud.Mobile;
            txtEmail.Text = stud.Email;
            
            DateTime dt = Convert.ToDateTime(stud.DOB);
            txtDOB.Text =dt.ToString("MM/dd/yyyy");
            Response.Write(stud.DOB+" "+dt+" "+txtDOB.Text);
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        dbStud = new studDataClassesDataContext();
        var s = from stud in dbStud.TblStudents
                where stud.EnRollNo == hdnErnollno.Value
                select stud;

        foreach (var stud in s)
        {
            stud.Email = txtEmail.Text;
            stud.Mobile = txtMono.Text;
            DateTime dobt = Convert.ToDateTime(txtDOB.Text);
            stud.DOB = dobt.ToShortDateString();
        }

        dbStud.SubmitChanges();
    }
}