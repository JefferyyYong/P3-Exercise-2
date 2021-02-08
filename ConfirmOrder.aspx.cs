using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3_Exercise_2
{
    public partial class ConfirmOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                CheckBox MenuNo1 = PreviousPage.FindControl("set1") as CheckBox;
                CheckBox MenuNo2 = PreviousPage.FindControl("set2") as CheckBox;
                CheckBox MenuNo3 = PreviousPage.FindControl("set3") as CheckBox;
                TextBox Quantity1 = PreviousPage.FindControl("qs1") as TextBox;
                TextBox Quantity2 = PreviousPage.FindControl("qs2") as TextBox;
                TextBox Quantity3 = PreviousPage.FindControl("qs3") as TextBox;
                Label TotalPrice = PreviousPage.FindControl("lblTotalPrice") as Label;

                if (!string.IsNullOrEmpty(Quantity3.Text))
                {
                    if (!string.IsNullOrEmpty(Quantity2.Text))
                    {
                        if (!string.IsNullOrEmpty(Quantity1.Text))
                        {
                            lblOrder.Text = Quantity1.Text + "- Menu " + MenuNo1.Text + "</br>" +
                               Quantity2.Text + "- Menu " + MenuNo2.Text + "</br>" +
                               Quantity3.Text + "- Menu " + MenuNo3.Text + "</br>" +
                               "Total Price = RM " + TotalPrice.Text;
                        }
                        else
                        {
                            lblOrder.Text =
                                  Quantity2.Text + "- Menu " + MenuNo2.Text + "</br>" +
                                  Quantity3.Text + "- Menu " + MenuNo3.Text + "</br>" +
                                  "Total Price = RM " + TotalPrice.Text;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(Quantity1.Text))
                        {
                            lblOrder.Text = Quantity1.Text + "- Menu " + MenuNo1.Text + "</br>" +
                               Quantity3.Text + "- Menu " + MenuNo3.Text + "</br>" +
                               "Total Price = RM " + TotalPrice.Text;
                        }
                        else
                        {
                            lblOrder.Text =
                                  Quantity3.Text + "- Menu " + MenuNo3.Text + "</br>" +
                                  "Total Price = RM " + TotalPrice.Text;
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Quantity2.Text))
                    {
                        if (!string.IsNullOrEmpty(Quantity1.Text))
                        {
                            lblOrder.Text = Quantity1.Text + "- Menu " + MenuNo1.Text + "</br>" +
                               Quantity2.Text + "- Menu " + MenuNo2.Text + "</br>" +
                               "Total Price = RM " + TotalPrice.Text;
                        }
                        else
                        {
                            lblOrder.Text =
                                  Quantity2.Text + "- Menu " + MenuNo2.Text + "</br>" +
                                  "Total Price = RM " + TotalPrice.Text;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(Quantity1.Text))
                        {
                            lblOrder.Text = Quantity1.Text + "- Menu " + MenuNo1.Text + "</br>" +
                               "Total Price = RM " + TotalPrice.Text;
                        }
                        else
                        {
                            lblOrder.Text =
                                  "Total Price = RM " + TotalPrice.Text;
                        }
                    }
                }
                
            }
            lblTimeNow.Text = DateTime.Now.ToString("hh:mm tt");
            DateTime Receive = DateTime.Now.AddMinutes(25);
            lblReceiveTime.Text = Receive.ToString("hh:mm tt");
            Response.Write("<script>alert('This page is to confirm your breakfast order')</script>");

        }
    }
}