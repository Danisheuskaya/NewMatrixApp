namespace LOginForm
{
    partial class TeamMembersDropBox
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
            this.attorneyComboBox = new System.Windows.Forms.ComboBox();
            this.attorneyLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addAttorneyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attorneyComboBox
            // 
            this.attorneyComboBox.FormattingEnabled = true;
            this.attorneyComboBox.Location = new System.Drawing.Point(316, 45);
            this.attorneyComboBox.Name = "attorneyComboBox";
            this.attorneyComboBox.Size = new System.Drawing.Size(258, 28);
            this.attorneyComboBox.TabIndex = 0;
            this.attorneyComboBox.SelectedIndexChanged += new System.EventHandler(this.attorneyComboBox_SelectedIndexChanged);
            // 
            // attorneyLabel
            // 
            this.attorneyLabel.AutoSize = true;
            this.attorneyLabel.Location = new System.Drawing.Point(59, 49);
            this.attorneyLabel.Name = "attorneyLabel";
            this.attorneyLabel.Size = new System.Drawing.Size(202, 20);
            this.attorneyLabel.TabIndex = 1;
            this.attorneyLabel.Text = "Please, select new attorney";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(63, 125);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(156, 31);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addAttorneyButton
            // 
            this.addAttorneyButton.Location = new System.Drawing.Point(387, 125);
            this.addAttorneyButton.Name = "addAttorneyButton";
            this.addAttorneyButton.Size = new System.Drawing.Size(156, 31);
            this.addAttorneyButton.TabIndex = 3;
            this.addAttorneyButton.Text = "Save Changes";
            this.addAttorneyButton.UseVisualStyleBackColor = true;
            this.addAttorneyButton.Click += new System.EventHandler(this.addAttorneyButton_Click);
            // 
            // TeamMembersDropBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 215);
            this.Controls.Add(this.addAttorneyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.attorneyLabel);
            this.Controls.Add(this.attorneyComboBox);
            this.Name = "TeamMembersDropBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attorney List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox attorneyComboBox;
        private System.Windows.Forms.Label attorneyLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addAttorneyButton;
    }
}