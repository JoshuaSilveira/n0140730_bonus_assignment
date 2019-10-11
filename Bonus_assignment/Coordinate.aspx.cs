using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonus_assignment
{
    public partial class Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)// prints the quadrant only if inputs are recieved
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    int x = Convert.ToInt32(x_value.Text);
                    int y = Convert.ToInt32(y_value.Text);
                    position_summary.InnerHtml = "";//empty summary

                    if (x > 0 && y > 0)//check which side of 0 the two values are and print accordingly
                    {
                        position_summary.InnerHtml = "Quadrant 1";
                    }
                    else if (x < 0 && y > 0)
                    {
                        position_summary.InnerHtml = "Quadrant 2";
                    }
                    else if (x < 0 && y < 0)
                    {
                        position_summary.InnerHtml = "Quadrant 3";
                    }
                    else
                    {
                        position_summary.InnerHtml = "Quadrant 4";
                    }
                }
            }
        }
        protected void NumIsNotZero(object sender, ServerValidateEventArgs e)//validate for 0,0 coordinate
        {
            bool NumisInt = Int32.TryParse(e.Value, out int coordinate);
            if (!NumisInt)
            {
                e.IsValid = false;
            }
            else if (coordinate == 0)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }
    }
}