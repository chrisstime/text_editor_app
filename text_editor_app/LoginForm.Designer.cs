namespace text_editor_app
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.RegisterDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameInput
            // 
            this.UserNameInput.AllowDrop = true;
            this.UserNameInput.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameInput.Location = new System.Drawing.Point(75, 108);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(243, 23);
            this.UserNameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Location = new System.Drawing.Point(75, 183);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(243, 22);
            this.PasswordInput.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(72, 89);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(78, 16);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(72, 164);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoginButton.Location = new System.Drawing.Point(232, 252);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 33);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLink.Location = new System.Drawing.Point(35, 272);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(96, 13);
            this.RegisterLink.TabIndex = 6;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Create an Account";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // RegisterDesc
            // 
            this.RegisterDesc.AutoSize = true;
            this.RegisterDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterDesc.Location = new System.Drawing.Point(35, 252);
            this.RegisterDesc.Name = "RegisterDesc";
            this.RegisterDesc.Size = new System.Drawing.Size(122, 13);
            this.RegisterDesc.TabIndex = 7;
            this.RegisterDesc.Text = "Don\'t have an account?";
            this.RegisterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 312);
            this.Controls.Add(this.RegisterDesc);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Wripe Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Label RegisterDesc;
    }
}