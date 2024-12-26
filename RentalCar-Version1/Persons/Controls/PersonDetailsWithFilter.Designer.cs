namespace RentalCar_Version1.Persons.Controls
{
    partial class PersonDetailsWithFilter
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
            this.Filterbox = new System.Windows.Forms.GroupBox();
            this.FilterBy = new System.Windows.Forms.ComboBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.personDetails1 = new RentalCar_Version1.Persons.Controls.PersonDetails();
            this.button1 = new System.Windows.Forms.Button();
            this.Filterbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Filterbox
            // 
            this.Filterbox.Controls.Add(this.button1);
            this.Filterbox.Controls.Add(this.FilterBy);
            this.Filterbox.Controls.Add(this.SearchBTN);
            this.Filterbox.Controls.Add(this.SearchText);
            this.Filterbox.Location = new System.Drawing.Point(45, 20);
            this.Filterbox.Name = "Filterbox";
            this.Filterbox.Size = new System.Drawing.Size(730, 92);
            this.Filterbox.TabIndex = 1;
            this.Filterbox.TabStop = false;
            this.Filterbox.Text = "Filter";
            // 
            // FilterBy
            // 
            this.FilterBy.FormattingEnabled = true;
            this.FilterBy.Items.AddRange(new object[] {
            "Person ID",
            "Nationality ID"});
            this.FilterBy.Location = new System.Drawing.Point(55, 36);
            this.FilterBy.Name = "FilterBy";
            this.FilterBy.Size = new System.Drawing.Size(121, 21);
            this.FilterBy.TabIndex = 2;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Image = global::RentalCar_Version1.Properties.Resources.SearchPerson;
            this.SearchBTN.Location = new System.Drawing.Point(402, 27);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(43, 36);
            this.SearchBTN.TabIndex = 1;
            this.SearchBTN.UseCompatibleTextRendering = true;
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchText
            // 
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchText.Location = new System.Drawing.Point(193, 36);
            this.SearchText.Multiline = true;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(203, 21);
            this.SearchText.TabIndex = 0;
            this.SearchText.Validating += new System.ComponentModel.CancelEventHandler(this.SearchText_Validating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // personDetails1
            // 
            this.personDetails1.BackColor = System.Drawing.Color.White;
            this.personDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personDetails1.Location = new System.Drawing.Point(45, 118);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.Size = new System.Drawing.Size(730, 275);
            this.personDetails1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = global::RentalCar_Version1.Properties.Resources.AddPerson_32;
            this.button1.Location = new System.Drawing.Point(451, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 36);
            this.button1.TabIndex = 3;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Filterbox);
            this.Controls.Add(this.personDetails1);
            this.Name = "PersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(810, 416);
            this.Load += new System.EventHandler(this.PersonDetailsWithFilter_Load);
            this.Filterbox.ResumeLayout(false);
            this.Filterbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails personDetails1;
        private System.Windows.Forms.GroupBox Filterbox;
        private System.Windows.Forms.ComboBox FilterBy;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}
