namespace Check_Me_In
{
    partial class login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.username_lab = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.log_lab = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_PW, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.username_lab, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pw_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_UserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // username_lab
            // 
            this.username_lab.AutoSize = true;
            this.username_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lab.Location = new System.Drawing.Point(3, 0);
            this.username_lab.Name = "username_lab";
            this.username_lab.Size = new System.Drawing.Size(135, 29);
            this.username_lab.TabIndex = 0;
            this.username_lab.Text = "User Name";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_label.Location = new System.Drawing.Point(3, 110);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(120, 29);
            this.pw_label.TabIndex = 1;
            this.pw_label.Text = "Password";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(165, 3);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(156, 20);
            this.textBox_UserName.TabIndex = 2;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(165, 113);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.PasswordChar = '*';
            this.textBox_PW.Size = new System.Drawing.Size(156, 20);
            this.textBox_PW.TabIndex = 3;
            // 
            // log_lab
            // 
            this.log_lab.AutoSize = true;
            this.log_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_lab.Location = new System.Drawing.Point(325, 23);
            this.log_lab.Name = "log_lab";
            this.log_lab.Size = new System.Drawing.Size(122, 37);
            this.log_lab.TabIndex = 1;
            this.log_lab.Text = "LOGIN";
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(332, 369);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(144, 36);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.log_lab);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label username_lab;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label log_lab;
        private System.Windows.Forms.Button button_login;
    }
}