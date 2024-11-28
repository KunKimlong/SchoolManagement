namespace SchoolManagement
{
    partial class ClassFrm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(665, 157);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 47);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "- Delete Course";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(450, 157);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 47);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "* Update Course";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCourseAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCourseAdd.Location = new System.Drawing.Point(56, 157);
            this.btnCourseAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(140, 47);
            this.btnCourseAdd.TabIndex = 28;
            this.btnCourseAdd.Text = "+ Add Class";
            this.btnCourseAdd.UseVisualStyleBackColor = false;
/*            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
*/            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(56, 237);
            this.dataGridViewClass.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.Size = new System.Drawing.Size(762, 251);
            this.dataGridViewClass.TabIndex = 27;
            this.dataGridViewClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.label1.Size = new System.Drawing.Size(291, 62);
            this.label1.TabIndex = 26;
            this.label1.Text = "Class Management";
            // 
            // ClassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCourseAdd);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ClassFrm";
            this.Text = "Teacher_ID";
            this.Load += new System.EventHandler(this.ClassFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Label label1;
    }
}