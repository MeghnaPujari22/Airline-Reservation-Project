using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystemCollegeProject
{
    public partial class Record_New_Hotels : Form
    {
        public Record_New_Hotels()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Record_New_Hotels_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
       

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (hidtb.Text != "" && Hnametb.Text != "" && Hlocationcb.Text != ""  && roomtb.Text != ""  && Ratetb.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("insert into TblHotel(Hotel_Id,Hotel_Name,Location,NoRooms,Rate) values(@hid,@Hname,@Hloc,@Hroom,@Hrate)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@hid", hidtb.Text);
                cmd.Parameters.AddWithValue("@Hname", Hnametb.Text);
                cmd.Parameters.AddWithValue("@Hloc", Hlocationcb.Text);
                cmd.Parameters.AddWithValue("@Hroom", roomtb.Text);
                cmd.Parameters.AddWithValue("@Hrate", Ratetb.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hotel Details Recorded Successfully");

            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }
        //exit btn
        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            hidtb.Text = "";
            Hnametb.Text = "";
            roomtb.Text = "";
            Ratetb.Text = "";
        }

        //view  btn
        private void Showbtn_Click(object sender, EventArgs e)
        {
            View_Scheduled_Hotels h = new View_Scheduled_Hotels();
            h.Show();
            this.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
