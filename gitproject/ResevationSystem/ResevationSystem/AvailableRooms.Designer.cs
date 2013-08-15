namespace ResevationSystem
{
    partial class AvailableRooms
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
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgRooms = new System.Windows.Forms.DataGridView();
            this.iRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seach Room";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(113, 75);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 5;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check-Out";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-In";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgRooms);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rooms";
            // 
            // dgRooms
            // 
            this.dgRooms.AutoGenerateColumns = false;
            this.dgRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomTypeDataGridViewTextBoxColumn,
            this.roomStateDataGridViewTextBoxColumn,
            this.iRoomNum,
            this.isAvailableDataGridViewTextBoxColumn});
            this.dgRooms.DataSource = this.iRoomBindingSource;
            this.dgRooms.Location = new System.Drawing.Point(6, 19);
            this.dgRooms.Name = "dgRooms";
            this.dgRooms.ReadOnly = true;
            this.dgRooms.Size = new System.Drawing.Size(441, 373);
            this.dgRooms.TabIndex = 0;
            this.dgRooms.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DCRoom);
            // 
            // iRoomBindingSource
            // 
            this.iRoomBindingSource.DataSource = typeof(ResevationSystem.IRoom);
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomStateDataGridViewTextBoxColumn
            // 
            this.roomStateDataGridViewTextBoxColumn.DataPropertyName = "RoomState";
            this.roomStateDataGridViewTextBoxColumn.HeaderText = "RoomState";
            this.roomStateDataGridViewTextBoxColumn.Name = "roomStateDataGridViewTextBoxColumn";
            this.roomStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iRoomNum
            // 
            this.iRoomNum.DataPropertyName = "IRoomNumber";
            this.iRoomNum.HeaderText = "IRoomNumber";
            this.iRoomNum.Name = "iRoomNum";
            this.iRoomNum.ReadOnly = true;
            // 
            // isAvailableDataGridViewTextBoxColumn
            // 
            this.isAvailableDataGridViewTextBoxColumn.DataPropertyName = "isAvailable";
            this.isAvailableDataGridViewTextBoxColumn.HeaderText = "isAvailable";
            this.isAvailableDataGridViewTextBoxColumn.Name = "isAvailableDataGridViewTextBoxColumn";
            this.isAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AvailableRooms";
            this.Text = "AvailableRooms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRoomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgRooms;
        private System.Windows.Forms.BindingSource iRoomBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailableDataGridViewTextBoxColumn;
    }
}