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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");
  
        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;

            string logQuery = "select * from LoginTbl where Userid = @id and  Password= @pin";

            SqlCommand logCmd = new SqlCommand(logQuery, con);
            logCmd.Parameters.AddWithValue("@id", user);
            logCmd.Parameters.AddWithValue("@pin", pass);

            SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
            DataSet LogSet = new DataSet();
            LogAdpater.Fill(LogSet);

            if ((LogSet.Tables[0].Rows.Count) > 0)
            {
                MessageBox.Show("Login Successfully :)");
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credientials are incorrect. Try Again :)");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            con.Close();


        }

    }
}
