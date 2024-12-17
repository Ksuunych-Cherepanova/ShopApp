using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ShopLib;

namespace ShopApp
{
    public partial class Form1 : Form
    {
              
        public Form1()
        {
            InitializeComponent();
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\user\\Desktop\\����\\��\\ShopDB"))
            {
                connection.Open();
               
            }
        }
        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("����������, ������� ����� � ������.");
                return;
            }

            if (UserService.AuthorizeUser(username, password))
            {
                try
                {
                    int userId = UserService.GetUserIdByUsername(username);
                    MainForm mainForm = new MainForm(userId);
                    mainForm.Show();
                    this.Hide(); // �������� ���� �����������
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("�������� ��� ������������ ��� ������.");
            }



        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}

