using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class Administrator : System.Web.UI.Page
    {
        KarateSchoolDataContext dbcon;
        protected void Page_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\" +
                          "Users\\elvis\\OneDrive\\Desktop\\Project 4\\Assignment_4\\App_Data\\" +
                          "KarateSchool(1).mdf\";Integrated Security=True";

            dbcon = new KarateSchoolDataContext(conn);

            // Select all records from the member table
            var result = from item in dbcon.Members
                         orderby item.MemberFirstName, item.MemberLastName, item.MemberPhoneNumber, item.MemberDateJoined
                         select item;

            // Add it to the GridView1
            GridView1.DataSource = result;
            GridView1.DataBind();

            // Select all Records from the Instructors Table
            var instructor = from item in dbcon.Instructors
                                    orderby item.InstructorFirstName, item.InstructorLastName
                                    select new
                                    {
                                        item.InstructorFirstName,
                                        item.InstructorLastName
                                    };

            // Add it to the GridView2
            GridView2.DataSource = instructor;
            GridView2.DataBind();
            

        }

        protected void MemberCreateBtn_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\" +
                         "Users\\elvis\\OneDrive\\Desktop\\Project 4\\Assignment_4\\App_Data\\" +
                         "KarateSchool(1).mdf\";Integrated Security=True";

            dbcon = new KarateSchoolDataContext(conn);

            // Create Instance of the Member Table
            //Member NewMember = new Member();
           // NetUser user = new NetUser();
            //NewMember.Member_UserID = NetUser.
        }

        protected void MemberFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}