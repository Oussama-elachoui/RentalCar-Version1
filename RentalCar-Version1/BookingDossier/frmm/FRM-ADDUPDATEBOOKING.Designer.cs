namespace RentalCar_Version1.BookingDossier.frmm
{
    partial class FRM_ADDUPDATEBOOKING
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.SelectVehicle = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.filterVehicule1 = new RentalCar_Version1.Vehicules1.control.FilterVehicule();
            this.SelectPerson = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.filerCustomers1 = new RentalCar_Version1.Customers1.filerCustomers();
            this.TOTALPRICE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PRICE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DAYS = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Vehicleid = new System.Windows.Forms.Label();
            this.Customerid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.Pickup = new System.Windows.Forms.TextBox();
            this.Dropoff = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBINFORMATIONS = new System.Windows.Forms.GroupBox();
            this.Tab.SuspendLayout();
            this.SelectVehicle.SuspendLayout();
            this.SelectPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBINFORMATIONS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.SelectVehicle);
            this.Tab.Controls.Add(this.SelectPerson);
            this.Tab.Location = new System.Drawing.Point(36, 62);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(864, 498);
            this.Tab.TabIndex = 0;
            // 
            // SelectVehicle
            // 
            this.SelectVehicle.Controls.Add(this.Next);
            this.SelectVehicle.Controls.Add(this.filterVehicule1);
            this.SelectVehicle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectVehicle.Location = new System.Drawing.Point(4, 22);
            this.SelectVehicle.Name = "SelectVehicle";
            this.SelectVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.SelectVehicle.Size = new System.Drawing.Size(856, 472);
            this.SelectVehicle.TabIndex = 0;
            this.SelectVehicle.Text = "Select Vehicle";
            this.SelectVehicle.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(680, 411);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(116, 45);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // filterVehicule1
            // 
            this.filterVehicule1.BackColor = System.Drawing.Color.White;
            this.filterVehicule1.FilterEnabled = false;
            this.filterVehicule1.Location = new System.Drawing.Point(4, 0);
            this.filterVehicule1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filterVehicule1.Name = "filterVehicule1";
            this.filterVehicule1.Size = new System.Drawing.Size(852, 472);
            this.filterVehicule1.TabIndex = 0;
            // 
            // SelectPerson
            // 
            this.SelectPerson.Controls.Add(this.button3);
            this.SelectPerson.Controls.Add(this.filerCustomers1);
            this.SelectPerson.Location = new System.Drawing.Point(4, 22);
            this.SelectPerson.Name = "SelectPerson";
            this.SelectPerson.Padding = new System.Windows.Forms.Padding(3);
            this.SelectPerson.Size = new System.Drawing.Size(856, 472);
            this.SelectPerson.TabIndex = 1;
            this.SelectPerson.Text = "Select Person";
            this.SelectPerson.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Valider";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filerCustomers1
            // 
            this.filerCustomers1.BackColor = System.Drawing.Color.White;
            this.filerCustomers1.FilterEnabled = false;
            this.filerCustomers1.Location = new System.Drawing.Point(6, 3);
            this.filerCustomers1.Name = "filerCustomers1";
            this.filerCustomers1.Size = new System.Drawing.Size(847, 466);
            this.filerCustomers1.TabIndex = 0;
            // 
            // TOTALPRICE
            // 
            this.TOTALPRICE.AutoSize = true;
            this.TOTALPRICE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTALPRICE.Location = new System.Drawing.Point(240, 241);
            this.TOTALPRICE.Name = "TOTALPRICE";
            this.TOTALPRICE.Size = new System.Drawing.Size(69, 15);
            this.TOTALPRICE.TabIndex = 269;
            this.TOTALPRICE.Text = "[????????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 15);
            this.label5.TabIndex = 268;
            this.label5.Text = "Initial Total Due Amount: ";
            // 
            // PRICE
            // 
            this.PRICE.AutoSize = true;
            this.PRICE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE.Location = new System.Drawing.Point(675, 183);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(69, 15);
            this.PRICE.TabIndex = 266;
            this.PRICE.Text = "[????????]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 265;
            this.label8.Text = "Rental Price Per Day : ";
            // 
            // DAYS
            // 
            this.DAYS.AutoSize = true;
            this.DAYS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAYS.Location = new System.Drawing.Point(240, 183);
            this.DAYS.Name = "DAYS";
            this.DAYS.Size = new System.Drawing.Size(69, 15);
            this.DAYS.TabIndex = 263;
            this.DAYS.Text = "[????????]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 15);
            this.label12.TabIndex = 262;
            this.label12.Text = "Initial Rental Days : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 15);
            this.label10.TabIndex = 259;
            this.label10.Text = "Drop off Location  : ";
            // 
            // Vehicleid
            // 
            this.Vehicleid.AutoSize = true;
            this.Vehicleid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicleid.Location = new System.Drawing.Point(240, 24);
            this.Vehicleid.Name = "Vehicleid";
            this.Vehicleid.Size = new System.Drawing.Size(69, 15);
            this.Vehicleid.TabIndex = 250;
            this.Vehicleid.Text = "[????????]";
            // 
            // Customerid
            // 
            this.Customerid.AutoSize = true;
            this.Customerid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerid.Location = new System.Drawing.Point(674, 24);
            this.Customerid.Name = "Customerid";
            this.Customerid.Size = new System.Drawing.Size(69, 15);
            this.Customerid.TabIndex = 249;
            this.Customerid.Text = "[????????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 248;
            this.label9.Text = "Pickup Location  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 247;
            this.label7.Text = "Rental End Date : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 246;
            this.label6.Text = "Rental Start Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 245;
            this.label4.Text = "Vehicle ID : ";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(460, 24);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(101, 15);
            this.Customer.TabIndex = 244;
            this.Customer.Text = "Customer ID : ";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(686, 74);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 271;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(243, 72);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 272;
            // 
            // Pickup
            // 
            this.Pickup.Location = new System.Drawing.Point(243, 128);
            this.Pickup.Multiline = true;
            this.Pickup.Name = "Pickup";
            this.Pickup.Size = new System.Drawing.Size(200, 31);
            this.Pickup.TabIndex = 273;
            this.Pickup.Click += new System.EventHandler(this.Pickup_Click);
            this.Pickup.TextChanged += new System.EventHandler(this.Pickup_TextChanged);
            this.Pickup.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.Pickup_ChangeUICues);
            // 
            // Dropoff
            // 
            this.Dropoff.Location = new System.Drawing.Point(686, 125);
            this.Dropoff.Multiline = true;
            this.Dropoff.Name = "Dropoff";
            this.Dropoff.Size = new System.Drawing.Size(200, 31);
            this.Dropoff.TabIndex = 274;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(460, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 15);
            this.label16.TabIndex = 275;
            this.label16.Text = "Initial Check Notes : ";
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(686, 220);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(200, 71);
            this.Notes.TabIndex = 277;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(679, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 278;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(828, 880);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 46);
            this.button2.TabIndex = 279;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Title_label.Location = new System.Drawing.Point(328, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(284, 50);
            this.Title_label.TabIndex = 280;
            this.Title_label.Text = "Booking Now ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RentalCar_Version1.Properties.Resources.icons8_notes_32;
            this.pictureBox5.Location = new System.Drawing.Point(638, 231);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 276;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RentalCar_Version1.Properties.Resources.icons8_money_transfer_32;
            this.pictureBox4.Location = new System.Drawing.Point(203, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 270;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::RentalCar_Version1.Properties.Resources.icons8_price_32;
            this.pictureBox10.Location = new System.Drawing.Point(638, 178);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 267;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::RentalCar_Version1.Properties.Resources.icons8_appointment_32;
            this.pictureBox9.Location = new System.Drawing.Point(203, 178);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 264;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::RentalCar_Version1.Properties.Resources.icons8_location_32;
            this.pictureBox8.Location = new System.Drawing.Point(638, 128);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 261;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::RentalCar_Version1.Properties.Resources.icons8_person_32;
            this.pictureBox7.Location = new System.Drawing.Point(638, 19);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 258;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::RentalCar_Version1.Properties.Resources.icons8_end_32;
            this.pictureBox6.Location = new System.Drawing.Point(638, 69);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 257;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RentalCar_Version1.Properties.Resources.icons8_car_32;
            this.pictureBox3.Location = new System.Drawing.Point(203, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 256;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RentalCar_Version1.Properties.Resources.icons8_pickup_point_32;
            this.pictureBox2.Location = new System.Drawing.Point(203, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 255;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentalCar_Version1.Properties.Resources.icons8_start_32__1_;
            this.pictureBox1.Location = new System.Drawing.Point(203, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 254;
            this.pictureBox1.TabStop = false;
            // 
            // GBINFORMATIONS
            // 
            this.GBINFORMATIONS.Controls.Add(this.pictureBox3);
            this.GBINFORMATIONS.Controls.Add(this.Customer);
            this.GBINFORMATIONS.Controls.Add(this.label4);
            this.GBINFORMATIONS.Controls.Add(this.label6);
            this.GBINFORMATIONS.Controls.Add(this.Notes);
            this.GBINFORMATIONS.Controls.Add(this.label7);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox5);
            this.GBINFORMATIONS.Controls.Add(this.label9);
            this.GBINFORMATIONS.Controls.Add(this.label16);
            this.GBINFORMATIONS.Controls.Add(this.Customerid);
            this.GBINFORMATIONS.Controls.Add(this.Dropoff);
            this.GBINFORMATIONS.Controls.Add(this.Vehicleid);
            this.GBINFORMATIONS.Controls.Add(this.Pickup);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox1);
            this.GBINFORMATIONS.Controls.Add(this.dateStart);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox2);
            this.GBINFORMATIONS.Controls.Add(this.dateEnd);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox6);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox4);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox7);
            this.GBINFORMATIONS.Controls.Add(this.TOTALPRICE);
            this.GBINFORMATIONS.Controls.Add(this.label10);
            this.GBINFORMATIONS.Controls.Add(this.label5);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox8);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox10);
            this.GBINFORMATIONS.Controls.Add(this.label12);
            this.GBINFORMATIONS.Controls.Add(this.PRICE);
            this.GBINFORMATIONS.Controls.Add(this.DAYS);
            this.GBINFORMATIONS.Controls.Add(this.label8);
            this.GBINFORMATIONS.Controls.Add(this.pictureBox9);
            this.GBINFORMATIONS.Location = new System.Drawing.Point(36, 566);
            this.GBINFORMATIONS.Name = "GBINFORMATIONS";
            this.GBINFORMATIONS.Size = new System.Drawing.Size(904, 308);
            this.GBINFORMATIONS.TabIndex = 281;
            this.GBINFORMATIONS.TabStop = false;
            this.GBINFORMATIONS.Text = "Informations";
            // 
            // FRM_ADDUPDATEBOOKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 940);
            this.Controls.Add(this.GBINFORMATIONS);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tab);
            this.Name = "FRM_ADDUPDATEBOOKING";
            this.Text = "FRM_ADDUPDATEBOOKING";
            this.Load += new System.EventHandler(this.FRM_ADDUPDATEBOOKING_Load);
            this.Tab.ResumeLayout(false);
            this.SelectVehicle.ResumeLayout(false);
            this.SelectPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBINFORMATIONS.ResumeLayout(false);
            this.GBINFORMATIONS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage SelectVehicle;
        private System.Windows.Forms.TabPage SelectPerson;
        private System.Windows.Forms.Button Next;
        private Vehicules1.control.FilterVehicule filterVehicule1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label TOTALPRICE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label PRICE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label DAYS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Vehicleid;
        private System.Windows.Forms.Label Customerid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox Pickup;
        private System.Windows.Forms.TextBox Dropoff;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Title_label;
        private Customers1.filerCustomers filerCustomers1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox GBINFORMATIONS;
    }
}