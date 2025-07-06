using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand(@"
                    SELECT Role, UserID
                    FROM Users
                    WHERE Username = @usr
                      AND PasswordHash = @pwd", conn))
                {
                    cmd.Parameters.AddWithValue("@usr", username);
                    cmd.Parameters.AddWithValue("@pwd", password);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Invalid credentials.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        string role = reader.GetString(0);
                        int userId = reader.GetInt32(1);
                        reader.Close();

                        Form nextForm;
                        if (role == "Admin")
                        {
                            nextForm = new AdminDashboardForm();
                        }
                        else
                        {
                            nextForm = new StudentForm(userId, username);
                        }

                        nextForm.FormClosed += (s, args) => this.Close();
                        nextForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnOpenRegister_Click(object sender, EventArgs e)
        {
            var regForm = new RegisterForm();
            regForm.FormClosed += (s, args) => this.Show();
            regForm.Show();
            this.Hide();
        }
    }
}