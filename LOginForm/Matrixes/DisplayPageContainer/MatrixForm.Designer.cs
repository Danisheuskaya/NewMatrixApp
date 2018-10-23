namespace LOginForm
{
    partial class MatrixForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewRecordBtn = new System.Windows.Forms.Button();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.modefyTableRecordBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1836, 849);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(866, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name";
            // 
            // addNewRecordBtn
            // 
            this.addNewRecordBtn.Location = new System.Drawing.Point(34, 71);
            this.addNewRecordBtn.Name = "addNewRecordBtn";
            this.addNewRecordBtn.Size = new System.Drawing.Size(216, 35);
            this.addNewRecordBtn.TabIndex = 4;
            this.addNewRecordBtn.Text = "Add New Record";
            this.addNewRecordBtn.UseVisualStyleBackColor = true;
            this.addNewRecordBtn.Visible = false;
            this.addNewRecordBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Location = new System.Drawing.Point(290, 71);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(216, 35);
            this.deleteRecordBtn.TabIndex = 5;
            this.deleteRecordBtn.Text = "Delete Record";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            this.deleteRecordBtn.Visible = false;
            this.deleteRecordBtn.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // modefyTableRecordBtn
            // 
            this.modefyTableRecordBtn.Location = new System.Drawing.Point(1365, 71);
            this.modefyTableRecordBtn.Name = "modefyTableRecordBtn";
            this.modefyTableRecordBtn.Size = new System.Drawing.Size(216, 35);
            this.modefyTableRecordBtn.TabIndex = 6;
            this.modefyTableRecordBtn.Text = "Save Changes";
            this.modefyTableRecordBtn.UseVisualStyleBackColor = true;
            this.modefyTableRecordBtn.Visible = false;
            this.modefyTableRecordBtn.Click += new System.EventHandler(this.modefyBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1638, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1887, 749);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.modefyTableRecordBtn);
            this.Controls.Add(this.deleteRecordBtn);
            this.Controls.Add(this.addNewRecordBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MatrixForm";
            this.Text = "Matrix Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatrixForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewRecordBtn;
        private System.Windows.Forms.Button deleteRecordBtn;
        private System.Windows.Forms.Button modefyTableRecordBtn;
        private System.Windows.Forms.Button button5;
    }
}