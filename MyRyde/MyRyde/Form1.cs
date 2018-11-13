using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRyde
{
    public partial class frm_start : Form
    {
        public frm_start()
        {
            InitializeComponent();
        }

        private void frm_start_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            String err_msg = "";
            int flag = 0;
            double distance = 0;
            

            if (txt_from.Text.Trim() == "")
                err_msg = "Please Enter 'From Location'";
            else if (txt_to.Text.Trim() == "")
                err_msg = "Please Enter 'To Location'";
            else
            {
                if(rb_direct.Checked == false && rb_pool.Checked == false)
                    err_msg = "Please Select Ride Type";
            }

            if(err_msg != "")
            { 
            MessageBox.Show(err_msg, "Ryde",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if((txt_from.Text == "275 Yorkland Blvd" && txt_to.Text == "CN Tower") || (txt_from.Text == "CN Tower" && txt_to.Text == "275 Yorkland Blvd"))
                {
                    distance = 22.9;
                    flag = 0;
                }
                else if ((txt_from.Text == "Fairview Mall" && txt_to.Text == "Tim Hortons") || (txt_from.Text == "Tim Hortons" && txt_to.Text == "Fairview Mall"))
                {
                    distance = 1.2;
                    flag = 0;
                }
                else
                {
                    flag = 1;
                    MessageBox.Show("Please enter valid combination of from/to locations", "Ryde", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                if (flag == 0)
                {

                    double minimum_fare = 5.50;
                    double base_fare = 2.50;
                    double distance_charge = .81;
                    double service_fees = 1.75;
                    


                    //Ryde Direct:   Base fare increases by 10% and per km charge increases by 15%

                    if (rb_direct.Checked == true)
                    {
                        base_fare += Math.Round((base_fare * 10) / 100,2);
                        distance_charge += Math.Round((distance_charge * 15) / 100, 2);

                    }

                    var date = DateTime.Now;
                    
                    //The price per km increases by 20% during peak hours (10am-12pm, 4-6pm, 8-9pm)
                    if ((date.Hour >=10 && date.Hour <= 11) || (date.Hour >= 16 && date.Hour <= 17) || (date.Hour == 20) || (date.Hour == 12 && date.Minute == 0) || (date.Hour == 18 && date.Minute == 0) || (date.Hour == 21 && date.Minute == 0))
                    {
                        distance_charge += Math.Round((distance_charge * 20) / 100, 2);
                    }

                    // Total Price
                    double total_price = Math.Round(base_fare + (distance * distance_charge) + service_fees, 2);

                    // Minimum fare 5.50
                    if (total_price < minimum_fare)
                        total_price = minimum_fare;


                    //set values

                 

                    /* r1.lb_booking.Text = base_fare.ToString();
                     r1.lb_distance.Text = distance_charge.ToString();
                     r1.lb_service.Text = service_fees.ToString();
                     r1.lb_total.Text = total_price.ToString();*/

                   // Ride_Details r1 = new Ride_Details(base_fare.ToString());


                    this.Hide();
                    Ride_Details f2 = new Ride_Details(txt_from.Text,txt_to.Text, base_fare.ToString(), distance_charge.ToString(), service_fees.ToString(), total_price.ToString());
                    f2.ShowDialog();
                }

                
            }
        }
    }
}
