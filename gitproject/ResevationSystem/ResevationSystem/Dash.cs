using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResevationSystem
{
    public partial class Dash : Form
    {
       // private int childFormNumber = 0;

        public Dash()
        {
            InitializeComponent();
            CalendarHome dt = new CalendarHome();
            dt.MdiParent = this;
            dt.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            AvailableRooms ar = new AvailableRooms ();
            ar.Show();
        }

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

     

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilitiesReport fp = new FacilitiesReport();
            fp.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FacilityBookingMenuItem_Click(object sender, EventArgs e)
        {
            ReserveFacilitycs rf = new ReserveFacilitycs();
            rf.Show();
        }

        private void showReportstrip_Click(object sender, EventArgs e)
        {
            //CustomerReport rp = new CustomerReport();
            //rp.Show();
            COHMainForm ch = new COHMainForm();
            ch.Show();
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReserveFacilitycs rf = new ReserveFacilitycs();
            rf.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arrivals r = new Arrivals();
            r.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=EMC2\\SQLEXPRESS;Initial Catalog=HM2; User ID=hm; Password=stadia4321");
                 
           // SqlConnection con = new SqlConnection("Data Source=SPORTSSTADIA\\SQLEXPRESS;Initial Catalog=HM2; User ID=hm2; Password=stadia4321");
            string strSQL = "SELECT dbo.HiredFacilities.HQuantity, dbo.HiredFacilities.TFacility, dbo.IFunction.ContactPerson, dbo.IFunction.Organization, dbo.IFunction.FunctionName, dbo.IFunction.PhoneNum, dbo.IFunction.StartDateFunction, dbo.IFunction.EndDateFunction, dbo.IFunction.Location, dbo.IFunction.ResidentialNum, dbo.IFunction.NRnum, dbo.IFunction.CustomerNumber FROM         dbo.HiredFacilities INNER JOIN  dbo.IFunction ON dbo.HiredFacilities.FunctionID = dbo.IFunction.FunctionID";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet("ArrayOfItemInfo");
            dt.Fill(ds, "ItemInfo");
            ds.WriteXml(Application.StartupPath + @"\functions.xml");
            MessageBox.Show("Log-out then Login to refresh the calendar");
        }
    }
}
