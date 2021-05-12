using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Me_In
{
    public partial class room_status : Form

    {
        private readonly checkMeInDBEntities checkMeInDB;

        public room_status()
        {
            InitializeComponent();
            checkMeInDB = new checkMeInDBEntities();
        }
        private void room_status_Load(object sender, EventArgs e)
        {
            var rooms = checkMeInDB.Bookings.Select(q => new
            {
                ID = q.id,
                guest = q.guest_FK,
                room = q.rooms_FK,
                datecheckin = q.checkInDate,
                checkoutdate = q.checkOutDate
            }).ToList();
            room_view_win.DataSource = rooms;
            room_view_win.Columns[0].Visible = false;
            room_view_win.Columns[1].HeaderText = "Guest ID";
            room_view_win.Columns[2].HeaderText = "Room Number";
            room_view_win.Columns[3].HeaderText = "Date Checked In";
            room_view_win.Columns[4].HeaderText = "Date Checked Out";
        }

        private void Update_Click(object sender, EventArgs e)
        {
           var Update = new Update_window();
          //  var getID = (int)room_view_win.SelectedRows[0].Cells["id"].Value;
          //  var gotID = checkMeInDB.Bookings.FirstOrDefault(q => q.id == getID);



            Update.ShowDialog();
            room_view_win.Refresh();

        }

        private void Delete_Click(object sender, EventArgs e)

        {
            var getID = (int)room_view_win.SelectedRows[0].Cells["id"].Value;
            var gotID = checkMeInDB.Bookings.FirstOrDefault(q => q.id == getID);

            DialogResult dr = MessageBox.Show("Are you sure you want to add this booking?", "update", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                checkMeInDB.Bookings.Remove(gotID);
                
                checkMeInDB.SaveChanges();

                room_view_win.Refresh();

            }


        }

        private void room_stat_Click(object sender, EventArgs e)
        {

        }

        private void refresh_tb_Click(object sender, EventArgs e)
        {
            room_view_win.Refresh();

                
        }
    }
}