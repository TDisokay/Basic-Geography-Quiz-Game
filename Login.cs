using System;
using System.Windows.Forms;

namespace Game_WFDemo_1202
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (creatorRadio.Checked)
            {
                if (username == "admin" && password == "admin123")
                {
                    Creator creator = new Creator();
                    creator.FormClosed += (s, args) => this.Show();
                    this.Hide();
                    creator.Show();
                }
                else
                {
                    MessageBox.Show("Invalid creator credentials!");
                }
            }
            else
            {
                if (username == "duongnguyen" && password == "duong123")
                    if (GameData.QuestionBank.Count != 0)
                    {
                        Player player = new Player();
                        player.FormClosed += (s, args) => this.Show();
                        this.Hide();
                        player.Show();
                    }
                    else
                    {
                        MessageBox.Show("No questions available. Please add questions first.");
                    }
                else
                {
                    MessageBox.Show("Invalid player credentials!");
                }
            }
        }
    }
}