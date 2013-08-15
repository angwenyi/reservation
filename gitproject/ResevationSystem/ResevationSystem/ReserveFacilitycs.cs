using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace ResevationSystem
{
    
    public partial class ReserveFacilitycs : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        
        public ReserveFacilitycs()
        {
            InitializeComponent();
            iLocationBindingSource.DataSource = dc.ILocations;
            iTypeRoomCustComboBox.DataSource = dc.ITypeRoomCusts;
            txtChequeNum.Visible = true;
        }
        private void DoubleClickDG(object sender, DataGridViewCellEventArgs e)
        {
            var qty = iFacilitiesDataGridView.Rows[e.RowIndex].Cells["Quantity23"].Value.ToString();
            var fn = iFacilitiesDataGridView.Rows[e.RowIndex].Cells["FName"].Value.ToString();
            var pr = iFacilitiesDataGridView.Rows[e.RowIndex].Cells["daColumnPrice"].Value.ToString();

            lstSelected.Items.Add(string.Format("Quantity:{0},Facility:{1},Price:{2}", qty, fn, pr));
        }
        private void twice(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoubleClickDG(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
               txtAmount.Text= null;
            }
            IFunction func = new IFunction();
            //Combine both date and time in one column in DB
            DateTime startDT = dpStartDate.Value.Date.Add(dpStartTime.Value.TimeOfDay);
            DateTime endDT = dpEndDate.Value.Date.Add(dpEndTime.Value.TimeOfDay);
            func.ContactPerson = txtContactPerson.Text;
            func.Organization = txtOrganization.Text;
            func.PhoneNum = Int32.Parse(txtPhoneNum.Text); 
            func.FunctionName = txtFunctionName.Text;
            func.StartDateFunction = startDT;
            func.EndDateFunction = endDT;
            func.DepositedAmount = decimal.Parse(txtAmount.Text);

            if (rbBD.Checked == true) { func.PaymentType = rbBD.Text; }
            else if (rbCash.Checked == true) { func.PaymentType = rbCash.Text; }
            else if (rbcheque.Checked == true)
            {
                if (txtChequeNum.Visible == false)
                {
                    txtChequeNum.Visible = true;
                }
                else { txtChequeNum.Visible = false; }
                func.ChequeNum = Int32.Parse(txtChequeNum.Text);
                func.PaymentType = rbcheque.Text;
            }
            else if (rbEFT.Checked == true) { func.PaymentType = rbEFT.Text; }
            else if (rbGratis.Checked == true) { func.PaymentType = rbGratis.Text; }
            else if (rbLSO.Checked == true) { func.PaymentType = rbLSO.Text; }
            else { MessageBox.Show("Select payment type"); }
            func.Location = iLocationComboBox.Text;
            dc.IFunctions.InsertOnSubmit(func);

           

            foreach (var l in lstSelected.Items) {
                string input = l.ToString();
                string[] itemss = input.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string qty23 = itemss[1];
                string fa = itemss[3];
                string prce = itemss[5];
                
                HiredFacility hf = new HiredFacility();
                hf.TFacility = fa.ToString();
                hf.TPricing = decimal.Parse(prce.ToString());
                 hf.HQuantity = decimal.Parse(qty23.ToString());
                hf.IFunction = func;
                dc.HiredFacilities.InsertOnSubmit(hf);
                //dc.SubmitChanges();
                
            }
            foreach (var x in lstPax.Items) { 
            
            string input =x.ToString();
            string [] itemsss=input.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string ss=itemsss[1];
            string cst=itemsss[3];
            string px=itemsss[5];

            Xtra xt= new Xtra();
            xt.SelectedService=ss.ToString();
            xt.Cost=decimal.Parse(cst.ToString());
            xt.Pax=Int32.Parse(px.ToString());
            xt.IFunction=func;
            dc.Xtras.InsertOnSubmit(xt);
            dc.SubmitChanges();


            }
            MessageBox.Show("Function has been Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedIndex != -1) {

                foreach (var s in lstSelected.SelectedItem.ToString()) {
                    lstSelected.Items.Remove(s);
                }
            }
        }

      
        private void gbPayment_Enter(object sender, EventArgs e)
        {
            //if (rbCash.Checked==true) {
            //    MessageBox.Show("Disable all other windows");
            //    txtBankDeposit.Visible = false;
            //}
        }

        private void ReserveFacilitycs_Load(object sender, EventArgs e)
        {

        }
        

        private void iTypeRoomCustComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
            else
            {
                individualsDataGridView.DataSource = dc.Individuals;
                iSportsDataGridView.Visible = false;
                iCorporatesDataGridView.Visible = false;
                individualsDataGridView.Visible = true;
            }

        }

        private void DGCorp(object sender, DataGridViewCellEventArgs e)
        {
            var type = iCorporatesDataGridView.Rows[e.RowIndex].Cells["typeDataGridViewTextBoxColumn"].Value.ToString();
            var price = iCorporatesDataGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txtCost.Text = price;
            txtSelected.Text = type;
        }

        private void DCSports(object sender, DataGridViewCellEventArgs e)
        {
            var type = iSportsDataGridView.Rows[e.RowIndex].Cells["SportsType"].Value.ToString();
            var price = iSportsDataGridView.Rows[e.RowIndex].Cells["SportsPrice"].Value.ToString();
            txtCost.Text = price;
            txtSelected.Text = type;
        }

        private void DCIndiv(object sender, DataGridViewCellEventArgs e)
        {
            var type = individualsDataGridView.Rows[e.RowIndex].Cells["indType"].Value.ToString();
            var price = individualsDataGridView.Rows[e.RowIndex].Cells["indPrice"].Value.ToString();
            txtCost.Text = price;
            txtSelected.Text = type;
        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPax_Click(object sender, EventArgs e)
        {
            
            var selected = txtSelected.Text;
            var cost =decimal.Parse( txtCost.Text);
            var pax = Int32.Parse(txtPax.Text);
            lstPax.Items.Add(string.Format("Service:{0},Pax:{1},Cost:{2}", selected, pax,cost));

        }

        private void ContactPerson(object sender, CancelEventArgs e)
        {
            if (txtContactPerson.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtContactPerson, "Contact Person is required");
                e.Cancel = true;
            }
            else
                errorProvider1.Clear();
        }

        private void OrganizationValidation(object sender, CancelEventArgs e)
        {
            if (txtOrganization.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtOrganization, " Organization is required");
            }
            else
                errorProvider1.Clear();
        }

        private void CheckingDigits(object sender, EventArgs e)
        {
            // Determine if the TextBox has a digit character.
            string text = txtPhoneNum.Text;
	         bool hasDigit = false;
	        foreach (char letter in text)
	    {
		    if (char.IsDigit(letter))
		    {
		        hasDigit = true;
		        break;
		    }
	    }
	    // Call SetError or Clear on the ErrorProvider.
	    if (!hasDigit)
	        {errorProvider1.SetError(txtPhoneNum, "Needs to contain a digit");}
	    else
	        {errorProvider1.Clear(); }
        }

        private void PhoneNumValidation(object sender, EventArgs e)
        {
            if (txtPhoneNum.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtPhoneNum, "Provide Phone number");
            }
            else { errorProvider1.Clear(); }
        }

        private void validation(object sender, CancelEventArgs e)
        {
            if (txtFunctionName.Text.Trim() == String.Empty)
            { errorProvider1.SetError(txtFunctionName, "Function name Required"); }
            else { errorProvider1.Clear(); }
        }

        private void DAmnt(object sender, EventArgs e)
        {
            // Determine if the TextBox has a digit character.
            string text = txtAmount.Text;
            bool hasDigit = false;
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    hasDigit = true;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (!hasDigit)
            { errorProvider1.SetError(txtAmount, "Need to have digits"); }
            else
            { errorProvider1.Clear(); }
        }

        private void AmntValidation(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtAmount, "Kindly fill the deposited Amount, if no Amount is deposited fill 0");
            }
            else {errorProvider1.Clear();}
        }


       

       

       

       

        
        


       

      

       
  
    }


    class Validation
    {
        public static bool hasValidationErrors(System.Windows.Forms.Control.ControlCollection controls)
        {
            bool hasError = false;

            // Now we need to loop through the controls and deterime if any of them have errors
            foreach (Control control in controls)
            {
                // check the control and see what it returns
                bool validControl = IsValid(control);
                // If it's not valid then set the flag and keep going.  We want to get through all
                // the validators so they will display on the screen if errorProviders were used.
                if (!validControl)
                    hasError = true;

                // If its a container control then it may have children that need to be checked
                if (control.HasChildren)
                {
                    if (hasValidationErrors(control.Controls))
                        hasError = true;
                }
            }
            return hasError;
        }

        // Here, let's determine if the control has a validating method attached to it
        // and if it does, let's execute it and return the result
        private static bool IsValid(object eventSource)
        {
            string name = "EventValidating";

            Type targetType = eventSource.GetType();

            do
            {
                FieldInfo[] fields = targetType.GetFields(
                     BindingFlags.Static |
                     BindingFlags.Instance |
                     BindingFlags.NonPublic);

                foreach (FieldInfo field in fields)
                {
                    if (field.Name == name)
                    {
                        EventHandlerList eventHandlers = ((EventHandlerList)(eventSource.GetType().GetProperty("Events",
                            (BindingFlags.FlattenHierarchy |
                            (BindingFlags.NonPublic | BindingFlags.Instance))).GetValue(eventSource, null)));

                        Delegate d = eventHandlers[field.GetValue(eventSource)];

                        if ((!(d == null)))
                        {
                            Delegate[] subscribers = d.GetInvocationList();

                            // ok we found the validation event,  let's get the event method and call it
                            foreach (Delegate d1 in subscribers)
                            {
                                // create the parameters
                                object sender = eventSource;
                                CancelEventArgs eventArgs = new CancelEventArgs();
                                eventArgs.Cancel = false;
                                object[] parameters = new object[2];
                                parameters[0] = sender;
                                parameters[1] = eventArgs;
                                // call the method
                                d1.DynamicInvoke(parameters);
                                // if the validation failed we need to return that failure
                                if (eventArgs.Cancel)
                                    return false;
                                else
                                    return true;
                            }
                        }
                    }
                }

                targetType = targetType.BaseType;

            } while (targetType != null);

            return true;
        }

    }
}
