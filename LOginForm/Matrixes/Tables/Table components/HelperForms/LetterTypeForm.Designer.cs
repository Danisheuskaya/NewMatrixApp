namespace LOginForm
{
    partial class LetterTypeForm
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
            this.letterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.letterTypeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // letterTypeComboBox
            // 
            this.letterTypeComboBox.FormattingEnabled = true;
            this.letterTypeComboBox.Items.AddRange(new object[] {
            "",
            "48",
            "1158"});
            this.letterTypeComboBox.Location = new System.Drawing.Point(296, 64);
            this.letterTypeComboBox.Name = "letterTypeComboBox";
            this.letterTypeComboBox.Size = new System.Drawing.Size(221, 28);
            this.letterTypeComboBox.TabIndex = 0;
            this.letterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.letterTypeComboBox_SelectedIndexChanged);
            // 
            // letterTypeLabel
            // 
            this.letterTypeLabel.AutoSize = true;
            this.letterTypeLabel.Location = new System.Drawing.Point(39, 68);
            this.letterTypeLabel.Name = "letterTypeLabel";
            this.letterTypeLabel.Size = new System.Drawing.Size(214, 20);
            this.letterTypeLabel.TabIndex = 1;
            this.letterTypeLabel.Text = "Please, select new letter type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(383, 143);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 33);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LetterTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 220);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.letterTypeLabel);
            this.Controls.Add(this.letterTypeComboBox);
            this.Name = "LetterTypeForm";
            this.Text = "Letter Type Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox letterTypeComboBox;
        private System.Windows.Forms.Label letterTypeLabel;
        private System.Windows.Forms.Button saveButton;
    }
}