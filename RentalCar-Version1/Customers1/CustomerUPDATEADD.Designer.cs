namespace RentalCar_Version1.Customers1
{
    partial class CustomerUPDATEADD
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
            this.PersonTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerTAB = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.personIDTXT = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.Label();
            this.CustomerIDTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DriverLicenseNumberTXT = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.personDetailsWithFilter1 = new RentalCar_Version1.Persons.Controls.PersonDetailsWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.PersonTab.SuspendLayout();
            this.CustomerTAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonTab);
            this.tabControl1.Controls.Add(this.CustomerTAB);
            this.tabControl1.Location = new System.Drawing.Point(24, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 493);
            this.tabControl1.TabIndex = 1;
            // 
            // PersonTab
            // 
            this.PersonTab.BackColor = System.Drawing.Color.White;
            this.PersonTab.Controls.Add(this.button1);
            this.PersonTab.Controls.Add(this.personDetailsWithFilter1);
            this.PersonTab.Location = new System.Drawing.Point(4, 22);
            this.PersonTab.Name = "PersonTab";
            this.PersonTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonTab.Size = new System.Drawing.Size(817, 467);
            this.PersonTab.TabIndex = 0;
            this.PersonTab.Text = "Select Person";
            // 
            // button1
            // 
            this.button1.Image = global::RentalCar_Version1.Properties.Resources.Next_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(670, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerTAB
            // 
            this.CustomerTAB.Controls.Add(this.pictureBox2);
            this.CustomerTAB.Controls.Add(this.label6);
            this.CustomerTAB.Controls.Add(this.personIDTXT);
            this.CustomerTAB.Controls.Add(this.TITLE);
            this.CustomerTAB.Controls.Add(this.CustomerIDTXT);
            this.CustomerTAB.Controls.Add(this.label4);
            this.CustomerTAB.Controls.Add(this.label1);
            this.CustomerTAB.Controls.Add(this.DriverLicenseNumberTXT);
            this.CustomerTAB.Controls.Add(this.pictureBox7);
            this.CustomerTAB.Controls.Add(this.button3);
            this.CustomerTAB.Controls.Add(this.button2);
            this.CustomerTAB.Location = new System.Drawing.Point(4, 22);
            this.CustomerTAB.Name = "CustomerTAB";
            this.CustomerTAB.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTAB.Size = new System.Drawing.Size(817, 467);
            this.CustomerTAB.TabIndex = 1;
            this.CustomerTAB.Text = "Customer";
            this.CustomerTAB.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RentalCar_Version1.Properties.Resources.PersonDetails_32;
            this.pictureBox2.Location = new System.Drawing.Point(259, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 157;
            this.label6.Text = "Person ID :";
            // 
            // personIDTXT
            // 
            this.personIDTXT.Enabled = false;
            this.personIDTXT.Location = new System.Drawing.Point(316, 153);
            this.personIDTXT.Name = "personIDTXT";
            this.personIDTXT.Size = new System.Drawing.Size(159, 20);
            this.personIDTXT.TabIndex = 156;
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.Red;
            this.TITLE.Location = new System.Drawing.Point(195, 22);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(434, 42);
            this.TITLE.TabIndex = 155;
            this.TITLE.Text = "ADD NEW CUSTOMER";
            // 
            // CustomerIDTXT
            // 
            this.CustomerIDTXT.AutoSize = true;
            this.CustomerIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTXT.ForeColor = System.Drawing.Color.Red;
            this.CustomerIDTXT.Location = new System.Drawing.Point(160, 87);
            this.CustomerIDTXT.Name = "CustomerIDTXT";
            this.CustomerIDTXT.Size = new System.Drawing.Size(54, 18);
            this.CustomerIDTXT.TabIndex = 152;
            this.CustomerIDTXT.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 151;
            this.label4.Text = "Customer ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 148;
            this.label1.Text = "Driver License Number :";
            // 
            // DriverLicenseNumberTXT
            // 
            this.DriverLicenseNumberTXT.Location = new System.Drawing.Point(317, 193);
            this.DriverLicenseNumberTXT.Name = "DriverLicenseNumberTXT";
            this.DriverLicenseNumberTXT.Size = new System.Drawing.Size(159, 20);
            this.DriverLicenseNumberTXT.TabIndex = 143;
            this.DriverLicenseNumberTXT.TextChanged += new System.EventHandler(this.DriverLicenseNumberTXT_TextChanged);
            this.DriverLicenseNumberTXT.Validating += new System.ComponentModel.CancelEventHandler(this.DriverLicenseNumberTXT_Validating);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::RentalCar_Version1.Properties.Resources.Person_32;
            this.pictureBox7.Location = new System.Drawing.Point(259, 191);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 153;
            this.pictureBox7.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = global::RentalCar_Version1.Properties.Resources.Close_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(542, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 146;
            this.button3.Text = "    Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::RentalCar_Version1.Properties.Resources.Save_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(671, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 145;
            this.button2.Text = "    Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personDetailsWithFilter1
            // 
            this.personDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.personDetailsWithFilter1.FilterEnabled = false;
            this.personDetailsWithFilter1.Location = new System.Drawing.Point(6, 4);
            this.personDetailsWithFilter1.Name = "personDetailsWithFilter1";
            this.personDetailsWithFilter1.Size = new System.Drawing.Size(798, 416);
            this.personDetailsWithFilter1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // CustomerUPDATEADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerUPDATEADD";
            this.Text = "CustomerUPDATEADD";
            this.Load += new System.EventHandler(this.CustomerUPDATEADD_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonTab.ResumeLayout(false);
            this.CustomerTAB.ResumeLayout(false);
            this.CustomerTAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonTab;
        private System.Windows.Forms.Button button1;
        private Persons.Controls.PersonDetailsWithFilter personDetailsWithFilter1;
        private System.Windows.Forms.TabPage CustomerTAB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox personIDTXT;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Label CustomerIDTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DriverLicenseNumberTXT;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}