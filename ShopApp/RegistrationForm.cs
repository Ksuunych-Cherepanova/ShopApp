using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SQLite;
using ShopLib;


namespace ShopApp
{
    public partial class RegistrationForm : Form
    {
        
        
        public RegistrationForm()
        {
            
            InitializeComponent();
            
        }
        
        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxLogin.Text.Trim();
            string newPassword = textBoxPassword.Text.Trim();
            string newPasswordRepeat = textBoxPasswordRepeat.Text.Trim();

             
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }
            else if (newPassword != newPasswordRepeat)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }
            try
            {
                if (UserService.RegisterUser(newUsername, newPassword))
                {

                    try
                    {
                        int userId = UserService.GetUserIdByUsername(newUsername);
                        MainForm mainForm = new MainForm(userId);
                        mainForm.Show();
                        this.Hide(); // Скрываем окно авторизации
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Регистрация не прошла.");
            }
            
        }


    }
}
