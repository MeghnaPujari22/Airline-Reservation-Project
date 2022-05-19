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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startPoint = 0 ;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login L = new Login();
                L.Show();
                this.Hide();
            }
                //timer1.Enabled = true;
                //progressBar1.Increment(2);
                //if (progressBar1.Value == 100)
                //{
                //    timer1.Enabled=false;
                //    Login L = new Login();
                //    L.Show();
                //    this.Hide();
                //}
            }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
