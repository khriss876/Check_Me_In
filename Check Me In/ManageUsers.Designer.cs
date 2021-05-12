namespace Check_Me_In
{
    partial class ManageUsers
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
            this.Reset = new System.Windows.Forms.Button();
            this.room_stat = new System.Windows.Forms.Label();
            this.dactiveUser = new System.Windows.Forms.Button();
            this.Adduser = new System.Windows.Forms.Button();
            this.user_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.user_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(367, 342);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(86, 43);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset Password";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // room_stat
            // 
            this.room_stat.AutoSize = true;
            this.room_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_stat.Location = new System.Drawing.Point(307, 66);
            this.room_stat.Name = "room_stat";
            this.room_stat.Size = new System.Drawing.Size(216, 33);
            this.room_stat.TabIndex = 8;
            this.room_stat.Text = "Manage Users";
            // 
            // dactiveUser
            // 
            this.dactiveUser.Location = new System.Drawing.Point(540, 342);
            this.dactiveUser.Name = "dactiveUser";
            this.dactiveUser.Size = new System.Drawing.Size(86, 43);
            this.dactiveUser.TabIndex = 7;
            this.dactiveUser.Text = "deactive User";
            this.dactiveUser.UseVisualStyleBackColor = true;
            this.dactiveUser.Click += new System.EventHandler(this.dactiveUser_Click);
            // 
            // Adduser
            // 
            this.Adduser.Location = new System.Drawing.Point(196, 342);
            this.Adduser.Name = "Adduser";
            this.Adduser.Size = new System.Drawing.Size(90, 43);
            this.Adduser.TabIndex = 6;
            this.Adduser.Text = "Add User";
            this.Adduser.UseVisualStyleBackColor = true;
            this.Adduser.Click += new System.EventHandler(this.Adduser_Click);
            // 
            // user_view
            // 
            this.user_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_view.Location = new System.Drawing.Point(175, 112);
            this.user_view.Name = "user_view";
            this.user_view.Size = new System.Drawing.Size(451, 202);
            this.user_view.TabIndex = 5;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.room_stat);
            this.Controls.Add(this.dactiveUser);
            this.Controls.Add(this.Adduser);
            this.Controls.Add(this.user_view);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.user_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label room_stat;
        private System.Windows.Forms.Button dactiveUser;
        private System.Windows.Forms.Button Adduser;
        private System.Windows.Forms.DataGridView user_view;
    }
}