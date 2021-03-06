﻿namespace LOginForm
{
    partial class CourtListRecord
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
            this.caseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JudjeDept = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.court = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rullings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.motion = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caseNumber
            // 
            this.caseNumber.Location = new System.Drawing.Point(346, 48);
            this.caseNumber.Name = "caseNumber";
            this.caseNumber.Size = new System.Drawing.Size(393, 27);
            this.caseNumber.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Case Number *";
            // 
            // caseName
            // 
            this.caseName.Location = new System.Drawing.Point(346, 123);
            this.caseName.Name = "caseName";
            this.caseName.Size = new System.Drawing.Size(393, 27);
            this.caseName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Case Name";
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.addButton.Location = new System.Drawing.Point(766, 654);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(193, 37);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(70, 655);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(207, 36);
            this.clearBtn.TabIndex = 37;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 63);
            this.label6.TabIndex = 41;
            this.label6.Text = "In order to add a new record,\r\nplease, make sure to insert a \r\nUNIQUE Case Number" +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Judge / Department";
            // 
            // JudjeDept
            // 
            this.JudjeDept.Location = new System.Drawing.Point(346, 187);
            this.JudjeDept.Name = "JudjeDept";
            this.JudjeDept.Size = new System.Drawing.Size(393, 27);
            this.JudjeDept.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Court Information";
            // 
            // court
            // 
            this.court.Location = new System.Drawing.Point(346, 250);
            this.court.Name = "court";
            this.court.Size = new System.Drawing.Size(393, 27);
            this.court.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Report Information";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(346, 309);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(393, 27);
            this.report.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tentative Rullings";
            // 
            // rullings
            // 
            this.rullings.Location = new System.Drawing.Point(346, 377);
            this.rullings.Name = "rullings";
            this.rullings.Size = new System.Drawing.Size(393, 27);
            this.rullings.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 21);
            this.label8.TabIndex = 51;
            this.label8.Text = "Motion Information";
            // 
            // motion
            // 
            this.motion.Location = new System.Drawing.Point(346, 426);
            this.motion.Multiline = true;
            this.motion.Name = "motion";
            this.motion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.motion.Size = new System.Drawing.Size(393, 171);
            this.motion.TabIndex = 50;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(341, 88);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(327, 21);
            this.warning.TabIndex = 52;
            this.warning.Text = "Make sure to insert UNIQUE case number";
            this.warning.Visible = false;
            // 
            // CourtListRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 749);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.motion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rullings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.report);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.court);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JudjeDept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caseNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CourtListRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Court List Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caseNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JudjeDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox court;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rullings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox motion;
        private System.Windows.Forms.Label warning;
    }
}