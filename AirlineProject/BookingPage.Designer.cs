
namespace AirlineReservationSystemCollegeProject
{
    partial class BookingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HolidayBtn = new System.Windows.Forms.Button();
            this.HotelBtn = new System.Windows.Forms.Button();
            this.FlightBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Singapore Airline";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 95);
            this.panel1.TabIndex = 13;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(686, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 24);
            this.ExitBtn.TabIndex = 31;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(295, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Book Now";
            // 
            // HolidayBtn
            // 
            this.HolidayBtn.AutoSize = true;
            this.HolidayBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.HolidayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HolidayBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayBtn.ForeColor = System.Drawing.Color.White;
            this.HolidayBtn.ImageKey = "(none)";
            this.HolidayBtn.Location = new System.Drawing.Point(67, 243);
            this.HolidayBtn.Name = "HolidayBtn";
            this.HolidayBtn.Size = new System.Drawing.Size(182, 36);
            this.HolidayBtn.TabIndex = 17;
            this.HolidayBtn.Text = "Holiday Package";
            this.HolidayBtn.UseVisualStyleBackColor = false;
            this.HolidayBtn.Click += new System.EventHandler(this.HolidayBtn_Click);
            // 
            // HotelBtn
            // 
            this.HotelBtn.AutoSize = true;
            this.HotelBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.HotelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotelBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelBtn.ForeColor = System.Drawing.Color.White;
            this.HotelBtn.ImageKey = "(none)";
            this.HotelBtn.Location = new System.Drawing.Point(67, 187);
            this.HotelBtn.Name = "HotelBtn";
            this.HotelBtn.Size = new System.Drawing.Size(182, 36);
            this.HotelBtn.TabIndex = 16;
            this.HotelBtn.Text = "Hotels";
            this.HotelBtn.UseVisualStyleBackColor = false;
            this.HotelBtn.Click += new System.EventHandler(this.HotelBtn_Click);
            // 
            // FlightBtn
            // 
            this.FlightBtn.AutoSize = true;
            this.FlightBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.FlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightBtn.ForeColor = System.Drawing.Color.White;
            this.FlightBtn.ImageKey = "(none)";
            this.FlightBtn.Location = new System.Drawing.Point(67, 130);
            this.FlightBtn.Name = "FlightBtn";
            this.FlightBtn.Size = new System.Drawing.Size(182, 36);
            this.FlightBtn.TabIndex = 15;
            this.FlightBtn.Text = "Flight";
            this.FlightBtn.UseVisualStyleBackColor = false;
            this.FlightBtn.Click += new System.EventHandler(this.FlightBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(67, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HolidayBtn);
            this.Controls.Add(this.HotelBtn);
            this.Controls.Add(this.FlightBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button HolidayBtn;
        private System.Windows.Forms.Button HotelBtn;
        private System.Windows.Forms.Button FlightBtn;
        private System.Windows.Forms.Button button1;
    }
}