namespace RentalCar_Version1.Dossier_Returns.frm
{
    partial class ADDUPDATE_return
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabBooking = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.detailsWithFilterBooking1 = new RentalCar_Version1.BookingDossier.Controls.DetailsWithFilterBooking();
            this.TabReturn = new System.Windows.Forms.TabPage();
            this.Infos = new System.Windows.Forms.GroupBox();
            this.Customer = new System.Windows.Forms.Label();
            this.ACTUALRETURNDATE = new System.Windows.Forms.DateTimePicker();
            this.FinalCheckNotes = new System.Windows.Forms.RichTextBox();
            this.Close = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Mileage = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ActualRentalDays = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ReturnID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdditionalCharges = new System.Windows.Forms.TextBox();
            this.ActualTotalDueAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConsumedMileage = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabBooking.SuspendLayout();
            this.TabReturn.SuspendLayout();
            this.Infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabBooking);
            this.tabControl1.Controls.Add(this.TabReturn);
            this.tabControl1.Location = new System.Drawing.Point(26, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 689);
            this.tabControl1.TabIndex = 2;
            // 
            // TabBooking
            // 
            this.TabBooking.Controls.Add(this.Next);
            this.TabBooking.Controls.Add(this.detailsWithFilterBooking1);
            this.TabBooking.Location = new System.Drawing.Point(4, 22);
            this.TabBooking.Name = "TabBooking";
            this.TabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.TabBooking.Size = new System.Drawing.Size(779, 663);
            this.TabBooking.TabIndex = 0;
            this.TabBooking.Text = "SelectBooking";
            this.TabBooking.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(638, 580);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(114, 45);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // detailsWithFilterBooking1
            // 
            this.detailsWithFilterBooking1.FilterEnabled = false;
            this.detailsWithFilterBooking1.Location = new System.Drawing.Point(-31, -2);
            this.detailsWithFilterBooking1.Name = "detailsWithFilterBooking1";
            this.detailsWithFilterBooking1.Size = new System.Drawing.Size(814, 639);
            this.detailsWithFilterBooking1.TabIndex = 0;
            // 
            // TabReturn
            // 
            this.TabReturn.Controls.Add(this.Infos);
            this.TabReturn.Controls.Add(this.pictureBox1);
            this.TabReturn.Controls.Add(this.label3);
            this.TabReturn.Location = new System.Drawing.Point(4, 22);
            this.TabReturn.Name = "TabReturn";
            this.TabReturn.Padding = new System.Windows.Forms.Padding(3);
            this.TabReturn.Size = new System.Drawing.Size(779, 663);
            this.TabReturn.TabIndex = 1;
            this.TabReturn.Text = "Returns";
            this.TabReturn.UseVisualStyleBackColor = true;
            // 
            // Infos
            // 
            this.Infos.Controls.Add(this.ConsumedMileage);
            this.Infos.Controls.Add(this.Customer);
            this.Infos.Controls.Add(this.ACTUALRETURNDATE);
            this.Infos.Controls.Add(this.FinalCheckNotes);
            this.Infos.Controls.Add(this.Close);
            this.Infos.Controls.Add(this.label16);
            this.Infos.Controls.Add(this.pictureBox5);
            this.Infos.Controls.Add(this.Save);
            this.Infos.Controls.Add(this.pictureBox8);
            this.Infos.Controls.Add(this.label2);
            this.Infos.Controls.Add(this.pictureBox9);
            this.Infos.Controls.Add(this.label10);
            this.Infos.Controls.Add(this.Mileage);
            this.Infos.Controls.Add(this.pictureBox4);
            this.Infos.Controls.Add(this.label4);
            this.Infos.Controls.Add(this.pictureBox3);
            this.Infos.Controls.Add(this.ActualRentalDays);
            this.Infos.Controls.Add(this.pictureBox10);
            this.Infos.Controls.Add(this.label6);
            this.Infos.Controls.Add(this.pictureBox2);
            this.Infos.Controls.Add(this.ReturnID);
            this.Infos.Controls.Add(this.label7);
            this.Infos.Controls.Add(this.AdditionalCharges);
            this.Infos.Controls.Add(this.ActualTotalDueAmount);
            this.Infos.Controls.Add(this.label9);
            this.Infos.Location = new System.Drawing.Point(6, 175);
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(767, 473);
            this.Infos.TabIndex = 300;
            this.Infos.TabStop = false;
            this.Infos.Text = "Info";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(368, 78);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(131, 15);
            this.Customer.TabIndex = 268;
            this.Customer.Text = "Additional Charges";
            // 
            // ACTUALRETURNDATE
            // 
            this.ACTUALRETURNDATE.Location = new System.Drawing.Point(192, 78);
            this.ACTUALRETURNDATE.Name = "ACTUALRETURNDATE";
            this.ACTUALRETURNDATE.Size = new System.Drawing.Size(170, 20);
            this.ACTUALRETURNDATE.TabIndex = 299;
            // 
            // FinalCheckNotes
            // 
            this.FinalCheckNotes.BackColor = System.Drawing.Color.White;
            this.FinalCheckNotes.Location = new System.Drawing.Point(140, 336);
            this.FinalCheckNotes.Name = "FinalCheckNotes";
            this.FinalCheckNotes.Size = new System.Drawing.Size(434, 68);
            this.FinalCheckNotes.TabIndex = 279;
            this.FinalCheckNotes.Text = "";
            this.FinalCheckNotes.Click += new System.EventHandler(this.FinalCheckNotes_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(509, 427);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 39);
            this.Close.TabIndex = 298;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(285, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 15);
            this.label16.TabIndex = 278;
            this.label16.Text = "Final Check Notes : ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RentalCar_Version1.Properties.Resources.icons8_notes_32;
            this.pictureBox5.Location = new System.Drawing.Point(248, 305);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 280;
            this.pictureBox5.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(633, 427);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 39);
            this.Save.TabIndex = 297;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::RentalCar_Version1.Properties.Resources.icons8_speedometer_32__1_;
            this.pictureBox8.Location = new System.Drawing.Point(554, 228);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 277;
            this.pictureBox8.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 267;
            this.label2.Text = "Return ID : ";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::RentalCar_Version1.Properties.Resources.icons8_appointment_32;
            this.pictureBox9.Location = new System.Drawing.Point(156, 158);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 281;
            this.pictureBox9.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 15);
            this.label10.TabIndex = 276;
            this.label10.Text = "Consumed Mileage  : ";
            // 
            // Mileage
            // 
            this.Mileage.Location = new System.Drawing.Point(196, 225);
            this.Mileage.Name = "Mileage";
            this.Mileage.Size = new System.Drawing.Size(152, 20);
            this.Mileage.TabIndex = 295;
            this.Mileage.Validated += new System.EventHandler(this.Mileage_Validated);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RentalCar_Version1.Properties.Resources.icons8_money_transfer_32;
            this.pictureBox4.Location = new System.Drawing.Point(554, 159);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 282;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 269;
            this.label4.Text = "Actual Return Date : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RentalCar_Version1.Properties.Resources.icons8_date_32;
            this.pictureBox3.Location = new System.Drawing.Point(155, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 275;
            this.pictureBox3.TabStop = false;
            // 
            // ActualRentalDays
            // 
            this.ActualRentalDays.Location = new System.Drawing.Point(196, 163);
            this.ActualRentalDays.Name = "ActualRentalDays";
            this.ActualRentalDays.ReadOnly = true;
            this.ActualRentalDays.Size = new System.Drawing.Size(152, 20);
            this.ActualRentalDays.TabIndex = 294;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::RentalCar_Version1.Properties.Resources.icons8_price_32;
            this.pictureBox10.Location = new System.Drawing.Point(554, 73);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 283;
            this.pictureBox10.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 270;
            this.label6.Text = "Actual Rental Days : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RentalCar_Version1.Properties.Resources.icons8_speedometer_32;
            this.pictureBox2.Location = new System.Drawing.Point(155, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 274;
            this.pictureBox2.TabStop = false;
            // 
            // ReturnID
            // 
            this.ReturnID.AutoSize = true;
            this.ReturnID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnID.Location = new System.Drawing.Point(135, 17);
            this.ReturnID.Name = "ReturnID";
            this.ReturnID.Size = new System.Drawing.Size(69, 15);
            this.ReturnID.TabIndex = 273;
            this.ReturnID.Text = "[????????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 15);
            this.label7.TabIndex = 271;
            this.label7.Text = "Actual Total Due Amount : ";
            // 
            // AdditionalCharges
            // 
            this.AdditionalCharges.Location = new System.Drawing.Point(594, 75);
            this.AdditionalCharges.Name = "AdditionalCharges";
            this.AdditionalCharges.Size = new System.Drawing.Size(166, 20);
            this.AdditionalCharges.TabIndex = 290;
            this.AdditionalCharges.Click += new System.EventHandler(this.AdditionalCharges_Click);
            // 
            // ActualTotalDueAmount
            // 
            this.ActualTotalDueAmount.Location = new System.Drawing.Point(594, 161);
            this.ActualTotalDueAmount.Name = "ActualTotalDueAmount";
            this.ActualTotalDueAmount.ReadOnly = true;
            this.ActualTotalDueAmount.Size = new System.Drawing.Size(166, 20);
            this.ActualTotalDueAmount.TabIndex = 291;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 272;
            this.label9.Text = "Mileage  : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentalCar_Version1.Properties.Resources.icons8_refund_96;
            this.pictureBox1.Location = new System.Drawing.Point(326, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 296;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(304, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD RETURNS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConsumedMileage
            // 
            this.ConsumedMileage.Location = new System.Drawing.Point(594, 231);
            this.ConsumedMileage.Name = "ConsumedMileage";
            this.ConsumedMileage.Size = new System.Drawing.Size(166, 20);
            this.ConsumedMileage.TabIndex = 300;
            // 
            // ADDUPDATE_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 770);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "ADDUPDATE_return";
            this.Text = "ADDUPDATE_return";
            this.Load += new System.EventHandler(this.ADDUPDATE_return_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabBooking.ResumeLayout(false);
            this.TabReturn.ResumeLayout(false);
            this.TabReturn.PerformLayout();
            this.Infos.ResumeLayout(false);
            this.Infos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabBooking;
        private System.Windows.Forms.TabPage TabReturn;
        private BookingDossier.Controls.DetailsWithFilterBooking detailsWithFilterBooking1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox ActualRentalDays;
        private System.Windows.Forms.TextBox ActualTotalDueAmount;
        private System.Windows.Forms.TextBox AdditionalCharges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RichTextBox FinalCheckNotes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ReturnID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Mileage;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ACTUALRETURNDATE;
        private System.Windows.Forms.GroupBox Infos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ConsumedMileage;
    }
}