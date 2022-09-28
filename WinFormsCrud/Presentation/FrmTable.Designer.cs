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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.ClientPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txtBoxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMessageValidation = new System.Windows.Forms.Label();
            this.btnSaveClient = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(155, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(77, 33);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(135, 138);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 33);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Last Name:";
            this.txtLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(135, 232);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(97, 33);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "Address:";
            // 
            // ClientPalette
            // 
            this.ClientPalette.ButtonSpecs.FormClose.Image = global::WinFormsCrud.Properties.Resources.mc_red;
            this.ClientPalette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::WinFormsCrud.Properties.Resources.sign_error_icon;
            this.ClientPalette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::WinFormsCrud.Properties.Resources.sign_error_icon;
            this.ClientPalette.ButtonSpecs.FormMax.Image = global::WinFormsCrud.Properties.Resources.mc_yellw;
            this.ClientPalette.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::WinFormsCrud.Properties.Resources.mc_yellw;
            this.ClientPalette.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::WinFormsCrud.Properties.Resources.mc_yellw;
            this.ClientPalette.ButtonSpecs.FormMin.Image = global::WinFormsCrud.Properties.Resources.mc_green;
            this.ClientPalette.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::WinFormsCrud.Properties.Resources.mc_green;
            this.ClientPalette.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::WinFormsCrud.Properties.Resources.mc_green;
            this.ClientPalette.ButtonSpecs.FormRestore.Image = global::WinFormsCrud.Properties.Resources.mc_yellw;
            this.ClientPalette.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::WinFormsCrud.Properties.Resources.mc_yellw;
            this.ClientPalette.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::WinFormsCrud.Properties.Resources.mc_yellw;
            this.ClientPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.ClientPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.ClientPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClientPalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.ClientPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.ClientPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.ClientPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClientPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.ClientPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.ClientPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.ClientPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClientPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.ClientPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ClientPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.ClientPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClientPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.ClientPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.ClientPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ClientPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.ClientPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.ClientPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(58, 83);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(270, 36);
            this.txtBoxName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBoxName.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxName.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBoxName.StateCommon.Border.Rounding = 20;
            this.txtBoxName.StateCommon.Border.Width = 1;
            this.txtBoxName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBoxName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtBoxName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBoxName.TabIndex = 10;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(58, 175);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(270, 36);
            this.txtBoxLastName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBoxLastName.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxLastName.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxLastName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxLastName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBoxLastName.StateCommon.Border.Rounding = 20;
            this.txtBoxLastName.StateCommon.Border.Width = 1;
            this.txtBoxLastName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBoxLastName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtBoxLastName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBoxLastName.TabIndex = 11;
            this.txtBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(58, 269);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(270, 36);
            this.txtBoxAddress.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBoxAddress.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxAddress.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxAddress.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBoxAddress.StateCommon.Border.Rounding = 20;
            this.txtBoxAddress.StateCommon.Border.Width = 1;
            this.txtBoxAddress.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBoxAddress.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtBoxAddress.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBoxAddress.TabIndex = 12;
            this.txtBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMessageValidation
            // 
            this.txtMessageValidation.AutoSize = true;
            this.txtMessageValidation.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageValidation.Location = new System.Drawing.Point(30, 395);
            this.txtMessageValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMessageValidation.Name = "txtMessageValidation";
            this.txtMessageValidation.Size = new System.Drawing.Size(0, 33);
            this.txtMessageValidation.TabIndex = 13;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveClient.Location = new System.Drawing.Point(58, 343);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSaveClient.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSaveClient.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveClient.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveClient.OverrideDefault.Border.Rounding = 20;
            this.btnSaveClient.OverrideDefault.Border.Width = 1;
            this.btnSaveClient.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSaveClient.Size = new System.Drawing.Size(270, 44);
            this.btnSaveClient.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveClient.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveClient.StateCommon.Border.Rounding = 20;
            this.btnSaveClient.StateCommon.Border.Width = 1;
            this.btnSaveClient.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSaveClient.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSaveClient.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveClient.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveClient.StateCommon.Content.ShortText.ColorAngle = 135F;
            this.btnSaveClient.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveClient.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.StatePressed.Back.ColorAngle = 135F;
            this.btnSaveClient.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.StatePressed.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.StatePressed.Border.ColorAngle = 135F;
            this.btnSaveClient.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveClient.StatePressed.Border.Rounding = 20;
            this.btnSaveClient.StatePressed.Border.Width = 1;
            this.btnSaveClient.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.StateTracking.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.StateTracking.Back.ColorAngle = 45F;
            this.btnSaveClient.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSaveClient.StateTracking.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveClient.StateTracking.Border.ColorAngle = 45F;
            this.btnSaveClient.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveClient.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveClient.StateTracking.Border.Rounding = 20;
            this.btnSaveClient.StateTracking.Border.Width = 1;
            this.btnSaveClient.TabIndex = 14;
            this.btnSaveClient.Values.Text = "Save changes!";
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 476);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.txtMessageValidation);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTable";
            this.Palette = this.ClientPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer data";
            this.Load += new System.EventHandler(this.FrmTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.Label txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette ClientPalette;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxAddress;
        private System.Windows.Forms.Label txtMessageValidation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveClient;
    }
}