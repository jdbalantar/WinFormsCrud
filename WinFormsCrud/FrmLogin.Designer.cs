namespace WinFormsCrud
{
    partial class FrmLogin
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
            this.ClientPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtBoxUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSignUp = new System.Windows.Forms.Label();
            this.btnLoginn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessageValidation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign in";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(137, 131);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 42);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(137, 235);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 42);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(89, 176);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(231, 36);
            this.txtBoxUser.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBoxUser.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxUser.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxUser.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBoxUser.StateCommon.Border.Rounding = 20;
            this.txtBoxUser.StateCommon.Border.Width = 1;
            this.txtBoxUser.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBoxUser.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtBoxUser.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBoxUser.TabIndex = 9;
            this.txtBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(89, 280);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.Size = new System.Drawing.Size(231, 36);
            this.txtBoxPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBoxPassword.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxPassword.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBoxPassword.StateCommon.Border.Rounding = 20;
            this.txtBoxPassword.StateCommon.Border.Width = 1;
            this.txtBoxPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtBoxPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBoxPassword.TabIndex = 10;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtSignUp
            // 
            this.txtSignUp.AutoSize = true;
            this.txtSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSignUp.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSignUp.Location = new System.Drawing.Point(92, 415);
            this.txtSignUp.Name = "txtSignUp";
            this.txtSignUp.Size = new System.Drawing.Size(215, 26);
            this.txtSignUp.TabIndex = 12;
            this.txtSignUp.Text = "Don\'t have a user? Sign up!";
            this.txtSignUp.Click += new System.EventHandler(this.txtSignUp_Click);
            // 
            // btnLoginn
            // 
            this.btnLoginn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginn.Location = new System.Drawing.Point(89, 356);
            this.btnLoginn.Name = "btnLoginn";
            this.btnLoginn.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.OverrideDefault.Back.ColorAngle = 45F;
            this.btnLoginn.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.OverrideDefault.Border.ColorAngle = 45F;
            this.btnLoginn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoginn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLoginn.OverrideDefault.Border.Rounding = 20;
            this.btnLoginn.OverrideDefault.Border.Width = 1;
            this.btnLoginn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLoginn.Size = new System.Drawing.Size(231, 44);
            this.btnLoginn.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoginn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLoginn.StateCommon.Border.Rounding = 20;
            this.btnLoginn.StateCommon.Border.Width = 1;
            this.btnLoginn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnLoginn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnLoginn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLoginn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLoginn.StateCommon.Content.ShortText.ColorAngle = 135F;
            this.btnLoginn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoginn.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.StatePressed.Back.ColorAngle = 135F;
            this.btnLoginn.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.StatePressed.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.StatePressed.Border.ColorAngle = 135F;
            this.btnLoginn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoginn.StatePressed.Border.Rounding = 20;
            this.btnLoginn.StatePressed.Border.Width = 1;
            this.btnLoginn.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.StateTracking.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.StateTracking.Back.ColorAngle = 45F;
            this.btnLoginn.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginn.StateTracking.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginn.StateTracking.Border.ColorAngle = 45F;
            this.btnLoginn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoginn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLoginn.StateTracking.Border.Rounding = 20;
            this.btnLoginn.StateTracking.Border.Width = 1;
            this.btnLoginn.TabIndex = 13;
            this.btnLoginn.Values.Text = "Login!";
            this.btnLoginn.Click += new System.EventHandler(this.btnLoginn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(12, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "By: David Balanta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMessageValidation
            // 
            this.txtMessageValidation.AutoSize = true;
            this.txtMessageValidation.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageValidation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMessageValidation.Location = new System.Drawing.Point(92, 462);
            this.txtMessageValidation.Name = "txtMessageValidation";
            this.txtMessageValidation.Size = new System.Drawing.Size(0, 26);
            this.txtMessageValidation.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsCrud.Properties.Resources.logo_transparente;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(241, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 36);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 632);
            this.Controls.Add(this.txtMessageValidation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoginn);
            this.Controls.Add(this.txtSignUp);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Palette = this.ClientPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette ClientPalette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxPassword;
        private System.Windows.Forms.Label txtSignUp;
        private System.Windows.Forms.Button btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoginn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtMessageValidation;
    }
}