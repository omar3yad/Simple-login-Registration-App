namespace FirstDescktopApp
{
    partial class Register
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            txt_confirmPassword = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            label3 = new Label();
            lbl_confirmPassword = new Label();
            btn_register = new Button();
            num_age = new NumericUpDown();
            dtp_birthDate = new DateTimePicker();
            radio_male = new RadioButton();
            radio_female = new RadioButton();
            combo_country = new ComboBox();
            lbl_age = new Label();
            lbl_birthDate = new Label();
            lbl_gender = new Label();
            lbl_country = new Label();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.ForeColor = SystemColors.HotTrack;
            txt_username.Location = new Point(163, 59);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(130, 23);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(163, 105);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(130, 23);
            txt_password.TabIndex = 1;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(163, 151);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.PasswordChar = '*';
            txt_confirmPassword.Size = new Size(130, 23);
            txt_confirmPassword.TabIndex = 2;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_username.ForeColor = SystemColors.HotTrack;
            lbl_username.Location = new Point(25, 58);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(73, 17);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = SystemColors.HotTrack;
            lbl_password.Location = new Point(25, 105);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 17);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(163, 9);
            label3.Name = "label3";
            label3.Size = new Size(145, 33);
            label3.TabIndex = 3;
            label3.Text = "Register ";
            label3.Click += label3_Click;
            // 
            // lbl_confirmPassword
            // 
            lbl_confirmPassword.AutoSize = true;
            lbl_confirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_confirmPassword.ForeColor = SystemColors.HotTrack;
            lbl_confirmPassword.Location = new Point(25, 152);
            lbl_confirmPassword.Name = "lbl_confirmPassword";
            lbl_confirmPassword.Size = new Size(124, 17);
            lbl_confirmPassword.TabIndex = 5;
            lbl_confirmPassword.Text = "Confirm Password:";
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.MenuHighlight;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_register.ForeColor = SystemColors.ControlLightLight;
            btn_register.Location = new Point(174, 195);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(100, 30);
            btn_register.TabIndex = 6;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // num_age
            // 
            num_age.BackColor = Color.White;
            num_age.ForeColor = SystemColors.HotTrack;
            num_age.Location = new Point(422, 105);
            num_age.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_age.Name = "num_age";
            num_age.Size = new Size(131, 23);
            num_age.TabIndex = 2;
            num_age.Value = new decimal(new int[] { 1, 0, 0, 0 });
            num_age.ValueChanged += num_age_ValueChanged;
            // 
            // dtp_birthDate
            // 
            dtp_birthDate.AccessibleRole = AccessibleRole.TitleBar;
            dtp_birthDate.CalendarForeColor = Color.White;
            dtp_birthDate.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            dtp_birthDate.CalendarTitleBackColor = Color.FromArgb(60, 60, 60);
            dtp_birthDate.Format = DateTimePickerFormat.Short;
            dtp_birthDate.Location = new Point(422, 58);
            dtp_birthDate.MaxDate = new DateTime(2025, 1, 21, 0, 0, 0, 0);
            dtp_birthDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtp_birthDate.Name = "dtp_birthDate";
            dtp_birthDate.Size = new Size(131, 23);
            dtp_birthDate.TabIndex = 3;
            dtp_birthDate.Value = new DateTime(2025, 1, 21, 0, 0, 0, 0);
            // 
            // radio_male
            // 
            radio_male.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_male.ForeColor = SystemColors.HotTrack;
            radio_male.Location = new Point(503, 196);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(60, 20);
            radio_male.TabIndex = 4;
            radio_male.Text = "Male";
            // 
            // radio_female
            // 
            radio_female.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_female.ForeColor = SystemColors.HotTrack;
            radio_female.Location = new Point(422, 196);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(70, 20);
            radio_female.TabIndex = 5;
            radio_female.Text = "Female";
            // 
            // combo_country
            // 
            combo_country.AccessibleRole = AccessibleRole.ScrollBar;
            combo_country.BackColor = SystemColors.ButtonHighlight;
            combo_country.FlatStyle = FlatStyle.Flat;
            combo_country.ForeColor = Color.Chocolate;
            combo_country.Items.AddRange(new object[] { "United States", "Canada", "United Kingdom", "Australia", "Egypt", "Other" });
            combo_country.Location = new Point(422, 151);
            combo_country.Name = "combo_country";
            combo_country.Size = new Size(131, 23);
            combo_country.TabIndex = 6;
            // 
            // lbl_age
            // 
            lbl_age.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_age.ForeColor = SystemColors.HotTrack;
            lbl_age.Location = new Point(328, 105);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(100, 23);
            lbl_age.TabIndex = 7;
            lbl_age.Text = "Age:";
            // 
            // lbl_birthDate
            // 
            lbl_birthDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_birthDate.ForeColor = SystemColors.HotTrack;
            lbl_birthDate.Location = new Point(328, 58);
            lbl_birthDate.Name = "lbl_birthDate";
            lbl_birthDate.Size = new Size(100, 23);
            lbl_birthDate.TabIndex = 8;
            lbl_birthDate.Text = "Birth Date:";
            // 
            // lbl_gender
            // 
            lbl_gender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_gender.ForeColor = SystemColors.HotTrack;
            lbl_gender.Location = new Point(328, 197);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(100, 23);
            lbl_gender.TabIndex = 9;
            lbl_gender.Text = "Gender:";
            // 
            // lbl_country
            // 
            lbl_country.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_country.ForeColor = SystemColors.HotTrack;
            lbl_country.Location = new Point(328, 155);
            lbl_country.Name = "lbl_country";
            lbl_country.Size = new Size(100, 23);
            lbl_country.TabIndex = 10;
            lbl_country.Text = "Country:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(602, 237);
            Controls.Add(btn_register);
            Controls.Add(lbl_confirmPassword);
            Controls.Add(lbl_password);
            Controls.Add(num_age);
            Controls.Add(lbl_username);
            Controls.Add(dtp_birthDate);
            Controls.Add(radio_male);
            Controls.Add(radio_female);
            Controls.Add(combo_country);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(txt_username);
            Controls.Add(lbl_age);
            Controls.Add(lbl_birthDate);
            Controls.Add(lbl_gender);
            Controls.Add(lbl_country);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.NumericUpDown num_age;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.DateTimePicker dtp_birthDate;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_confirmPassword;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_birthDate;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_country;
    }
}