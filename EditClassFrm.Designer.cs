namespace SchoolManagement
{
    partial class EditClassFrm
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
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSart = new System.Windows.Forms.DateTimePicker();
            this.class_date = new System.Windows.Forms.Label();
            this.teacherIdCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomIdCbo = new System.Windows.Forms.ComboBox();
            this.classid = new System.Windows.Forms.Label();
            this.courseCbo = new System.Windows.Forms.ComboBox();
            this.class_courseid = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.classname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(428, 421);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(213, 49);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnClassUpdate.Location = new System.Drawing.Point(171, 421);
            this.btnClassUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(213, 49);
            this.btnClassUpdate.TabIndex = 43;
            this.btnClassUpdate.Text = "Edite";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(309, 354);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(332, 32);
            this.dateEnd.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "End_Date";
            // 
            // dateSart
            // 
            this.dateSart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSart.Location = new System.Drawing.Point(309, 295);
            this.dateSart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateSart.Name = "dateSart";
            this.dateSart.Size = new System.Drawing.Size(332, 32);
            this.dateSart.TabIndex = 40;
            // 
            // class_date
            // 
            this.class_date.AutoSize = true;
            this.class_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_date.Location = new System.Drawing.Point(167, 295);
            this.class_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class_date.Name = "class_date";
            this.class_date.Size = new System.Drawing.Size(99, 24);
            this.class_date.TabIndex = 39;
            this.class_date.Text = "Start_Date";
            // 
            // teacherIdCbo
            // 
            this.teacherIdCbo.AllowDrop = true;
            this.teacherIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIdCbo.FormattingEnabled = true;
            this.teacherIdCbo.Location = new System.Drawing.Point(309, 237);
            this.teacherIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.teacherIdCbo.Name = "teacherIdCbo";
            this.teacherIdCbo.Size = new System.Drawing.Size(333, 32);
            this.teacherIdCbo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Teacher";
            // 
            // roomIdCbo
            // 
            this.roomIdCbo.AllowDrop = true;
            this.roomIdCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdCbo.FormattingEnabled = true;
            this.roomIdCbo.Location = new System.Drawing.Point(309, 181);
            this.roomIdCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.roomIdCbo.Name = "roomIdCbo";
            this.roomIdCbo.Size = new System.Drawing.Size(333, 32);
            this.roomIdCbo.TabIndex = 36;
            // 
            // classid
            // 
            this.classid.AutoSize = true;
            this.classid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classid.Location = new System.Drawing.Point(167, 190);
            this.classid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classid.Name = "classid";
            this.classid.Size = new System.Drawing.Size(59, 24);
            this.classid.TabIndex = 35;
            this.classid.Text = "Room";
            // 
            // courseCbo
            // 
            this.courseCbo.AllowDrop = true;
            this.courseCbo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCbo.FormattingEnabled = true;
            this.courseCbo.Location = new System.Drawing.Point(309, 117);
            this.courseCbo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.courseCbo.Name = "courseCbo";
            this.courseCbo.Size = new System.Drawing.Size(333, 32);
            this.courseCbo.TabIndex = 34;
            // 
            // class_courseid
            // 
            this.class_courseid.AutoSize = true;
            this.class_courseid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_courseid.Location = new System.Drawing.Point(167, 117);
            this.class_courseid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class_courseid.Name = "class_courseid";
            this.class_courseid.Size = new System.Drawing.Size(68, 24);
            this.class_courseid.TabIndex = 33;
            this.class_courseid.Text = "Course";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(309, 60);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(333, 32);
            this.nameTxt.TabIndex = 32;
            // 
            // classname
            // 
            this.classname.AutoSize = true;
            this.classname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classname.Location = new System.Drawing.Point(167, 63);
            this.classname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(59, 24);
            this.classname.TabIndex = 31;
            this.classname.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 30;
            this.label1.Text = "Edit Class";
            // 
            // EditClassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClassUpdate);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateSart);
            this.Controls.Add(this.class_date);
            this.Controls.Add(this.teacherIdCbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomIdCbo);
            this.Controls.Add(this.classid);
            this.Controls.Add(this.courseCbo);
            this.Controls.Add(this.class_courseid);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label1);
            this.Name = "EditClassFrm";
            this.Text = "EditClassFrm";
            this.Load += new System.EventHandler(this.EditClassFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateSart;
        private System.Windows.Forms.Label class_date;
        private System.Windows.Forms.ComboBox teacherIdCbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomIdCbo;
        private System.Windows.Forms.Label classid;
        private System.Windows.Forms.ComboBox courseCbo;
        private System.Windows.Forms.Label class_courseid;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label classname;
        private System.Windows.Forms.Label label1;
    }
}