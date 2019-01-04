using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataAndTime2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Initize a specific date in the past/future
            DateTime myValue = new DateTime(1942, 8, 28);
            //Day of the year
            resultLabel.Text = myValue.ToLongDateString();
        }
         
           
    }
}