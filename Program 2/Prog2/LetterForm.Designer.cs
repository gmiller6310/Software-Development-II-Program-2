namespace UPVApp
{
    partial class LetterForm
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
            this.originAddressLabel = new System.Windows.Forms.Label();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.destinationAddressComboBox = new System.Windows.Forms.ComboBox();
            this.originAddressComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originAddressLabel
            // 
            this.originAddressLabel.AutoSize = true;
            this.originAddressLabel.Location = new System.Drawing.Point(32, 17);
            this.originAddressLabel.Name = "originAddressLabel";
            this.originAddressLabel.Size = new System.Drawing.Size(78, 13);
            this.originAddressLabel.TabIndex = 0;
            this.originAddressLabel.Text = "Origin Address:";
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(6, 50);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(104, 13);
            this.destinationAddressLabel.TabIndex = 1;
            this.destinationAddressLabel.Text = "Destination Address:";
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(51, 88);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(59, 13);
            this.fixedCostLabel.TabIndex = 2;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(125, 85);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(121, 20);
            this.fixedCostTextBox.TabIndex = 3;
            // 
            // destinationAddressComboBox
            // 
            this.destinationAddressComboBox.FormattingEnabled = true;
            this.destinationAddressComboBox.Location = new System.Drawing.Point(125, 47);
            this.destinationAddressComboBox.Name = "destinationAddressComboBox";
            this.destinationAddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationAddressComboBox.TabIndex = 4;
            // 
            // originAddressComboBox
            // 
            this.originAddressComboBox.FormattingEnabled = true;
            this.originAddressComboBox.Location = new System.Drawing.Point(125, 14);
            this.originAddressComboBox.Name = "originAddressComboBox";
            this.originAddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.originAddressComboBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(44, 133);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(146, 133);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.originAddressComboBox);
            this.Controls.Add(this.destinationAddressComboBox);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destinationAddressLabel);
            this.Controls.Add(this.originAddressLabel);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originAddressLabel;
        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.ComboBox destinationAddressComboBox;
        private System.Windows.Forms.ComboBox originAddressComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}