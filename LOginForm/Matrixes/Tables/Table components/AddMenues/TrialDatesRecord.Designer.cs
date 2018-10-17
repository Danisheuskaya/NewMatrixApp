namespace LOginForm
{
    partial class TrialDatesRecord
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
            this.placeLable = new System.Windows.Forms.Label();
            this.placeTextHolder = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.startDateLable = new System.Windows.Forms.Label();
            this.trialRadioButton = new System.Windows.Forms.RadioButton();
            this.travelRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.caseNoteLable = new System.Windows.Forms.Label();
            this.caseNoteTextHolder = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLable = new System.Windows.Forms.Label();
            this.requirementWarning = new System.Windows.Forms.Label();
            this.typeWarning = new System.Windows.Forms.Label();
            this.startDateWarning = new System.Windows.Forms.Label();
            this.endDateWarning = new System.Windows.Forms.Label();
            this.noteWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // placeLable
            // 
            this.placeLable.AutoSize = true;
            this.placeLable.Location = new System.Drawing.Point(129, 293);
            this.placeLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeLable.Name = "placeLable";
            this.placeLable.Size = new System.Drawing.Size(34, 13);
            this.placeLable.TabIndex = 27;
            this.placeLable.Text = "Place";
            // 
            // placeTextHolder
            // 
            this.placeTextHolder.Location = new System.Drawing.Point(275, 289);
            this.placeTextHolder.Margin = new System.Windows.Forms.Padding(2);
            this.placeTextHolder.Name = "placeTextHolder";
            this.placeTextHolder.Size = new System.Drawing.Size(206, 20);
            this.placeTextHolder.TabIndex = 26;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(275, 106);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.startDateTimePicker.TabIndex = 24;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(130, 342);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 22);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(548, 341);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(85, 23);
            this.addRecordButton.TabIndex = 22;
            this.addRecordButton.Text = "Add";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // startDateLable
            // 
            this.startDateLable.AutoSize = true;
            this.startDateLable.Location = new System.Drawing.Point(129, 106);
            this.startDateLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLable.Name = "startDateLable";
            this.startDateLable.Size = new System.Drawing.Size(59, 13);
            this.startDateLable.TabIndex = 20;
            this.startDateLable.Text = "Start Date*";
            // 
            // trialRadioButton
            // 
            this.trialRadioButton.AutoSize = true;
            this.trialRadioButton.Location = new System.Drawing.Point(337, 29);
            this.trialRadioButton.Name = "trialRadioButton";
            this.trialRadioButton.Size = new System.Drawing.Size(45, 17);
            this.trialRadioButton.TabIndex = 30;
            this.trialRadioButton.TabStop = true;
            this.trialRadioButton.Text = "Trial";
            this.trialRadioButton.UseVisualStyleBackColor = true;
            // 
            // travelRadioButton
            // 
            this.travelRadioButton.AutoSize = true;
            this.travelRadioButton.Location = new System.Drawing.Point(337, 52);
            this.travelRadioButton.Name = "travelRadioButton";
            this.travelRadioButton.Size = new System.Drawing.Size(58, 17);
            this.travelRadioButton.TabIndex = 31;
            this.travelRadioButton.TabStop = true;
            this.travelRadioButton.Text = "Travel ";
            this.travelRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Record Type*";
            // 
            // caseNoteLable
            // 
            this.caseNoteLable.AutoSize = true;
            this.caseNoteLable.Location = new System.Drawing.Point(129, 231);
            this.caseNoteLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caseNoteLable.Name = "caseNoteLable";
            this.caseNoteLable.Size = new System.Drawing.Size(69, 13);
            this.caseNoteLable.TabIndex = 34;
            this.caseNoteLable.Text = "Case / Note*";
            // 
            // caseNoteTextHolder
            // 
            this.caseNoteTextHolder.Location = new System.Drawing.Point(275, 212);
            this.caseNoteTextHolder.Margin = new System.Windows.Forms.Padding(2);
            this.caseNoteTextHolder.Multiline = true;
            this.caseNoteTextHolder.Name = "caseNoteTextHolder";
            this.caseNoteTextHolder.Size = new System.Drawing.Size(206, 56);
            this.caseNoteTextHolder.TabIndex = 33;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(275, 162);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.endDateTimePicker.TabIndex = 36;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // endDateLable
            // 
            this.endDateLable.AutoSize = true;
            this.endDateLable.Location = new System.Drawing.Point(129, 162);
            this.endDateLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLable.Name = "endDateLable";
            this.endDateLable.Size = new System.Drawing.Size(52, 13);
            this.endDateLable.TabIndex = 35;
            this.endDateLable.Text = "End Date";
            // 
            // requirementWarning
            // 
            this.requirementWarning.AutoSize = true;
            this.requirementWarning.Location = new System.Drawing.Point(535, 42);
            this.requirementWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requirementWarning.Name = "requirementWarning";
            this.requirementWarning.Size = new System.Drawing.Size(215, 13);
            this.requirementWarning.TabIndex = 37;
            this.requirementWarning.Text = "Please, select Record Type AND Start Date";
            // 
            // typeWarning
            // 
            this.typeWarning.AutoSize = true;
            this.typeWarning.ForeColor = System.Drawing.Color.Red;
            this.typeWarning.Location = new System.Drawing.Point(130, 56);
            this.typeWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeWarning.Name = "typeWarning";
            this.typeWarning.Size = new System.Drawing.Size(138, 13);
            this.typeWarning.TabIndex = 38;
            this.typeWarning.Text = "Please, select Record Type";
            this.typeWarning.Visible = false;
            // 
            // startDateWarning
            // 
            this.startDateWarning.AutoSize = true;
            this.startDateWarning.ForeColor = System.Drawing.Color.Red;
            this.startDateWarning.Location = new System.Drawing.Point(130, 119);
            this.startDateWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateWarning.Name = "startDateWarning";
            this.startDateWarning.Size = new System.Drawing.Size(124, 13);
            this.startDateWarning.TabIndex = 39;
            this.startDateWarning.Text = "Please, select Start Date";
            this.startDateWarning.Visible = false;
            // 
            // endDateWarning
            // 
            this.endDateWarning.AutoSize = true;
            this.endDateWarning.ForeColor = System.Drawing.Color.Red;
            this.endDateWarning.Location = new System.Drawing.Point(130, 175);
            this.endDateWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateWarning.Name = "endDateWarning";
            this.endDateWarning.Size = new System.Drawing.Size(86, 13);
            this.endDateWarning.TabIndex = 40;
            this.endDateWarning.Text = "Invalid End Date";
            this.endDateWarning.Visible = false;
            // 
            // noteWarning
            // 
            this.noteWarning.AutoSize = true;
            this.noteWarning.ForeColor = System.Drawing.Color.Red;
            this.noteWarning.Location = new System.Drawing.Point(130, 244);
            this.noteWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noteWarning.Name = "noteWarning";
            this.noteWarning.Size = new System.Drawing.Size(108, 13);
            this.noteWarning.TabIndex = 41;
            this.noteWarning.Text = "PLease, leave a note";
            this.noteWarning.Visible = false;
            // 
            // TrialTravelDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteWarning);
            this.Controls.Add(this.endDateWarning);
            this.Controls.Add(this.startDateWarning);
            this.Controls.Add(this.typeWarning);
            this.Controls.Add(this.requirementWarning);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateLable);
            this.Controls.Add(this.caseNoteLable);
            this.Controls.Add(this.caseNoteTextHolder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.travelRadioButton);
            this.Controls.Add(this.trialRadioButton);
            this.Controls.Add(this.placeLable);
            this.Controls.Add(this.placeTextHolder);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.startDateLable);
            this.Name = "TrialTravelDates";
            this.Text = "Trial and Travel Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label placeLable;
        private System.Windows.Forms.TextBox placeTextHolder;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Label startDateLable;
        private System.Windows.Forms.RadioButton trialRadioButton;
        private System.Windows.Forms.RadioButton travelRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label caseNoteLable;
        private System.Windows.Forms.TextBox caseNoteTextHolder;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endDateLable;
        private System.Windows.Forms.Label requirementWarning;
        private System.Windows.Forms.Label typeWarning;
        private System.Windows.Forms.Label startDateWarning;
        private System.Windows.Forms.Label endDateWarning;
        private System.Windows.Forms.Label noteWarning;
    }
}