using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystemCollegeProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlightBtn_Click(object sender, EventArgs e)
        {
            Record_New_Flight RNF = new Record_New_Flight();
            RNF.Show();
            this.Hide();
        }

        private void B_Click(object sender, EventArgs e)
        {
            BookingPage fb = new BookingPage();
            fb.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Passanger_Details pd = new Passanger_Details();
            pd.Show();
            this.Hide();
        }

        private void HolidayBtn_Click(object sender, EventArgs e)
        {
            Record_Holidays_packages h = new Record_Holidays_packages();
            h.Show();
            this.Hide();
        }

        private void HotelBtn_Click(object sender, EventArgs e)
        {
            Record_New_Hotels H = new Record_New_Hotels();
            H.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CancelFlightTicket CF = new CancelFlightTicket();
            CF.Show();
            this.Hide();
        }
    }
}
