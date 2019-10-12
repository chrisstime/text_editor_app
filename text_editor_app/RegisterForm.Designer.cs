namespace text_editor_app
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.CancelAccountCreate = new System.Windows.Forms.LinkLabel();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.FNameField = new System.Windows.Forms.TextBox();
            this.LNameField = new System.Windows.Forms.TextBox();
            this.DobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CreateAccountHeading = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreateAccountButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateAccountButton.Location = new System.Drawing.Point(402, 311);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(133, 30);
            this.CreateAccountButton.TabIndex = 0;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // CancelAccountCreate
            // 
            this.CancelAccountCreate.AutoSize = true;
            this.CancelAccountCreate.Location = new System.Drawing.Point(39, 320);
            this.CancelAccountCreate.Name = "CancelAccountCreate";
            this.CancelAccountCreate.Size = new System.Drawing.Size(40, 13);
            this.CancelAccountCreate.TabIndex = 1;
            this.CancelAccountCreate.TabStop = true;
            this.CancelAccountCreate.Text = "Cancel";
            this.CancelAccountCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CancelAccountCreate_LinkClicked);
            // 
            // UsernameField
            // 
            this.UsernameField.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameField.Location = new System.Drawing.Point(41, 95);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(233, 23);
            this.UsernameField.TabIndex = 2;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(302, 95);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(233, 23);
            this.PasswordField.TabIndex = 3;
            // 
            // FNameField
            // 
            this.FNameField.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameField.Location = new System.Drawing.Point(41, 164);
            this.FNameField.Name = "FNameField";
            this.FNameField.Size = new System.Drawing.Size(233, 23);
            this.FNameField.TabIndex = 4;
            // 
            // LNameField
            // 
            this.LNameField.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameField.Location = new System.Drawing.Point(302, 164);
            this.LNameField.Name = "LNameField";
            this.LNameField.Size = new System.Drawing.Size(233, 23);
            this.LNameField.TabIndex = 5;
            // 
            // DobDatePicker
            // 
            this.DobDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DobDatePicker.Location = new System.Drawing.Point(302, 234);
            this.DobDatePicker.MaxDate = new System.DateTime(2019, 10, 11, 0, 0, 0, 0);
            this.DobDatePicker.Name = "DobDatePicker";
            this.DobDatePicker.Size = new System.Drawing.Size(233, 23);
            this.DobDatePicker.TabIndex = 6;
            this.DobDatePicker.Value = new System.DateTime(2019, 10, 11, 0, 0, 0, 0);
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserTypeComboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeComboBox.Location = new System.Drawing.Point(41, 234);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(233, 24);
            this.UserTypeComboBox.TabIndex = 7;
            // 
            // CreateAccountHeading
            // 
            this.CreateAccountHeading.AutoSize = true;
            this.CreateAccountHeading.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountHeading.Location = new System.Drawing.Point(38, 27);
            this.CreateAccountHeading.Name = "CreateAccountHeading";
            this.CreateAccountHeading.Size = new System.Drawing.Size(236, 23);
            this.CreateAccountHeading.TabIndex = 8;
            this.CreateAccountHeading.Text = "Create A Wripe Account";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(39, 76);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 16);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "*Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "User-Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of Birth";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 367);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.CreateAccountHeading);
            this.Controls.Add(this.UserTypeComboBox);
            this.Controls.Add(this.DobDatePicker);
            this.Controls.Add(this.LNameField);
            this.Controls.Add(this.FNameField);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.CancelAccountCreate);
            this.Controls.Add(this.CreateAccountButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Create An Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.LinkLabel CancelAccountCreate;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox FNameField;
        private System.Windows.Forms.TextBox LNameField;
        private System.Windows.Forms.DateTimePicker DobDatePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.Label CreateAccountHeading;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}