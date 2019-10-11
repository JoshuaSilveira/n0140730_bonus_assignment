using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonus_assignment
{
    public partial class Weekly_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)//so the list is printed only when submit is hit
            {
                //Internal List of days
                List<string> Days = new List<string>();
                Days.Add("Monday");
                Days.Add("Tuesday");
                Days.Add("Wednesday");
                Days.Add("Thursday");
                Days.Add("Friday");
                Days.Add("Saturday");
                Days.Add("Sunday");



                month_summary.InnerHtml = " ";//set the summary to be empty
                int listIterator = 1;//start from tuesday since october starts with a tuesday

                for (int i = 1; i <= 31; i++)
                {
                    ListItem day = week_schedule.Items[listIterator];//grab the current day from checkbox list
                    if (day.Selected == true)
                    {//if checkbox is selected then time to work or study
                        month_summary.InnerHtml += "Oct " + i + " is a " + Days[listIterator] + "! Time to work/study" + "<br>";

                    }
                    else
                    {//other wise you get the day off
                        month_summary.InnerHtml += "Oct " + i + " is a " + Days[listIterator] + "! you get the day off!!" + "<br>";
                    }

                    listIterator++;//increment day
                    if (listIterator > 6)//if the iterator reaches the end of the week
                    {
                        listIterator = 0;//loop back to the start
                    }

                }
            }
        }
    }
}