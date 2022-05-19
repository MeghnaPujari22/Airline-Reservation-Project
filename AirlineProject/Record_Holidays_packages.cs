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
    public partial class Record_Holidays_packages : Form
    {
        public Record_Holidays_packages()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");


        //Record btn
        private void Record_btn_Click(object sender, EventArgs e)
        {
            if (hidTB.Text != "" && CnameCB.Text != "" && PackageTypeCB.Text != "" && BudgetTB.Text != "")
            {
                con.Open();
                string qry = "insert into TblHoliday(holiday_Id,Country_name,Package_type,Budget) values(@hid,@cname,@packagetype,@budget)";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@hid", hidTB.Text);
                cmd.Parameters.AddWithValue("@cname", CnameCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@packagetype", PackageTypeCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@budget", BudgetTB.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Holiday Package Recorded Successfully ;)");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        //Reset btn
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            hidTB.Text = "";
            CnameCB.Text = "";
            PackageTypeCB.Text = "";
            BudgetTB.Text = "";
        }

        //redirected to view scheduled holidays page
        private void Button1_Click(object sender, EventArgs e)
        {
            View_Scheduled_Holiday RSH = new View_Scheduled_Holiday();
            RSH.Show();
            this.Hide();
        }

        //exit btn
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Home bp = new Home();
            bp.Show();
            this.Hide();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
