using System;
using System.Data.Entity;
using System.Windows.Forms;
using WinFormsCrud.Models;


namespace WinFormsCrud.Presentation
{
    public partial class FrmTable : Form
    {
        public int? Id;
        private Client oClient = null;

        public FrmTable(int? id = null)
        {
            InitializeComponent();
            Id = id;

            if (id != null)
                LoadData();
        }

        private void LoadData()
        {
            using (CrudWinFormsEntities db = new CrudWinFormsEntities())
            {
                oClient = db.Client.Find(Id);
                if (oClient != null)
                {
                    txtBoxName.Text = oClient.Name;
                    txtBoxLastName.Text = oClient.LastName;
                    txtBoxAddress.Text = oClient.Address;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CrudWinFormsEntities db = new CrudWinFormsEntities())
            {
                if (Id == null)
                    oClient = new Client();

                oClient.Name = txtBoxName.Text;
                oClient.LastName = txtBoxLastName.Text;
                oClient.Address = txtBoxAddress.Text;

                if (Id == null)
                    db.Client.Add(oClient);
                else
                    db.Entry(oClient).State = EntityState.Modified;

                db.SaveChanges();
                this.Close();
            }
        }
    }
}