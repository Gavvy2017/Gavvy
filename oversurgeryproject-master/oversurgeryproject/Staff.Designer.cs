namespace oversurgeryproject
{
    partial class Staff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oversugeryDBDataSet3 = new oversurgeryproject.OversugeryDBDataSet3();
            this.staffTableAdapter = new oversurgeryproject.OversugeryDBDataSet3TableAdapters.staffTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oversugeryDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(886, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(999, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log off";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(838, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mondayDataGridViewTextBoxColumn,
            this.tuesdayDataGridViewTextBoxColumn,
            this.wednesdayDataGridViewTextBoxColumn,
            this.thursdayDataGridViewTextBoxColumn,
            this.fridayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 300);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(46, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 37);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.oversugeryDBDataSet3;
            // 
            // oversugeryDBDataSet3
            // 
            this.oversugeryDBDataSet3.DataSetName = "OversugeryDBDataSet3";
            this.oversugeryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name ";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mondayDataGridViewTextBoxColumn
            // 
            this.mondayDataGridViewTextBoxColumn.DataPropertyName = "Monday ";
            this.mondayDataGridViewTextBoxColumn.HeaderText = "Monday ";
            this.mondayDataGridViewTextBoxColumn.Name = "mondayDataGridViewTextBoxColumn";
            // 
            // tuesdayDataGridViewTextBoxColumn
            // 
            this.tuesdayDataGridViewTextBoxColumn.DataPropertyName = "Tuesday ";
            this.tuesdayDataGridViewTextBoxColumn.HeaderText = "Tuesday ";
            this.tuesdayDataGridViewTextBoxColumn.Name = "tuesdayDataGridViewTextBoxColumn";
            // 
            // wednesdayDataGridViewTextBoxColumn
            // 
            this.wednesdayDataGridViewTextBoxColumn.DataPropertyName = "Wednesday ";
            this.wednesdayDataGridViewTextBoxColumn.HeaderText = "Wednesday ";
            this.wednesdayDataGridViewTextBoxColumn.Name = "wednesdayDataGridViewTextBoxColumn";
            // 
            // thursdayDataGridViewTextBoxColumn
            // 
            this.thursdayDataGridViewTextBoxColumn.DataPropertyName = "Thursday ";
            this.thursdayDataGridViewTextBoxColumn.HeaderText = "Thursday ";
            this.thursdayDataGridViewTextBoxColumn.Name = "thursdayDataGridViewTextBoxColumn";
            // 
            // fridayDataGridViewTextBoxColumn
            // 
            this.fridayDataGridViewTextBoxColumn.DataPropertyName = "Friday ";
            this.fridayDataGridViewTextBoxColumn.HeaderText = "Friday ";
            this.fridayDataGridViewTextBoxColumn.Name = "fridayDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Confrimed ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1114, 515);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oversugeryDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private OversugeryDBDataSet3 oversugeryDBDataSet3;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private OversugeryDBDataSet3TableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}