using ComponentFactory.Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using WinFormsCrud.Models;
using WinFormsCrud.Util;

namespace WinFormsCrud
{
    public partial class FrmLogin : KryptonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtMessageValidation.Text = "";
        }

        private void btnLoginn_Click(object sender, EventArgs e)
        {
            var userName = txtBoxUser.Text;
            var sPassWord = Encrypt.GetSha256(txtBoxPassword.Text.Trim());
            using (var db = new CrudWinFormsEntities())
            {
                if (userName == "" || sPassWord == "")
                {
                    txtMessageValidation.ForeColor = Color.Red;
                    txtMessageValidation.Text = @"There cannot be any empty field!";
                }
                else
                {
                    var userDb = from user in db.User
                        where user.UserName == userName && user.Password == sPassWord
                        select user;

                    if (userDb.Any())
                    {
                        this.Hide();
                        var clientForm = new ClientForm();
                        clientForm.FormClosed += (s, args) => this.Close();
                        clientForm.Show();
                    }
                    else
                    {
                        txtMessageValidation.ForeColor = Color.Red;
                        txtMessageValidation.Text = @"The user does not exist!";
                    }
                }
            }
        }

        private void txtSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmRegister();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
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