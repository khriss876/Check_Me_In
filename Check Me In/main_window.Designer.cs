namespace Check_Me_In
{
    partial class main_window
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkRoomStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAroom = new System.Windows.Forms.ToolStripMenuItem();
            this.VIEWROOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.STATUS = new System.Windows.Forms.ToolStripMenuItem();
            this.welcome_lab = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loginstatuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkRoomStatusToolStripMenuItem,
            this.VIEWROOMS,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // checkRoomStatusToolStripMenuItem
            // 
            this.checkRoomStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAroom});
            this.checkRoomStatusToolStripMenuItem.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRoomStatusToolStripMenuItem.Name = "checkRoomStatusToolStripMenuItem";
            this.checkRoomStatusToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.checkRoomStatusToolStripMenuItem.Text = "BOOKINGS";
            // 
            // bookAroom
            // 
            this.bookAroom.Name = "bookAroom";
            this.bookAroom.Size = new System.Drawing.Size(165, 24);
            this.bookAroom.Text = "BOOK A ROOM";
            this.bookAroom.Click += new System.EventHandler(this.bookAroom_Click);
            // 
            // VIEWROOMS
            // 
            this.VIEWROOMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STATUS});
            this.VIEWROOMS.Font = new System.Drawing.Font("Impact", 12F);
            this.VIEWROOMS.Name = "VIEWROOMS";
            this.VIEWROOMS.Size = new System.Drawing.Size(102, 24);
            this.VIEWROOMS.Text = "VIEW ROOMS";
            // 
            // STATUS
            // 
            this.STATUS.Font = new System.Drawing.Font("Impact", 12F);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(180, 24);
            this.STATUS.Text = "STATUS";
            this.STATUS.Click += new System.EventHandler(this.STATUS_Click);
            // 
            // welcome_lab
            // 
            this.welcome_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_lab.AutoSize = true;
            this.welcome_lab.BackColor = System.Drawing.Color.White;
            this.welcome_lab.Font = new System.Drawing.Font("Sitka Small", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lab.ForeColor = System.Drawing.Color.Black;
            this.welcome_lab.Location = new System.Drawing.Point(17, 86);
            this.welcome_lab.Name = "welcome_lab";
            this.welcome_lab.Size = new System.Drawing.Size(714, 78);
            this.welcome_lab.TabIndex = 1;
            this.welcome_lab.Text = "Welcome To Check Me In";
            this.welcome_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(504, 183);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginstatuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loginstatuslabel
            // 
            this.loginstatuslabel.Name = "loginstatuslabel";
            this.loginstatuslabel.Size = new System.Drawing.Size(0, 17);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Check_Me_In.Properties.Resources.bell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.welcome_lab);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_window";
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_window_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkRoomStatusToolStripMenuItem;
        private System.Windows.Forms.Label welcome_lab;
        private System.Windows.Forms.ToolStripMenuItem bookAroom;
        private System.Windows.Forms.ToolStripMenuItem VIEWROOMS;
        private System.Windows.Forms.ToolStripMenuItem STATUS;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loginstatuslabel;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}

