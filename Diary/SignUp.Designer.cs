namespace Diary
{
    partial class SignUp
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
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1Sign = new System.Windows.Forms.TextBox();
            this.textBox2Sign = new System.Windows.Forms.TextBox();
            this.createAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userName.Font = new System.Drawing.Font("MS Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(72, 76);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(127, 24);
            this.userName.TabIndex = 0;
            this.userName.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password.Font = new System.Drawing.Font("MS Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(85, 137);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(114, 24);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // textBox1Sign
            // 
            this.textBox1Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Sign.Location = new System.Drawing.Point(235, 65);
            this.textBox1Sign.Multiline = true;
            this.textBox1Sign.Name = "textBox1Sign";
            this.textBox1Sign.Size = new System.Drawing.Size(221, 35);
            this.textBox1Sign.TabIndex = 2;
            // 
            // textBox2Sign
            // 
            this.textBox2Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Sign.Location = new System.Drawing.Point(238, 126);
            this.textBox2Sign.Multiline = true;
            this.textBox2Sign.Name = "textBox2Sign";
            this.textBox2Sign.PasswordChar = '*';
            this.textBox2Sign.Size = new System.Drawing.Size(194, 35);
            this.textBox2Sign.TabIndex = 3;
            // 
            // createAccount
            // 
            this.createAccount.BackColor = System.Drawing.Color.Salmon;
            this.createAccount.Font = new System.Drawing.Font("Stencil", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.Location = new System.Drawing.Point(215, 224);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(270, 49);
            this.createAccount.TabIndex = 4;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = false;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.textBox2Sign);
            this.Controls.Add(this.textBox1Sign);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox1Sign;
        private System.Windows.Forms.TextBox textBox2Sign;
        private System.Windows.Forms.Button createAccount;
    }
}