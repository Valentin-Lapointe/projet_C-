using System.ComponentModel;

namespace CheckersClient
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxPasswordCheck = new System.Windows.Forms.TextBox();
            this.labelPasswordCheck = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(162, 248);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "S\'inscrire";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(162, 188);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(100, 23);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Vérifier";
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Location = new System.Drawing.Point(42, 50);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(56, 17);
            this.labelPseudo.TabIndex = 2;
            this.labelPseudo.Text = "Pseudo";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(162, 47);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPseudo.TabIndex = 3;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(162, 75);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 22);
            this.textBoxMail.TabIndex = 5;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(42, 78);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(33, 17);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Mail";
            // 
            // textBoxPasswordCheck
            // 
            this.textBoxPasswordCheck.Location = new System.Drawing.Point(162, 160);
            this.textBoxPasswordCheck.Name = "textBoxPasswordCheck";
            this.textBoxPasswordCheck.Size = new System.Drawing.Size(100, 22);
            this.textBoxPasswordCheck.TabIndex = 9;
            // 
            // labelPasswordCheck
            // 
            this.labelPasswordCheck.AutoSize = true;
            this.labelPasswordCheck.Location = new System.Drawing.Point(42, 163);
            this.labelPasswordCheck.Name = "labelPasswordCheck";
            this.labelPasswordCheck.Size = new System.Drawing.Size(87, 17);
            this.labelPasswordCheck.TabIndex = 8;
            this.labelPasswordCheck.Text = "Confirmation";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(162, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(42, 135);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(322, 325);
            this.Controls.Add(this.textBoxPasswordCheck);
            this.Controls.Add(this.labelPasswordCheck);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.labelPseudo);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonSend);
            this.Name = "RegisterForm";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxPasswordCheck;
        private System.Windows.Forms.Label labelPasswordCheck;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}