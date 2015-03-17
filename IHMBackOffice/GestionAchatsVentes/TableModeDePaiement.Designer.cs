namespace IHMBackOffice.GestionAchatsVentes
{
    partial class TableModeDePaiement
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
            this.modeDePaiementDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPrincipalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeDePaiementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rechercherLabel = new System.Windows.Forms.Label();
            this.rechercherTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.modeDePaiementDataGridView)).BeginInit();
            this.menuPrincipalContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeDePaiementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rafraichirButton
            // 
            this.rafraichirButton.Location = new System.Drawing.Point(198, 510);
            this.rafraichirButton.Name = "rafraichirButton";
            this.rafraichirButton.Size = new System.Drawing.Size(75, 23);
            this.rafraichirButton.TabIndex = 27;
            this.rafraichirButton.Text = "Rafraichir";
            this.rafraichirButton.UseVisualStyleBackColor = true;
            this.rafraichirButton.Click += new System.EventHandler(this.rafraichirButton_Click_1);
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(292, 510);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(75, 23);
            this.fermerButton.TabIndex = 26;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click_1);
            // 
            // modeDePaiementDataGridView
            // 
            this.modeDePaiementDataGridView.AllowUserToAddRows = false;
            this.modeDePaiementDataGridView.AllowUserToDeleteRows = false;
            this.modeDePaiementDataGridView.AllowUserToResizeRows = false;
            this.modeDePaiementDataGridView.AutoGenerateColumns = false;
            this.modeDePaiementDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.modeDePaiementDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modeDePaiementDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.modeDePaiementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeDePaiementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.commandesDataGridViewTextBoxColumn});
            this.modeDePaiementDataGridView.ContextMenuStrip = this.menuPrincipalContextMenu;
            this.modeDePaiementDataGridView.DataSource = this.modeDePaiementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modeDePaiementDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.modeDePaiementDataGridView.Location = new System.Drawing.Point(12, 60);
            this.modeDePaiementDataGridView.Name = "modeDePaiementDataGridView";
            this.modeDePaiementDataGridView.ReadOnly = true;
            this.modeDePaiementDataGridView.RowHeadersVisible = false;
            this.modeDePaiementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modeDePaiementDataGridView.Size = new System.Drawing.Size(355, 441);
            this.modeDePaiementDataGridView.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 250;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandesDataGridViewTextBoxColumn
            // 
            this.commandesDataGridViewTextBoxColumn.DataPropertyName = "Commandes";
            this.commandesDataGridViewTextBoxColumn.HeaderText = "Commandes";
            this.commandesDataGridViewTextBoxColumn.Name = "commandesDataGridViewTextBoxColumn";
            this.commandesDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modeDePaiementBindingSource
            // 
            this.modeDePaiementBindingSource.DataSource = typeof(DAL.Models.ModeDePaiement);
            // 
            // rechercherLabel
            // 
            this.rechercherLabel.AutoSize = true;
            this.rechercherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherLabel.Location = new System.Drawing.Point(12, 9);
            this.rechercherLabel.Name = "rechercherLabel";
            this.rechercherLabel.Size = new System.Drawing.Size(133, 24);
            this.rechercherLabel.TabIndex = 24;
            this.rechercherLabel.Text = "Mot recherché";
            // 
            // rechercherTextBox
            // 
            this.rechercherTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherTextBox.Location = new System.Drawing.Point(165, 6);
            this.rechercherTextBox.Name = "rechercherTextBox";
            this.rechercherTextBox.Size = new System.Drawing.Size(202, 31);
            this.rechercherTextBox.TabIndex = 23;
            this.rechercherTextBox.TextChanged += new System.EventHandler(this.rechercherTextBox_TextChanged_1);
            // 
            // TableModeDePaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 541);
            this.Controls.Add(this.rafraichirButton);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.modeDePaiementDataGridView);
            this.Controls.Add(this.rechercherLabel);
            this.Controls.Add(this.rechercherTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableModeDePaiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeDePaiementcs";
            this.Load += new System.EventHandler(this.TableModeDePaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modeDePaiementDataGridView)).EndInit();
            this.menuPrincipalContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeDePaiementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rafraichirButton;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.DataGridView modeDePaiementDataGridView;
        private System.Windows.Forms.ContextMenuStrip menuPrincipalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.BindingSource modeDePaiementBindingSource;
        private System.Windows.Forms.Label rechercherLabel;
        private System.Windows.Forms.TextBox rechercherTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandesDataGridViewTextBoxColumn;


    }
}