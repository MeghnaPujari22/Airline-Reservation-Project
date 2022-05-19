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
    public partial class CancelFlightTicket : Form
    {
        public CancelFlightTicket()
        {
            InitializeComponent();
            BindGrid();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillflightTicket()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TId from BookFlightTicket", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(int));
            dt.Load(sdr);
            Tidcb.ValueMember = "TId";
            Tidcb.DataSource = dt;
            con.Close();
        }

        //Fetch data from database
        private string Fid;
        private void FetchFlight()
        {
            con.Open();
            string qry = "select * from BookFlightTicket where TId=" + Tidcb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow sdr in dt.Rows)
            {
                Fid = sdr["Flight_Number"].ToString();
                Fidtb.Text = Fid;
            }
            con.Close();
        }

        //when we cancel flight ticket then remove ticket from database booking flight
        private void DeleteFlightTicket()
        {
            try
                {
                    con.Open();
                    string query = "delete from BookFlightTicket where TId=" + Tidcb.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    con.Close();
                    Populate();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        
        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblCancelFlightTicket", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Cidtb.Text != "")
            {
                string Cid = Cidtb.Text;
                string Flight_Number = Fidtb.Text;
                string Tid = Tidcb.Text;
                string CDate = dateTimePicker1.Value.ToString();
                con.Open();
                string firstQuery = "INSERT INTO TblCancelFlightTicket(Cid, Tid, Flight_Number, CDate) values(@cid, @tid,@fn, @cdate)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@cid", Cid);
                cmd.Parameters.AddWithValue("@tid", Tid);
                cmd.Parameters.AddWithValue("@fn", Flight_Number);
                cmd.Parameters.AddWithValue("@cdate", CDate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight Ticket Cancelled Successfully ;) ");
                con.Close();
                Populate();
                DeleteFlightTicket();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Cidtb.Text = "";
            Fidtb.Text = "";
        }

        private void CancelFlightTicket_Load(object sender, EventArgs e)
        {
            
            FillflightTicket();
        }

        private void Tidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchFlight();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cidtb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tidcb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Fidtb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TblCancelFlightTicket", con))
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
