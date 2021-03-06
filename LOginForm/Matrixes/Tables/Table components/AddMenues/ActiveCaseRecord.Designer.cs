﻿namespace LOginForm
{
    partial class ActiveCaseRecord
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
            this.caseNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.trialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.teamIdComboHolder = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caseNumber
            // 
            this.caseNumber.Location = new System.Drawing.Point(413, 41);
            this.caseNumber.Name = "caseNumber";
            this.caseNumber.Size = new System.Drawing.Size(341, 27);
            this.caseNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Case Number *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Case Name";
            // 
            // caseName
            // 
            this.caseName.Location = new System.Drawing.Point(413, 122);
            this.caseName.Name = "caseName";
            this.caseName.Size = new System.Drawing.Size(341, 27);
            this.caseName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trial Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(868, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(172, 453);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(154, 36);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // trialDateTimePicker
            // 
            this.trialDateTimePicker.Location = new System.Drawing.Point(413, 209);
            this.trialDateTimePicker.Name = "trialDateTimePicker";
            this.trialDateTimePicker.Size = new System.Drawing.Size(341, 27);
            this.trialDateTimePicker.TabIndex = 10;
            this.trialDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // teamIdComboHolder
            // 
            this.teamIdComboHolder.FormattingEnabled = true;
            this.teamIdComboHolder.Location = new System.Drawing.Point(413, 299);
            this.teamIdComboHolder.Name = "teamIdComboHolder";
            this.teamIdComboHolder.Size = new System.Drawing.Size(341, 29);
            this.teamIdComboHolder.TabIndex = 11;
            this.teamIdComboHolder.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(413, 366);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(341, 27);
            this.note.TabIndex = 12;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(413, 71);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(327, 21);
            this.warning.TabIndex = 14;
            this.warning.Text = "Make sure to insert UNIQUE case number";
            this.warning.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(831, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 63);
            this.label6.TabIndex = 15;
            this.label6.Text = "In order to add a new record,\r\nplease, make sure to insert a \r\nUNIQUE Case Number" +
    "";
            // 
            // ActiveCaseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.note);
            this.Controls.Add(this.teamIdComboHolder);
            this.Controls.Add(this.trialDateTimePicker);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caseNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActiveCaseRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Active Case Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caseNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DateTimePicker trialDateTimePicker;
        private System.Windows.Forms.ComboBox teamIdComboHolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label label6;
    }
}