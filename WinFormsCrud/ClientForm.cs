using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsCrud.Models;
using WinFormsCrud.Presentation;

namespace WinFormsCrud
{
    public partial class ClientForm : Form
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
                return int.Parse(clientDataGridView.Rows[clientDataGridView.CurrentRow.Index].Cells[0].Value
                    .ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation.FrmTable oFrmTable = new Presentation.FrmTable();
            oFrmTable.ShowDialog();
            Refresh();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Presentation.FrmTable oFrmTable = new FrmTable(id);
                oFrmTable.ShowDialog();
                Refresh();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (CrudWinFormsEntities db = new CrudWinFormsEntities())
                {
                    Client client = db.Client.Find(id);
                    if (client != null) db.Client.Remove(client);
                    db.SaveChanges();
                }
                Refresh();
            }
        }
    }
}