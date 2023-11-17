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
        KarateSchoolDataContext dbcon2;
        protected void Page_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\elvis\\source\\repos\\CSCI_213_Assignment_4\\App_Data\\KarateSchool(1).mdf;Integrated Security=True";
            dbcon = new KarateSchoolDataContext(conn);
            dbcon2 = new KarateSchoolDataContext(conn);

            // Select all records from the member table
            var result = from item in dbcon.Members
                                                  select item;

            // Add it to the GridView1
            GridView1.DataSource = result;
            GridView1.DataBind();

            // Select all Records from the Instructors Table
            var instructor = from item in dbcon2.Instructors
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

            // Create Instance of the NetUser Table
            NetUser newUser = new NetUser();
            newUser.UserName = usernameTextBox.Text;
            newUser.UserPassword = passwordTextBox.Text;
            newUser.UserType = usertypeDropDown.SelectedValue;

            // Insert the data into NetUser table
            dbcon.NetUsers.InsertOnSubmit(newUser);
            dbcon.SubmitChanges();

            //Select the UserId 
            var userId = (from item in dbcon.NetUsers
                          where item.UserType == usernameTextBox.Text
                          select item.UserID).First();

            // Create Instance of the Member Tabel
            Member member = new Member();
            member.Member_UserID = userId;
            member.MemberFirstName = MemberFirstNameTxt.Text;
            member.MemberLastName = MemberLastNameTxt.Text;
            member.MemberDateJoined = Convert.ToDateTime(MemberDateTxt.Text);
            member.MemberPhoneNumber = MemberPhoneTxt.Text;
            member.MemberEmail = MemberEmailTxt.Text;

            // Checking the user type 
            if (usertypeDropDown.SelectedValue == "Instructor")
            {
                Console.WriteLine("Change the User Type to member or fill up the instructor form.");
            }

            else
            {
                dbcon.Members.InsertOnSubmit(member);
                dbcon.SubmitChanges() ;
            }
        }

        protected void MemberFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void InstructorBtn_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\" +
                         "Users\\elvis\\OneDrive\\Desktop\\Project 4\\Assignment_4\\App_Data\\" +
                         "KarateSchool(1).mdf\";Integrated Security=True";

            dbcon = new KarateSchoolDataContext(conn);

            // Create Instance of the NetUser Table
            NetUser newUser = new NetUser();
            newUser.UserName = usernameTextBox.Text;
            newUser.UserPassword = passwordTextBox.Text;
            newUser.UserType = usertypeDropDown.SelectedValue;

            // Insert the data into NetUser table
            dbcon.NetUsers.InsertOnSubmit(newUser);
            dbcon.SubmitChanges();

            // Select the UserId 
            var userId = (from item in dbcon.NetUsers
                          where item.UserType == usernameTextBox.Text
                          select item.UserID).First();

            // Create Instance of the Instructor Tabel
            Instructor instructor = new Instructor();
            instructor.InstructorID = userId;
            instructor.InstructorFirstName = FirstNameTextBox.Text;
            instructor.InstructorLastName = LastNameTextBox.Text;
            instructor.InstructorPhoneNumber = PhoneNumberTextBox.Text;

            // Checking the user type
            if (usertypeDropDown.SelectedValue == "Member")
            {
                Console.WriteLine("Change the User Type to Instructor or fill up the member form.");
            }

            else
            {   
                dbcon.Instructors.InsertOnSubmit(instructor);
                dbcon.SubmitChanges();
            }

        }
    }
}