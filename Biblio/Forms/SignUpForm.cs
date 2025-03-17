using Biblio.Data;
using Biblio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Biblio
{
    public partial class SignUpForm : Form
    {
        private readonly AppDbContext _dbContext;

        public SignUpForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(textnom.Text) || string.IsNullOrWhiteSpace(textEmail.Text) || 
                string.IsNullOrWhiteSpace(textPasswd.Text) || string.IsNullOrWhiteSpace(textConfirm.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (textPasswd.Text != textConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!_dbContext.Users.Any(u => u.Email == textEmail.Text))
            {
                // Hash the password
                var hashedPassword = HashPassword(textPasswd.Text);

                // Create a new user
                var user = new User
                {
                    Nom = textnom.Text,
                    Email = textEmail.Text,
                    PasswordHash = hashedPassword
                };

                // Save user to database
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                MessageBox.Show("User registered successfully!");
                this.Close(); // Optionally close the form after successful registration
            }
            else
            {
                MessageBox.Show("This email is already registered.");
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var hashedBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedBytes);
            }
        }

        // Event Handlers for TextChanged events (optional, for additional validation if necessary)
        private void textnom_TextChanged(object sender, EventArgs e) { }

        private void textEmail_TextChanged(object sender, EventArgs e) { }

        private void textPasswd_TextChanged(object sender, EventArgs e) { }

        private void textConfirm_TextChanged(object sender, EventArgs e) { }

        // Form Load event
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
