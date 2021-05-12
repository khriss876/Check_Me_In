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
    public partial class delete_record_win : Form
    {
        private readonly checkMeInDBEntities checkMeInDB;
        public delete_record_win()
        {
            InitializeComponent();
            checkMeInDB = new checkMeInDBEntities();
        }

        private void delete_record_win_Load(object sender, EventArgs e)
        {
            var delete = checkMeInDB.Rooms.ToList();
            Select_room_CB.DisplayMember = "roomNum";
            Select_room_CB.DataSource = delete;
        }
    }
}