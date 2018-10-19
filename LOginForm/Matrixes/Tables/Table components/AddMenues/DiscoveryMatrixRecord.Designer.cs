namespace LOginForm
{
    partial class DiscoveryMatrixRecord
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
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.caseNameHolder = new System.Windows.Forms.TextBox();
            this.teamIdComboHolder = new System.Windows.Forms.ComboBox();
            this.teamLabel = new System.Windows.Forms.Label();
            this.discoveryHolder = new System.Windows.Forms.TextBox();
            this.discoveryLabel = new System.Windows.Forms.Label();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.serevdLabel = new System.Windows.Forms.Label();
            this.noteLable = new System.Windows.Forms.Label();
            this.notesHolder = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.Location = new System.Drawing.Point(156, 57);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(92, 20);
            this.caseNameLabel.TabIndex = 5;
            this.caseNameLabel.Text = "Case Name";
            // 
            // caseNameHolder
            // 
            this.caseNameHolder.Location = new System.Drawing.Point(325, 57);
            this.caseNameHolder.Name = "caseNameHolder";
            this.caseNameHolder.Size = new System.Drawing.Size(307, 26);
            this.caseNameHolder.TabIndex = 4;
            // 
            // teamIdComboHolder
            // 
            this.teamIdComboHolder.FormattingEnabled = true;
            this.teamIdComboHolder.Location = new System.Drawing.Point(324, 113);
            this.teamIdComboHolder.Name = "teamIdComboHolder";
            this.teamIdComboHolder.Size = new System.Drawing.Size(307, 28);
            this.teamIdComboHolder.TabIndex = 13;
            this.teamIdComboHolder.SelectedIndexChanged += new System.EventHandler(this.teamIdComboHolder_SelectedIndexChanged);
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(156, 117);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(136, 20);
            this.teamLabel.TabIndex = 12;
            this.teamLabel.Text = "Handling Attorney";
            // 
            // discoveryHolder
            // 
            this.discoveryHolder.Location = new System.Drawing.Point(324, 166);
            this.discoveryHolder.Multiline = true;
            this.discoveryHolder.Name = "discoveryHolder";
            this.discoveryHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.discoveryHolder.Size = new System.Drawing.Size(307, 93);
            this.discoveryHolder.TabIndex = 56;
            // 
            // discoveryLabel
            // 
            this.discoveryLabel.AutoSize = true;
            this.discoveryLabel.Location = new System.Drawing.Point(156, 210);
            this.discoveryLabel.Name = "discoveryLabel";
            this.discoveryLabel.Size = new System.Drawing.Size(77, 20);
            this.discoveryLabel.TabIndex = 55;
            this.discoveryLabel.Text = "Discovery";
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.Location = new System.Drawing.Point(324, 295);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(307, 26);
            this.dueDateTimePicker.TabIndex = 58;
            this.dueDateTimePicker.ValueChanged += new System.EventHandler(this.dueDateTimePicker_ValueChanged);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(156, 295);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(78, 20);
            this.dueDateLabel.TabIndex = 57;
            this.dueDateLabel.Text = "Due Date";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(325, 379);
            this.noRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(54, 24);
            this.noRadioButton.TabIndex = 60;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(325, 344);
            this.yesRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(62, 24);
            this.yesRadioButton.TabIndex = 59;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // serevdLabel
            // 
            this.serevdLabel.AutoSize = true;
            this.serevdLabel.Location = new System.Drawing.Point(156, 364);
            this.serevdLabel.Name = "serevdLabel";
            this.serevdLabel.Size = new System.Drawing.Size(86, 20);
            this.serevdLabel.TabIndex = 61;
            this.serevdLabel.Text = "SERVED?";
            // 
            // noteLable
            // 
            this.noteLable.AutoSize = true;
            this.noteLable.Location = new System.Drawing.Point(155, 462);
            this.noteLable.Name = "noteLable";
            this.noteLable.Size = new System.Drawing.Size(51, 20);
            this.noteLable.TabIndex = 63;
            this.noteLable.Text = "Notes";
            // 
            // notesHolder
            // 
            this.notesHolder.Location = new System.Drawing.Point(325, 433);
            this.notesHolder.Multiline = true;
            this.notesHolder.Name = "notesHolder";
            this.notesHolder.Size = new System.Drawing.Size(307, 84);
            this.notesHolder.TabIndex = 62;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(646, 57);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(212, 60);
            this.warningLabel.TabIndex = 69;
            this.warningLabel.Text = "In order to add a new record,\r\nplease, make sure to enter\r\nCase Name And Attorney" +
    "";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(58, 586);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(139, 34);
            this.clearBtn.TabIndex = 71;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 70;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiscoveryMatrixRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 677);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.noteLable);
            this.Controls.Add(this.notesHolder);
            this.Controls.Add(this.serevdLabel);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.dueDateTimePicker);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.discoveryHolder);
            this.Controls.Add(this.discoveryLabel);
            this.Controls.Add(this.teamIdComboHolder);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.caseNameLabel);
            this.Controls.Add(this.caseNameHolder);
            this.Name = "DiscoveryMatrixRecord";
            this.Text = "DiscoveryMatrixRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.TextBox caseNameHolder;
        private System.Windows.Forms.ComboBox teamIdComboHolder;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.TextBox discoveryHolder;
        private System.Windows.Forms.Label discoveryLabel;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label serevdLabel;
        private System.Windows.Forms.Label noteLable;
        private System.Windows.Forms.TextBox notesHolder;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button1;
    }
}