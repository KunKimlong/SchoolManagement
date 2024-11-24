namespace SchoolManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_txt = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.headLoginLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLoginLbl = new System.Windows.Forms.Label();
            this.passwordLoginnlbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // login_txt
            // 
            this.login_txt.AutoSize = true;
            this.login_txt.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_txt.Location = new System.Drawing.Point(192, 135);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(73, 33);
            this.login_txt.TabIndex = 0;
            this.login_txt.Text = "Login";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(177, 70);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(101, 58);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // headLoginLbl
            // 
            this.headLoginLbl.AutoSize = true;
            this.headLoginLbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLoginLbl.Location = new System.Drawing.Point(112, 25);
            this.headLoginLbl.Name = "headLoginLbl";
            this.headLoginLbl.Size = new System.Drawing.Size(239, 33);
            this.headLoginLbl.TabIndex = 2;
            this.headLoginLbl.Text = "School Management";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(177, 194);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(231, 26);
            this.emailTxt.TabIndex = 3;
            // 
            // emailLoginLbl
            // 
            this.emailLoginLbl.AutoSize = true;
            this.emailLoginLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLoginLbl.Location = new System.Drawing.Point(81, 198);
            this.emailLoginLbl.Name = "emailLoginLbl";
            this.emailLoginLbl.Size = new System.Drawing.Size(49, 19);
            this.emailLoginLbl.TabIndex = 4;
            this.emailLoginLbl.Text = "Email:";
            // 
            // passwordLoginnlbl
            // 
            this.passwordLoginnlbl.AutoSize = true;
            this.passwordLoginnlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginnlbl.Location = new System.Drawing.Point(81, 241);
            this.passwordLoginnlbl.Name = "passwordLoginnlbl";
            this.passwordLoginnlbl.Size = new System.Drawing.Size(75, 19);
            this.passwordLoginnlbl.TabIndex = 6;
            this.passwordLoginnlbl.Text = "Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(177, 237);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(231, 26);
            this.passwordTxt.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(165, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 38);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 358);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordLoginnlbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailLoginLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.headLoginLbl);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.login_txt);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_txt;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label headLoginLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLoginLbl;
        private System.Windows.Forms.Label passwordLoginnlbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button btnLogin;
    }
}