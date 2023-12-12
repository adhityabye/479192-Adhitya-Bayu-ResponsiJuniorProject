namespace Responsi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtDepartemen = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            label3 = new Label();
            btnLoaddata = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 102);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 148);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan";
            // 
            // txtName
            // 
            txtName.Location = new Point(208, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(215, 23);
            txtName.TabIndex = 2;
            // 
            // txtDepartemen
            // 
            txtDepartemen.Location = new Point(208, 148);
            txtDepartemen.Name = "txtDepartemen";
            txtDepartemen.Size = new Size(215, 23);
            txtDepartemen.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(91, 222);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(348, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(611, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(91, 272);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(595, 150);
            dgvData.TabIndex = 7;
            dgvData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 23);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Hello World";
            // 
            // btnLoaddata
            // 
            btnLoaddata.Location = new Point(611, 102);
            btnLoaddata.Name = "btnLoaddata";
            btnLoaddata.Size = new Size(75, 23);
            btnLoaddata.TabIndex = 9;
            btnLoaddata.Text = "Load";
            btnLoaddata.UseVisualStyleBackColor = true;
            btnLoaddata.Click += btnLoaddata_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoaddata);
            Controls.Add(label3);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(txtDepartemen);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtDepartemen;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Label label3;
        private Button btnLoaddata;
    }
}