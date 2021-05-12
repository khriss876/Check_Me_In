namespace Check_Me_In
{
    partial class room_status
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
            this.room_view_win = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.room_stat = new System.Windows.Forms.Label();
            this.refresh_tb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.room_view_win)).BeginInit();
            this.SuspendLayout();
            // 
            // room_view_win
            // 
            this.room_view_win.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_view_win.Location = new System.Drawing.Point(39, 74);
            this.room_view_win.Name = "room_view_win";
            this.room_view_win.Size = new System.Drawing.Size(451, 202);
            this.room_view_win.TabIndex = 0;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(60, 304);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 43);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(404, 304);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 43);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // room_stat
            // 
            this.room_stat.AutoSize = true;
            this.room_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_stat.Location = new System.Drawing.Point(171, 28);
            this.room_stat.Name = "room_stat";
            this.room_stat.Size = new System.Drawing.Size(194, 33);
            this.room_stat.TabIndex = 3;
            this.room_stat.Text = "Room Status";
            this.room_stat.Click += new System.EventHandler(this.room_stat_Click);
            // 
            // refresh_tb
            // 
            this.refresh_tb.Location = new System.Drawing.Point(231, 304);
            this.refresh_tb.Name = "refresh_tb";
            this.refresh_tb.Size = new System.Drawing.Size(86, 43);
            this.refresh_tb.TabIndex = 4;
            this.refresh_tb.Text = "Refresh";
            this.refresh_tb.UseVisualStyleBackColor = true;
            this.refresh_tb.Click += new System.EventHandler(this.refresh_tb_Click);
            // 
            // room_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh_tb);
            this.Controls.Add(this.room_stat);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.room_view_win);
            this.Name = "room_status";
            this.Text = "room_status";
            this.Load += new System.EventHandler(this.room_status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room_view_win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView room_view_win;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label room_stat;
        private System.Windows.Forms.Button refresh_tb;
    }
}