namespace IHMBackOffice.GestionAchatsVentes
{
    partial class DetailsPrix
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
            this.TablePrixGroupBox = new System.Windows.Forms.GroupBox();
            this.fermerButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prixHtTextBox = new System.Windows.Forms.TextBox();
            this.tvaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exemplaireIdTextBox = new System.Windows.Forms.TextBox();
            this.modifierButton = new System.Windows.Forms.Button();
            this.entrerButton = new System.Windows.Forms.Button();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.livreIdTextBox = new System.Windows.Forms.TextBox();
            this.titreLabel = new System.Windows.Forms.Label();
            this.prixDataGridView = new System.Windows.Forms.DataGridView();
            this.prixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablePrixGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePrixGroupBox
            // 
            this.TablePrixGroupBox.Controls.Add(this.fermerButton);
            this.TablePrixGroupBox.Controls.Add(this.groupBox1);
            this.TablePrixGroupBox.Controls.Add(this.exemplaireIdTextBox);
            this.TablePrixGroupBox.Controls.Add(this.modifierButton);
            this.TablePrixGroupBox.Controls.Add(this.entrerButton);
            this.TablePrixGroupBox.Controls.Add(this.isbnLabel);
            this.TablePrixGroupBox.Controls.Add(this.livreIdTextBox);
            this.TablePrixGroupBox.Controls.Add(this.titreLabel);
            this.TablePrixGroupBox.Controls.Add(this.prixDataGridView);
            this.TablePrixGroupBox.Location = new System.Drawing.Point(13, 13);
            this.TablePrixGroupBox.Name = "TablePrixGroupBox";
            this.TablePrixGroupBox.Size = new System.Drawing.Size(559, 337);
            this.TablePrixGroupBox.TabIndex = 0;
            this.TablePrixGroupBox.TabStop = false;
            this.TablePrixGroupBox.Text = "Table des prix";
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(424, 308);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(120, 23);
            this.fermerButton.TabIndex = 15;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(this.prixHtTextBox);
            this.groupBox1.Controls.Add(this.tvaTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editer prix";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(64, 22);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 14;
            // 
            // prixHtTextBox
            // 
            this.prixHtTextBox.Location = new System.Drawing.Point(100, 48);
            this.prixHtTextBox.Name = "prixHtTextBox";
            this.prixHtTextBox.Size = new System.Drawing.Size(146, 20);
            this.prixHtTextBox.TabIndex = 11;
            // 
            // tvaTextBox
            // 
            this.tvaTextBox.Location = new System.Drawing.Point(100, 74);
            this.tvaTextBox.Name = "tvaTextBox";
            this.tvaTextBox.Size = new System.Drawing.Size(146, 20);
            this.tvaTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TVA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prix Hors Taxe";
            // 
            // exemplaireIdTextBox
            // 
            this.exemplaireIdTextBox.Location = new System.Drawing.Point(397, 31);
            this.exemplaireIdTextBox.Name = "exemplaireIdTextBox";
            this.exemplaireIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.exemplaireIdTextBox.TabIndex = 4;
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(298, 271);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(120, 23);
            this.modifierButton.TabIndex = 6;
            this.modifierButton.Text = "Modifier";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // entrerButton
            // 
            this.entrerButton.Location = new System.Drawing.Point(298, 242);
            this.entrerButton.Name = "entrerButton";
            this.entrerButton.Size = new System.Drawing.Size(120, 23);
            this.entrerButton.TabIndex = 5;
            this.entrerButton.Text = "Valider";
            this.entrerButton.UseVisualStyleBackColor = true;
            this.entrerButton.Click += new System.EventHandler(this.entrerButton_Click);
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(266, 34);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(125, 13);
            this.isbnLabel.TabIndex = 3;
            this.isbnLabel.Text = "Identifiant de l\'exemplaire";
            // 
            // livreIdTextBox
            // 
            this.livreIdTextBox.Location = new System.Drawing.Point(126, 31);
            this.livreIdTextBox.Name = "livreIdTextBox";
            this.livreIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.livreIdTextBox.TabIndex = 2;
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Location = new System.Drawing.Point(30, 34);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(90, 13);
            this.titreLabel.TabIndex = 1;
            this.titreLabel.Text = "Identifiant du livre";
            // 
            // prixDataGridView
            // 
            this.prixDataGridView.AllowUserToAddRows = false;
            this.prixDataGridView.AllowUserToDeleteRows = false;
            this.prixDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prixDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.prixHTDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn});
            this.prixDataGridView.DataSource = this.prixBindingSource;
            this.prixDataGridView.Location = new System.Drawing.Point(6, 61);
            this.prixDataGridView.Name = "prixDataGridView";
            this.prixDataGridView.ReadOnly = true;
            this.prixDataGridView.RowHeadersVisible = false;
            this.prixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prixDataGridView.Size = new System.Drawing.Size(538, 150);
            this.prixDataGridView.TabIndex = 0;
            this.prixDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prixDataGridView_CellContentClick);
            // 
            // prixBindingSource
            // 
            this.prixBindingSource.DataSource = typeof(DAL.Models.Prix);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixHTDataGridViewTextBoxColumn
            // 
            this.prixHTDataGridViewTextBoxColumn.DataPropertyName = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.HeaderText = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.Name = "prixHTDataGridViewTextBoxColumn";
            this.prixHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DetailsPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.TablePrixGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsPrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablePrix";
            this.Load += new System.EventHandler(this.TablePrix_Load);
            this.TablePrixGroupBox.ResumeLayout(false);
            this.TablePrixGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TablePrixGroupBox;
        private System.Windows.Forms.DataGridView prixDataGridView;
        private System.Windows.Forms.TextBox prixHtTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.Button entrerButton;
        private System.Windows.Forms.TextBox exemplaireIdTextBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox livreIdTextBox;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.BindingSource prixBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tvaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
    }
}