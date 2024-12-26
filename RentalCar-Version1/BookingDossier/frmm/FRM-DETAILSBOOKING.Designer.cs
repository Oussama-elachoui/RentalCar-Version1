namespace RentalCar_Version1.BookingDossier.frmm
{
    partial class FRM_DETAILSBOOKING
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailsBookingCtrl1
            // 
            this.detailsBookingCtrl1.Location = new System.Drawing.Point(50, 106);
            this.detailsBookingCtrl1.Name = "detailsBookingCtrl1";
            this.detailsBookingCtrl1.Size = new System.Drawing.Size(676, 526);
            this.detailsBookingCtrl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(251, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details Booking";
            // 
            // FRM_DETAILSBOOKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsBookingCtrl1);
            this.Name = "FRM_DETAILSBOOKING";
            this.Text = "FRM_DETAILSBOOKING";
            this.Load += new System.EventHandler(this.FRM_DETAILSBOOKING_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DetailsBookingCtrl detailsBookingCtrl1;
        private System.Windows.Forms.Label label1;
    }
}