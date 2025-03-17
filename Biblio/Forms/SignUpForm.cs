using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BCrypt.Net;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Biblio.Biblio.Data;
using Biblio.Biblio.Models;
using global::Biblio.Data;

namespace Biblio
{
    namespace Biblio
    {
        public partial class SignUpForm : Form
        {
            public SignUpForm()
            {
                InitializeComponent();
            }

            private void buttonSignUp_Click(object sender, EventArgs e)
            {
                string nom = textnom.Text.Trim();
                string email = textEmail.Text.Trim();
                string password = textPasswd.Text;
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                string confirmPassword = textConfirm.Text;

                if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(email, emailPattern))
                {
                    MessageBox.Show("Email invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                using (var context = new AppDbContext())
                {
                    if (context.Users.Any(u => u.Email == email))
                    {
                        MessageBox.Show("Cet email est déjà utilisé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Models.User newUser = new Models.User { Nom = nom, Email = email, PasswordHash = hashedPassword };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                MessageBox.Show("Inscription réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            private void label1_Click(object sender, EventArgs e)
            {
                // Laisse vide ou ajoute un MessageBox si nécessaire
            }
            private void Email_Click(object sender, EventArgs e)
            {
                // Code ici si nécessaire, sinon laisse vide.
            }


        }
    }

}
