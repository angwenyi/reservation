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
    public partial class SingleFacility : Form
    {
       public string Item;
       public string Price;

       ReserveFacilitycs ff = new ReserveFacilitycs();

        public SingleFacility()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            txtItem.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";

           
            
        }
    }
}
