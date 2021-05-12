namespace Check_Me_In
{
    partial class delete_record_win
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
            this.Delete_Page = new System.Windows.Forms.Label();
            this.Select_room_CB = new System.Windows.Forms.ComboBox();
            this.Select_a_room = new System.Windows.Forms.Label();
            this.DeleteRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_Page
            // 
            this.Delete_Page.AutoSize = true;
            this.Delete_Page.Font = new System.Drawing.Font("Lucida Bright", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Page.Location = new System.Drawing.Point(197, 43);
            this.Delete_Page.Name = "Delete_Page";
            this.Delete_Page.Size = new System.Drawing.Size(409, 42);
            this.Delete_Page.TabIndex = 3;
            this.Delete_Page.Text = "Delete Room Records";
            // 
            // Select_room_CB
            // 
            this.Select_room_CB.FormattingEnabled = true;
            this.Select_room_CB.Location = new System.Drawing.Point(28, 184);
            this.Select_room_CB.Name = "Select_room_CB";
            this.Select_room_CB.Size = new System.Drawing.Size(121, 21);
            this.Select_room_CB.TabIndex = 4;
            // 
            // Select_a_room
            // 
            this.Select_a_room.AutoSize = true;
            this.Select_a_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_a_room.Location = new System.Drawing.Point(23, 138);
            this.Select_a_room.Name = "Select_a_room";
            this.Select_a_room.Size = new System.Drawing.Size(167, 25);
            this.Select_a_room.TabIndex = 5;
            this.Select_a_room.Text = "Select A Room";
            // 
            // DeleteRec
            // 
            this.DeleteRec.Location = new System.Drawing.Point(308, 284);
            this.DeleteRec.Name = "DeleteRec";
            this.DeleteRec.Size = new System.Drawing.Size(173, 36);
            this.DeleteRec.TabIndex = 6;
            this.DeleteRec.Text = "Delete Records";
            this.DeleteRec.UseVisualStyleBackColor = true;
            // 
            // delete_record_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteRec);
            this.Controls.Add(this.Select_a_room);
            this.Controls.Add(this.Select_room_CB);
            this.Controls.Add(this.Delete_Page);
            this.Name = "delete_record_win";
            this.Text = "delete_record_win";
            this.Load += new System.EventHandler(this.delete_record_win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Delete_Page;
        private System.Windows.Forms.ComboBox Select_room_CB;
        private System.Windows.Forms.Label Select_a_room;
        private System.Windows.Forms.Button DeleteRec;
    }
}