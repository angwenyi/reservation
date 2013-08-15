namespace ResevationSystem
{
    partial class RoomBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNumOfNight = new System.Windows.Forms.TextBox();
            this.txtNumOfAdults = new System.Windows.Forms.TextBox();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCheckRoom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iTypeRoomCustComboBox = new System.Windows.Forms.ComboBox();
            this.iTypeRoomCustBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtChequeNum = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnBook = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.iCorporatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTypeRoomCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCorporatesDataGridView = new System.Windows.Forms.DataGridView();
            this.dgtxtTypeCorp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtPriceCorp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSportsDataGridView = new System.Windows.Forms.DataGridView();
            this.dgTypeSports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPriceSports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.individualsDataGridView = new System.Windows.Forms.DataGridView();
            this.dgtxtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTypeRoomCustBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCorporatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTypeRoomCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCorporatesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSportsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.22047F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.77953F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSurname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherNames, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Other Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(140, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(237, 27);
            this.txtSurname.TabIndex = 4;
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherNames.Location = new System.Drawing.Point(140, 33);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(237, 27);
            this.txtOtherNames.TabIndex = 5;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(140, 63);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(237, 27);
            this.txtPhoneNum.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(140, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Others";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtNumOfNight, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtNumOfAdults, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtRoomNum, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dpArrivalDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dpArrivalTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dpDepartureTime, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dpDepartureDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 258);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtNumOfNight
            // 
            this.txtNumOfNight.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfNight.Location = new System.Drawing.Point(190, 147);
            this.txtNumOfNight.Name = "txtNumOfNight";
            this.txtNumOfNight.ReadOnly = true;
            this.txtNumOfNight.Size = new System.Drawing.Size(126, 27);
            this.txtNumOfNight.TabIndex = 11;
            // 
            // txtNumOfAdults
            // 
            this.txtNumOfAdults.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfAdults.Location = new System.Drawing.Point(190, 183);
            this.txtNumOfAdults.Name = "txtNumOfAdults";
            this.txtNumOfAdults.Size = new System.Drawing.Size(126, 27);
            this.txtNumOfAdults.TabIndex = 12;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNum.Location = new System.Drawing.Point(190, 219);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.ReadOnly = true;
            this.txtRoomNum.Size = new System.Drawing.Size(126, 27);
            this.txtRoomNum.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Arrival date";
            // 
            // dpArrivalDate
            // 
            this.dpArrivalDate.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpArrivalDate.Location = new System.Drawing.Point(190, 3);
            this.dpArrivalDate.Name = "dpArrivalDate";
            this.dpArrivalDate.Size = new System.Drawing.Size(181, 27);
            this.dpArrivalDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Arrival Time";
            // 
            // dpArrivalTime
            // 
            this.dpArrivalTime.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpArrivalTime.Location = new System.Drawing.Point(190, 39);
            this.dpArrivalTime.Name = "dpArrivalTime";
            this.dpArrivalTime.Size = new System.Drawing.Size(126, 27);
            this.dpArrivalTime.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Departure Date";
            // 
            // dpDepartureTime
            // 
            this.dpDepartureTime.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpDepartureTime.Location = new System.Drawing.Point(190, 111);
            this.dpDepartureTime.Name = "dpDepartureTime";
            this.dpDepartureTime.Size = new System.Drawing.Size(126, 27);
            this.dpDepartureTime.TabIndex = 19;
            // 
            // dpDepartureDate
            // 
            this.dpDepartureDate.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDepartureDate.Location = new System.Drawing.Point(190, 75);
            this.dpDepartureDate.Name = "dpDepartureDate";
            this.dpDepartureDate.Size = new System.Drawing.Size(181, 27);
            this.dpDepartureDate.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Departure Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Number of Nights";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Number of adults";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Room Number";
            // 
            // btnCheckRoom
            // 
            this.btnCheckRoom.Location = new System.Drawing.Point(413, 409);
            this.btnCheckRoom.Name = "btnCheckRoom";
            this.btnCheckRoom.Size = new System.Drawing.Size(69, 39);
            this.btnCheckRoom.TabIndex = 2;
            this.btnCheckRoom.Text = "check rooms";
            this.btnCheckRoom.UseVisualStyleBackColor = true;
            this.btnCheckRoom.Click += new System.EventHandler(this.btnCheckRoom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(434, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 139);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Type";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.iTypeRoomCustComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSelected, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtCost, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // iTypeRoomCustComboBox
            // 
            this.iTypeRoomCustComboBox.DataSource = this.iTypeRoomCustBindingSource1;
            this.iTypeRoomCustComboBox.DisplayMember = "Type";
            this.iTypeRoomCustComboBox.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTypeRoomCustComboBox.FormattingEnabled = true;
            this.iTypeRoomCustComboBox.Location = new System.Drawing.Point(139, 3);
            this.iTypeRoomCustComboBox.Name = "iTypeRoomCustComboBox";
            this.iTypeRoomCustComboBox.Size = new System.Drawing.Size(174, 25);
            this.iTypeRoomCustComboBox.TabIndex = 10;
            this.iTypeRoomCustComboBox.ValueMember = "Type";
            this.iTypeRoomCustComboBox.SelectedIndexChanged += new System.EventHandler(this.iTypeRoomCustComboBox_SelectedIndexChanged);
            // 
            // iTypeRoomCustBindingSource1
            // 
            this.iTypeRoomCustBindingSource1.DataSource = typeof(ResevationSystem.ITypeRoomCust);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Client Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Selected";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cost";
            // 
            // txtSelected
            // 
            this.txtSelected.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelected.Location = new System.Drawing.Point(139, 36);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.ReadOnly = true;
            this.txtSelected.Size = new System.Drawing.Size(198, 27);
            this.txtSelected.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(139, 69);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(198, 27);
            this.txtCost.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtChequeNum);
            this.groupBox4.Controls.Add(this.txtAmount);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(15, 504);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 137);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(92, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Cheque Num";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(92, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Amount";
            // 
            // txtChequeNum
            // 
            this.txtChequeNum.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNum.Location = new System.Drawing.Point(203, 99);
            this.txtChequeNum.Name = "txtChequeNum";
            this.txtChequeNum.Size = new System.Drawing.Size(153, 27);
            this.txtChequeNum.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(203, 54);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(153, 27);
            this.txtAmount.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(15, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cheque";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(516, 577);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(129, 48);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(679, 577);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 48);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(331, 460);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // iCorporatesBindingSource
            // 
            this.iCorporatesBindingSource.DataMember = "ICorporates";
            this.iCorporatesBindingSource.DataSource = this.iTypeRoomCustBindingSource;
            // 
            // iTypeRoomCustBindingSource
            // 
            this.iTypeRoomCustBindingSource.DataSource = typeof(ResevationSystem.ITypeRoomCust);
            // 
            // iCorporatesDataGridView
            // 
            this.iCorporatesDataGridView.AutoGenerateColumns = false;
            this.iCorporatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iCorporatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtxtTypeCorp,
            this.dgtxtPriceCorp});
            this.iCorporatesDataGridView.DataSource = this.iCorporatesBindingSource;
            this.iCorporatesDataGridView.Location = new System.Drawing.Point(434, 154);
            this.iCorporatesDataGridView.Name = "iCorporatesDataGridView";
            this.iCorporatesDataGridView.ReadOnly = true;
            this.iCorporatesDataGridView.Size = new System.Drawing.Size(365, 180);
            this.iCorporatesDataGridView.TabIndex = 10;
            this.iCorporatesDataGridView.Visible = false;
            this.iCorporatesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DCCorp);
            // 
            // dgtxtTypeCorp
            // 
            this.dgtxtTypeCorp.DataPropertyName = "Type";
            this.dgtxtTypeCorp.HeaderText = "Type";
            this.dgtxtTypeCorp.Name = "dgtxtTypeCorp";
            this.dgtxtTypeCorp.ReadOnly = true;
            this.dgtxtTypeCorp.Width = 150;
            // 
            // dgtxtPriceCorp
            // 
            this.dgtxtPriceCorp.DataPropertyName = "Price";
            this.dgtxtPriceCorp.HeaderText = "Price";
            this.dgtxtPriceCorp.Name = "dgtxtPriceCorp";
            this.dgtxtPriceCorp.ReadOnly = true;
            this.dgtxtPriceCorp.Width = 150;
            // 
            // iSportsBindingSource
            // 
            this.iSportsBindingSource.DataMember = "ISports";
            this.iSportsBindingSource.DataSource = this.iTypeRoomCustBindingSource;
            // 
            // iSportsDataGridView
            // 
            this.iSportsDataGridView.AutoGenerateColumns = false;
            this.iSportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iSportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTypeSports,
            this.dgPriceSports});
            this.iSportsDataGridView.DataSource = this.iSportsBindingSource;
            this.iSportsDataGridView.Location = new System.Drawing.Point(434, 157);
            this.iSportsDataGridView.Name = "iSportsDataGridView";
            this.iSportsDataGridView.ReadOnly = true;
            this.iSportsDataGridView.Size = new System.Drawing.Size(365, 220);
            this.iSportsDataGridView.TabIndex = 11;
            this.iSportsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DCSports);
            // 
            // dgTypeSports
            // 
            this.dgTypeSports.DataPropertyName = "Type";
            this.dgTypeSports.HeaderText = "Type";
            this.dgTypeSports.Name = "dgTypeSports";
            this.dgTypeSports.ReadOnly = true;
            this.dgTypeSports.Width = 150;
            // 
            // dgPriceSports
            // 
            this.dgPriceSports.DataPropertyName = "Price";
            this.dgPriceSports.HeaderText = "Price";
            this.dgPriceSports.Name = "dgPriceSports";
            this.dgPriceSports.ReadOnly = true;
            this.dgPriceSports.Width = 150;
            // 
            // individualsBindingSource
            // 
            this.individualsBindingSource.DataMember = "Individuals";
            this.individualsBindingSource.DataSource = this.iTypeRoomCustBindingSource;
            // 
            // individualsDataGridView
            // 
            this.individualsDataGridView.AutoGenerateColumns = false;
            this.individualsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtxtType,
            this.dgtxtPrice});
            this.individualsDataGridView.DataSource = this.individualsBindingSource;
            this.individualsDataGridView.Location = new System.Drawing.Point(434, 157);
            this.individualsDataGridView.Name = "individualsDataGridView";
            this.individualsDataGridView.ReadOnly = true;
            this.individualsDataGridView.Size = new System.Drawing.Size(365, 220);
            this.individualsDataGridView.TabIndex = 11;
            this.individualsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DCIndi);
            // 
            // dgtxtType
            // 
            this.dgtxtType.DataPropertyName = "Type";
            this.dgtxtType.HeaderText = "Type";
            this.dgtxtType.Name = "dgtxtType";
            this.dgtxtType.ReadOnly = true;
            this.dgtxtType.Width = 150;
            // 
            // dgtxtPrice
            // 
            this.dgtxtPrice.DataPropertyName = "Price";
            this.dgtxtPrice.HeaderText = "Price";
            this.dgtxtPrice.Name = "dgtxtPrice";
            this.dgtxtPrice.ReadOnly = true;
            this.dgtxtPrice.Width = 150;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 488);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(503, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Fill 0 if no payments were made during booking. Fill 0 on cheque number of the bo" +
                "oking was done in cash";
            // 
            // RoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 683);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.individualsDataGridView);
            this.Controls.Add(this.iSportsDataGridView);
            this.Controls.Add(this.iCorporatesDataGridView);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCheckRoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomBooking";
            this.Text = "RoomBooking";
            this.Load += new System.EventHandler(this.RoomBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTypeRoomCustBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCorporatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTypeRoomCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCorporatesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSportsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNumOfNight;
        private System.Windows.Forms.TextBox txtNumOfAdults;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpArrivalDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpArrivalTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpDepartureTime;
        private System.Windows.Forms.DateTimePicker dpDepartureDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCheckRoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtChequeNum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.BindingSource iTypeRoomCustBindingSource;
        private System.Windows.Forms.BindingSource iCorporatesBindingSource;
        private System.Windows.Forms.ComboBox iTypeRoomCustComboBox;
        private System.Windows.Forms.BindingSource iTypeRoomCustBindingSource1;
        private System.Windows.Forms.DataGridView iCorporatesDataGridView;
        private System.Windows.Forms.BindingSource iSportsBindingSource;
        private System.Windows.Forms.DataGridView iSportsDataGridView;
        private System.Windows.Forms.BindingSource individualsBindingSource;
        private System.Windows.Forms.DataGridView individualsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTypeSports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPriceSports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtTypeCorp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtPriceCorp;
        private System.Windows.Forms.Label label17;
    }
}