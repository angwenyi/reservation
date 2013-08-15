using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace ResevationSystem
{
    public partial class RoomBooking : Form
    {
        DataClasses1DataContext dc= new DataClasses1DataContext();

        //public string RN;
        public string roomnumber
        {

            get { return txtRoomNum.Text; }
            set {txtRoomNum.Text = value;
            //txtRoomNum.Text = RN;
            }
        }

        public RoomBooking()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            iTypeRoomCustComboBox.DataSource = dc.ITypeRoomCusts;
           
        }
        
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            IBooking book = new IBooking();
            
            

                book.Surname = txtSurname.Text;
                book.OtherNames = txtOtherNames.Text;
                book.PhoneNum = Int32.Parse(txtPhoneNum.Text);
                book.Email = txtEmail.Text;
                book.ArrivalDate = dpArrivalDate.Value;
                book.ArrivalTime = dpArrivalTime.Value.TimeOfDay;
                book.DepatureDate = dpDepartureDate.Value;
                book.DepartureTime = dpDepartureTime.Value.TimeOfDay;
                book.NoOfNights = Int32.Parse(txtNumOfNight.Text);
                book.NumberOfAdults = Int32.Parse(txtNumOfAdults.Text);
                book.RoomNum = txtRoomNum.Text;
                book.ClientType = iTypeRoomCustComboBox.Text;
                book.Selected = txtSelected.Text;
                book.RoomRate = decimal.Parse(txtCost.Text);
                book.DepositedAmount=decimal.Parse(txtAmount.Text);
                book.ChequeNum = Int32.Parse(txtChequeNum.Text);
                dc.IBookings.InsertOnSubmit(book);
                dc.SubmitChanges();

                MessageBox.Show("Booking done SuccessFull", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            


          
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime darrival= dpArrivalDate.Value.Date;
            DateTime ddeparture=dpDepartureDate.Value.Date;
            TimeSpan difference=ddeparture.Subtract(darrival);
            txtNumOfNight.Text=difference.TotalDays.ToString();

        
        }

        private void cmdClient_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //private Observableitem _items;
        //public class Observableitem : ObservableCollection<ICorporate1>
        //{

        //    public Observableitem(DataClasses1DataContext dataDC)
        //    {
        //        foreach (ICorporate i in dataDC.ICorporate)
        //        {
        //            this.Add(i);
        //        }
        //    }

        //}

        //private void RoomBooking_Load(object sender, EventArgs e)
        //{
        //    _items = new Observableitem(dc);
        //}

        private void lstBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void iTypeRoomCustComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iTypeRoomCustComboBox.Text == "Corporate                     ")
            {
                iCorporatesDataGridView.DataSource = dc.ICorporates;
                iCorporatesDataGridView.Visible = true;
                iSportsDataGridView.Visible = false;
                individualsDataGridView.Visible = false;
            }
            else if (iTypeRoomCustComboBox.Text == "Sports Groups                 ")
            {
                iSportsDataGridView.DataSource = dc.ISports;
                iSportsDataGridView.Visible = true;
                iCorporatesDataGridView.Visible = false;
                individualsDataGridView.Visible = false;
            }
            else {
                individualsDataGridView.DataSource = dc.Individuals;
                iSportsDataGridView.Visible = false;
                iCorporatesDataGridView.Visible = false;
                individualsDataGridView.Visible = true;
            }
        }

        private void DCIndi(object sender, DataGridViewCellMouseEventArgs e)
        {
            var price = individualsDataGridView.Rows[e.RowIndex].Cells["dgtxtPrice"].Value.ToString();
            var type = individualsDataGridView.Rows[e.RowIndex].Cells["dgtxtType"].Value.ToString();
            txtCost.Text = price;
            txtSelected.Text = type;
        }

        private void DCSports(object sender, DataGridViewCellMouseEventArgs e)
        {

            var price = iSportsDataGridView.Rows[e.RowIndex].Cells["dgPriceSports"].Value.ToString();
            var type = iSportsDataGridView.Rows[e.RowIndex].Cells["dgTypeSports"].Value.ToString();
            txtCost.Text = price;
            txtSelected.Text = type;

        }


        private void DCCorp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var price = iCorporatesDataGridView.Rows[e.RowIndex].Cells["dgtxtPriceCorp"].Value.ToString();
            var type = iCorporatesDataGridView.Rows[e.RowIndex].Cells["dgtxtTypeCorp"].Value.ToString();
            txtCost.Text = price;
            txtSelected.Text = type;
        }

        private void btnCheckRoom_Click(object sender, EventArgs e)
        {
            AvailableRooms ar = new AvailableRooms();
            ar.Show();
        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {

        }

       
      

       

       
    }
}
