namespace RentalCar_Version1
{
    partial class Vehicules
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
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.FilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DGVVEHICLES = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEAVAIBILTYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnAddVehicule = new System.Windows.Forms.Button();
            this.Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVEHICLES)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterText);
            this.Filter.Controls.Add(this.FilterBy);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Location = new System.Drawing.Point(38, 192);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(707, 55);
            this.Filter.TabIndex = 108;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // FilterText
            // 
            this.FilterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterText.Location = new System.Drawing.Point(223, 19);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(145, 20);
            this.FilterText.TabIndex = 96;
            this.FilterText.TextChanged += new System.EventHandler(this.FilterText_TextChanged);
            // 
            // FilterBy
            // 
            this.FilterBy.FormattingEnabled = true;
            this.FilterBy.Items.AddRange(new object[] {
            "Vehicule ID",
            "Plate Number",
            "Make",
            "Model"});
            this.FilterBy.Location = new System.Drawing.Point(78, 18);
            this.FilterBy.Name = "FilterBy";
            this.FilterBy.Size = new System.Drawing.Size(121, 21);
            this.FilterBy.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Filter By :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(265, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(379, 39);
            this.lblTitle.TabIndex = 107;
            this.lblTitle.Text = "Manage vehicules";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVVEHICLES
            // 
            this.DGVVEHICLES.BackgroundColor = System.Drawing.Color.White;
            this.DGVVEHICLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVEHICLES.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVVEHICLES.Location = new System.Drawing.Point(38, 253);
            this.DGVVEHICLES.Name = "DGVVEHICLES";
            this.DGVVEHICLES.Size = new System.Drawing.Size(808, 244);
            this.DGVVEHICLES.TabIndex = 104;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.uPDATEToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.uPDATEAVAIBILTYToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_add_car_32;
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDToolStripMenuItem.Text = "ADD";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_modifier_voiture_32;
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            this.uPDATEToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_supprimer_voiture_32;
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // uPDATEAVAIBILTYToolStripMenuItem
            // 
            this.uPDATEAVAIBILTYToolStripMenuItem.Image = global::RentalCar_Version1.Properties.Resources.icons8_volet_de_détails_32;
            this.uPDATEAVAIBILTYToolStripMenuItem.Name = "uPDATEAVAIBILTYToolStripMenuItem";
            this.uPDATEAVAIBILTYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uPDATEAVAIBILTYToolStripMenuItem.Text = "INFO";
            this.uPDATEAVAIBILTYToolStripMenuItem.Click += new System.EventHandler(this.uPDATEAVAIBILTYToolStripMenuItem_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::RentalCar_Version1.Properties.Resources.icons8_vehicle_100;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(365, 14);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(166, 128);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 106;
            this.pbPersonImage.TabStop = false;
            // 
            // btnAddVehicule
            // 
            this.btnAddVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicule.Image = global::RentalCar_Version1.Properties.Resources.icons8_add_321;
            this.btnAddVehicule.Location = new System.Drawing.Point(751, 192);
            this.btnAddVehicule.Name = "btnAddVehicule";
            this.btnAddVehicule.Size = new System.Drawing.Size(73, 53);
            this.btnAddVehicule.TabIndex = 105;
            this.btnAddVehicule.UseVisualStyleBackColor = true;
            this.btnAddVehicule.Click += new System.EventHandler(this.btnAddVehicule_Click);
            // 
            // Vehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.btnAddVehicule);
            this.Controls.Add(this.DGVVEHICLES);
            this.Name = "Vehicules";
            this.Size = new System.Drawing.Size(876, 569);
            this.Load += new System.EventHandler(this.Vehicules_Load);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVEHICLES)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterText;
        private System.Windows.Forms.ComboBox FilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnAddVehicule;
        private System.Windows.Forms.DataGridView DGVVEHICLES;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEAVAIBILTYToolStripMenuItem;
    }
}
