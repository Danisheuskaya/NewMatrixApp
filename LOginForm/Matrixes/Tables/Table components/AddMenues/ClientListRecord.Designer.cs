namespace LOginForm
{
    partial class ClientListRecord
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
            this.label6 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.attorneyInfo = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caseNumber = new System.Windows.Forms.TextBox();
            this.clientInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 63);
            this.label6.TabIndex = 29;
            this.label6.Text = "In order to add a new record,\r\nplease, make sure to insert a \r\nUNIQUE Case Number" +
    "";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(280, 59);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(327, 21);
            this.warning.TabIndex = 28;
            this.warning.Text = "Make sure to insert UNIQUE case number";
            this.warning.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Attorney Information";
            // 
            // attorneyInfo
            // 
            this.attorneyInfo.Location = new System.Drawing.Point(280, 302);
            this.attorneyInfo.Multiline = true;
            this.attorneyInfo.Name = "attorneyInfo";
            this.attorneyInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attorneyInfo.Size = new System.Drawing.Size(341, 123);
            this.attorneyInfo.TabIndex = 26;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(39, 440);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(154, 36);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(734, 439);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 37);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Client Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Case Name";
            // 
            // caseName
            // 
            this.caseName.Location = new System.Drawing.Point(280, 109);
            this.caseName.Name = "caseName";
            this.caseName.Size = new System.Drawing.Size(341, 27);
            this.caseName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Case Number *";
            // 
            // caseNumber
            // 
            this.caseNumber.Location = new System.Drawing.Point(280, 28);
            this.caseNumber.Name = "caseNumber";
            this.caseNumber.Size = new System.Drawing.Size(341, 27);
            this.caseNumber.TabIndex = 16;
            // 
            // clientInfo
            // 
            this.clientInfo.Location = new System.Drawing.Point(280, 153);
            this.clientInfo.Multiline = true;
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientInfo.Size = new System.Drawing.Size(341, 123);
            this.clientInfo.TabIndex = 30;
            // 
            // ClientListRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 511);
            this.Controls.Add(this.clientInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attorneyInfo);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caseNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientListRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client List Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox attorneyInfo;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caseNumber;
        private System.Windows.Forms.TextBox clientInfo;
    }
}