namespace SchoolManagement
{
    partial class AddClassFrm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSart = new System.Windows.Forms.DateTimePicker();
            this.class_date = new System.Windows.Forms.Label();
            this.teacherIdCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomIdCbo = new System.Windows.Forms.ComboBox();
            this.classid = new System.Windows.Forms.Label();
            this.courseIdCbo = new System.Windows.Forms.ComboBox();
            this.class_courseid = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.classname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(346, 453);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 49);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(79, 453);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 49);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add Class";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(227, 375);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(320, 32);
            this.dateEnd.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "End_Date";
            // 
            // dateSart
            // 
            this.dateSart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSart.Location = new System.Drawing.Point(227, 316);
            this.dateSart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateSart.Name = "dateSart";
            this.dateSart.Size = new System.Drawing.Size(320, 32);
            this.dateSart.TabIndex = 25;
            // 
            // class_date
            // 
            this.class_date.AutoSize = true;
            this.class_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_date.Location = new System.Drawing.Point(85, 316);
            this.class_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class_date.Name = "class_date";
            this.class_date.Size = new System.Drawing.Size(99, 24);
            this.class_date.TabIndex = 24;
            this.class_date.Text = "Start_Date";
            // 
            // teacherIdCbo
            // 
            this.teacherIdCbo.AllowDrop = true;
            this.teacherIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIdCbo.FormattingEnabled = true;
            this.teacherIdCbo.Location = new System.Drawing.Point(227, 258);
            this.teacherIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.teacherIdCbo.Name = "teacherIdCbo";
            this.teacherIdCbo.Size = new System.Drawing.Size(321, 32);
            this.teacherIdCbo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Teacher_ID";
            // 
            // roomIdCbo
            // 
            this.roomIdCbo.AllowDrop = true;
            this.roomIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdCbo.FormattingEnabled = true;
            this.roomIdCbo.Location = new System.Drawing.Point(227, 202);
            this.roomIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.roomIdCbo.Name = "roomIdCbo";
            this.roomIdCbo.Size = new System.Drawing.Size(321, 32);
            this.roomIdCbo.TabIndex = 21;
            // 
            // classid
            // 
            this.classid.AutoSize = true;
            this.classid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classid.Location = new System.Drawing.Point(85, 211);
            this.classid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classid.Name = "classid";
            this.classid.Size = new System.Drawing.Size(86, 24);
            this.classid.TabIndex = 20;
            this.classid.Text = "Room_ID";
            // 
            // courseIdCbo
            // 
            this.courseIdCbo.AllowDrop = true;
            this.courseIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdCbo.FormattingEnabled = true;
            this.courseIdCbo.Location = new System.Drawing.Point(227, 138);
            this.courseIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.courseIdCbo.Name = "courseIdCbo";
            this.courseIdCbo.Size = new System.Drawing.Size(321, 32);
            this.courseIdCbo.TabIndex = 19;
            // 
            // class_courseid
            // 
            this.class_courseid.AutoSize = true;
            this.class_courseid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_courseid.Location = new System.Drawing.Point(85, 138);
            this.class_courseid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class_courseid.Name = "class_courseid";
            this.class_courseid.Size = new System.Drawing.Size(95, 24);
            this.class_courseid.TabIndex = 18;
            this.class_courseid.Text = "Course_ID";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(227, 81);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(321, 32);
            this.nameTxt.TabIndex = 17;
            // 
            // classname
            // 
            this.classname.AutoSize = true;
            this.classname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classname.Location = new System.Drawing.Point(85, 84);
            this.classname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(59, 24);
            this.classname.TabIndex = 16;
            this.classname.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Class";
            // 
            // AddClassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 576);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateSart);
            this.Controls.Add(this.class_date);
            this.Controls.Add(this.teacherIdCbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomIdCbo);
            this.Controls.Add(this.classid);
            this.Controls.Add(this.courseIdCbo);
            this.Controls.Add(this.class_courseid);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label1);
            this.Name = "AddClassFrm";
            this.Text = "AddClassFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateSart;
        private System.Windows.Forms.Label class_date;
        private System.Windows.Forms.ComboBox teacherIdCbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomIdCbo;
        private System.Windows.Forms.Label classid;
        private System.Windows.Forms.ComboBox courseIdCbo;
        private System.Windows.Forms.Label class_courseid;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label classname;
        private System.Windows.Forms.Label label1;
    }
}