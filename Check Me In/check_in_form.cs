using System;
using System.Linq;
using System.Windows.Forms;

namespace Check_Me_In
{
    public partial class check_in_form : Form
    {
        private readonly checkMeInDBEntities checkMeInDB;
        public check_in_form()
        {
            InitializeComponent();
            checkMeInDB = new checkMeInDBEntities();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_out_Click(object sender, EventArgs e)
        {

        }

        private void dateOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_in_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookin_Click(object sender, EventArgs e)
        {
            string firstName = F_Name.Text;
            string lastName = L_Name.Text;
            var checkInDate = dateIn.Value;
            var checkOutDate = dateOut.Value;
            var room = Select_room_CB.Text;
            string contact = contact_tb.Text;
            string country = countryTB.Text;
            string gender = gendertb.Text;
            
             var newguest = new Guest();
            newguest.firstName = firstName;
            newguest.lastName = lastName;
            newguest.telephoneNum = contact;
            newguest.homeAddress = country;
            newguest.gender = gender;
            newguest.roomNum = (int)Select_room_CB.SelectedValue;


            checkMeInDB.Guests.Add(newguest);
            checkMeInDB.SaveChanges();


            var savebooking = new Booking();
            savebooking.checkInDate = checkInDate;
            savebooking.guest_FK = newguest.id;
            savebooking.checkOutDate = checkOutDate;
            savebooking.rooms_FK = newguest.roomNum;
            
            checkMeInDB.Bookings.Add(savebooking);
            checkMeInDB.SaveChanges();
        
            
            var isValid = true;
            
            if (String.IsNullOrEmpty(firstName)) 
            
            {
                isValid = false;
                MessageBox.Show("Please eneter a valid first name");
            }

            if (String.IsNullOrEmpty(lastName))
            {
                isValid = false;
                MessageBox.Show("Please eneter a valid last name");
            }

            if (checkInDate > checkOutDate )
            {
                isValid = false;
                MessageBox.Show("Please eneter a valid Date");

            }
            if (String.IsNullOrEmpty(gender))
            {
                isValid = false;
                MessageBox.Show("Please eneter your gender");
            }
            if (String.IsNullOrEmpty(country))
            {
                isValid = false;
                MessageBox.Show("Please eneter your country of origin");
            }
            if (String.IsNullOrEmpty(contact))
            {
                isValid = false;
                MessageBox.Show("Please eneter a contact number");
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to add this booking?", "update", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (isValid == true)
                {
                    MessageBox.Show($" Congrats!! {firstName} {lastName}\n\r \n\r" +
                 $"you have booked room {room}\n\r \n\r" +
                 $"from {checkInDate}   to the   {checkOutDate}\n\r \n\r" +
                 $"Thank you will see you there ");




                    this.Controls.Clear();

                  


                }


            }




        }

        private void check_in_form_Load(object sender, EventArgs e)
        {
            var select = checkMeInDB.Rooms.ToList();
            Select_room_CB.DisplayMember = "roomNum";
            Select_room_CB.ValueMember = "id";
            Select_room_CB.DataSource = select;

            var pay= checkMeInDB.PaymentMethods.ToList();
            status_cb.DisplayMember="type";
            status_cb.ValueMember = "id";
            status_cb.DataSource = pay;



        }

        private void Select_room_CB_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Select_room_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = (int)Select_room_CB.SelectedValue;
            var rate = checkMeInDB.Rooms.FirstOrDefault(q => q.id == index).cost;
            Ratebox.Text = rate;
        }
    }
}
