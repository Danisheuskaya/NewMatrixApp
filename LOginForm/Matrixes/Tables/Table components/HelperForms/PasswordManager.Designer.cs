namespace LOginForm.Matrixes.Tables.Table_components.HelperForms
{
    partial class PasswordManager
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
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordHandeler = new System.Windows.Forms.TextBox();
            this.newPasswordHolder = new System.Windows.Forms.TextBox();
            this.newPasswordlabel = new System.Windows.Forms.Label();
            this.confirmPasswordHolder = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Location = new System.Drawing.Point(78, 58);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(233, 20);
            this.oldPasswordLabel.TabIndex = 0;
            this.oldPasswordLabel.Text = "Please, ener your old Password:";
            // 
            // oldPasswordHandeler
            // 
            this.oldPasswordHandeler.Location = new System.Drawing.Point(396, 55);
            this.oldPasswordHandeler.Name = "oldPasswordHandeler";
            this.oldPasswordHandeler.Size = new System.Drawing.Size(201, 26);
            this.oldPasswordHandeler.TabIndex = 1;
            // 
            // newPasswordHolder
            // 
            this.newPasswordHolder.Location = new System.Drawing.Point(396, 105);
            this.newPasswordHolder.Name = "newPasswordHolder";
            this.newPasswordHolder.Size = new System.Drawing.Size(201, 26);
            this.newPasswordHolder.TabIndex = 3;
            // 
            // newPasswordlabel
            // 
            this.newPasswordlabel.AutoSize = true;
            this.newPasswordlabel.Location = new System.Drawing.Point(78, 108);
            this.newPasswordlabel.Name = "newPasswordlabel";
            this.newPasswordlabel.Size = new System.Drawing.Size(117, 20);
            this.newPasswordlabel.TabIndex = 2;
            this.newPasswordlabel.Text = "New Password:";
            // 
            // confirmPasswordHolder
            // 
            this.confirmPasswordHolder.Location = new System.Drawing.Point(396, 156);
            this.confirmPasswordHolder.Name = "confirmPasswordHolder";
            this.confirmPasswordHolder.Size = new System.Drawing.Size(201, 26);
            this.confirmPasswordHolder.TabIndex = 5;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(78, 159);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(176, 20);
            this.confirmPasswordLabel.TabIndex = 4;
            this.confirmPasswordLabel.Text = "Confirm New Password:";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(485, 236);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(154, 40);
            this.saveChangesButton.TabIndex = 6;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 330);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.confirmPasswordHolder);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.newPasswordHolder);
            this.Controls.Add(this.newPasswordlabel);
            this.Controls.Add(this.oldPasswordHandeler);
            this.Controls.Add(this.oldPasswordLabel);
            this.Name = "PasswordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox oldPasswordHandeler;
        private System.Windows.Forms.TextBox newPasswordHolder;
        private System.Windows.Forms.Label newPasswordlabel;
        private System.Windows.Forms.TextBox confirmPasswordHolder;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button saveChangesButton;
    }
}