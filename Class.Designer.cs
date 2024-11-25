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
            this.label1 = new System.Windows.Forms.Label();
            this.classname = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.class_courseid = new System.Windows.Forms.Label();
            this.courseIdCbo = new System.Windows.Forms.ComboBox();
            this.roomIdCbo = new System.Windows.Forms.ComboBox();
            this.classid = new System.Windows.Forms.Label();
            this.teacherIdCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.class_date = new System.Windows.Forms.Label();
            this.dateSart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Class";
            // 
            // classname
            // 
            this.classname.AutoSize = true;
            this.classname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classname.Location = new System.Drawing.Point(74, 113);
            this.classname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(59, 24);
            this.classname.TabIndex = 1;
            this.classname.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(216, 110);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(321, 32);
            this.nameTxt.TabIndex = 2;
            // 
            // class_courseid
            // 
            this.class_courseid.AutoSize = true;
            this.class_courseid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_courseid.Location = new System.Drawing.Point(74, 167);
            this.class_courseid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class_courseid.Name = "class_courseid";
            this.class_courseid.Size = new System.Drawing.Size(95, 24);
            this.class_courseid.TabIndex = 3;
            this.class_courseid.Text = "Course_ID";
            // 
            // courseIdCbo
            // 
            this.courseIdCbo.AllowDrop = true;
            this.courseIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdCbo.FormattingEnabled = true;
            this.courseIdCbo.Location = new System.Drawing.Point(216, 167);
            this.courseIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.courseIdCbo.Name = "courseIdCbo";
            this.courseIdCbo.Size = new System.Drawing.Size(321, 32);
            this.courseIdCbo.TabIndex = 4;
            this.courseIdCbo.SelectedIndexChanged += new System.EventHandler(this.class_cbid_SelectedIndexChanged);
            // 
            // roomIdCbo
            // 
            this.roomIdCbo.AllowDrop = true;
            this.roomIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdCbo.FormattingEnabled = true;
            this.roomIdCbo.Location = new System.Drawing.Point(216, 231);
            this.roomIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.roomIdCbo.Name = "roomIdCbo";
            this.roomIdCbo.Size = new System.Drawing.Size(321, 32);
            this.roomIdCbo.TabIndex = 6;
            // 
            // classid
            // 
            this.classid.AutoSize = true;
            this.classid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classid.Location = new System.Drawing.Point(74, 240);
            this.classid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classid.Name = "classid";
            this.classid.Size = new System.Drawing.Size(86, 24);
            this.classid.TabIndex = 5;
            this.classid.Text = "Room_ID";
            // 
            // teacherIdCbo
            // 
            this.teacherIdCbo.AllowDrop = true;
            this.teacherIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIdCbo.FormattingEnabled = true;
            this.teacherIdCbo.Location = new System.Drawing.Point(216, 287);
            this.teacherIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.teacherIdCbo.Name = "teacherIdCbo";
            this.teacherIdCbo.Size = new System.Drawing.Size(321, 32);
            this.teacherIdCbo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Teacher_ID";
            // 
            // class_date
            // 
            this.class_date.AutoSize = true;
            this.class_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_date.Location = new System.Drawing.Point(74, 345);
            this.class_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class_date.Name = "class_date";
            this.class_date.Size = new System.Drawing.Size(99, 24);
            this.class_date.TabIndex = 9;
            this.class_date.Text = "Start_Date";
            // 
            // dateSart
            // 
            this.dateSart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSart.Location = new System.Drawing.Point(216, 345);
            this.dateSart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateSart.Name = "dateSart";
            this.dateSart.Size = new System.Drawing.Size(320, 32);
            this.dateSart.TabIndex = 10;
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(216, 404);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(320, 32);
            this.dateEnd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "End_Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(68, 482);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 49);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Class";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(335, 482);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 49);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // ClassFrm
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ClassFrm";
            this.Text = "Teacher_ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label classname;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label class_courseid;
        private System.Windows.Forms.ComboBox courseIdCbo;
        private System.Windows.Forms.ComboBox roomIdCbo;
        private System.Windows.Forms.Label classid;
        private System.Windows.Forms.ComboBox teacherIdCbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label class_date;
        private System.Windows.Forms.DateTimePicker dateSart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}