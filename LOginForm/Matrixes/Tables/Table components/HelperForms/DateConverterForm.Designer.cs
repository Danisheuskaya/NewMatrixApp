namespace LOginForm
{
    partial class DateConverterForm
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
            this.qustionLabel = new System.Windows.Forms.Label();
            this.newDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qustionLabel
            // 
            this.qustionLabel.AutoSize = true;
            this.qustionLabel.Location = new System.Drawing.Point(79, 60);
            this.qustionLabel.Name = "qustionLabel";
            this.qustionLabel.Size = new System.Drawing.Size(171, 20);
            this.qustionLabel.TabIndex = 0;
            this.qustionLabel.Text = "Plese, select new date:";
            // 
            // newDateTimePicker
            // 
            this.newDateTimePicker.Location = new System.Drawing.Point(355, 57);
            this.newDateTimePicker.Name = "newDateTimePicker";
            this.newDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.newDateTimePicker.TabIndex = 1;
            this.newDateTimePicker.ValueChanged += new System.EventHandler(this.newDateTimePicker_ValueChanged);
            // 
            // saveDateButton
            // 
            this.saveDateButton.Location = new System.Drawing.Point(423, 141);
            this.saveDateButton.Name = "saveDateButton";
            this.saveDateButton.Size = new System.Drawing.Size(132, 29);
            this.saveDateButton.TabIndex = 2;
            this.saveDateButton.Text = "Save Changes";
            this.saveDateButton.UseVisualStyleBackColor = true;
            this.saveDateButton.Click += new System.EventHandler(this.saveDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(83, 141);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(132, 29);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // DateConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 219);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveDateButton);
            this.Controls.Add(this.newDateTimePicker);
            this.Controls.Add(this.qustionLabel);
            this.Name = "DateConverterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date Converter Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qustionLabel;
        private System.Windows.Forms.DateTimePicker newDateTimePicker;
        private System.Windows.Forms.Button saveDateButton;
        private System.Windows.Forms.Button clearButton;
    }
}