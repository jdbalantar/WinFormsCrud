namespace WinFormsCrud
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewClient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(874, 450);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(273, 12);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "Eliminar";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(130, 12);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(75, 23);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "Editar";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(12, 12);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(75, 23);
            this.btnNewClient.TabIndex = 0;
            this.btnNewClient.Text = "Nuevo";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientDataGridView.MultiSelect = false;
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.ReadOnly = true;
            this.clientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDataGridView.Size = new System.Drawing.Size(874, 392);
            this.clientDataGridView.TabIndex = 0;
            this.clientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ClientForm";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
    }
}

