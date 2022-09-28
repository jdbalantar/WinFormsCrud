using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.Entity;
using System.Drawing;
using WinFormsCrud.Models;


namespace WinFormsCrud.Presentation
{
    public partial class FrmTable : KryptonForm
    {
        public int? Id;
        private Client _oClient = null;

        public FrmTable(int? id = null)
        {
            InitializeComponent();
            Id = id;

            if (id != null)
                LoadData();
        }

        private void LoadData()
        {
            using (var db = new CrudWinFormsEntities())
            {
                _oClient = db.Client.Find(Id);
                if (_oClient != null)
                {
                    txtBoxName.Text = _oClient.Name;
                    txtBoxLastName.Text = _oClient.LastName;
                    txtBoxAddress.Text = _oClient.Address;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmTable_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            using (var db = new CrudWinFormsEntities())
            {
                if (Id == null)
                    _oClient = new Client();

                var name = txtBoxName.Text;
                var lastName = txtBoxLastName.Text;
                var address = txtBoxAddress.Text;
                if (name == "" || lastName == "" || address == "")
                {
                    txtMessageValidation.ForeColor = Color.Red;
                    txtMessageValidation.Text = @"There cannot be any empty field";
                }
                else
                {
                    _oClient.Name = name;
                    _oClient.LastName = lastName;
                    _oClient.Address = address;

                    if (Id == null)
                        db.Client.Add(_oClient);
                    else
                        db.Entry(_oClient).State = EntityState.Modified;

                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}