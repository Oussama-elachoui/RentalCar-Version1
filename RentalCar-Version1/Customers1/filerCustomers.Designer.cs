namespace RentalCar_Version1.Customers1
{
    partial class filerCustomers
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.personDetails1 = new RentalCar_Version1.Persons.Controls.PersonDetails();
            this.CustomerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.customid = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.driverlicence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // personDetails1
            // 
            this.personDetails1.BackColor = System.Drawing.Color.White;
            this.personDetails1.Location = new System.Drawing.Point(16, 124);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.Size = new System.Drawing.Size(730, 313);
            this.personDetails1.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(237, 422);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(69, 15);
            this.CustomerID.TabIndex = 153;
            this.CustomerID.Text = "[????????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 152;
            this.label3.Text = "DriverLicenseNumber : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 151;
            this.label2.Text = "Customer ID : ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::RentalCar_Version1.Properties.Resources.Person_32;
            this.pictureBox7.Location = new System.Drawing.Point(201, 417);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 155;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RentalCar_Version1.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(367, 417);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 154;
            this.pictureBox4.TabStop = false;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.customid);
            this.Filter.Controls.Add(this.SearchBTN);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Controls.Add(this.comboBox1);
            this.Filter.Location = new System.Drawing.Point(87, 39);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(589, 63);
            this.Filter.TabIndex = 156;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // customid
            // 
            this.customid.Location = new System.Drawing.Point(282, 24);
            this.customid.Name = "customid";
            this.customid.Size = new System.Drawing.Size(140, 20);
            this.customid.TabIndex = 5;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Image = global::RentalCar_Version1.Properties.Resources.icons8_chercher_32;
            this.SearchBTN.Location = new System.Drawing.Point(447, 16);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(43, 36);
            this.SearchBTN.TabIndex = 4;
            this.SearchBTN.UseCompatibleTextRendering = true;
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer ID"});
            this.comboBox1.Location = new System.Drawing.Point(102, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // driverlicence
            // 
            this.driverlicence.AutoSize = true;
            this.driverlicence.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverlicence.Location = new System.Drawing.Point(583, 422);
            this.driverlicence.Name = "driverlicence";
            this.driverlicence.Size = new System.Drawing.Size(69, 15);
            this.driverlicence.TabIndex = 157;
            this.driverlicence.Text = "[????????]";
            // 
            // filerCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.driverlicence);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personDetails1);
            this.Name = "filerCustomers";
            this.Size = new System.Drawing.Size(756, 492);
            this.Load += new System.EventHandler(this.filerCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Persons.Controls.PersonDetails personDetails1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox customid;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label driverlicence;
    }
}
