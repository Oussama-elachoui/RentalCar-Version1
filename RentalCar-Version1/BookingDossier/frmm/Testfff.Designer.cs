namespace RentalCar_Version1.BookingDossier.frmm
{
    partial class Testfff
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
            this.detailsBookingCtrl1 = new RentalCar_Version1.BookingDossier.Controls.DetailsBookingCtrl();
            this.SuspendLayout();
            // 
            // detailsBookingCtrl1
            // 
            this.detailsBookingCtrl1.Location = new System.Drawing.Point(1, 12);
            this.detailsBookingCtrl1.Name = "detailsBookingCtrl1";
            this.detailsBookingCtrl1.Size = new System.Drawing.Size(734, 498);
            this.detailsBookingCtrl1.TabIndex = 0;
            // 
            // Testfff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 553);
            this.Controls.Add(this.detailsBookingCtrl1);
            this.Name = "Testfff";
            this.Text = "Testfff";
            this.Load += new System.EventHandler(this.Testfff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DetailsBookingCtrl detailsBookingCtrl1;
    }
}