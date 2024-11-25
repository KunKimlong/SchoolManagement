namespace SchoolManagement
{
    partial class Class
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
            this.class_txtname = new System.Windows.Forms.TextBox();
            this.class_courseid = new System.Windows.Forms.Label();
            this.class_cbcourseid = new System.Windows.Forms.ComboBox();
            this.class_cbroomid = new System.Windows.Forms.ComboBox();
            this.classid = new System.Windows.Forms.Label();
            this.class_cbteacherid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.class_date = new System.Windows.Forms.Label();
            this.class_startdate = new System.Windows.Forms.DateTimePicker();
            this.class_enddate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.class_btnadd = new System.Windows.Forms.Button();
            this.class_btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Class";
            // 
            // classname
            // 
            this.classname.AutoSize = true;
            this.classname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classname.Location = new System.Drawing.Point(73, 113);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(59, 24);
            this.classname.TabIndex = 1;
            this.classname.Text = "Name";
            // 
            // class_txtname
            // 
            this.class_txtname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_txtname.Location = new System.Drawing.Point(216, 110);
            this.class_txtname.Name = "class_txtname";
            this.class_txtname.Size = new System.Drawing.Size(321, 32);
            this.class_txtname.TabIndex = 2;
            // 
            // class_courseid
            // 
            this.class_courseid.AutoSize = true;
            this.class_courseid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_courseid.Location = new System.Drawing.Point(73, 168);
            this.class_courseid.Name = "class_courseid";
            this.class_courseid.Size = new System.Drawing.Size(95, 24);
            this.class_courseid.TabIndex = 3;
            this.class_courseid.Text = "Course_ID";
            // 
            // class_cbcourseid
            // 
            this.class_cbcourseid.AllowDrop = true;
            this.class_cbcourseid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_cbcourseid.FormattingEnabled = true;
            this.class_cbcourseid.Location = new System.Drawing.Point(216, 168);
            this.class_cbcourseid.Name = "class_cbcourseid";
            this.class_cbcourseid.Size = new System.Drawing.Size(321, 32);
            this.class_cbcourseid.TabIndex = 4;
            this.class_cbcourseid.SelectedIndexChanged += new System.EventHandler(this.class_cbid_SelectedIndexChanged);
            // 
            // class_cbroomid
            // 
            this.class_cbroomid.AllowDrop = true;
            this.class_cbroomid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_cbroomid.FormattingEnabled = true;
            this.class_cbroomid.Location = new System.Drawing.Point(216, 232);
            this.class_cbroomid.Name = "class_cbroomid";
            this.class_cbroomid.Size = new System.Drawing.Size(321, 32);
            this.class_cbroomid.TabIndex = 6;
            // 
            // classid
            // 
            this.classid.AutoSize = true;
            this.classid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classid.Location = new System.Drawing.Point(73, 240);
            this.classid.Name = "classid";
            this.classid.Size = new System.Drawing.Size(86, 24);
            this.classid.TabIndex = 5;
            this.classid.Text = "Room_ID";
            // 
            // class_cbteacherid
            // 
            this.class_cbteacherid.AllowDrop = true;
            this.class_cbteacherid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_cbteacherid.FormattingEnabled = true;
            this.class_cbteacherid.Location = new System.Drawing.Point(216, 287);
            this.class_cbteacherid.Name = "class_cbteacherid";
            this.class_cbteacherid.Size = new System.Drawing.Size(321, 32);
            this.class_cbteacherid.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Teacher_ID";
            // 
            // class_date
            // 
            this.class_date.AutoSize = true;
            this.class_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_date.Location = new System.Drawing.Point(73, 344);
            this.class_date.Name = "class_date";
            this.class_date.Size = new System.Drawing.Size(99, 24);
            this.class_date.TabIndex = 9;
            this.class_date.Text = "Start_Date";
            // 
            // class_startdate
            // 
            this.class_startdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_startdate.Location = new System.Drawing.Point(216, 344);
            this.class_startdate.Name = "class_startdate";
            this.class_startdate.Size = new System.Drawing.Size(320, 32);
            this.class_startdate.TabIndex = 10;
            // 
            // class_enddate
            // 
            this.class_enddate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_enddate.Location = new System.Drawing.Point(216, 404);
            this.class_enddate.Name = "class_enddate";
            this.class_enddate.Size = new System.Drawing.Size(320, 32);
            this.class_enddate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "End_Date";
            // 
            // class_btnadd
            // 
            this.class_btnadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_btnadd.ForeColor = System.Drawing.Color.Black;
            this.class_btnadd.Location = new System.Drawing.Point(68, 482);
            this.class_btnadd.Name = "class_btnadd";
            this.class_btnadd.Size = new System.Drawing.Size(201, 49);
            this.class_btnadd.TabIndex = 13;
            this.class_btnadd.Text = "Add Class";
            this.class_btnadd.UseVisualStyleBackColor = true;
            // 
            // class_btnclear
            // 
            this.class_btnclear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_btnclear.Location = new System.Drawing.Point(335, 482);
            this.class_btnclear.Name = "class_btnclear";
            this.class_btnclear.Size = new System.Drawing.Size(201, 49);
            this.class_btnclear.TabIndex = 14;
            this.class_btnclear.Text = "Clear";
            this.class_btnclear.UseVisualStyleBackColor = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 576);
            this.Controls.Add(this.class_btnclear);
            this.Controls.Add(this.class_btnadd);
            this.Controls.Add(this.class_enddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.class_startdate);
            this.Controls.Add(this.class_date);
            this.Controls.Add(this.class_cbteacherid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.class_cbroomid);
            this.Controls.Add(this.classid);
            this.Controls.Add(this.class_cbcourseid);
            this.Controls.Add(this.class_courseid);
            this.Controls.Add(this.class_txtname);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label1);
            this.Name = "Class";
            this.Text = "Teacher_ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label classname;
        private System.Windows.Forms.TextBox class_txtname;
        private System.Windows.Forms.Label class_courseid;
        private System.Windows.Forms.ComboBox class_cbcourseid;
        private System.Windows.Forms.ComboBox class_cbroomid;
        private System.Windows.Forms.Label classid;
        private System.Windows.Forms.ComboBox class_cbteacherid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label class_date;
        private System.Windows.Forms.DateTimePicker class_startdate;
        private System.Windows.Forms.DateTimePicker class_enddate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button class_btnadd;
        private System.Windows.Forms.Button class_btnclear;
    }
}