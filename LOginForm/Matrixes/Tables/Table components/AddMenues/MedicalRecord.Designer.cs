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
            this.warning.Location = new System.Drawing.Point(438, 168);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 20);
            this.warning.TabIndex = 70;
            this.warning.Visible = false;
            // 
            // uniqueComboWarning
            // 
            this.uniqueComboWarning.AutoSize = true;
            this.uniqueComboWarning.Location = new System.Drawing.Point(852, 70);
            this.uniqueComboWarning.Name = "uniqueComboWarning";
            this.uniqueComboWarning.Size = new System.Drawing.Size(212, 60);
            this.uniqueComboWarning.TabIndex = 59;
            this.uniqueComboWarning.Text = "In order to add a new record,\r\nplease, insert UNIQUE\r\nName, Number AND Facility";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(180, 702);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(186, 34);
            this.clearButton.TabIndex = 58;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(806, 700);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(174, 35);
            this.AddRecordButton.TabIndex = 57;
            this.AddRecordButton.Text = "Add";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // caseNumberLable
            // 
            this.caseNumberLable.AutoSize = true;
            this.caseNumberLable.Location = new System.Drawing.Point(219, 119);
            this.caseNumberLable.Name = "caseNumberLable";
            this.caseNumberLable.Size = new System.Drawing.Size(116, 20);
            this.caseNumberLable.TabIndex = 54;
            this.caseNumberLable.Text = "Case Number *";
            // 
            // caseNumberHolder
            // 
            this.caseNumberHolder.Location = new System.Drawing.Point(442, 113);
            this.caseNumberHolder.Name = "caseNumberHolder";
            this.caseNumberHolder.Size = new System.Drawing.Size(307, 26);
            this.caseNumberHolder.TabIndex = 53;
            // 
            // caseNameLable
            // 
            this.caseNameLable.AutoSize = true;
            this.caseNameLable.Location = new System.Drawing.Point(219, 70);
            this.caseNameLable.Name = "caseNameLable";
            this.caseNameLable.Size = new System.Drawing.Size(98, 20);
            this.caseNameLable.TabIndex = 72;
            this.caseNameLable.Text = "Case Name*";
            // 
            // caseNameHolder
            // 
            this.caseNameHolder.Location = new System.Drawing.Point(442, 64);
            this.caseNameHolder.Name = "caseNameHolder";
            this.caseNameHolder.Size = new System.Drawing.Size(307, 26);
            this.caseNameHolder.TabIndex = 71;
            // 
            // facilityLable
            // 
            this.facilityLable.AutoSize = true;
            this.facilityLable.Location = new System.Drawing.Point(219, 168);
            this.facilityLable.Name = "facilityLable";
            this.facilityLable.Size = new System.Drawing.Size(63, 20);
            this.facilityLable.TabIndex = 76;
            this.facilityLable.Text = "Facility*";
            // 
            // facilityHolder
            // 
            this.facilityHolder.Location = new System.Drawing.Point(442, 162);
            this.facilityHolder.Name = "facilityHolder";
            this.facilityHolder.Size = new System.Drawing.Size(307, 26);
            this.facilityHolder.TabIndex = 75;
            // 
            // addressLable
            // 
            this.addressLable.AutoSize = true;
            this.addressLable.Location = new System.Drawing.Point(219, 237);
            this.addressLable.Name = "addressLable";
            this.addressLable.Size = new System.Drawing.Size(68, 20);
            this.addressLable.TabIndex = 79;
            this.addressLable.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(438, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 77;
            this.label2.Visible = false;
            // 
            // letterTypeDropBox
            // 
            this.letterTypeDropBox.FormattingEnabled = true;
            this.letterTypeDropBox.Location = new System.Drawing.Point(442, 324);
            this.letterTypeDropBox.Name = "letterTypeDropBox";
            this.letterTypeDropBox.Size = new System.Drawing.Size(307, 28);
            this.letterTypeDropBox.TabIndex = 81;
            this.letterTypeDropBox.SelectedValueChanged += new System.EventHandler(this.letterTypeDropBox_SelectedValueChanged);
            // 
            // letterTypeLable
            // 
            this.letterTypeLable.AutoSize = true;
            this.letterTypeLable.Location = new System.Drawing.Point(219, 330);
            this.letterTypeLable.Name = "letterTypeLable";
            this.letterTypeLable.Size = new System.Drawing.Size(89, 20);
            this.letterTypeLable.TabIndex = 80;
            this.letterTypeLable.Text = "Letter Type";
            // 
            // dateRequestedTimePicker
            // 
            this.dateRequestedTimePicker.Location = new System.Drawing.Point(442, 380);
            this.dateRequestedTimePicker.Name = "dateRequestedTimePicker";
            this.dateRequestedTimePicker.Size = new System.Drawing.Size(307, 26);
            this.dateRequestedTimePicker.TabIndex = 82;
            this.dateRequestedTimePicker.ValueChanged += new System.EventHandler(this.dateRequestedTimePicker_ValueChanged);
            // 
            // dateRequestedLable
            // 
            this.dateRequestedLable.AutoSize = true;
            this.dateRequestedLable.Location = new System.Drawing.Point(219, 387);
            this.dateRequestedLable.Name = "dateRequestedLable";
            this.dateRequestedLable.Size = new System.Drawing.Size(127, 20);
            this.dateRequestedLable.TabIndex = 83;
            this.dateRequestedLable.Text = "Date Requested";
            // 
            // expirationDateHolder
            // 
            this.expirationDateHolder.AutoSize = true;
            this.expirationDateHolder.ForeColor = System.Drawing.Color.Firebrick;
            this.expirationDateHolder.Location = new System.Drawing.Point(438, 436);
            this.expirationDateHolder.Name = "expirationDateHolder";
            this.expirationDateHolder.Size = new System.Drawing.Size(164, 20);
            this.expirationDateHolder.TabIndex = 85;
            this.expirationDateHolder.Text = "First, select letter type";
            // 
            // expirationDateLable
            // 
            this.expirationDateLable.AutoSize = true;
            this.expirationDateLable.Location = new System.Drawing.Point(219, 436);
            this.expirationDateLable.Name = "expirationDateLable";
            this.expirationDateLable.Size = new System.Drawing.Size(118, 20);
            this.expirationDateLable.TabIndex = 84;
            this.expirationDateLable.Text = "Expiration Date";
            // 
            // dateRecievedLable
            // 
            this.dateRecievedLable.AutoSize = true;
            this.dateRecievedLable.Location = new System.Drawing.Point(216, 482);
            this.dateRecievedLable.Name = "dateRecievedLable";
            this.dateRecievedLable.Size = new System.Drawing.Size(170, 20);
            this.dateRecievedLable.TabIndex = 87;
            this.dateRecievedLable.Text = "Date Record Recieved";
            // 
            // dateRecievdTimePicker
            // 
            this.dateRecievdTimePicker.Location = new System.Drawing.Point(442, 476);
            this.dateRecievdTimePicker.Name = "dateRecievdTimePicker";
            this.dateRecievdTimePicker.Size = new System.Drawing.Size(307, 26);
            this.dateRecievdTimePicker.TabIndex = 86;
            this.dateRecievdTimePicker.ValueChanged += new System.EventHandler(this.dateRecievdTimePicker_ValueChanged);
            // 
            // recieveDateWarningLable
            // 
            this.recieveDateWarningLable.AutoSize = true;
            this.recieveDateWarningLable.ForeColor = System.Drawing.Color.Firebrick;
            this.recieveDateWarningLable.Location = new System.Drawing.Point(808, 476);
            this.recieveDateWarningLable.Name = "recieveDateWarningLable";
            this.recieveDateWarningLable.Size = new System.Drawing.Size(370, 40);
            this.recieveDateWarningLable.TabIndex = 88;
            this.recieveDateWarningLable.Text = "Receiving date cannot be earlier than request date.\r\n\r\n";
            this.recieveDateWarningLable.Visible = false;
            // 
            // notesLable
            // 
            this.notesLable.AutoSize = true;
            this.notesLable.Location = new System.Drawing.Point(219, 565);
            this.notesLable.Name = "notesLable";
            this.notesLable.Size = new System.Drawing.Size(51, 20);
            this.notesLable.TabIndex = 90;
            this.notesLable.Text = "Notes";
            // 
            // notesHolder
            // 
            this.notesHolder.Location = new System.Drawing.Point(416, 536);
            this.notesHolder.Multiline = true;
            this.notesHolder.Name = "notesHolder";
            this.notesHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesHolder.Size = new System.Drawing.Size(378, 76);
            this.notesHolder.TabIndex = 89;
            // 
            // addressHolder
            // 
            this.addressHolder.Location = new System.Drawing.Point(416, 208);
            this.addressHolder.Multiline = true;
            this.addressHolder.Name = "addressHolder";
            this.addressHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressHolder.Size = new System.Drawing.Size(378, 76);
            this.addressHolder.TabIndex = 91;
            // 
            // MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 798);
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
            this.Controls.Add(this.caseNameLable);
            this.Controls.Add(this.caseNameHolder);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.uniqueComboWarning);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.caseNumberLable);
            this.Controls.Add(this.caseNumberHolder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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