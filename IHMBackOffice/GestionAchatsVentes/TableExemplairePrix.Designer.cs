namespace IHMBackOffice.GestionAchatsVentes
{
    partial class TableExemplairePrix
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
            this.exemplaireDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditeurId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URLimage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.afficherLesPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPrincipalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rafraichirButton = new System.Windows.Forms.Button();
            this.fermerButton = new System.Windows.Forms.Button();
            this.rechercherLabel = new System.Windows.Forms.Label();
            this.rechercherTextBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sousTitreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exemplaireGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireDataGridView)).BeginInit();
            this.prixContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource)).BeginInit();
            this.menuPrincipalContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            this.exemplaireGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exemplaireDataGridView
            // 
            this.exemplaireDataGridView.AllowUserToAddRows = false;
            this.exemplaireDataGridView.AllowUserToDeleteRows = false;
            this.exemplaireDataGridView.AllowUserToResizeRows = false;
            this.exemplaireDataGridView.AutoGenerateColumns = false;
            this.exemplaireDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exemplaireDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.exemplaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exemplaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.LivreId,
            this.EditeurId,
            this.ISBN,
            this.Type,
            this.Stock,
            this.Pages,
            this.URLimage,
            this.DateEdition});
            this.exemplaireDataGridView.ContextMenuStrip = this.prixContextMenu;
            this.exemplaireDataGridView.DataSource = this.exemplaireBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exemplaireDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.exemplaireDataGridView.Location = new System.Drawing.Point(24, 19);
            this.exemplaireDataGridView.Name = "exemplaireDataGridView";
            this.exemplaireDataGridView.ReadOnly = true;
            this.exemplaireDataGridView.RowHeadersVisible = false;
            this.exemplaireDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exemplaireDataGridView.Size = new System.Drawing.Size(713, 162);
            this.exemplaireDataGridView.TabIndex = 10;
            this.exemplaireDataGridView.SelectionChanged += new System.EventHandler(this.exemplaireDataGridView_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // LivreId
            // 
            this.LivreId.DataPropertyName = "LivreId";
            this.LivreId.HeaderText = "LivreId";
            this.LivreId.Name = "LivreId";
            this.LivreId.ReadOnly = true;
            this.LivreId.Width = 50;
            // 
            // EditeurId
            // 
            this.EditeurId.DataPropertyName = "EditeurId";
            this.EditeurId.HeaderText = "EditeurId";
            this.EditeurId.Name = "EditeurId";
            this.EditeurId.ReadOnly = true;
            this.EditeurId.Width = 50;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 50;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Pages
            // 
            this.Pages.DataPropertyName = "Pages";
            this.Pages.HeaderText = "Pages";
            this.Pages.Name = "Pages";
            this.Pages.ReadOnly = true;
            // 
            // URLimage
            // 
            this.URLimage.DataPropertyName = "URLimage";
            this.URLimage.HeaderText = "URLimage";
            this.URLimage.Name = "URLimage";
            this.URLimage.ReadOnly = true;
            // 
            // DateEdition
            // 
            this.DateEdition.DataPropertyName = "DateEdition";
            this.DateEdition.HeaderText = "DateEdition";
            this.DateEdition.Name = "DateEdition";
            this.DateEdition.ReadOnly = true;
            // 
            // prixContextMenu
            // 
            this.prixContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLesPrixToolStripMenuItem,
            this.modifierLeStockToolStripMenuItem});
            this.prixContextMenu.Name = "contextMenuStrip1";
            this.prixContextMenu.Size = new System.Drawing.Size(164, 48);
            // 
            // afficherLesPrixToolStripMenuItem
            // 
            this.afficherLesPrixToolStripMenuItem.Name = "afficherLesPrixToolStripMenuItem";
            this.afficherLesPrixToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.afficherLesPrixToolStripMenuItem.Text = "Afficher les prix";
            this.afficherLesPrixToolStripMenuItem.Click += new System.EventHandler(this.afficherLesPrixToolStripMenuItem_Click);
            // 
            // modifierLeStockToolStripMenuItem
            // 
            this.modifierLeStockToolStripMenuItem.Name = "modifierLeStockToolStripMenuItem";
            this.modifierLeStockToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.modifierLeStockToolStripMenuItem.Text = "Modifier le Stock";
            this.modifierLeStockToolStripMenuItem.Click += new System.EventHandler(this.modifierLeStockToolStripMenuItem_Click);
            // 
            // exemplaireBindingSource
            // 
            this.exemplaireBindingSource.DataSource = typeof(DAL.Models.Exemplaire);
            // 
            // menuPrincipalContextMenu
            // 
            this.menuPrincipalContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.menuPrincipalContextMenu.Name = "menuPrincipalContextMenu";
            this.menuPrincipalContextMenu.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // rafraichirButton
            // 
            this.rafraichirButton.Location = new System.Drawing.Point(580, 538);
            this.rafraichirButton.Name = "rafraichirButton";
            this.rafraichirButton.Size = new System.Drawing.Size(75, 23);
            this.rafraichirButton.TabIndex = 12;
            this.rafraichirButton.Text = "Rafraichir";
            this.rafraichirButton.UseVisualStyleBackColor = true;
            this.rafraichirButton.Click += new System.EventHandler(this.rafraichirButton_Click);
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(674, 538);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(75, 23);
            this.fermerButton.TabIndex = 11;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click_1);
            // 
            // rechercherLabel
            // 
            this.rechercherLabel.AutoSize = true;
            this.rechercherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherLabel.Location = new System.Drawing.Point(172, 27);
            this.rechercherLabel.Name = "rechercherLabel";
            this.rechercherLabel.Size = new System.Drawing.Size(163, 24);
            this.rechercherLabel.TabIndex = 9;
            this.rechercherLabel.Text = "Mot clé recherché";
            // 
            // rechercherTextBox
            // 
            this.rechercherTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherTextBox.Location = new System.Drawing.Point(345, 24);
            this.rechercherTextBox.Name = "rechercherTextBox";
            this.rechercherTextBox.Size = new System.Drawing.Size(202, 31);
            this.rechercherTextBox.TabIndex = 8;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titreDataGridViewTextBoxColumn,
            this.sousTitreDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn,
            this.resumeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(713, 245);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sousTitreDataGridViewTextBoxColumn
            // 
            this.sousTitreDataGridViewTextBoxColumn.DataPropertyName = "SousTitre";
            this.sousTitreDataGridViewTextBoxColumn.HeaderText = "SousTitre";
            this.sousTitreDataGridViewTextBoxColumn.Name = "sousTitreDataGridViewTextBoxColumn";
            this.sousTitreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resumeDataGridViewTextBoxColumn
            // 
            this.resumeDataGridViewTextBoxColumn.DataPropertyName = "Resume";
            this.resumeDataGridViewTextBoxColumn.HeaderText = "Resume";
            this.resumeDataGridViewTextBoxColumn.Name = "resumeDataGridViewTextBoxColumn";
            this.resumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.resumeDataGridViewTextBoxColumn.Width = 310;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataSource = typeof(DAL.Models.Livre);
            // 
            // exemplaireGroupBox
            // 
            this.exemplaireGroupBox.Controls.Add(this.exemplaireDataGridView);
            this.exemplaireGroupBox.Location = new System.Drawing.Point(12, 345);
            this.exemplaireGroupBox.Name = "exemplaireGroupBox";
            this.exemplaireGroupBox.Size = new System.Drawing.Size(760, 187);
            this.exemplaireGroupBox.TabIndex = 14;
            this.exemplaireGroupBox.TabStop = false;
            this.exemplaireGroupBox.Text = "Liste des exemplaires";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 270);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des livres";
            // 
            // TableExemplairePrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exemplaireGroupBox);
            this.Controls.Add(this.rafraichirButton);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.rechercherLabel);
            this.Controls.Add(this.rechercherTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableExemplairePrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableExemplairePrix";
            this.Load += new System.EventHandler(this.TableExemplairePrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireDataGridView)).EndInit();
            this.prixContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource)).EndInit();
            this.menuPrincipalContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            this.exemplaireGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exemplaireDataGridView;
        private System.Windows.Forms.ContextMenuStrip menuPrincipalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.BindingSource exemplaireBindingSource;
        private System.Windows.Forms.Button rafraichirButton;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.Label rechercherLabel;
        private System.Windows.Forms.TextBox rechercherTextBox;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sousTitreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox exemplaireGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip prixContextMenu;
        private System.Windows.Forms.ToolStripMenuItem afficherLesPrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLeStockToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditeurId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn URLimage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEdition;
    }
}