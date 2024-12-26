namespace RentalCar_Version1
{
    partial class Transactions
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReturnDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciveMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciveMoneyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblTitle.Location = new System.Drawing.Point(250, 186);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(379, 39);
            this.lblTitle.TabIndex = 112;
            this.lblTitle.Text = "Transactions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTransactions.Location = new System.Drawing.Point(34, 266);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ShowRowErrors = false;
            this.dgvTransactions.Size = new System.Drawing.Size(808, 244);
            this.dgvTransactions.TabIndex = 109;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerDetailsToolStripMenuItem,
            this.showBookingDetailsToolStripMenuItem,
            this.showReturnDetailsToolStripMenuItem,
            this.reciveMoneyToolStripMenuItem,
            this.reciveMoneyToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 136);
            // 
            // showCustomerDetailsToolStripMenuItem
            // 
            this.showCustomerDetailsToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_view_details_481;
            this.showCustomerDetailsToolStripMenuItem.Name = "showCustomerDetailsToolStripMenuItem";
            this.showCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showCustomerDetailsToolStripMenuItem.Text = "Show Customer Details";
            this.showCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCustomerDetailsToolStripMenuItem_Click);
            // 
            // showBookingDetailsToolStripMenuItem
            // 
            this.showBookingDetailsToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_view_details_481;
            this.showBookingDetailsToolStripMenuItem.Name = "showBookingDetailsToolStripMenuItem";
            this.showBookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showBookingDetailsToolStripMenuItem.Text = "Show Booking Details";
            this.showBookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.showBookingDetailsToolStripMenuItem_Click);
            // 
            // showReturnDetailsToolStripMenuItem
            // 
            this.showReturnDetailsToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_view_details_481;
            this.showReturnDetailsToolStripMenuItem.Name = "showReturnDetailsToolStripMenuItem";
            this.showReturnDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showReturnDetailsToolStripMenuItem.Text = "Show Return Details";
            this.showReturnDetailsToolStripMenuItem.Click += new System.EventHandler(this.showReturnDetailsToolStripMenuItem_Click);
            // 
            // reciveMoneyToolStripMenuItem
            // 
            this.reciveMoneyToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_view_details_481;
            this.reciveMoneyToolStripMenuItem.Name = "reciveMoneyToolStripMenuItem";
            this.reciveMoneyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reciveMoneyToolStripMenuItem.Text = "Vehicle Details";
            this.reciveMoneyToolStripMenuItem.Click += new System.EventHandler(this.reciveMoneyToolStripMenuItem_Click);
            // 
            // reciveMoneyToolStripMenuItem1
            // 
            this.reciveMoneyToolStripMenuItem1.Image = global::RentalCar_Version1.Properties.Resources.Release_Detained_License_32;
            this.reciveMoneyToolStripMenuItem1.Name = "reciveMoneyToolStripMenuItem1";
            this.reciveMoneyToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.reciveMoneyToolStripMenuItem1.Text = "Recive Payment";
            this.reciveMoneyToolStripMenuItem1.Click += new System.EventHandler(this.reciveMoneyToolStripMenuItem1_Click_1);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::RentalCar_Version1.Properties.Resources.icons8_transaction_96;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(385, 69);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(112, 100);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 111;
            this.pbPersonImage.TabStop = false;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(876, 569);
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReturnDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciveMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciveMoneyToolStripMenuItem1;
    }
}
