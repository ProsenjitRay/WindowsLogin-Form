namespace WindowsLogin_Form
{
    partial class Form1
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.panelSIGNIN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panelSIGNIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(33, 275);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(125, 26);
            this.username.TabIndex = 0;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(33, 373);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(110, 26);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // textuser
            // 
            this.textuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textuser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(283, 275);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(284, 30);
            this.textuser.TabIndex = 2;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(283, 355);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(284, 30);
            this.textpassword.TabIndex = 3;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonlogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(283, 475);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(110, 68);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "LogIn";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonexit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonexit.Location = new System.Drawing.Point(457, 475);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(110, 68);
            this.buttonexit.TabIndex = 5;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // panelSIGNIN
            // 
            this.panelSIGNIN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSIGNIN.Controls.Add(this.labelX);
            this.panelSIGNIN.Controls.Add(this.label1);
            this.panelSIGNIN.Location = new System.Drawing.Point(-1, -3);
            this.panelSIGNIN.Name = "panelSIGNIN";
            this.panelSIGNIN.Size = new System.Drawing.Size(643, 182);
            this.panelSIGNIN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(226, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelX.Location = new System.Drawing.Point(572, 12);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(41, 41);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(624, 654);
            this.Controls.Add(this.panelSIGNIN);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSIGNIN.ResumeLayout(false);
            this.panelSIGNIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Panel panelSIGNIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
    }
}

