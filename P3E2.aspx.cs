using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3_Exercise_2
{
    public partial class P3E2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rblSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblSet.SelectedItem.Text == "Set 1")
            {
                lblDetail.Text = "<u>Menu Set 1</u> </br>" + "Nasi Lemak </br> Chichken Rendang </br>" +
                    "Teh Tarik </br> <strong>RM 12.50</strong>";
            }
            else if (rblSet.SelectedItem.Text == "Set 2")
            {
                lblDetail.Text = "<u>Menu Set 2</u> </br>" + "Mee Goreng </br> Fried Egg </br>" +
                    "Teh Tarik </br> <strong>RM 8.50</strong>";
            }
            else if (rblSet.SelectedItem.Text == "Set 3")
            {
                lblDetail.Text = "<u>Menu Set 3</u> </br>" + "Chicken sausages </br> Omelette </br>" +
                "Red beans </br>" + "Coffee </br> <strong>RM 10.50</strong>";
            }
        }

        protected void set1_CheckedChanged(object sender, EventArgs e)
        {
            if(set1.Checked == true)
            {
                double quantity;
                if (string.IsNullOrEmpty(qs1.Text))
                {
                    quantity = 1;
                    qs1.Text = "1";
                }
                else
                {
                    quantity = double.Parse(qs1.Text);
       
                }
                double s1Total = 12.50 * quantity;
                lblPriceSet1.Text = s1Total.ToString("0.00");
            }
            else
            {
                qs1.Text = null;
                lblPriceSet1.Text = null;
            }

        }

        protected void set2_CheckedChanged(object sender, EventArgs e)
        {
            if (set2.Checked == true)
            {
                double quantity;
                if (string.IsNullOrEmpty(qs2.Text))
                {
                    quantity = 1;
                    qs2.Text = "1";
                }
                else
                {
                    quantity = double.Parse(qs2.Text);
                    
                }
                double s2Total = 8.50 * quantity;
                lblPriceSet2.Text = s2Total.ToString("0.00");
            }
            else
            {
                qs2.Text = null;
                lblPriceSet2.Text = null;
            }
        }

        protected void set3_CheckedChanged(object sender, EventArgs e)
        {
            if (set3.Checked == true)
            {
                double quantity;

                if (string.IsNullOrEmpty(qs3.Text))
                {
                    quantity = 1;
                    qs3.Text = "1";
                }
                else
                {
                    quantity = double.Parse(qs3.Text);
                    
                }
                double s3Total = 10.50 * quantity;
                lblPriceSet3.Text = s3Total.ToString("0.00");
            }
            else
            {
                qs3.Text = null;
                lblPriceSet3.Text = null;
            }
        }

        protected void qs3_TextChanged(object sender, EventArgs e)
        {
            double quantity = double.Parse(qs3.Text);
            double s3Total = 10.50 * quantity;
            lblPriceSet3.Text = s3Total.ToString("0.00");
        }

        protected void qs1_TextChanged(object sender, EventArgs e)
        {
            double quantity = double.Parse(qs1.Text);
            double s1Total = 12.50 * quantity;
            lblPriceSet1.Text = s1Total.ToString("0.00");
        }

        protected void qs2_TextChanged(object sender, EventArgs e)
        {
            double quantity = double.Parse(qs2.Text);
            double s2Total = 8.50 * quantity;
            lblPriceSet2.Text = s2Total.ToString("0.00");
        }

        protected void calcBTN_Click(object sender, EventArgs e)
        {
            double quantity1;
            double quantity2;
            double quantity3;
                if (string.IsNullOrEmpty(qs1.Text))
                {
                    quantity1 = 0;
                }
                else
                {
                    quantity1 = double.Parse(qs1.Text);
                }

                if (string.IsNullOrEmpty(qs2.Text))
                {
                    quantity2 = 0;
                }
                else
                {
                    quantity2 = double.Parse(qs2.Text);
                }
                if (string.IsNullOrEmpty(qs3.Text))
                {
                    quantity3 = 0;
                }
                else
                {
                    quantity3 = double.Parse(qs3.Text);
                }
                double s1Total = 12.50 * quantity1;
                double s2Total = 8.50 * quantity2;
                double s3Total = 10.50 * quantity3;
                double totalPrice = 0;
                totalPrice = s1Total + s2Total + s3Total;
                lblTotalPrice.Text = totalPrice.ToString("0.00");
            }

        protected void cancBTN_Click(object sender, EventArgs e)
        {
            rblSet.ClearSelection();
            lblDetail.Text = "";
            set1.Checked = false;
            set2.Checked = false;
            set3.Checked = false;
            qs1.Text = "";
            qs2.Text = "";
            qs3.Text = "";
            lblPriceSet1.Text = "";
            lblPriceSet2.Text = "";
            lblPriceSet3.Text = "";
            lblTotalPrice.Text = "";
        }

        protected void cOBTN_Click(object sender, EventArgs e)
        {

        }
    }
}