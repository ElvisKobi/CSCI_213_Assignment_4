using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class Logon : System.Web.UI.Page
    {
        KarateSchoolDataContext dbcon;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            dbcon = new KarateSchoolDataContext(ConnectionString.conn);
            string name = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            NetUser user;

            //try to find user with credentials
            try
            {
                user = (from x in dbcon.NetUsers
                        where (x.UserName == name) && (x.UserPassword == password)
                        select x).First();
            } 
            catch //if unable to find user, display error message
            {
                errorlbl.Text = "Invalid login credentials. Please try again.";
                return;
            }
            
            if (user.UserType == "Member") //redirect to member page
            {
                HttpContext.Current.Session["userID"] = user.UserID;
                Response.Redirect("Member.aspx", true);
            }
            else if (user.UserType == "Instructor") //redirect to instructor page
            {
                HttpContext.Current.Session["userID"] = user.UserID;
                Response.Redirect("Instructor.aspx", true);
            }
            else if (user.UserType == "Administrator") //redirect to administrator page
            {
                Response.Redirect("Administrator.aspx", true);
            }
        }
    }
}