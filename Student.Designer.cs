namespace SchoolManagement
{
    partial class StudentFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 38);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label1.Size = new System.Drawing.Size(331, 62);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Management";
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudentAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudentAdd.Location = new System.Drawing.Point(40, 176);
            this.btnStudentAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(160, 47);
            this.btnStudentAdd.TabIndex = 27;
            this.btnStudentAdd.Text = "+ Add Course";
            this.btnStudentAdd.UseVisualStyleBackColor = false;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(39, 280);
            this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.Size = new System.Drawing.Size(871, 251);
            this.dataGridViewStudent.TabIndex = 26;
            // 
            // StudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 567);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StudentFrm";
            this.Text = "StudentManagement";
            this.Load += new System.EventHandler(this.StudentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
    }
}