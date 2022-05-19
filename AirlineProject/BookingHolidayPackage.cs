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
    public partial class BookingHolidayPackage : Form
    {
        public BookingHolidayPackage()
        {
            InitializeComponent();
            BindGrid();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // fill the passenger information
        private void Fillpassenger()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from TblPassanger", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(sdr);
            Passidcb.ValueMember = "PassId";
            Passidcb.DataSource = dt;
            con.Close();
        }

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblBookHolidayPackage", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Your Data Recorded Successfully");
     
        }

        // fill the Holiday information
        private void Fillholiday()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select holiday_Id from TblHoliday", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("holiday_Id", typeof(int));
            dt.Load(sdr);
            hidcb.ValueMember = "holiday_Id";
            hidcb.DataSource = dt;
            con.Close();
        }

        //Fetch data from database
        private string Fbudget;
        private void FetchHoliday()
        {
            con.Open();
            string qry = "select * from TblHoliday where holiday_Id=" + hidcb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow sdr in dt.Rows)
            {
                Fbudget = sdr["Budget"].ToString();
                BudgetTB.Text = Fbudget;
            }
            con.Close();
        }

        //Fetch data from database
        private string Pname;

        private void FetchPassenger()
        {
            con.Open();
            string qry = "select * from TblPassanger where PassId=" + Passidcb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow sdr in dt.Rows)
            {
                Pname = sdr["PassName"].ToString();
                Passname.Text = Pname;
            }
            con.Close();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (Pidtb.Text != "")
            {
                string Pid = Pidtb.Text;
                string holiday_Id = hidcb.Text;
                string PassId = Passidcb.Text;
                string PassName = Passname.Text;
                string Pjdate = dateTimePicker1.Text;
                string Budget = BudgetTB.Text;
                con.Open();
                string firstQuery = "INSERT INTO TblBookHolidayPackage(Pid,holiday_Id, PassId, PassName,Pjdate,Budget) values(@pid,@hid, @pi, @pn, @pjdate,@budget)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@pid", Pid);
                cmd.Parameters.AddWithValue("@hid", holiday_Id);
                cmd.Parameters.AddWithValue("@pi", PassId);
                cmd.Parameters.AddWithValue("@pn", PassName);
                cmd.Parameters.AddWithValue("@pjdate", Pjdate);
                cmd.Parameters.AddWithValue("@budget", Budget);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Holiday Package Booked Successfully ;) ");
                con.Close();
                Populate();

            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Pidtb.Text = "";
            hidcb.Text = "";
            Pidtb.Text = "";
            Passname.Text = "";
        
            BudgetTB.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BookingPage bp = new BookingPage();
            bp.Show();
            this.Hide();
        }

        private void BookingHolidayPackage_Load(object sender, EventArgs e)
        {
            
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fillpassenger();
            Fillholiday();
        }

        private void Hidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchHoliday();
        }

        private void Passidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPassenger();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Pidtb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            hidcb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Passidcb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Passname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            BudgetTB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TblBookHolidayPackage", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }
    }
}

