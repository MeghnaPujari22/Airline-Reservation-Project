using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Drawing;

namespace AirlineReservationSystemCollegeProject
{
    public partial class View_Scheduled_Flights : Form
    {

        public View_Scheduled_Flights()
        {
            InitializeComponent();
            BindGrid();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblFlight", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           // MessageBox.Show("Flight Recorded Successfully");
        }

        //Delete btn
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Fid.Text == "")
            {
                MessageBox.Show("Enter the Flight id to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from TblFlight where Flight_Number=" + Fid.Text + ";";
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
        }

        private void View_Scheduled_Flights_Load(object sender, EventArgs e)
        {

        }

        //Update btn
        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (Fid.Text != "" && Airlname.Text != "" && sourcecb.Text != "" && destcb.Text != "" && faretb.Text != "" && seats.Text != "" && pricetb.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update TblFlight set Flight_Number=@fid,Airline_name=@Airlname,A_From=@source,A_To=@dest,Fare=@fare,Arrival_Date=@Arridate,Seats=@seats,Price=@price where Flight_Number=@fid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fid", Fid.Text);
                cmd.Parameters.AddWithValue("@Airlname", Airlname.Text);
                cmd.Parameters.AddWithValue("@source", sourcecb.Text);
                cmd.Parameters.AddWithValue("@dest", destcb.Text);
                cmd.Parameters.AddWithValue("@fare", faretb.Text);
                cmd.Parameters.AddWithValue("@Arridate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@seats", seats.Text);
                cmd.Parameters.AddWithValue("@price", pricetb.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Flight Details Updated Successfully");
                Populate();

            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        //insert btn 
        //private void InsertBtn_Click(object sender, EventArgs e)
        //{
        //    if (Fid.Text != "" && Airlname.Text != "" && sourcecb.Text != "" && destcb.Text != "" && faretb.Text != "" && seats.Text != "" && pricetb.Text != "")
        //    {
        //        SqlCommand cmd = new SqlCommand("insert into TblFlight(Flight_Number,Airline_name,A_From,A_To,Fare,Arrival_Date,Seats,Price) values(@fid,@Airlname,@source,@dest,@fare,@Arridate,@seats,@price)", con);
        //        con.Open();
        //        cmd.Parameters.AddWithValue("@fid", Fid.Text);
        //        cmd.Parameters.AddWithValue("@Airlname", Airlname.Text);
        //        cmd.Parameters.AddWithValue("@source", sourcecb.Text);
        //        cmd.Parameters.AddWithValue("@dest", destcb.Text);
        //        cmd.Parameters.AddWithValue("@fare", faretb.Text);
        //        cmd.Parameters.AddWithValue("@Arridate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
        //        cmd.Parameters.AddWithValue("@seats", seats.Text);
        //        cmd.Parameters.AddWithValue("@price", pricetb.Text);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show("Flight Details Inserted Successfully");
        //        Populate();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter mandatory details!");
        //    }
        //}

        //Reset btn
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Fid.Text = "";
            Airlname.Text = "";
            faretb.Text = "";
            seats.Text = "";
            pricetb.Text = "";
        }

        //Back btn
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Record_New_Flight RNF = new Record_New_Flight();
            RNF.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Fid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Airlname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            sourcecb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            destcb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            faretb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            seats.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            pricetb.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TblFlight", con))
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