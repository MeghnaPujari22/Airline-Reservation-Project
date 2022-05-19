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
    public partial class BookingPage : Form
    {
        public BookingPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlightBtn_Click(object sender, EventArgs e)
        {
            FlightBooking fb = new FlightBooking();
            fb.Show();
            this.Hide();
        }

        private void HotelBtn_Click(object sender, EventArgs e)
        {
            HotelBooking hb = new HotelBooking();
            hb.Show();
            this.Hide();
        }

        private void HolidayBtn_Click(object sender, EventArgs e)
        {
            BookingHolidayPackage h = new BookingHolidayPackage();
            h.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
