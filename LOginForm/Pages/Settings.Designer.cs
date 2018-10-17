namespace LOginForm
{
    partial class Settings
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.level = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 115);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(650, 38);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(103, 319);
            this.level.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(310, 37);
            this.level.TabIndex = 1;
            this.level.TextChanged += new System.EventHandler(this.level_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(107)))), ((int)(((byte)(97)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(487, 516);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "SAVE CHANGES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please, select a user from the list below : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current restriction level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restriction level will block certain Matrices\r\nand/or limit users ability to modi" +
    "fy the content.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 125);
            this.label4.TabIndex = 7;
            this.label4.Text = "Levels and description:\r\n0: User only can see non secret Matrices\r\n1: User can se" +
    "e and modify non secret Matrices\r\n2: User can see all the Matrices\r\n3: User can " +
    "see and modify all Matrices\r\n";
            // 
            // ErMessage
            // 
            this.ErMessage.AutoSize = true;
            this.ErMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErMessage.ForeColor = System.Drawing.Color.Brown;
            this.ErMessage.Location = new System.Drawing.Point(99, 372);
            this.ErMessage.Name = "ErMessage";
            this.ErMessage.Size = new System.Drawing.Size(352, 21);
            this.ErMessage.TabIndex = 8;
            this.ErMessage.Text = "Please, enter number between 0 and 3";
            this.ErMessage.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.ErMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.level);
            this.Controls.Add(this.comboBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Settings";
            this.Text = "Restriction Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ErMessage;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}