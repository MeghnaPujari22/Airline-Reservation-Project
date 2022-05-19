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
    public partial class View_Scheduled_Hotels : Form
    {
        public View_Scheduled_Hotels()
        {
            InitializeComponent();
            BindGrid();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblHotel", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            //MessageBox.Show("Hotels Recorded Successfully");
            con.Close();
        }

        //update  btn
        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (hidtb.Text != "" && Hnametb.Text != "" && Hlocationcb.Text != "" && roomtb.Text != "" && Ratetb.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update TblHotel set Hotel_Id=@hid, Hotel_Name=@Hname,Location=@Loca,NoRooms=@Hroom,Rate=@Hrate where Hotel_Id=@hid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@hid", hidtb.Text);
                cmd.Parameters.AddWithValue("@Hname", Hnametb.Text);
                cmd.Parameters.AddWithValue("@Loca", Hlocationcb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Hroom", roomtb.Text);
                cmd.Parameters.AddWithValue("@Hrate", Ratetb.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hotels Details Updated Successfully");
                Populate();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        //delete  btn
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (hidtb.Text == "")
            {
                MessageBox.Show("Enter the Hotel id to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from TblHotel where Hotel_Id=" + hidtb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hotel Deleted Successfully");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //reset btn
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            hidtb.Text = "";
            Hnametb.Text = "";
            roomtb.Text = "";
            Ratetb.Text = "";
        }

        //back  btn
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Record_New_Hotels h = new Record_New_Hotels();
            h.Show();
            this.Hide();
        }

        private void View_Scheduled_Hotels_Load(object sender, EventArgs e)
        {
            

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hidtb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Hnametb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Hlocationcb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            roomtb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Ratetb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TblHotel", con))
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
