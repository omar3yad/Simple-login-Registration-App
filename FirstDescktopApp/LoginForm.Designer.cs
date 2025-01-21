namespace FirstDescktopApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            but_login = new Button();
            txt_pass = new Label();
            txt_username = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // but_login
            // 
            but_login.BackColor = SystemColors.MenuHighlight;
            but_login.FlatStyle = FlatStyle.Flat;
            but_login.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            but_login.ForeColor = SystemColors.ControlLightLight;
            but_login.Location = new Point(146, 204);
            but_login.Name = "but_login";
            but_login.Size = new Size(83, 34);
            but_login.TabIndex = 0;
            but_login.Text = "LogIn";
            but_login.UseVisualStyleBackColor = false;
            but_login.Click += but_login_Click;
            // 
            // txt_pass
            // 
            txt_pass.AutoSize = true;
            txt_pass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txt_pass.Location = new Point(38, 149);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(66, 17);
            txt_pass.TabIndex = 1;
            txt_pass.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.AutoSize = true;
            txt_username.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.ForeColor = SystemColors.HotTrack;
            txt_username.Location = new Point(38, 96);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(75, 17);
            txt_username.TabIndex = 2;
            txt_username.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(146, 24);
            label3.Name = "label3";
            label3.Size = new Size(95, 33);
            label3.TabIndex = 3;
            label3.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 146);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(356, 261);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txt_username);
            Controls.Add(txt_pass);
            Controls.Add(but_login);
            ForeColor = SystemColors.HotTrack;
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_login;
        private Label txt_pass;
        private Label txt_username;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
