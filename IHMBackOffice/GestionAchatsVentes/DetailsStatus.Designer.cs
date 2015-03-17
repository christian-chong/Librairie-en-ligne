namespace IHMBackOffice.GestionAchatsVentes
{
    partial class DetailsStatus
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
            this.modeDePaiementGroupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.validerButton = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.modeDePaiementGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modeDePaiementGroupBox
            // 
            this.modeDePaiementGroupBox.Controls.Add(this.resetButton);
            this.modeDePaiementGroupBox.Controls.Add(this.annulerButton);
            this.modeDePaiementGroupBox.Controls.Add(this.nomTextBox);
            this.modeDePaiementGroupBox.Controls.Add(this.validerButton);
            this.modeDePaiementGroupBox.Controls.Add(this.nomLabel);
            this.modeDePaiementGroupBox.Location = new System.Drawing.Point(17, 15);
            this.modeDePaiementGroupBox.Name = "modeDePaiementGroupBox";
            this.modeDePaiementGroupBox.Size = new System.Drawing.Size(201, 213);
            this.modeDePaiementGroupBox.TabIndex = 8;
            this.modeDePaiementGroupBox.TabStop = false;
            this.modeDePaiementGroupBox.Text = "Détails du status";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(54, 145);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
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
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(25, 46);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(133, 20);
            this.nomTextBox.TabIndex = 4;
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
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(22, 30);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(37, 13);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Status";
            // 
            // DetailsStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 242);
            this.Controls.Add(this.modeDePaiementGroupBox);
            this.Name = "DetailsStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsStatus";
            this.Load += new System.EventHandler(this.DetailsStatus_Load);
            this.modeDePaiementGroupBox.ResumeLayout(false);
            this.modeDePaiementGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modeDePaiementGroupBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.Label nomLabel;
    }
}