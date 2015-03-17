namespace IHMBackOffice.GestionOuvrages
{
    partial class DetailsLivre
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
            this.livreGroupBox = new System.Windows.Forms.GroupBox();
            this.resumerTextBox = new System.Windows.Forms.TextBox();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.sousTitreTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.resumeLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.sousTitreLabel = new System.Windows.Forms.Label();
            this.titreLabel = new System.Windows.Forms.Label();
            this.validerButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.livreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // livreGroupBox
            // 
            this.livreGroupBox.Controls.Add(this.resumerTextBox);
            this.livreGroupBox.Controls.Add(this.themeTextBox);
            this.livreGroupBox.Controls.Add(this.sousTitreTextBox);
            this.livreGroupBox.Controls.Add(this.titreTextBox);
            this.livreGroupBox.Controls.Add(this.resumeLabel);
            this.livreGroupBox.Controls.Add(this.themeLabel);
            this.livreGroupBox.Controls.Add(this.sousTitreLabel);
            this.livreGroupBox.Controls.Add(this.titreLabel);
            this.livreGroupBox.Location = new System.Drawing.Point(12, 12);
            this.livreGroupBox.Name = "livreGroupBox";
            this.livreGroupBox.Size = new System.Drawing.Size(585, 213);
            this.livreGroupBox.TabIndex = 0;
            this.livreGroupBox.TabStop = false;
            this.livreGroupBox.Text = "Détails du livre";
            // 
            // resumerTextBox
            // 
            this.resumerTextBox.Location = new System.Drawing.Point(177, 46);
            this.resumerTextBox.Multiline = true;
            this.resumerTextBox.Name = "resumerTextBox";
            this.resumerTextBox.Size = new System.Drawing.Size(402, 161);
            this.resumerTextBox.TabIndex = 7;
            // 
            // themeTextBox
            // 
            this.themeTextBox.Location = new System.Drawing.Point(25, 161);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(133, 20);
            this.themeTextBox.TabIndex = 6;
            // 
            // sousTitreTextBox
            // 
            this.sousTitreTextBox.Location = new System.Drawing.Point(25, 98);
            this.sousTitreTextBox.Name = "sousTitreTextBox";
            this.sousTitreTextBox.Size = new System.Drawing.Size(133, 20);
            this.sousTitreTextBox.TabIndex = 5;
            // 
            // titreTextBox
            // 
            this.titreTextBox.Location = new System.Drawing.Point(25, 46);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(133, 20);
            this.titreTextBox.TabIndex = 4;
            // 
            // resumeLabel
            // 
            this.resumeLabel.AutoSize = true;
            this.resumeLabel.Location = new System.Drawing.Point(174, 30);
            this.resumeLabel.Name = "resumeLabel";
            this.resumeLabel.Size = new System.Drawing.Size(46, 13);
            this.resumeLabel.TabIndex = 3;
            this.resumeLabel.Text = "Résumé";
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(22, 134);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(40, 13);
            this.themeLabel.TabIndex = 2;
            this.themeLabel.Text = "Thème";
            // 
            // sousTitreLabel
            // 
            this.sousTitreLabel.AutoSize = true;
            this.sousTitreLabel.Location = new System.Drawing.Point(22, 82);
            this.sousTitreLabel.Name = "sousTitreLabel";
            this.sousTitreLabel.Size = new System.Drawing.Size(55, 13);
            this.sousTitreLabel.TabIndex = 1;
            this.sousTitreLabel.Text = "Sous Titre";
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Location = new System.Drawing.Point(22, 30);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(28, 13);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Titre";
            // 
            // validerButton
            // 
            this.validerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.validerButton.Location = new System.Drawing.Point(528, 227);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(75, 23);
            this.validerButton.TabIndex = 1;
            this.validerButton.Text = "Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerButton.Location = new System.Drawing.Point(433, 227);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 2;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(336, 227);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // DetailsLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 262);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.validerButton);
            this.Controls.Add(this.livreGroupBox);
            this.Name = "DetailsLivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsLivre";
            this.Load += new System.EventHandler(this.DetailsLivre_Load);
            this.livreGroupBox.ResumeLayout(false);
            this.livreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox livreGroupBox;
        private System.Windows.Forms.TextBox resumerTextBox;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.TextBox sousTitreTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.Label resumeLabel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Label sousTitreLabel;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Button resetButton;
    }
}