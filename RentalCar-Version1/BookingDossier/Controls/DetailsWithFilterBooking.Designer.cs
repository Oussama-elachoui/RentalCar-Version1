namespace RentalCar_Version1.BookingDossier.Controls
{
    partial class DetailsWithFilterBooking
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
            this.components = new System.ComponentModel.Container();
            this.detailsBookingCtrl1 = new RentalCar_Version1.BookingDossier.Controls.DetailsBookingCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsBookingCtrl1
            // 
            this.detailsBookingCtrl1.Location = new System.Drawing.Point(81, 111);
            this.detailsBookingCtrl1.Name = "detailsBookingCtrl1";
            this.detailsBookingCtrl1.Size = new System.Drawing.Size(676, 526);
            this.detailsBookingCtrl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextSearch);
            this.groupBox1.Controls.Add(this.SearchBTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(106, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(344, 30);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(140, 20);
            this.TextSearch.TabIndex = 9;
            this.TextSearch.Validated += new System.EventHandler(this.TextSearch_Validated);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Image = global::RentalCar_Version1.Properties.Resources.icons8_chercher_32;
            this.SearchBTN.Location = new System.Drawing.Point(509, 22);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(43, 36);
            this.SearchBTN.TabIndex = 8;
            this.SearchBTN.UseCompatibleTextRendering = true;
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter By :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Booking ID"});
            this.comboBox1.Location = new System.Drawing.Point(164, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DetailsWithFilterBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detailsBookingCtrl1);
            this.Name = "DetailsWithFilterBooking";
            this.Size = new System.Drawing.Size(814, 639);
            this.Load += new System.EventHandler(this.DetailsWithFilterBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DetailsBookingCtrl detailsBookingCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
