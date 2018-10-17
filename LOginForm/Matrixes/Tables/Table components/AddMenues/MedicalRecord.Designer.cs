namespace LOginForm
{
    partial class MedicalRecord
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
            this.warning = new System.Windows.Forms.Label();
            this.uniqueComboWarning = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.caseNumberLable = new System.Windows.Forms.Label();
            this.caseNumberHolder = new System.Windows.Forms.TextBox();
            this.caseNameLable = new System.Windows.Forms.Label();
            this.caseNameHolder = new System.Windows.Forms.TextBox();
            this.caseIDLable = new System.Windows.Forms.Label();
            this.caseIDHolder = new System.Windows.Forms.Label();
            this.facilityLable = new System.Windows.Forms.Label();
            this.facilityHolder = new System.Windows.Forms.TextBox();
            this.addressLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letterTypeDropBox = new System.Windows.Forms.ComboBox();
            this.letterTypeLable = new System.Windows.Forms.Label();
            this.dateRequestedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateRequestedLable = new System.Windows.Forms.Label();
            this.expirationDateHolder = new System.Windows.Forms.Label();
            this.expirationDateLable = new System.Windows.Forms.Label();
            this.dateRecievedLable = new System.Windows.Forms.Label();
            this.dateRecievdTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recieveDateWarningLable = new System.Windows.Forms.Label();
            this.notesLable = new System.Windows.Forms.Label();
            this.notesHolder = new System.Windows.Forms.TextBox();
            this.addressHolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(292, 121);
            this.warning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 13);
            this.warning.TabIndex = 70;
            this.warning.Visible = false;
            // 
            // uniqueComboWarning
            // 
            this.uniqueComboWarning.AutoSize = true;
            this.uniqueComboWarning.Location = new System.Drawing.Point(568, 57);
            this.uniqueComboWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uniqueComboWarning.Name = "uniqueComboWarning";
            this.uniqueComboWarning.Size = new System.Drawing.Size(144, 39);
            this.uniqueComboWarning.TabIndex = 59;
            this.uniqueComboWarning.Text = "In order to add a new record,\r\nplease, insert UNIQUE\r\nName, Number AND Facility";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(120, 468);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(124, 22);
            this.clearButton.TabIndex = 58;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(537, 467);
            this.AddRecordButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(116, 23);
            this.AddRecordButton.TabIndex = 57;
            this.AddRecordButton.Text = "Add";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // caseNumberLable
            // 
            this.caseNumberLable.AutoSize = true;
            this.caseNumberLable.Location = new System.Drawing.Point(146, 89);
            this.caseNumberLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caseNumberLable.Name = "caseNumberLable";
            this.caseNumberLable.Size = new System.Drawing.Size(78, 13);
            this.caseNumberLable.TabIndex = 54;
            this.caseNumberLable.Text = "Case Number *";
            // 
            // caseNumberHolder
            // 
            this.caseNumberHolder.Location = new System.Drawing.Point(295, 85);
            this.caseNumberHolder.Margin = new System.Windows.Forms.Padding(2);
            this.caseNumberHolder.Name = "caseNumberHolder";
            this.caseNumberHolder.Size = new System.Drawing.Size(206, 20);
            this.caseNumberHolder.TabIndex = 53;
            // 
            // caseNameLable
            // 
            this.caseNameLable.AutoSize = true;
            this.caseNameLable.Location = new System.Drawing.Point(146, 57);
            this.caseNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caseNameLable.Name = "caseNameLable";
            this.caseNameLable.Size = new System.Drawing.Size(66, 13);
            this.caseNameLable.TabIndex = 72;
            this.caseNameLable.Text = "Case Name*";
            // 
            // caseNameHolder
            // 
            this.caseNameHolder.Location = new System.Drawing.Point(295, 53);
            this.caseNameHolder.Margin = new System.Windows.Forms.Padding(2);
            this.caseNameHolder.Name = "caseNameHolder";
            this.caseNameHolder.Size = new System.Drawing.Size(206, 20);
            this.caseNameHolder.TabIndex = 71;
            // 
            // caseIDLable
            // 
            this.caseIDLable.AutoSize = true;
            this.caseIDLable.Location = new System.Drawing.Point(149, 25);
            this.caseIDLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caseIDLable.Name = "caseIDLable";
            this.caseIDLable.Size = new System.Drawing.Size(76, 13);
            this.caseIDLable.TabIndex = 73;
            this.caseIDLable.Text = "New Case ID :";
            // 
            // caseIDHolder
            // 
            this.caseIDHolder.AutoSize = true;
            this.caseIDHolder.Location = new System.Drawing.Point(295, 25);
            this.caseIDHolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caseIDHolder.Name = "caseIDHolder";
            this.caseIDHolder.Size = new System.Drawing.Size(76, 13);
            this.caseIDHolder.TabIndex = 74;
            this.caseIDHolder.Text = "New Case ID :";
            // 
            // facilityLable
            // 
            this.facilityLable.AutoSize = true;
            this.facilityLable.Location = new System.Drawing.Point(146, 121);
            this.facilityLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facilityLable.Name = "facilityLable";
            this.facilityLable.Size = new System.Drawing.Size(43, 13);
            this.facilityLable.TabIndex = 76;
            this.facilityLable.Text = "Facility*";
            // 
            // facilityHolder
            // 
            this.facilityHolder.Location = new System.Drawing.Point(295, 117);
            this.facilityHolder.Margin = new System.Windows.Forms.Padding(2);
            this.facilityHolder.Name = "facilityHolder";
            this.facilityHolder.Size = new System.Drawing.Size(206, 20);
            this.facilityHolder.TabIndex = 75;
            // 
            // addressLable
            // 
            this.addressLable.AutoSize = true;
            this.addressLable.Location = new System.Drawing.Point(146, 166);
            this.addressLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLable.Name = "addressLable";
            this.addressLable.Size = new System.Drawing.Size(45, 13);
            this.addressLable.TabIndex = 79;
            this.addressLable.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(292, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 77;
            this.label2.Visible = false;
            // 
            // letterTypeDropBox
            // 
            this.letterTypeDropBox.FormattingEnabled = true;
            this.letterTypeDropBox.Location = new System.Drawing.Point(295, 222);
            this.letterTypeDropBox.Margin = new System.Windows.Forms.Padding(2);
            this.letterTypeDropBox.Name = "letterTypeDropBox";
            this.letterTypeDropBox.Size = new System.Drawing.Size(206, 21);
            this.letterTypeDropBox.TabIndex = 81;
            this.letterTypeDropBox.SelectedValueChanged += new System.EventHandler(this.letterTypeDropBox_SelectedValueChanged);
            // 
            // letterTypeLable
            // 
            this.letterTypeLable.AutoSize = true;
            this.letterTypeLable.Location = new System.Drawing.Point(146, 226);
            this.letterTypeLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.letterTypeLable.Name = "letterTypeLable";
            this.letterTypeLable.Size = new System.Drawing.Size(61, 13);
            this.letterTypeLable.TabIndex = 80;
            this.letterTypeLable.Text = "Letter Type";
            // 
            // dateRequestedTimePicker
            // 
            this.dateRequestedTimePicker.Location = new System.Drawing.Point(295, 259);
            this.dateRequestedTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateRequestedTimePicker.Name = "dateRequestedTimePicker";
            this.dateRequestedTimePicker.Size = new System.Drawing.Size(206, 20);
            this.dateRequestedTimePicker.TabIndex = 82;
            this.dateRequestedTimePicker.ValueChanged += new System.EventHandler(this.dateRequestedTimePicker_ValueChanged);
            // 
            // dateRequestedLable
            // 
            this.dateRequestedLable.AutoSize = true;
            this.dateRequestedLable.Location = new System.Drawing.Point(146, 263);
            this.dateRequestedLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateRequestedLable.Name = "dateRequestedLable";
            this.dateRequestedLable.Size = new System.Drawing.Size(85, 13);
            this.dateRequestedLable.TabIndex = 83;
            this.dateRequestedLable.Text = "Date Requested";
            // 
            // expirationDateHolder
            // 
            this.expirationDateHolder.AutoSize = true;
            this.expirationDateHolder.ForeColor = System.Drawing.Color.Firebrick;
            this.expirationDateHolder.Location = new System.Drawing.Point(292, 295);
            this.expirationDateHolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expirationDateHolder.Name = "expirationDateHolder";
            this.expirationDateHolder.Size = new System.Drawing.Size(109, 13);
            this.expirationDateHolder.TabIndex = 85;
            this.expirationDateHolder.Text = "First, select letter type";
            // 
            // expirationDateLable
            // 
            this.expirationDateLable.AutoSize = true;
            this.expirationDateLable.Location = new System.Drawing.Point(146, 295);
            this.expirationDateLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expirationDateLable.Name = "expirationDateLable";
            this.expirationDateLable.Size = new System.Drawing.Size(79, 13);
            this.expirationDateLable.TabIndex = 84;
            this.expirationDateLable.Text = "Expiration Date";
            // 
            // dateRecievedLable
            // 
            this.dateRecievedLable.AutoSize = true;
            this.dateRecievedLable.Location = new System.Drawing.Point(144, 325);
            this.dateRecievedLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateRecievedLable.Name = "dateRecievedLable";
            this.dateRecievedLable.Size = new System.Drawing.Size(117, 13);
            this.dateRecievedLable.TabIndex = 87;
            this.dateRecievedLable.Text = "Date Record Recieved";
            // 
            // dateRecievdTimePicker
            // 
            this.dateRecievdTimePicker.Location = new System.Drawing.Point(295, 321);
            this.dateRecievdTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateRecievdTimePicker.Name = "dateRecievdTimePicker";
            this.dateRecievdTimePicker.Size = new System.Drawing.Size(206, 20);
            this.dateRecievdTimePicker.TabIndex = 86;
            this.dateRecievdTimePicker.ValueChanged += new System.EventHandler(this.dateRecievdTimePicker_ValueChanged);
            // 
            // recieveDateWarningLable
            // 
            this.recieveDateWarningLable.AutoSize = true;
            this.recieveDateWarningLable.ForeColor = System.Drawing.Color.Firebrick;
            this.recieveDateWarningLable.Location = new System.Drawing.Point(539, 321);
            this.recieveDateWarningLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recieveDateWarningLable.Name = "recieveDateWarningLable";
            this.recieveDateWarningLable.Size = new System.Drawing.Size(250, 26);
            this.recieveDateWarningLable.TabIndex = 88;
            this.recieveDateWarningLable.Text = "Receiving date cannot be earlier than request date.\r\n\r\n";
            this.recieveDateWarningLable.Visible = false;
            // 
            // notesLable
            // 
            this.notesLable.AutoSize = true;
            this.notesLable.Location = new System.Drawing.Point(146, 379);
            this.notesLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notesLable.Name = "notesLable";
            this.notesLable.Size = new System.Drawing.Size(35, 13);
            this.notesLable.TabIndex = 90;
            this.notesLable.Text = "Notes";
            // 
            // notesHolder
            // 
            this.notesHolder.Location = new System.Drawing.Point(277, 360);
            this.notesHolder.Margin = new System.Windows.Forms.Padding(2);
            this.notesHolder.Multiline = true;
            this.notesHolder.Name = "notesHolder";
            this.notesHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesHolder.Size = new System.Drawing.Size(253, 51);
            this.notesHolder.TabIndex = 89;
            // 
            // addressHolder
            // 
            this.addressHolder.Location = new System.Drawing.Point(277, 147);
            this.addressHolder.Margin = new System.Windows.Forms.Padding(2);
            this.addressHolder.Multiline = true;
            this.addressHolder.Name = "addressHolder";
            this.addressHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressHolder.Size = new System.Drawing.Size(253, 51);
            this.addressHolder.TabIndex = 91;
            // 
            // MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.addressHolder);
            this.Controls.Add(this.notesLable);
            this.Controls.Add(this.notesHolder);
            this.Controls.Add(this.recieveDateWarningLable);
            this.Controls.Add(this.dateRecievedLable);
            this.Controls.Add(this.dateRecievdTimePicker);
            this.Controls.Add(this.expirationDateHolder);
            this.Controls.Add(this.expirationDateLable);
            this.Controls.Add(this.dateRequestedLable);
            this.Controls.Add(this.dateRequestedTimePicker);
            this.Controls.Add(this.letterTypeDropBox);
            this.Controls.Add(this.letterTypeLable);
            this.Controls.Add(this.addressLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.facilityLable);
            this.Controls.Add(this.facilityHolder);
            this.Controls.Add(this.caseIDHolder);
            this.Controls.Add(this.caseIDLable);
            this.Controls.Add(this.caseNameLable);
            this.Controls.Add(this.caseNameHolder);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.uniqueComboWarning);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.caseNumberLable);
            this.Controls.Add(this.caseNumberHolder);
            this.Name = "MedicalRecord";
            this.Text = "MedicalRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label uniqueComboWarning;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Label caseNumberLable;
        private System.Windows.Forms.TextBox caseNumberHolder;
        private System.Windows.Forms.Label caseNameLable;
        private System.Windows.Forms.TextBox caseNameHolder;
        private System.Windows.Forms.Label caseIDLable;
        private System.Windows.Forms.Label caseIDHolder;
        private System.Windows.Forms.Label facilityLable;
        private System.Windows.Forms.TextBox facilityHolder;
        private System.Windows.Forms.Label addressLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox letterTypeDropBox;
        private System.Windows.Forms.Label letterTypeLable;
        private System.Windows.Forms.DateTimePicker dateRequestedTimePicker;
        private System.Windows.Forms.Label dateRequestedLable;
        private System.Windows.Forms.Label expirationDateHolder;
        private System.Windows.Forms.Label expirationDateLable;
        private System.Windows.Forms.Label dateRecievedLable;
        private System.Windows.Forms.DateTimePicker dateRecievdTimePicker;
        private System.Windows.Forms.Label recieveDateWarningLable;
        private System.Windows.Forms.Label notesLable;
        private System.Windows.Forms.TextBox notesHolder;
        private System.Windows.Forms.TextBox addressHolder;
    }
}