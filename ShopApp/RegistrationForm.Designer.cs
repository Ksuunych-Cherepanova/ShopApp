namespace ShopApp
{
    partial class RegistrationForm
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
            textBoxLogin = new TextBox();
            textBoxPasswordRepeat = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegistr = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(260, 141);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(231, 27);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPasswordRepeat
            // 
            textBoxPasswordRepeat.Location = new Point(260, 287);
            textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            textBoxPasswordRepeat.PasswordChar = '•';
            textBoxPasswordRepeat.Size = new Size(231, 27);
            textBoxPasswordRepeat.TabIndex = 1;
            textBoxPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(260, 213);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(231, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonRegistr
            // 
            buttonRegistr.FlatAppearance.BorderColor = Color.LightSteelBlue;
            buttonRegistr.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonRegistr.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegistr.Location = new Point(260, 348);
            buttonRegistr.Name = "buttonRegistr";
            buttonRegistr.Size = new Size(231, 44);
            buttonRegistr.TabIndex = 3;
            buttonRegistr.Text = "Зарегистрироваться";
            buttonRegistr.UseVisualStyleBackColor = true;
            buttonRegistr.Click += buttonRegistr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(182, 43);
            label1.Name = "label1";
            label1.Size = new Size(427, 48);
            label1.TabIndex = 4;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(260, 116);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 5;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(260, 188);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 6;
            label3.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(260, 261);
            label4.Name = "label4";
            label4.Size = new Size(162, 23);
            label4.TabIndex = 7;
            label4.Text = "Повторите пароль:";
            // 
            // RegistrationForm
            // 
            AcceptButton = buttonRegistr;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegistr);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxPasswordRepeat);
            Controls.Add(textBoxLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация в системе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPasswordRepeat;
        private TextBox textBoxPassword;
        private Button buttonRegistr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}