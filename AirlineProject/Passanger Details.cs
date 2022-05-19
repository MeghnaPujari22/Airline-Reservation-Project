using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AirlineReservationSystemCollegeProject
{
    public partial class Passanger_Details : Form
    {
        public Passanger_Details()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        //Record btn
        private void Button3_Click(object sender, EventArgs e)
        {
            if (Pidtb.Text != "" && Pnametb.Text != "" && Ppassportb.Text != "" && Paddrtb.Text != "" && Pnatcb.Text != "" && Pgencb.Text != "" && Pphonetb.Text != "")
            {
                string PassId = Pidtb.Text;
                string PassName = Pnametb.Text;
                string PassPassport = Ppassportb.Text;
                string PassAd = Paddrtb.Text;
                string PassNat = Pnatcb.SelectedItem.ToString();
                string PassGend = Pgencb.SelectedItem.ToString();
                string PassPhone = Pphonetb.Text;
                con.Open();
                string firstQuery = "INSERT INTO TblPassanger(PassId, PassName, PassPassport, PassAd, PassNat, PassGend, PassPhone) values(@pid, @name, @passport, @pad, @pnat, @pgend, @phone)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@pid", PassId);
                cmd.Parameters.AddWithValue("@name", PassName);
                cmd.Parameters.AddWithValue("@passport", PassPassport);
                cmd.Parameters.AddWithValue("@pad", PassAd);
                cmd.Parameters.AddWithValue("@pnat", PassNat);
                cmd.Parameters.AddWithValue("@pgend", PassGend);
                cmd.Parameters.AddWithValue("@phone", PassPhone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger Recorded Successfully!");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        //view passenger btn
        private void ViewPassengerbtn_Click(object sender, EventArgs e)
        {
            // redirected to View passenger page
            View_Passangers VP = new View_Passangers();
            VP.Show();
            this.Hide();
        }

        //Back btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home H=new Home();
            H.Show();
            this.Hide();
        }

        //Reset btn
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Pidtb.Text = "";
            Pnametb.Text = "";
            Ppassportb.Text = "";
            Paddrtb.Text = "";
            Pnatcb.Text = "";
            Pgencb.Text = "";
            Pphonetb.Text = "";
        }

        //exit btn
        private void Label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
