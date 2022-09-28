namespace WinFormsCrud.Presentation
{
    partial class FrmTable
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(129, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(49, 13);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nombres";
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(129, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(49, 13);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Apellidos";
            this.txtLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(129, 135);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(45, 13);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "Address";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(249, 49);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(278, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(249, 87);
            this.txtBoxLastName.MaxLength = 50;
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(278, 20);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(249, 128);
            this.txtBoxAddress.MaxLength = 50;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(278, 20);
            this.txtBoxAddress.TabIndex = 5;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Location = new System.Drawing.Point(249, 179);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClient.TabIndex = 6;
            this.btnSaveClient.Text = "Guardar";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 326);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Datos del cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Button btnSaveClient;
    }
}