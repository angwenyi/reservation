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
    public partial class Arrivals : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Arrivals()
        {
            InitializeComponent();
            var ar = from r in dc.IBookings
                     where r.ArrivalDate==DateTime.Today
                     select new
                     {
                         r.Surname,
                         r.OtherNames,
                         r.Email,
                         r.PhoneNum,
                         r.ArrivalDate,
                         r.ArrivalTime,
                         r.DepatureDate,
                         r.DepartureTime,
                         r.NumberOfAdults,
                         r.NoOfNights,
                         r.RoomNum,
                         r.Selected,
                         r.ClientType,
                         r.CheckIn,
                         r.CheckOut
                     };
            dgArrivals.DataSource = ar;

        }

        private void Arrivals_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime arrivals1;
            arrivals1 = arrivalsCalendar.SelectionRange.Start;
            var arrivals2 = from a in dc.IBookings
                            where a.ArrivalDate == arrivals1
                            select new
                            {
                                a.Surname,
                                a.OtherNames,
                                a.Email,
                                a.PhoneNum,
                                a.ArrivalDate,
                                a.ArrivalTime,
                                a.DepatureDate,
                                a.DepartureTime,
                                a.NumberOfAdults,
                                a.NoOfNights,
                                a.RoomNum,
                                a.Selected,
                                a.ClientType,
                                a.CheckIn,
                                a.CheckOut
                            };
            dgArrivals.DataSource = arrivals2;
            if (dgArrivals.RowCount == 0)
            {
                MessageBox.Show("There are no Arrivals", "No Arrivals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void chckbxIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
