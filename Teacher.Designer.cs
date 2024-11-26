namespace SchoolManagement
{
    partial class TeacherFrm
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
            this.headLoginLbl = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // headLoginLbl
            // 
            this.headLoginLbl.AutoSize = true;
            this.headLoginLbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLoginLbl.Location = new System.Drawing.Point(339, 37);
            this.headLoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headLoginLbl.Name = "headLoginLbl";
            this.headLoginLbl.Size = new System.Drawing.Size(319, 41);
            this.headLoginLbl.TabIndex = 15;
            this.headLoginLbl.Text = "Teacher Management";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(43, 185);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 47);
            this.btnLogin.TabIndex = 39;
            this.btnLogin.Text = "+ Add Teacher";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(43, 271);
            this.dataGridViewTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.RowHeadersWidth = 51;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(1004, 289);
            this.dataGridViewTeacher.TabIndex = 41;
            // 
            // TeacherFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 575);
            this.Controls.Add(this.dataGridViewTeacher);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.headLoginLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherFrm";
            this.Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headLoginLbl;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
    }
}