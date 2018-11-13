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
    public partial class Ride_Details : Form
    {
        public Ride_Details(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            InitializeComponent();           
            lb_f.Text = s1;
            lb_t.Text = s2;
            lb_booking.Text = s3;
            lb_distance.Text = s4;
            lb_service.Text = s5;
            lb_total.Text = s6;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_start f1 = new frm_start();
            f1.Close();
            this.Close();
        }

        private void Ride_Details_Load(object sender, EventArgs e)
        {
            frm_start f2 = new frm_start();
            //lb_f.Text = f2.txt_from.Text;
            //lb_t.Text = f2.txt_to.Text;

            
            //lb_f.Text = "hi";

        }

        public void ChangeLabel(string s)
        {
            MessageBox.Show(s);
            this.lb_f.Text = "Hello";
            
        }

    }
}
