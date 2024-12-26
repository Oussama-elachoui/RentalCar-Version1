namespace RentalCar_Version1.Vehicules1.control
{
    partial class FilterVehicule
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
            this.detailsVehicule1 = new RentalCar_Version1.Vehicules1.DetailsVehicule();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsVehicule1
            // 
            this.detailsVehicule1.BackColor = System.Drawing.Color.White;
            this.detailsVehicule1.Location = new System.Drawing.Point(3, 64);
            this.detailsVehicule1.Name = "detailsVehicule1";
            this.detailsVehicule1.Size = new System.Drawing.Size(643, 361);
            this.detailsVehicule1.TabIndex = 0;
            this.detailsVehicule1.Load += new System.EventHandler(this.detailsVehicule1_Load);
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.textBox1);
            this.Filter.Controls.Add(this.SearchBTN);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Controls.Add(this.comboBox1);
            this.Filter.Location = new System.Drawing.Point(37, 8);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(589, 63);
            this.Filter.TabIndex = 1;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
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
            "Vehicle ID",
            "Plate Number"});
            this.comboBox1.Location = new System.Drawing.Point(102, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FilterVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.detailsVehicule1);
            this.Name = "FilterVehicule";
            this.Size = new System.Drawing.Size(653, 426);
            this.Load += new System.EventHandler(this.FilterVehicule_Load);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DetailsVehicule detailsVehicule1;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
