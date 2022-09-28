using ComponentFactory.Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using WinFormsCrud.Models;
using WinFormsCrud.Util;

namespace WinFormsCrud
{
    public partial class FrmRegister : KryptonForm
    {
        public FrmRegister()
        {
            InitializeComponent();
            txtMessageValidation.Text = "";
        }



        private void FrmRegister_Load(object sender, EventArgs e)
        {
        }

        private void GoToLogin()
        {
            this.Hide();
            var form = new FrmLogin();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void txtSignIn_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var userName = txtBoxName.Text;
            var password = Encrypt.GetSha256(txtBoxPassword.Text.Trim());
            using (var db = new CrudWinFormsEntities())
            {
                if (userName == "" || password == "")
                {
                    txtMessageValidation.ForeColor = Color.Red;
                    txtMessageValidation.Text = @"There cannot be any empty field!";
                }
                else
                {
                    var user = from u in db.User
                        where u.UserName == userName && u.Password == password
                        select u;

                    if (user.Any())
                    {
                        txtMessageValidation.ForeColor = Color.Red;
                        txtMessageValidation.Text = @"The user already exists!";
                    }

                    else
                    {
                        var newUser = new User() { UserName = userName, Password = password };

                        db.User.Add(newUser);
                        db.SaveChanges();
                        GoToLogin();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ziursoftware.com/");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/jdbalantar/");
        }
    }
}