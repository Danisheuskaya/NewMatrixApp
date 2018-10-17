namespace LOginForm
{
    partial class SetteledJudgesRecord
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
            this.countyLable = new System.Windows.Forms.Label();
            this.countyNameHolder = new System.Windows.Forms.TextBox();
            this.judgeLabel = new System.Windows.Forms.Label();
            this.judgeNameHolder = new System.Windows.Forms.TextBox();
            this.caseNameHolder = new System.Windows.Forms.TextBox();
            this.caseNameLable = new System.Windows.Forms.Label();
            this.setteledYearComboBox = new System.Windows.Forms.ComboBox();
            this.yearLeble = new System.Windows.Forms.Label();
            this.notesHolder = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countyLable
            // 
            this.countyLable.AutoSize = true;
            this.countyLable.Location = new System.Drawing.Point(105, 86);
            this.countyLable.Name = "countyLable";
            this.countyLable.Size = new System.Drawing.Size(59, 20);
            this.countyLable.TabIndex = 18;
            this.countyLable.Text = "County";
            // 
            // countyNameHolder
            // 
            this.countyNameHolder.Location = new System.Drawing.Point(324, 80);
            this.countyNameHolder.Name = "countyNameHolder";
            this.countyNameHolder.Size = new System.Drawing.Size(307, 26);
            this.countyNameHolder.TabIndex = 17;
            // 
            // judgeLabel
            // 
            this.judgeLabel.AutoSize = true;
            this.judgeLabel.Location = new System.Drawing.Point(105, 35);
            this.judgeLabel.Name = "judgeLabel";
            this.judgeLabel.Size = new System.Drawing.Size(53, 20);
            this.judgeLabel.TabIndex = 16;
            this.judgeLabel.Text = "Judge";
            // 
            // judgeNameHolder
            // 
            this.judgeNameHolder.Location = new System.Drawing.Point(324, 29);
            this.judgeNameHolder.Name = "judgeNameHolder";
            this.judgeNameHolder.Size = new System.Drawing.Size(307, 26);
            this.judgeNameHolder.TabIndex = 15;
            // 
            // caseNameHolder
            // 
            this.caseNameHolder.Location = new System.Drawing.Point(324, 125);
            this.caseNameHolder.Multiline = true;
            this.caseNameHolder.Name = "caseNameHolder";
            this.caseNameHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.caseNameHolder.Size = new System.Drawing.Size(307, 93);
            this.caseNameHolder.TabIndex = 56;
            // 
            // caseNameLable
            // 
            this.caseNameLable.AutoSize = true;
            this.caseNameLable.Location = new System.Drawing.Point(105, 167);
            this.caseNameLable.Name = "caseNameLable";
            this.caseNameLable.Size = new System.Drawing.Size(92, 20);
            this.caseNameLable.TabIndex = 55;
            this.caseNameLable.Text = "Case Name";
            // 
            // setteledYearComboBox
            // 
            this.setteledYearComboBox.FormattingEnabled = true;
            this.setteledYearComboBox.Location = new System.Drawing.Point(324, 245);
            this.setteledYearComboBox.Name = "setteledYearComboBox";
            this.setteledYearComboBox.Size = new System.Drawing.Size(307, 28);
            this.setteledYearComboBox.TabIndex = 63;
            // 
            // yearLeble
            // 
            this.yearLeble.AutoSize = true;
            this.yearLeble.Location = new System.Drawing.Point(102, 245);
            this.yearLeble.Name = "yearLeble";
            this.yearLeble.Size = new System.Drawing.Size(98, 20);
            this.yearLeble.TabIndex = 62;
            this.yearLeble.Text = "Year Settled";
            // 
            // notesHolder
            // 
            this.notesHolder.Location = new System.Drawing.Point(324, 298);
            this.notesHolder.Multiline = true;
            this.notesHolder.Name = "notesHolder";
            this.notesHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesHolder.Size = new System.Drawing.Size(307, 93);
            this.notesHolder.TabIndex = 65;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(105, 340);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 20);
            this.notesLabel.TabIndex = 64;
            this.notesLabel.Text = "Notes";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(35, 413);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(139, 34);
            this.clearBtn.TabIndex = 67;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(649, 412);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 35);
            this.addBtn.TabIndex = 66;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(692, 32);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(212, 60);
            this.warningLabel.TabIndex = 68;
            this.warningLabel.Text = "In order to add a new record,\r\nplease, make sure to enter\r\nAttorney and Case Name" +
    "";
            // 
            // SetteledJudgesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 475);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.notesHolder);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.setteledYearComboBox);
            this.Controls.Add(this.yearLeble);
            this.Controls.Add(this.caseNameHolder);
            this.Controls.Add(this.caseNameLable);
            this.Controls.Add(this.countyLable);
            this.Controls.Add(this.countyNameHolder);
            this.Controls.Add(this.judgeLabel);
            this.Controls.Add(this.judgeNameHolder);
            this.Name = "SetteledJudgesRecord";
            this.Text = "SetteledJudgesRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countyLable;
        private System.Windows.Forms.TextBox countyNameHolder;
        private System.Windows.Forms.Label judgeLabel;
        private System.Windows.Forms.TextBox judgeNameHolder;
        private System.Windows.Forms.TextBox caseNameHolder;
        private System.Windows.Forms.Label caseNameLable;
        private System.Windows.Forms.ComboBox setteledYearComboBox;
        private System.Windows.Forms.Label yearLeble;
        private System.Windows.Forms.TextBox notesHolder;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label warningLabel;
    }
}