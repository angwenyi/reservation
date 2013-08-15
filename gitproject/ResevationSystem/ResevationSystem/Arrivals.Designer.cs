namespace ResevationSystem
{
    partial class Arrivals
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.arrivalsCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgArrivals = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chckbxIn = new System.Windows.Forms.CheckBox();
            this.btnPostpone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArrivals)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.arrivalsCalendar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 695);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SearchBox";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(72, 363);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // arrivalsCalendar
            // 
            this.arrivalsCalendar.Location = new System.Drawing.Point(12, 176);
            this.arrivalsCalendar.Name = "arrivalsCalendar";
            this.arrivalsCalendar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrivals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgArrivals);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 598);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arrivals";
            // 
            // dgArrivals
            // 
            this.dgArrivals.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgArrivals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArrivals.Location = new System.Drawing.Point(6, 19);
            this.dgArrivals.Name = "dgArrivals";
            this.dgArrivals.Size = new System.Drawing.Size(929, 566);
            this.dgArrivals.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnPostpone);
            this.groupBox3.Controls.Add(this.chckbxIn);
            this.groupBox3.Location = new System.Drawing.Point(267, 616);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // chckbxIn
            // 
            this.chckbxIn.AutoSize = true;
            this.chckbxIn.Location = new System.Drawing.Point(6, 36);
            this.chckbxIn.Name = "chckbxIn";
            this.chckbxIn.Size = new System.Drawing.Size(69, 17);
            this.chckbxIn.TabIndex = 0;
            this.chckbxIn.Text = "Check-In";
            this.chckbxIn.UseVisualStyleBackColor = true;
            this.chckbxIn.CheckedChanged += new System.EventHandler(this.chckbxIn_CheckedChanged);
            // 
            // btnPostpone
            // 
            this.btnPostpone.Location = new System.Drawing.Point(100, 32);
            this.btnPostpone.Name = "btnPostpone";
            this.btnPostpone.Size = new System.Drawing.Size(75, 23);
            this.btnPostpone.TabIndex = 1;
            this.btnPostpone.Text = "Postpone";
            this.btnPostpone.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Arrivals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 732);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Arrivals";
            this.Text = "Arrivals";
            this.Load += new System.EventHandler(this.Arrivals_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArrivals)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgArrivals;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MonthCalendar arrivalsCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPostpone;
        private System.Windows.Forms.CheckBox chckbxIn;
    }
}