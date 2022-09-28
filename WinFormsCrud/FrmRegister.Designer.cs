namespace WinFormsCrud
{
    partial class FrmRegister
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
            this.txtTittleSignUp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnRegister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessageValidation = new System.Windows.Forms.Label();
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
            // txtTittleSignUp
            // 
            this.txtTittleSignUp.AutoSize = true;
            this.txtTittleSignUp.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittleSignUp.Location = new System.Drawing.Point(117, 29);
            this.txtTittleSignUp.Name = "txtTittleSignUp";
            this.txtTittleSignUp.Size = new System.Drawing.Size(183, 70);
            this.txtTittleSignUp.TabIndex = 0;
            this.txtTittleSignUp.Text = "Sign up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsCrud.Properties.Resources.logo_transparente;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(241, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(89, 176);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(231, 36);
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
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(89, 356);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.OverrideDefault.Back.ColorAngle = 45F;
            this.btnRegister.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.OverrideDefault.Border.ColorAngle = 45F;
            this.btnRegister.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRegister.OverrideDefault.Border.Rounding = 20;
            this.btnRegister.OverrideDefault.Border.Width = 1;
            this.btnRegister.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnRegister.Size = new System.Drawing.Size(231, 44);
            this.btnRegister.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRegister.StateCommon.Border.Rounding = 20;
            this.btnRegister.StateCommon.Border.Width = 1;
            this.btnRegister.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnRegister.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnRegister.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegister.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRegister.StateCommon.Content.ShortText.ColorAngle = 135F;
            this.btnRegister.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.StatePressed.Back.ColorAngle = 135F;
            this.btnRegister.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.StatePressed.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.StatePressed.Border.ColorAngle = 135F;
            this.btnRegister.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StatePressed.Border.Rounding = 20;
            this.btnRegister.StatePressed.Border.Width = 1;
            this.btnRegister.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.StateTracking.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.StateTracking.Back.ColorAngle = 45F;
            this.btnRegister.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRegister.StateTracking.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.StateTracking.Border.ColorAngle = 45F;
            this.btnRegister.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRegister.StateTracking.Border.Rounding = 20;
            this.btnRegister.StateTracking.Border.Width = 1;
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Values.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txtSignIn
            // 
            this.txtSignIn.AutoSize = true;
            this.txtSignIn.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtSignIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSignIn.Location = new System.Drawing.Point(92, 415);
            this.txtSignIn.Name = "txtSignIn";
            this.txtSignIn.Size = new System.Drawing.Size(228, 26);
            this.txtSignIn.TabIndex = 7;
            this.txtSignIn.Text = "Already have a user? Sign in!";
            this.txtSignIn.Click += new System.EventHandler(this.txtSignIn_Click);
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
            this.label5.TabIndex = 8;
            this.label5.Text = "By: David Balanta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMessageValidation
            // 
            this.txtMessageValidation.AutoSize = true;
            this.txtMessageValidation.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtMessageValidation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMessageValidation.Location = new System.Drawing.Point(92, 453);
            this.txtMessageValidation.Name = "txtMessageValidation";
            this.txtMessageValidation.Size = new System.Drawing.Size(0, 26);
            this.txtMessageValidation.TabIndex = 9;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 632);
            this.Controls.Add(this.txtMessageValidation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSignIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTittleSignUp);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.Palette = this.ClientPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette ClientPalette;
        private System.Windows.Forms.Label txtTittleSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtMessageValidation;
    }
}