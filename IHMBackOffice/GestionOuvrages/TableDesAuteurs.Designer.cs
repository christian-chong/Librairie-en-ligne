namespace IHMBackOffice.GestionOuvrages
{
    partial class TableDesAuteurs
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
            this.rafraichirButton = new System.Windows.Forms.Button();
            this.fermerButton = new System.Windows.Forms.Button();
            this.livreDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPrincipalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rechercherLabel = new System.Windows.Forms.Label();
            this.rechercherTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).BeginInit();
            this.menuPrincipalContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rafraichirButton
            // 
            this.rafraichirButton.Location = new System.Drawing.Point(198, 530);
            this.rafraichirButton.Name = "rafraichirButton";
            this.rafraichirButton.Size = new System.Drawing.Size(75, 23);
            this.rafraichirButton.TabIndex = 12;
            this.rafraichirButton.Text = "Rafraichir";
            this.rafraichirButton.UseVisualStyleBackColor = true;
            this.rafraichirButton.Click += new System.EventHandler(this.rafraichirButton_Click);
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(292, 530);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(75, 23);
            this.fermerButton.TabIndex = 11;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
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
            this.prenomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.livreDataGridView.ContextMenuStrip = this.menuPrincipalContextMenu;
            this.livreDataGridView.DataSource = this.auteurBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.livreDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.livreDataGridView.Location = new System.Drawing.Point(12, 80);
            this.livreDataGridView.Name = "livreDataGridView";
            this.livreDataGridView.ReadOnly = true;
            this.livreDataGridView.RowHeadersVisible = false;
            this.livreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.livreDataGridView.Size = new System.Drawing.Size(355, 441);
            this.livreDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 150;
            // 
            // menuPrincipalContextMenu
            // 
            this.menuPrincipalContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.menuPrincipalContextMenu.Name = "contextMenuStrip1";
            this.menuPrincipalContextMenu.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click_1);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click_1);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click_1);
            // 
            // auteurBindingSource
            // 
            this.auteurBindingSource.DataSource = typeof(DAL.Models.Auteur);
            // 
            // rechercherLabel
            // 
            this.rechercherLabel.AutoSize = true;
            this.rechercherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherLabel.Location = new System.Drawing.Point(12, 29);
            this.rechercherLabel.Name = "rechercherLabel";
            this.rechercherLabel.Size = new System.Drawing.Size(133, 24);
            this.rechercherLabel.TabIndex = 9;
            this.rechercherLabel.Text = "Mot recherché";
            // 
            // rechercherTextBox
            // 
            this.rechercherTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherTextBox.Location = new System.Drawing.Point(165, 26);
            this.rechercherTextBox.Name = "rechercherTextBox";
            this.rechercherTextBox.Size = new System.Drawing.Size(202, 31);
            this.rechercherTextBox.TabIndex = 8;
            this.rechercherTextBox.TextChanged += new System.EventHandler(this.rechercherTextBox_TextChanged);
            // 
            // TableDesAuteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 562);
            this.Controls.Add(this.rafraichirButton);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.livreDataGridView);
            this.Controls.Add(this.rechercherLabel);
            this.Controls.Add(this.rechercherTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableDesAuteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableDesAuteurs";
            this.Load += new System.EventHandler(this.TableDesAuteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).EndInit();
            this.menuPrincipalContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rafraichirButton;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.DataGridView livreDataGridView;
        private System.Windows.Forms.Label rechercherLabel;
        private System.Windows.Forms.TextBox rechercherTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource auteurBindingSource;
        private System.Windows.Forms.ContextMenuStrip menuPrincipalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}