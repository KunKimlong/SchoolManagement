namespace SchoolManagement
{
    partial class AddRoomFrm
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
            this.btnRoomClear = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.txtRoomFloor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoomClear
            // 
            this.btnRoomClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomClear.Location = new System.Drawing.Point(242, 245);
            this.btnRoomClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomClear.Name = "btnRoomClear";
            this.btnRoomClear.Size = new System.Drawing.Size(106, 38);
            this.btnRoomClear.TabIndex = 34;
            this.btnRoomClear.Text = "Clear";
            this.btnRoomClear.UseVisualStyleBackColor = true;
            this.btnRoomClear.Click += new System.EventHandler(this.btnRoomClear_Click);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomAdd.Location = new System.Drawing.Point(83, 245);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(106, 38);
            this.btnRoomAdd.TabIndex = 33;
            this.btnRoomAdd.Text = "Add Room";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // txtRoomFloor
            // 
            this.txtRoomFloor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomFloor.Location = new System.Drawing.Point(138, 173);
            this.txtRoomFloor.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomFloor.Multiline = true;
            this.txtRoomFloor.Name = "txtRoomFloor";
            this.txtRoomFloor.Size = new System.Drawing.Size(210, 35);
            this.txtRoomFloor.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Floor";
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCode.Location = new System.Drawing.Point(138, 122);
            this.txtRoomCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomCode.Multiline = true;
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Size = new System.Drawing.Size(210, 35);
            this.txtRoomCode.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Room Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(147, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add Room";
            // 
            // AddRoomFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 366);
            this.Controls.Add(this.btnRoomClear);
            this.Controls.Add(this.btnRoomAdd);
            this.Controls.Add(this.txtRoomFloor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AddRoomFrm";
            this.Text = "AddRoomFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoomClear;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.TextBox txtRoomFloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}