namespace LOginForm
{
    partial class CaseTruckingRecord
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
            this.ComplaintServedHolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caseNameHolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caseNumberHolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VenueHolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.intDiscovery = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.attorneyText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AttorneyLevel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DemandText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.offerText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IssuesText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComplaintServedHolder
            // 
            this.ComplaintServedHolder.Location = new System.Drawing.Point(343, 265);
            this.ComplaintServedHolder.Multiline = true;
            this.ComplaintServedHolder.Name = "ComplaintServedHolder";
            this.ComplaintServedHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ComplaintServedHolder.Size = new System.Drawing.Size(341, 97);
            this.ComplaintServedHolder.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 63);
            this.label6.TabIndex = 43;
            this.label6.Text = "In order to add a new record,\r\nplease, make sure to insert a \r\nUNIQUE Case Number" +
    "";
            // 
            // trialDateTimePicker
            // 
            this.trialDateTimePicker.Location = new System.Drawing.Point(343, 649);
            this.trialDateTimePicker.Name = "trialDateTimePicker";
            this.trialDateTimePicker.Size = new System.Drawing.Size(341, 27);
            this.trialDateTimePicker.TabIndex = 40;
            this.trialDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(83, 1027);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(154, 36);
            this.clearBtn.TabIndex = 39;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(766, 1026);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 37);
            this.addBtn.TabIndex = 38;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date Served";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Case Name";
            // 
            // caseNameHolder
            // 
            this.caseNameHolder.Location = new System.Drawing.Point(343, 89);
            this.caseNameHolder.Multiline = true;
            this.caseNameHolder.Name = "caseNameHolder";
            this.caseNameHolder.Size = new System.Drawing.Size(341, 27);
            this.caseNameHolder.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Case Number *";
            // 
            // caseNumberHolder
            // 
            this.caseNumberHolder.Location = new System.Drawing.Point(343, 31);
            this.caseNumberHolder.Name = "caseNumberHolder";
            this.caseNumberHolder.Size = new System.Drawing.Size(341, 27);
            this.caseNumberHolder.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Venue";
            // 
            // VenueHolder
            // 
            this.VenueHolder.Location = new System.Drawing.Point(343, 147);
            this.VenueHolder.Multiline = true;
            this.VenueHolder.Name = "VenueHolder";
            this.VenueHolder.Size = new System.Drawing.Size(341, 27);
            this.VenueHolder.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Team";
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(343, 205);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(341, 29);
            this.teamComboBox.TabIndex = 50;
            this.teamComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // intDiscovery
            // 
            this.intDiscovery.Location = new System.Drawing.Point(343, 393);
            this.intDiscovery.Multiline = true;
            this.intDiscovery.Name = "intDiscovery";
            this.intDiscovery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.intDiscovery.Size = new System.Drawing.Size(341, 97);
            this.intDiscovery.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Initial Discovery";
            // 
            // attorneyText
            // 
            this.attorneyText.Location = new System.Drawing.Point(343, 521);
            this.attorneyText.Multiline = true;
            this.attorneyText.Name = "attorneyText";
            this.attorneyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attorneyText.Size = new System.Drawing.Size(341, 97);
            this.attorneyText.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Attorney";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 655);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Trial Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 713);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 57;
            this.label10.Text = "Attorney Level";
            // 
            // AttorneyLevel
            // 
            this.AttorneyLevel.Location = new System.Drawing.Point(343, 707);
            this.AttorneyLevel.Name = "AttorneyLevel";
            this.AttorneyLevel.Size = new System.Drawing.Size(341, 27);
            this.AttorneyLevel.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 771);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 59;
            this.label11.Text = "Demand";
            // 
            // DemandText
            // 
            this.DemandText.Location = new System.Drawing.Point(343, 764);
            this.DemandText.Name = "DemandText";
            this.DemandText.Size = new System.Drawing.Size(341, 27);
            this.DemandText.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 825);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 61;
            this.label12.Text = "Offer";
            // 
            // offerText
            // 
            this.offerText.Location = new System.Drawing.Point(343, 822);
            this.offerText.Name = "offerText";
            this.offerText.Size = new System.Drawing.Size(341, 27);
            this.offerText.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 886);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 21);
            this.label13.TabIndex = 63;
            this.label13.Text = "Issues";
            // 
            // IssuesText
            // 
            this.IssuesText.Location = new System.Drawing.Point(343, 880);
            this.IssuesText.Name = "IssuesText";
            this.IssuesText.Size = new System.Drawing.Size(341, 27);
            this.IssuesText.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(97, 944);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 21);
            this.label14.TabIndex = 65;
            this.label14.Text = "Medical Rewiever";
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(343, 938);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(341, 27);
            this.review.TabIndex = 64;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(343, 65);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(327, 21);
            this.warning.TabIndex = 66;
            this.warning.Text = "Make sure to insert UNIQUE case number";
            this.warning.Visible = false;
            // 
            // CaseTruckingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1023, 1096);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.review);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.IssuesText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.offerText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DemandText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AttorneyLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attorneyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intDiscovery);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VenueHolder);
            this.Controls.Add(this.ComplaintServedHolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trialDateTimePicker);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caseNameHolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caseNumberHolder);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CaseTruckingRecord";
            this.Text = "Case Trucking Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComplaintServedHolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker trialDateTimePicker;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caseNameHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caseNumberHolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VenueHolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.TextBox intDiscovery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox attorneyText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AttorneyLevel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DemandText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox offerText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IssuesText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.Label warning;
    }
}