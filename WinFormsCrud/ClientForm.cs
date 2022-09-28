#nullable enable
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsCrud.Models;
using WinFormsCrud.Presentation;

namespace WinFormsCrud
{
    public partial class ClientForm : KryptonForm

    {
        public ClientForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER

        private void Refresh()
        {
            using (CrudWinFormsEntities db = new CrudWinFormsEntities())
            {
                var list = from d in db.Client
                    select d;
                clientDataGridView.DataSource = list.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                if (clientDataGridView.Rows is { Count: > 0 })
                {
                    return int.Parse(clientDataGridView.Rows[clientDataGridView.CurrentRow.Index].Cells[0].Value
                        .ToString());
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            var oFrmTable = new FrmTable();
            oFrmTable.ShowDialog();
            Refresh();
        }

        private void btnEditClient_Click_1(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                var oFrmTable = new FrmTable(id);
                oFrmTable.ShowDialog();
                Refresh();
            }
        }

        private void btnDeleteClient_Click_1(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (var db = new CrudWinFormsEntities())
                {
                    var client = db.Client.Find(id);
                    if (client != null) db.Client.Remove(client);
                    db.SaveChanges();
                }

                Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmLogin();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}