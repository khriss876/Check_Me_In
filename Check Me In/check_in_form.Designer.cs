namespace Check_Me_In
{
    partial class check_in_form
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
            this.checkIn_Page = new System.Windows.Forms.Label();
            this.Select_room_CB = new System.Windows.Forms.ComboBox();
            this.Select_a_room = new System.Windows.Forms.Label();
            this.bookin = new System.Windows.Forms.Button();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.date_in = new System.Windows.Forms.Label();
            this.date_out = new System.Windows.Forms.Label();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.L_Name = new System.Windows.Forms.TextBox();
            this.FirstNameLB = new System.Windows.Forms.Label();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Ratebox = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.country_Lab = new System.Windows.Forms.Label();
            this.ContactNum_lab = new System.Windows.Forms.Label();
            this.contact_tb = new System.Windows.Forms.TextBox();
            this.HomeAddre_lab = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.gendertb = new System.Windows.Forms.TextBox();
            this.stats_sel = new System.Windows.Forms.Label();
            this.status_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkIn_Page
            // 
            this.checkIn_Page.AutoSize = true;
            this.checkIn_Page.Font = new System.Drawing.Font("Lucida Bright", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_Page.Location = new System.Drawing.Point(286, 24);
            this.checkIn_Page.Name = "checkIn_Page";
            this.checkIn_Page.Size = new System.Drawing.Size(305, 42);
            this.checkIn_Page.TabIndex = 4;
            this.checkIn_Page.Text = "Check  In Guest";
            // 
            // Select_room_CB
            // 
            this.Select_room_CB.FormattingEnabled = true;
            this.Select_room_CB.Items.AddRange(new object[] {
            "1 room",
            "2 room",
            "3 room",
            "4 room",
            "5 room",
            "6 room"});
            this.Select_room_CB.Location = new System.Drawing.Point(23, 89);
            this.Select_room_CB.Name = "Select_room_CB";
            this.Select_room_CB.Size = new System.Drawing.Size(121, 21);
            this.Select_room_CB.TabIndex = 5;
            this.Select_room_CB.SelectedIndexChanged += new System.EventHandler(this.Select_room_CB_SelectedIndexChanged);
            this.Select_room_CB.SelectionChangeCommitted += new System.EventHandler(this.Select_room_CB_SelectionChangeCommitted);
            // 
            // Select_a_room
            // 
            this.Select_a_room.AutoSize = true;
            this.Select_a_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_a_room.Location = new System.Drawing.Point(1, 61);
            this.Select_a_room.Name = "Select_a_room";
            this.Select_a_room.Size = new System.Drawing.Size(167, 25);
            this.Select_a_room.TabIndex = 6;
            this.Select_a_room.Text = "Select A Room";
            // 
            // bookin
            // 
            this.bookin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookin.Location = new System.Drawing.Point(305, 389);
            this.bookin.Name = "bookin";
            this.bookin.Size = new System.Drawing.Size(159, 49);
            this.bookin.TabIndex = 7;
            this.bookin.Text = "Book In Guest";
            this.bookin.UseVisualStyleBackColor = true;
            this.bookin.Click += new System.EventHandler(this.bookin_Click);
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(23, 249);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateIn.TabIndex = 8;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateIn_ValueChanged);
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(23, 347);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(200, 20);
            this.dateOut.TabIndex = 9;
            this.dateOut.ValueChanged += new System.EventHandler(this.dateOut_ValueChanged);
            // 
            // date_in
            // 
            this.date_in.AutoSize = true;
            this.date_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.Location = new System.Drawing.Point(23, 230);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(61, 18);
            this.date_in.TabIndex = 10;
            this.date_in.Text = "Date In";
            this.date_in.Click += new System.EventHandler(this.date_in_Click);
            // 
            // date_out
            // 
            this.date_out.AutoSize = true;
            this.date_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_out.Location = new System.Drawing.Point(23, 326);
            this.date_out.Name = "date_out";
            this.date_out.Size = new System.Drawing.Size(75, 18);
            this.date_out.TabIndex = 11;
            this.date_out.Text = "Date Out";
            this.date_out.Click += new System.EventHandler(this.date_out_Click);
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(338, 114);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(159, 20);
            this.F_Name.TabIndex = 12;
            this.F_Name.TextChanged += new System.EventHandler(this.F_Name_TextChanged);
            // 
            // L_Name
            // 
            this.L_Name.Location = new System.Drawing.Point(532, 114);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(159, 20);
            this.L_Name.TabIndex = 13;
            // 
            // FirstNameLB
            // 
            this.FirstNameLB.AutoSize = true;
            this.FirstNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLB.Location = new System.Drawing.Point(335, 89);
            this.FirstNameLB.Name = "FirstNameLB";
            this.FirstNameLB.Size = new System.Drawing.Size(91, 18);
            this.FirstNameLB.TabIndex = 14;
            this.FirstNameLB.Text = "First Name";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LastNameLB.Location = new System.Drawing.Point(534, 89);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(89, 18);
            this.LastNameLB.TabIndex = 15;
            this.LastNameLB.Text = "Last Name";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gender.Location = new System.Drawing.Point(335, 154);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 18);
            this.Gender.TabIndex = 16;
            this.Gender.Text = "Gender";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rate.Location = new System.Drawing.Point(23, 141);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(57, 18);
            this.Rate.TabIndex = 19;
            this.Rate.Text = "Rate $";
            // 
            // Ratebox
            // 
            this.Ratebox.Location = new System.Drawing.Point(23, 177);
            this.Ratebox.Name = "Ratebox";
            this.Ratebox.Size = new System.Drawing.Size(159, 20);
            this.Ratebox.TabIndex = 20;
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(532, 219);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(172, 20);
            this.countryTB.TabIndex = 21;
            // 
            // country_Lab
            // 
            this.country_Lab.AutoSize = true;
            this.country_Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.country_Lab.Location = new System.Drawing.Point(534, 198);
            this.country_Lab.Name = "country_Lab";
            this.country_Lab.Size = new System.Drawing.Size(137, 18);
            this.country_Lab.TabIndex = 22;
            this.country_Lab.Text = "Country of Origin";
            // 
            // ContactNum_lab
            // 
            this.ContactNum_lab.AutoSize = true;
            this.ContactNum_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ContactNum_lab.Location = new System.Drawing.Point(327, 198);
            this.ContactNum_lab.Name = "ContactNum_lab";
            this.ContactNum_lab.Size = new System.Drawing.Size(131, 18);
            this.ContactNum_lab.TabIndex = 23;
            this.ContactNum_lab.Text = "Contact Number";
            // 
            // contact_tb
            // 
            this.contact_tb.Location = new System.Drawing.Point(325, 219);
            this.contact_tb.Name = "contact_tb";
            this.contact_tb.Size = new System.Drawing.Size(172, 20);
            this.contact_tb.TabIndex = 24;
            // 
            // HomeAddre_lab
            // 
            this.HomeAddre_lab.AutoSize = true;
            this.HomeAddre_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeAddre_lab.Location = new System.Drawing.Point(327, 271);
            this.HomeAddre_lab.Name = "HomeAddre_lab";
            this.HomeAddre_lab.Size = new System.Drawing.Size(119, 18);
            this.HomeAddre_lab.TabIndex = 25;
            this.HomeAddre_lab.Text = "Home Address";
            this.HomeAddre_lab.Click += new System.EventHandler(this.label1_Click);
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(472, 269);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(316, 20);
            this.address_tb.TabIndex = 26;
            // 
            // gendertb
            // 
            this.gendertb.Location = new System.Drawing.Point(404, 155);
            this.gendertb.Name = "gendertb";
            this.gendertb.Size = new System.Drawing.Size(100, 20);
            this.gendertb.TabIndex = 27;
            // 
            // stats_sel
            // 
            this.stats_sel.AutoSize = true;
            this.stats_sel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_sel.Location = new System.Drawing.Point(343, 325);
            this.stats_sel.Name = "stats_sel";
            this.stats_sel.Size = new System.Drawing.Size(199, 20);
            this.stats_sel.TabIndex = 29;
            this.stats_sel.Text = "Select Payment Method";
            // 
            // status_cb
            // 
            this.status_cb.FormattingEnabled = true;
            this.status_cb.Location = new System.Drawing.Point(561, 323);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(121, 21);
            this.status_cb.TabIndex = 28;
            // 
            // check_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.stats_sel);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.gendertb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.HomeAddre_lab);
            this.Controls.Add(this.contact_tb);
            this.Controls.Add(this.ContactNum_lab);
            this.Controls.Add(this.country_Lab);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.Ratebox);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastNameLB);
            this.Controls.Add(this.FirstNameLB);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.date_out);
            this.Controls.Add(this.date_in);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.bookin);
            this.Controls.Add(this.Select_a_room);
            this.Controls.Add(this.Select_room_CB);
            this.Controls.Add(this.checkIn_Page);
            this.Name = "check_in_form";
            this.Text = "check_in_form";
            this.Load += new System.EventHandler(this.check_in_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkIn_Page;
        private System.Windows.Forms.ComboBox Select_room_CB;
        private System.Windows.Forms.Label Select_a_room;
        private System.Windows.Forms.Button bookin;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label date_in;
        private System.Windows.Forms.Label date_out;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.TextBox L_Name;
        private System.Windows.Forms.Label FirstNameLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.TextBox Ratebox;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.Label country_Lab;
        private System.Windows.Forms.Label ContactNum_lab;
        private System.Windows.Forms.TextBox contact_tb;
        private System.Windows.Forms.Label HomeAddre_lab;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox gendertb;
        private System.Windows.Forms.Label stats_sel;
        private System.Windows.Forms.ComboBox status_cb;
    }
}