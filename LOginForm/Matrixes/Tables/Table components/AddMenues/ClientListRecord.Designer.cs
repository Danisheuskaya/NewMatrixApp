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
            this.label6.Location = new System.Drawing.Point(628, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 60);
            this.label6.TabIndex = 29;
            this.label6.Text = "In order to add a new record,\r\nplease, make sure to insert a \r\nUNIQUE Case Number" +
    "";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(252, 56);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(307, 20);
            this.warning.TabIndex = 28;
            this.warning.Text = "Make sure to insert UNIQUE case number";
            this.warning.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Attorney Information";
            // 
            // attorneyInfo
            // 
            this.attorneyInfo.Location = new System.Drawing.Point(252, 288);
            this.attorneyInfo.Multiline = true;
            this.attorneyInfo.Name = "attorneyInfo";
            this.attorneyInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attorneyInfo.Size = new System.Drawing.Size(307, 117);
            this.attorneyInfo.TabIndex = 26;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(35, 419);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(139, 34);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(661, 418);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 35);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Client Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Case Name";
            // 
            // caseName
            // 
            this.caseName.Location = new System.Drawing.Point(252, 104);
            this.caseName.Name = "caseName";
            this.caseName.Size = new System.Drawing.Size(307, 26);
            this.caseName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Case Number *";
            // 
            // caseNumber
            // 
            this.caseNumber.Location = new System.Drawing.Point(252, 27);
            this.caseNumber.Name = "caseNumber";
            this.caseNumber.Size = new System.Drawing.Size(307, 26);
            this.caseNumber.TabIndex = 16;
            // 
            // clientInfo
            // 
            this.clientInfo.Location = new System.Drawing.Point(252, 146);
            this.clientInfo.Multiline = true;
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientInfo.Size = new System.Drawing.Size(307, 117);
            this.clientInfo.TabIndex = 30;
            // 
            // ClientListRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 487);
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
            this.Name = "ClientListRecord";
            this.Text = "ClientListRecord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientListRecord_FormClosing);
            
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