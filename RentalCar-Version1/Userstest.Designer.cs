namespace RentalCar_Version1
{
    partial class Userstest
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
            this.users1 = new RentalCar_Version1.UserControlMenu.Users();
            this.SuspendLayout();
            // 
            // users1
            // 
            this.users1.Location = new System.Drawing.Point(12, 2);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(876, 569);
            this.users1.TabIndex = 0;
            this.users1.Load += new System.EventHandler(this.users1_Load);
            // 
            // Userstest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 553);
            this.Controls.Add(this.users1);
            this.Name = "Userstest";
            this.Text = "Userstest";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlMenu.Users users1;
    }
}