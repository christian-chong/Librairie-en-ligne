namespace IHMBackOffice.GestionAchatsVentes
{
    partial class DetailsStock
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
            this.stockGroupBox = new System.Windows.Forms.GroupBox();
            this.annulerButton = new System.Windows.Forms.Button();
            this.validerButton = new System.Windows.Forms.Button();
            this.nouveauStockTextBox = new System.Windows.Forms.TextBox();
            this.stockActuelTextBox = new System.Windows.Forms.TextBox();
            this.nouveauStockLabel = new System.Windows.Forms.Label();
            this.stockAcuelLabel = new System.Windows.Forms.Label();
            this.stockGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockGroupBox
            // 
            this.stockGroupBox.Controls.Add(this.annulerButton);
            this.stockGroupBox.Controls.Add(this.validerButton);
            this.stockGroupBox.Controls.Add(this.nouveauStockTextBox);
            this.stockGroupBox.Controls.Add(this.stockActuelTextBox);
            this.stockGroupBox.Controls.Add(this.nouveauStockLabel);
            this.stockGroupBox.Controls.Add(this.stockAcuelLabel);
            this.stockGroupBox.Location = new System.Drawing.Point(0, 0);
            this.stockGroupBox.Name = "stockGroupBox";
            this.stockGroupBox.Size = new System.Drawing.Size(200, 100);
            this.stockGroupBox.TabIndex = 0;
            this.stockGroupBox.TabStop = false;
            this.stockGroupBox.Text = "Gestion du stock";
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(35, 71);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 5;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // validerButton
            // 
            this.validerButton.Location = new System.Drawing.Point(116, 71);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(75, 23);
            this.validerButton.TabIndex = 4;
            this.validerButton.Text = "Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // nouveauStockTextBox
            // 
            this.nouveauStockTextBox.Location = new System.Drawing.Point(94, 46);
            this.nouveauStockTextBox.Name = "nouveauStockTextBox";
            this.nouveauStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.nouveauStockTextBox.TabIndex = 3;
            // 
            // stockActuelTextBox
            // 
            this.stockActuelTextBox.Enabled = false;
            this.stockActuelTextBox.Location = new System.Drawing.Point(94, 17);
            this.stockActuelTextBox.Name = "stockActuelTextBox";
            this.stockActuelTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockActuelTextBox.TabIndex = 2;
            // 
            // nouveauStockLabel
            // 
            this.nouveauStockLabel.AutoSize = true;
            this.nouveauStockLabel.Location = new System.Drawing.Point(13, 48);
            this.nouveauStockLabel.Name = "nouveauStockLabel";
            this.nouveauStockLabel.Size = new System.Drawing.Size(80, 13);
            this.nouveauStockLabel.TabIndex = 1;
            this.nouveauStockLabel.Text = "Nouveau stock";
            // 
            // stockAcuelLabel
            // 
            this.stockAcuelLabel.AutoSize = true;
            this.stockAcuelLabel.Location = new System.Drawing.Point(13, 20);
            this.stockAcuelLabel.Name = "stockAcuelLabel";
            this.stockAcuelLabel.Size = new System.Drawing.Size(67, 13);
            this.stockAcuelLabel.TabIndex = 0;
            this.stockAcuelLabel.Text = "Stock actuel";
            // 
            // DetailsStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 112);
            this.Controls.Add(this.stockGroupBox);
            this.Name = "DetailsStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.stockGroupBox.ResumeLayout(false);
            this.stockGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox stockGroupBox;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.TextBox nouveauStockTextBox;
        private System.Windows.Forms.TextBox stockActuelTextBox;
        private System.Windows.Forms.Label nouveauStockLabel;
        private System.Windows.Forms.Label stockAcuelLabel;

    }
}