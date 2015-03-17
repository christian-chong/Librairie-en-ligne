namespace IHMBackOffice.GestionOuvrages
{
    partial class DetailsAuteur
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
            this.resetButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.validerButton = new System.Windows.Forms.Button();
            this.livreGroupBox = new System.Windows.Forms.GroupBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.livreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(54, 145);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // annulerButton
            // 
            this.annulerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerButton.Location = new System.Drawing.Point(6, 174);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 6;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click_1);
            // 
            // validerButton
            // 
            this.validerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.validerButton.Location = new System.Drawing.Point(107, 174);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(75, 23);
            this.validerButton.TabIndex = 5;
            this.validerButton.Text = "Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click_1);
            // 
            // livreGroupBox
            // 
            this.livreGroupBox.Controls.Add(this.resetButton);
            this.livreGroupBox.Controls.Add(this.prenomTextBox);
            this.livreGroupBox.Controls.Add(this.annulerButton);
            this.livreGroupBox.Controls.Add(this.nomTextBox);
            this.livreGroupBox.Controls.Add(this.validerButton);
            this.livreGroupBox.Controls.Add(this.prenomLabel);
            this.livreGroupBox.Controls.Add(this.nomLabel);
            this.livreGroupBox.Location = new System.Drawing.Point(12, 12);
            this.livreGroupBox.Name = "livreGroupBox";
            this.livreGroupBox.Size = new System.Drawing.Size(201, 213);
            this.livreGroupBox.TabIndex = 4;
            this.livreGroupBox.TabStop = false;
            this.livreGroupBox.Text = "Détails de l\'auteur";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(25, 98);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(133, 20);
            this.prenomTextBox.TabIndex = 5;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(25, 46);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(133, 20);
            this.nomTextBox.TabIndex = 4;
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(22, 82);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(43, 13);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "Prenom";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(22, 30);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(29, 13);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom";
            // 
            // DetailsAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 241);
            this.Controls.Add(this.livreGroupBox);
            this.Name = "DetailsAuteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DétailsAuteur";
            this.Load += new System.EventHandler(this.DetailsAuteur_Load);
            this.livreGroupBox.ResumeLayout(false);
            this.livreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.GroupBox livreGroupBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
    }
}