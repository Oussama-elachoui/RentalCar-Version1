namespace RentalCar_Version1.Dossier_Returns.frm
{
    partial class frm_ReturnDetails
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
            this.returnDetails1 = new RentalCar_Version1.Dossier_Returns.Control.ReturnDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnDetails1
            // 
            this.returnDetails1.Location = new System.Drawing.Point(35, 56);
            this.returnDetails1.Name = "returnDetails1";
            this.returnDetails1.Size = new System.Drawing.Size(681, 461);
            this.returnDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(239, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details Returns";
            // 
            // frm_ReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnDetails1);
            this.Name = "frm_ReturnDetails";
            this.Text = "frm_ReturnDetails";
            this.Load += new System.EventHandler(this.frm_ReturnDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ReturnDetails returnDetails1;
        private System.Windows.Forms.Label label1;
    }
}