using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonus_assignment
{
    public partial class RaffleBundle : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int ticketNum = Convert.ToInt32(ticket_num.Text);
                double total = 0;
                int leftOverCount = ticketNum;
                ticket_summary.InnerHtml = "";
                if (ticketNum < 50)//first case number of tickets is less that 50
                 {
                    printTicketSummary(1, ticketNum);//call to method with bundle size based on the ticket num
                 }
                 else if (ticketNum > 50 && ticketNum < 151)//in between 50 and 151
                 {
                    printTicketSummary(2, ticketNum);//call to method with bundle size based on the ticket num
                }
                else if (ticketNum > 150 && ticketNum < 301)//in between 150 and 301
                {
                    printTicketSummary(3, ticketNum);//call to method with bundle size based on the ticket num
                }
                else if (ticketNum > 300)//greater than 300
                {
                    printTicketSummary(5, ticketNum);//call to method with bundle size based on the ticket num
                }

                total = (double)ticketNum * 0.25;//multiply by ticket amount
                // Display string representations of numbers for en-us culture
                //documentation located at https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#example
                System.Globalization.CultureInfo ci = new CultureInfo("en-us");
                //So that the dollar amount is corrected to 2 decimal places
                ticket_summary.InnerHtml += "Your total is " + total.ToString("C", ci) + "CAD!";
                



            }
        }
        protected void printTicketSummary(int bundleSize, int ticketNum)
        {
            int leftOverCount = ticketNum;
            ticket_summary.InnerHtml = "";
            for (int i = bundleSize; i <= ticketNum; i+=bundleSize)//increment by bundle size
                {
                    leftOverCount -= bundleSize;
                    ticket_summary.InnerHtml += "You received a bundle of "+bundleSize+"! That’s " + i + " ticket(s)!<br>";
                }
            if (leftOverCount != 0)//check if there are any leftover tickets
            {
                //then print the rest of them out
                ticket_summary.InnerHtml += "Your leftover is " + leftOverCount + " ticket(s). That’s " + ticketNum + " ticket(s)!<br>";
            }

        }
    }

}