using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResevationSystem
{
    public partial class AvailableRooms : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
       
        public AvailableRooms()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            var roomquery = from r in dc.IRooms
                            where r.isAvailable == true
                            select r;
            dgRooms.DataSource = roomquery;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
        }

        private void DCRoom(object sender, DataGridViewCellMouseEventArgs e)
        {
            var roomnum = dgRooms.Rows[e.RowIndex].Cells["iRoomNum"].Value.ToString();
            RoomBooking rb = new RoomBooking();
            rb.roomnumber = roomnum;
           // rb.RN = roomnum;
            rb.Show();        

            
        }

      
    }
}
