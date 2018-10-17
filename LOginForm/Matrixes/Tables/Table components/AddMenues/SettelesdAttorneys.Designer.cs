namespace LOginForm
{
    partial class SettelesdAttorneys
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
            this.caseNameHolder = new System.Windows.Forms.TextBox();
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.attorneyNameHolder = new System.Windows.Forms.TextBox();
            this.attorneyLabel = new System.Windows.Forms.Label();
            this.yearLeble = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.closedYearComboBox = new System.Windows.Forms.ComboBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caseNameHolder
            // 
            this.caseNameHolder.Location = new System.Drawing.Point(320, 164);
            this.caseNameHolder.Multiline = true;
            this.caseNameHolder.Name = "caseNameHolder";
            this.caseNameHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.caseNameHolder.Size = new System.Drawing.Size(307, 93);
            this.caseNameHolder.TabIndex = 56;
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.Location = new System.Drawing.Point(101, 205);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(92, 20);
            this.caseNameLabel.TabIndex = 55;
            this.caseNameLabel.Text = "Case Name";
            // 
            // attorneyNameHolder
            // 
            this.attorneyNameHolder.Location = new System.Drawing.Point(320, 42);
            this.attorneyNameHolder.Multiline = true;
            this.attorneyNameHolder.Name = "attorneyNameHolder";
            this.attorneyNameHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attorneyNameHolder.Size = new System.Drawing.Size(307, 93);
            this.attorneyNameHolder.TabIndex = 54;
            // 
            // attorneyLabel
            // 
            this.attorneyLabel.AutoSize = true;
            this.attorneyLabel.Location = new System.Drawing.Point(101, 84);
            this.attorneyLabel.Name = "attorneyLabel";
            this.attorneyLabel.Size = new System.Drawing.Size(73, 20);
            this.attorneyLabel.TabIndex = 53;
            this.attorneyLabel.Text = "Attorney ";
            // 
            // yearLeble
            // 
            this.yearLeble.AutoSize = true;
            this.yearLeble.Location = new System.Drawing.Point(98, 308);
            this.yearLeble.Name = "yearLeble";
            this.yearLeble.Size = new System.Drawing.Size(96, 20);
            this.yearLeble.TabIndex = 58;
            this.yearLeble.Text = "Year Closed";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(33, 375);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(139, 34);
            this.clearBtn.TabIndex = 60;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(647, 374);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 35);
            this.addBtn.TabIndex = 59;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closedYearComboBox
            // 
            this.closedYearComboBox.FormattingEnabled = true;
            this.closedYearComboBox.Location = new System.Drawing.Point(320, 308);
            this.closedYearComboBox.Name = "closedYearComboBox";
            this.closedYearComboBox.Size = new System.Drawing.Size(307, 28);
            this.closedYearComboBox.TabIndex = 61;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(668, 61);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(212, 60);
            this.warningLabel.TabIndex = 62;
            this.warningLabel.Text = "In order to add a new record,\r\nplease, make sure to enter\r\nAttorney and Case Name" +
    "";
            // 
            // SettelesdAttorneys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.closedYearComboBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.yearLeble);
            this.Controls.Add(this.caseNameHolder);
            this.Controls.Add(this.caseNameLabel);
            this.Controls.Add(this.attorneyNameHolder);
            this.Controls.Add(this.attorneyLabel);
            this.Name = "SettelesdAttorneys";
            this.Text = "SettelesdAttorneys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caseNameHolder;
        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.TextBox attorneyNameHolder;
        private System.Windows.Forms.Label attorneyLabel;
        private System.Windows.Forms.Label yearLeble;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox closedYearComboBox;
        private System.Windows.Forms.Label warningLabel;
    }
}