namespace Biblio
{
    partial class SignUpForm
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
            Nom = new Label();
            Email = new Label();
            Password = new Label();
            ConfirmPasswd = new Label();
            textnom = new TextBox();
            textEmail = new TextBox();
            textPasswd = new TextBox();
            textConfirm = new TextBox();
            buttonSignup = new Button();
            SuspendLayout();
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(130, 25);
            Nom.Name = "Nom";
            Nom.Size = new Size(42, 20);
            Nom.TabIndex = 0;
            Nom.Text = "Nom";
            Nom.Click += label1_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(130, 79);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 1;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(130, 112);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // ConfirmPasswd
            // 
            ConfirmPasswd.AutoSize = true;
            ConfirmPasswd.Location = new Point(130, 149);
            ConfirmPasswd.Name = "ConfirmPasswd";
            ConfirmPasswd.Size = new Size(178, 20);
            ConfirmPasswd.TabIndex = 3;
            ConfirmPasswd.Text = "Confirmer votre Password";
            ConfirmPasswd.Click += ConfirmPasswd_Click;
            // 
            // textnom
            // 
            textnom.Location = new Point(213, 27);
            textnom.Name = "textnom";
            textnom.Size = new Size(125, 27);
            textnom.TabIndex = 4;
            textnom.TextChanged += textnom_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(215, 82);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 5;
            textEmail.TextChanged += textEmail_TextChanged;
            // 
            // textPasswd
            // 
            textPasswd.Location = new Point(217, 118);
            textPasswd.Name = "textPasswd";
            textPasswd.Size = new Size(125, 27);
            textPasswd.TabIndex = 6;
            textPasswd.TextChanged += textPasswd_TextChanged;
            // 
            // textConfirm
            // 
            textConfirm.Location = new Point(319, 153);
            textConfirm.Name = "textConfirm";
            textConfirm.Size = new Size(125, 27);
            textConfirm.TabIndex = 7;
            textConfirm.TextChanged += textConfirm_TextChanged;
            // 
            // buttonSignup
            // 
            buttonSignup.Location = new Point(247, 279);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(94, 29);
            buttonSignup.TabIndex = 8;
            buttonSignup.Text = "S'inscrire";
            buttonSignup.UseVisualStyleBackColor = true;
            buttonSignup.Click += button1_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignup);
            Controls.Add(textConfirm);
            Controls.Add(textPasswd);
            Controls.Add(textEmail);
            Controls.Add(textnom);
            Controls.Add(ConfirmPasswd);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Nom);
            Name = "SignUpForm";
            Text = "SignUp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nom;
        private Label Email;
        private Label Password;
        private Label ConfirmPasswd;
        private TextBox textnom;
        private TextBox textEmail;
        private TextBox textPasswd;
        private TextBox textConfirm;
        private Button buttonSignup;
    }
}
