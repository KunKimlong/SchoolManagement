namespace SchoolManagement
{
    partial class EditCourseFrm
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
            this.btnCourseClear = new System.Windows.Forms.Button();
            this.btnCourseUpdate = new System.Windows.Forms.Button();
            this.txtCourseDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoursePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCourseClear
            // 
            this.btnCourseClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseClear.Location = new System.Drawing.Point(257, 302);
            this.btnCourseClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseClear.Name = "btnCourseClear";
            this.btnCourseClear.Size = new System.Drawing.Size(106, 38);
            this.btnCourseClear.TabIndex = 32;
            this.btnCourseClear.Text = "Clear";
            this.btnCourseClear.UseVisualStyleBackColor = true;
            // 
            // btnCourseUpdate
            // 
            this.btnCourseUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseUpdate.Location = new System.Drawing.Point(99, 302);
            this.btnCourseUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseUpdate.Name = "btnCourseUpdate";
            this.btnCourseUpdate.Size = new System.Drawing.Size(106, 38);
            this.btnCourseUpdate.TabIndex = 31;
            this.btnCourseUpdate.Text = "Edit Course";
            this.btnCourseUpdate.UseVisualStyleBackColor = true;
            this.btnCourseUpdate.Click += new System.EventHandler(this.btnCourseUpdate_Click);
            // 
            // txtCourseDiscount
            // 
            this.txtCourseDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseDiscount.Location = new System.Drawing.Point(187, 216);
            this.txtCourseDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseDiscount.Name = "txtCourseDiscount";
            this.txtCourseDiscount.Size = new System.Drawing.Size(243, 27);
            this.txtCourseDiscount.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Course Discount:";
            // 
            // txtCoursePrice
            // 
            this.txtCoursePrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoursePrice.Location = new System.Drawing.Point(187, 166);
            this.txtCoursePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoursePrice.Name = "txtCoursePrice";
            this.txtCoursePrice.Size = new System.Drawing.Size(243, 27);
            this.txtCoursePrice.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Course Price:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(187, 122);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(243, 27);
            this.txtCourseName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(156, 51);
            this.label1.TabIndex = 24;
            this.label1.Text = "Edit Course";
            // 
            // EditCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.btnCourseClear);
            this.Controls.Add(this.btnCourseUpdate);
            this.Controls.Add(this.txtCourseDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCoursePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "EditCourseFrm";
            this.Text = "EditCourseFrm";
            this.Load += new System.EventHandler(this.EditCourseFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCourseClear;
        private System.Windows.Forms.Button btnCourseUpdate;
        private System.Windows.Forms.TextBox txtCourseDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCoursePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}