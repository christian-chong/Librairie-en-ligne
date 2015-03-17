namespace IHMBackOffice.GestionAchatsVentes
{
    partial class TableDesCommandes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panierGroupBox = new System.Windows.Forms.GroupBox();
            this.panierDataGridView = new System.Windows.Forms.DataGridView();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermerButton = new System.Windows.Forms.Button();
            this.rechercherLabel = new System.Windows.Forms.Label();
            this.rechercherTextBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafraichirButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeGroupBox = new System.Windows.Forms.GroupBox();
            this.panierGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.commandeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panierGroupBox
            // 
            this.panierGroupBox.Controls.Add(this.panierDataGridView);
            this.panierGroupBox.Location = new System.Drawing.Point(218, 58);
            this.panierGroupBox.Name = "panierGroupBox";
            this.panierGroupBox.Size = new System.Drawing.Size(665, 270);
            this.panierGroupBox.TabIndex = 20;
            this.panierGroupBox.TabStop = false;
            this.panierGroupBox.Text = "Détails du panier";
            // 
            // panierDataGridView
            // 
            this.panierDataGridView.AllowUserToAddRows = false;
            this.panierDataGridView.AllowUserToDeleteRows = false;
            this.panierDataGridView.AllowUserToResizeRows = false;
            this.panierDataGridView.AutoGenerateColumns = false;
            this.panierDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.panierDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panierDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.panierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantiteDataGridViewTextBoxColumn,
            this.ISBN,
            this.Titre,
            this.Prix,
            this.tVADataGridViewTextBoxColumn,
            this.prixTTCDataGridViewTextBoxColumn});
            this.panierDataGridView.DataSource = this.panierBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panierDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.panierDataGridView.Location = new System.Drawing.Point(6, 19);
            this.panierDataGridView.Name = "panierDataGridView";
            this.panierDataGridView.ReadOnly = true;
            this.panierDataGridView.RowHeadersVisible = false;
            this.panierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.panierDataGridView.Size = new System.Drawing.Size(652, 245);
            this.panierDataGridView.TabIndex = 10;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Titre
            // 
            this.Titre.DataPropertyName = "Titre";
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            this.Titre.Width = 150;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixTTCDataGridViewTextBoxColumn
            // 
            this.prixTTCDataGridViewTextBoxColumn.DataPropertyName = "PrixTTC";
            this.prixTTCDataGridViewTextBoxColumn.HeaderText = "PrixTTC";
            this.prixTTCDataGridViewTextBoxColumn.Name = "prixTTCDataGridViewTextBoxColumn";
            this.prixTTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panierBindingSource
            // 
            this.panierBindingSource.DataSource = typeof(DAL.Models.Panier);
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(795, 334);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(75, 23);
            this.fermerButton.TabIndex = 18;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // rechercherLabel
            // 
            this.rechercherLabel.AutoSize = true;
            this.rechercherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherLabel.Location = new System.Drawing.Point(25, 16);
            this.rechercherLabel.Name = "rechercherLabel";
            this.rechercherLabel.Size = new System.Drawing.Size(299, 24);
            this.rechercherLabel.TabIndex = 17;
            this.rechercherLabel.Text = "Numéro de commande recherché";
            // 
            // rechercherTextBox
            // 
            this.rechercherTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherTextBox.Location = new System.Drawing.Point(345, 13);
            this.rechercherTextBox.Name = "rechercherTextBox";
            this.rechercherTextBox.Size = new System.Drawing.Size(202, 31);
            this.rechercherTextBox.TabIndex = 16;
            this.rechercherTextBox.TextChanged += new System.EventHandler(this.rechercherTextBox_TextChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // rafraichirButton
            // 
            this.rafraichirButton.Location = new System.Drawing.Point(701, 334);
            this.rafraichirButton.Name = "rafraichirButton";
            this.rafraichirButton.Size = new System.Drawing.Size(75, 23);
            this.rafraichirButton.TabIndex = 19;
            this.rafraichirButton.Text = "Rafraichir";
            this.rafraichirButton.UseVisualStyleBackColor = true;
            this.rafraichirButton.Click += new System.EventHandler(this.rafraichirButton_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // commandeDataGrid
            // 
            this.commandeDataGrid.AllowUserToAddRows = false;
            this.commandeDataGrid.AllowUserToDeleteRows = false;
            this.commandeDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commandeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.commandeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.Date});
            this.commandeDataGrid.DataSource = this.commandeBindingSource;
            this.commandeDataGrid.Location = new System.Drawing.Point(6, 19);
            this.commandeDataGrid.Name = "commandeDataGrid";
            this.commandeDataGrid.ReadOnly = true;
            this.commandeDataGrid.RowHeadersVisible = false;
            this.commandeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commandeDataGrid.Size = new System.Drawing.Size(194, 245);
            this.commandeDataGrid.TabIndex = 13;
            this.commandeDataGrid.SelectionChanged += new System.EventHandler(this.commandeDataGrid_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 140;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataSource = typeof(DAL.Models.Commande);
            // 
            // commandeGroupBox
            // 
            this.commandeGroupBox.Controls.Add(this.commandeDataGrid);
            this.commandeGroupBox.Location = new System.Drawing.Point(12, 58);
            this.commandeGroupBox.Name = "commandeGroupBox";
            this.commandeGroupBox.Size = new System.Drawing.Size(200, 270);
            this.commandeGroupBox.TabIndex = 21;
            this.commandeGroupBox.TabStop = false;
            this.commandeGroupBox.Text = "Liste des commandes";
            // 
            // TableDesCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 380);
            this.Controls.Add(this.panierGroupBox);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.rechercherLabel);
            this.Controls.Add(this.rechercherTextBox);
            this.Controls.Add(this.rafraichirButton);
            this.Controls.Add(this.commandeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableDesCommandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableDesCommandes";
            this.Load += new System.EventHandler(this.TableDesCommandes_Load);
            this.panierGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.commandeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox panierGroupBox;
        private System.Windows.Forms.DataGridView panierDataGridView;
        private System.Windows.Forms.BindingSource panierBindingSource;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.Label rechercherLabel;
        private System.Windows.Forms.TextBox rechercherTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button rafraichirButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.DataGridView commandeDataGrid;
        private System.Windows.Forms.GroupBox commandeGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTTCDataGridViewTextBoxColumn;

    }
}