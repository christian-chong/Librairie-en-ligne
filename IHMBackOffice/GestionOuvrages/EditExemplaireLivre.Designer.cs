namespace IHMBackOffice.GestionOuvrages
{
    partial class EditExemplaireLivre
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
            this.rechercherTextBox = new System.Windows.Forms.TextBox();
            this.rechercherLabel = new System.Windows.Forms.Label();
            this.livreDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sousTitreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPrincipalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.détailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermerButton = new System.Windows.Forms.Button();
            this.rafraichirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).BeginInit();
            this.menuPrincipalContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rechercherTextBox
            // 
            this.rechercherTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherTextBox.Location = new System.Drawing.Point(341, 36);
            this.rechercherTextBox.Name = "rechercherTextBox";
            this.rechercherTextBox.Size = new System.Drawing.Size(202, 31);
            this.rechercherTextBox.TabIndex = 0;
            this.rechercherTextBox.TextChanged += new System.EventHandler(this.rechercherTextBox_TextChanged);
            // 
            // rechercherLabel
            // 
            this.rechercherLabel.AutoSize = true;
            this.rechercherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherLabel.Location = new System.Drawing.Point(177, 39);
            this.rechercherLabel.Name = "rechercherLabel";
            this.rechercherLabel.Size = new System.Drawing.Size(133, 24);
            this.rechercherLabel.TabIndex = 1;
            this.rechercherLabel.Text = "Mot recherché";
            // 
            // livreDataGridView
            // 
            this.livreDataGridView.AllowUserToAddRows = false;
            this.livreDataGridView.AllowUserToDeleteRows = false;
            this.livreDataGridView.AllowUserToResizeRows = false;
            this.livreDataGridView.AutoGenerateColumns = false;
            this.livreDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.livreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.livreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.livreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.sousTitreDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn});
            this.livreDataGridView.ContextMenuStrip = this.menuPrincipalContextMenu;
            this.livreDataGridView.DataSource = this.livreBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.livreDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.livreDataGridView.Location = new System.Drawing.Point(32, 92);
            this.livreDataGridView.Name = "livreDataGridView";
            this.livreDataGridView.ReadOnly = true;
            this.livreDataGridView.RowHeadersVisible = false;
            this.livreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.livreDataGridView.Size = new System.Drawing.Size(713, 429);
            this.livreDataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            this.titreDataGridViewTextBoxColumn.Width = 250;
            // 
            // sousTitreDataGridViewTextBoxColumn
            // 
            this.sousTitreDataGridViewTextBoxColumn.DataPropertyName = "SousTitre";
            this.sousTitreDataGridViewTextBoxColumn.HeaderText = "SousTitre";
            this.sousTitreDataGridViewTextBoxColumn.Name = "sousTitreDataGridViewTextBoxColumn";
            this.sousTitreDataGridViewTextBoxColumn.ReadOnly = true;
            this.sousTitreDataGridViewTextBoxColumn.Width = 250;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            this.themeDataGridViewTextBoxColumn.Width = 150;
            // 
            // menuPrincipalContextMenu
            // 
            this.menuPrincipalContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailsToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.menuPrincipalContextMenu.Name = "contextMenuStrip1";
            this.menuPrincipalContextMenu.Size = new System.Drawing.Size(166, 70);
            // 
            // détailsToolStripMenuItem
            // 
            this.détailsToolStripMenuItem.Name = "détailsToolStripMenuItem";
            this.détailsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.détailsToolStripMenuItem.Text = "Détails / Modifier";
            this.détailsToolStripMenuItem.Click += new System.EventHandler(this.détailsToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataSource = typeof(DAL.Models.Livre);
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(670, 527);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(75, 23);
            this.fermerButton.TabIndex = 3;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // rafraichirButton
            // 
            this.rafraichirButton.Location = new System.Drawing.Point(576, 527);
            this.rafraichirButton.Name = "rafraichirButton";
            this.rafraichirButton.Size = new System.Drawing.Size(75, 23);
            this.rafraichirButton.TabIndex = 4;
            this.rafraichirButton.Text = "Rafraichir";
            this.rafraichirButton.UseVisualStyleBackColor = true;
            this.rafraichirButton.Click += new System.EventHandler(this.rafraichirButton_Click);
            // 
            // EditExemplaireLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.rafraichirButton);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.livreDataGridView);
            this.Controls.Add(this.rechercherLabel);
            this.Controls.Add(this.rechercherTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditExemplaireLivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditExemplaireLivre";
            this.Load += new System.EventHandler(this.EditExemplaireLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).EndInit();
            this.menuPrincipalContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rechercherTextBox;
        private System.Windows.Forms.Label rechercherLabel;
        private System.Windows.Forms.DataGridView livreDataGridView;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sousTitreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button rafraichirButton;
        private System.Windows.Forms.ContextMenuStrip menuPrincipalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem détailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}