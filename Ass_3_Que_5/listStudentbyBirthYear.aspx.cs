using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

public partial class listStudentbyBirthYear : System.Web.UI.Page
{
    studDataClassesDataContext dbstud;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        dbstud = new studDataClassesDataContext();
        var s = from stud in dbstud.TblStudents
                where (Convert.ToDateTime(stud.DOB).Year)==Convert.ToInt16(txtYear.Text)
                select stud;
        gvStud.DataSource = s;
        gvStud.DataBind();
    }
}