namespace RentalCar_Version1.Persons.Forms
{
    partial class Frm_PesonDetailsWithfilter
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
            this.personDetailsWithFilter1 = new RentalCar_Version1.Persons.Controls.PersonDetailsWithFilter();
            this.SuspendLayout();
            // 
            // personDetailsWithFilter1
            // 
            this.personDetailsWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.personDetailsWithFilter1.Name = "personDetailsWithFilter1";
            this.personDetailsWithFilter1.Size = new System.Drawing.Size(807, 432);
            this.personDetailsWithFilter1.TabIndex = 0;
            this.personDetailsWithFilter1.Load += new System.EventHandler(this.personDetailsWithFilter1_Load);
            // 
            // Frm_PesonDetailsWithfilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 460);
            this.Controls.Add(this.personDetailsWithFilter1);
            this.Name = "Frm_PesonDetailsWithfilter";
            this.Text = "Frm_PesonDetailsWithfilter";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PersonDetailsWithFilter personDetailsWithFilter1;
    }
}