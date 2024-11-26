namespace SchoolManagement
{
    partial class CourseManagementFrm
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
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(261, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Management";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(38, 190);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.Size = new System.Drawing.Size(653, 204);
            this.dataGridViewCourses.TabIndex = 1;
            this.dataGridViewCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellClick);
            this.dataGridViewCourses.SelectionChanged += new System.EventHandler(this.dataGridViewCourses_SelectionChanged);
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCourseAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCourseAdd.Location = new System.Drawing.Point(38, 125);
            this.btnCourseAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(120, 38);
            this.btnCourseAdd.TabIndex = 23;
            this.btnCourseAdd.Text = "+ Add Course";
            this.btnCourseAdd.UseVisualStyleBackColor = false;
            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(422, 125);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 38);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "* Update Course";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(565, 125);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 38);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "- Delete Course";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CourseManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 421);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCourseAdd);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseManagementFrm";
            this.Text = "CourseManagement";
            this.Load += new System.EventHandler(this.CourseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}