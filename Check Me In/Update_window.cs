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
    public partial class Update_window : Form
    {
        private readonly checkMeInDBEntities checkMeInDB;
        public Update_window()
        {
            InitializeComponent();
            checkMeInDB = new checkMeInDBEntities();
        }
         public Update_window(Booking Update_room)
        {
            InitializeComponent();
            Populatefeilds(Update_room);

        }

        private void Populatefeilds(Booking UpdateAuto)
        {
            

            F_Name.Text = UpdateAuto.Guest.firstName;
            L_Name.Text = UpdateAuto.Guest.lastName;
            gendertb.Text = UpdateAuto.Guest.gender;
            address_tb.Text = UpdateAuto.Guest.homeAddress;
            dateIn.Value = UpdateAuto.checkInDate.Value;
            dateOut.Value = UpdateAuto.checkOutDate.Value;
            



        }

        private void Update_window_Load(object sender, EventArgs e)
        {
            var update = checkMeInDB.Rooms.ToList();
            Select_room_CB.DisplayMember = "roomNum";
            Select_room_CB.DataSource = update;

            var updat_stat = checkMeInDB.RoomStatus.ToList();
            status_cb.DisplayMember = "status";
            status_cb.ValueMember = "id";
            status_cb.DataSource = updat_stat;

                   }

        private void Select_room_CB_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Select_room_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }}
