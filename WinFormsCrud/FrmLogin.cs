using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsCrud.Models;
using WinFormsCrud.Util;

namespace WinFormsCrud
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sPassWord = Encrypt.GetSha256(txtBoxPassword.Text.Trim());
            using (CrudWinFormsEntities db = new CrudWinFormsEntities())
            {
                var user = from u in db.User
                    where u.UserName == txtBoxUser.Text && u.Password == sPassWord
                    select u;

                if (user.Any())
                {
                    this.Hide();
                    ClientForm clientForm = new ClientForm();
                    clientForm.FormClosed += (s, args) => this.Close();
                    clientForm.Show();
                }
                else
                    MessageBox.Show("Usuario inexistente");
            }
        }
    }
}