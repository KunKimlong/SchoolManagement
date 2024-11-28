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
            this.login_txt.Location = new System.Drawing.Point(256, 166);
            this.login_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(92, 41);
            this.login_txt.TabIndex = 0;
            this.login_txt.Text = "Login";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(236, 86);
            this.pictureBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(135, 71);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // headLoginLbl
            // 
            this.headLoginLbl.AutoSize = true;
            this.headLoginLbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLoginLbl.Location = new System.Drawing.Point(149, 31);
            this.headLoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headLoginLbl.Name = "headLoginLbl";
            this.headLoginLbl.Size = new System.Drawing.Size(303, 41);
            this.headLoginLbl.TabIndex = 2;
            this.headLoginLbl.Text = "School Management";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(236, 239);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(307, 30);
            this.emailTxt.TabIndex = 3;
            // 
            // emailLoginLbl
            // 
            this.emailLoginLbl.AutoSize = true;
            this.emailLoginLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLoginLbl.Location = new System.Drawing.Point(108, 244);
            this.emailLoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLoginLbl.Name = "emailLoginLbl";
            this.emailLoginLbl.Size = new System.Drawing.Size(61, 24);
            this.emailLoginLbl.TabIndex = 4;
            this.emailLoginLbl.Text = "Email:";
            // 
            // passwordLoginnlbl
            // 
            this.passwordLoginnlbl.AutoSize = true;
            this.passwordLoginnlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginnlbl.Location = new System.Drawing.Point(108, 297);
            this.passwordLoginnlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLoginnlbl.Name = "passwordLoginnlbl";
            this.passwordLoginnlbl.Size = new System.Drawing.Size(94, 24);
            this.passwordLoginnlbl.TabIndex = 6;
            this.passwordLoginnlbl.Text = "Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(236, 292);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(307, 30);
            this.passwordTxt.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(220, 357);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 47);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 441);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordLoginnlbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailLoginLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.headLoginLbl);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.login_txt);
            this.Margin = new System.Windows.Forms.Padding(4);
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