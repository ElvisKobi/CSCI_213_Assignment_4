using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class ooooooooooo : System.Web.UI.Page
    {
        KarateSchoolDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\elvis\\source\\repos\\CSCI_213_Assignment_4\\App_Data\\KarateSchool(1).mdf;Integrated Security=True";
      
      
        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KarateSchoolDataContext(conn);
            var result = from x in dbcon.Members
                         select x;
            GridView1.DataSource = result;
            GridView1.DataBind();

        }
    }
}