using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class LogIn : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KarateSchoolDataContext(conn);
            UnobtrusiveValidationMode =
    UnobtrusiveValidationMode.None;
        }
        KarateSchoolDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\elvis\\OneDrive\\Desktop\\" +
                     "Project 4\\Assignment_4\\App_Data\\KarateSchool(1).mdf\";Integrated Security=True";
        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            NetUser user = (from person in dbcon.NetUsers
                            select person).FirstOrDefault();
            
        }
    }
}