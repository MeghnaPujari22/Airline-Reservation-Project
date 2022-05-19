
namespace AirlineReservationSystemCollegeProject
{
    partial class CancelFlightTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelFlightTicket));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.Tidcb = new System.Windows.Forms.ComboBox();
            this.Cidtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkindate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fidtb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(170, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Flight Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ticket Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(206, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 59);
            this.label10.TabIndex = 0;
            this.label10.Text = "Flight Ticket Cancellation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 133);
            this.panel2.TabIndex = 62;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(1197, 10);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 24);
            this.ExitBtn.TabIndex = 34;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Tidcb
            // 
            this.Tidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tidcb.FormattingEnabled = true;
            this.Tidcb.Location = new System.Drawing.Point(299, 227);
            this.Tidcb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tidcb.Name = "Tidcb";
            this.Tidcb.Size = new System.Drawing.Size(238, 32);
            this.Tidcb.TabIndex = 63;
            this.Tidcb.SelectionChangeCommitted += new System.EventHandler(this.Tidcb_SelectionChangeCommitted);
            // 
            // Cidtb
            // 
            this.Cidtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cidtb.Location = new System.Drawing.Point(299, 162);
            this.Cidtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cidtb.Name = "Cidtb";
            this.Cidtb.Size = new System.Drawing.Size(238, 29);
            this.Cidtb.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(169, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "Cancel Id";
            // 
            // Checkindate
            // 
            this.Checkindate.AutoSize = true;
            this.Checkindate.BackColor = System.Drawing.Color.Transparent;
            this.Checkindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Checkindate.ForeColor = System.Drawing.Color.Black;
            this.Checkindate.Location = new System.Drawing.Point(170, 360);
            this.Checkindate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Checkindate.Name = "Checkindate";
            this.Checkindate.Size = new System.Drawing.Size(48, 24);
            this.Checkindate.TabIndex = 66;
            this.Checkindate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 360);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 29);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(406, 419);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(144, 48);
            this.BackBtn.TabIndex = 69;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(75, 419);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(140, 48);
            this.CancelBtn.TabIndex = 68;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(244, 419);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(142, 48);
            this.Resetbtn.TabIndex = 67;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Location = new System.Drawing.Point(27, 482);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 240);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // Fidtb
            // 
            this.Fidtb.BackColor = System.Drawing.Color.White;
            this.Fidtb.Enabled = false;
            this.Fidtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fidtb.Location = new System.Drawing.Point(300, 290);
            this.Fidtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fidtb.Name = "Fidtb";
            this.Fidtb.Size = new System.Drawing.Size(238, 29);
            this.Fidtb.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // CancelFlightTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 738);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Fidtb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Checkindate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tidcb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cidtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CancelFlightTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelFlightTicket";
            this.Load += new System.EventHandler(this.CancelFlightTicket_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.ComboBox Tidcb;
        private System.Windows.Forms.TextBox Cidtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Checkindate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Fidtb;
        private System.Windows.Forms.PictureBox pictureBox1;
      
    }
}