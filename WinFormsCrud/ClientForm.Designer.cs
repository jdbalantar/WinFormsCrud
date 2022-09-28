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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNewClient = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTitle = new System.Windows.Forms.Label();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnEditClient = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteClient = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.txtExit);
            this.splitContainer1.Panel1.Controls.Add(this.btnExit);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewClient);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(874, 450);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClient.Location = new System.Drawing.Point(38, 315);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.OverrideDefault.Back.ColorAngle = 45F;
            this.btnNewClient.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.OverrideDefault.Border.ColorAngle = 45F;
            this.btnNewClient.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewClient.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNewClient.OverrideDefault.Border.Rounding = 20;
            this.btnNewClient.OverrideDefault.Border.Width = 1;
            this.btnNewClient.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnNewClient.Size = new System.Drawing.Size(82, 44);
            this.btnNewClient.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewClient.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNewClient.StateCommon.Border.Rounding = 20;
            this.btnNewClient.StateCommon.Border.Width = 1;
            this.btnNewClient.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnNewClient.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnNewClient.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNewClient.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNewClient.StateCommon.Content.ShortText.ColorAngle = 135F;
            this.btnNewClient.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewClient.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.StatePressed.Back.ColorAngle = 135F;
            this.btnNewClient.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.StatePressed.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.StatePressed.Border.ColorAngle = 135F;
            this.btnNewClient.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewClient.StatePressed.Border.Rounding = 20;
            this.btnNewClient.StatePressed.Border.Width = 1;
            this.btnNewClient.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.StateTracking.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.StateTracking.Back.ColorAngle = 45F;
            this.btnNewClient.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNewClient.StateTracking.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnNewClient.StateTracking.Border.ColorAngle = 45F;
            this.btnNewClient.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewClient.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNewClient.StateTracking.Border.Rounding = 20;
            this.btnNewClient.StateTracking.Border.Width = 1;
            this.btnNewClient.TabIndex = 14;
            this.btnNewClient.Values.Text = "New";
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(33, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(281, 48);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "Client Managment";
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDataGridView.Size = new System.Drawing.Size(520, 450);
            this.clientDataGridView.TabIndex = 1;
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
            // btnEditClient
            // 
            this.btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClient.Location = new System.Drawing.Point(129, 315);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEditClient.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEditClient.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditClient.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEditClient.OverrideDefault.Border.Rounding = 20;
            this.btnEditClient.OverrideDefault.Border.Width = 1;
            this.btnEditClient.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEditClient.Size = new System.Drawing.Size(75, 44);
            this.btnEditClient.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditClient.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEditClient.StateCommon.Border.Rounding = 20;
            this.btnEditClient.StateCommon.Border.Width = 1;
            this.btnEditClient.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnEditClient.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnEditClient.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditClient.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEditClient.StateCommon.Content.ShortText.ColorAngle = 135F;
            this.btnEditClient.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditClient.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.StatePressed.Back.ColorAngle = 135F;
            this.btnEditClient.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.StatePressed.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.StatePressed.Border.ColorAngle = 135F;
            this.btnEditClient.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditClient.StatePressed.Border.Rounding = 20;
            this.btnEditClient.StatePressed.Border.Width = 1;
            this.btnEditClient.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.StateTracking.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.StateTracking.Back.ColorAngle = 45F;
            this.btnEditClient.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditClient.StateTracking.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditClient.StateTracking.Border.ColorAngle = 45F;
            this.btnEditClient.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditClient.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEditClient.StateTracking.Border.Rounding = 20;
            this.btnEditClient.StateTracking.Border.Width = 1;
            this.btnEditClient.TabIndex = 15;
            this.btnEditClient.Values.Text = "Edit";
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click_1);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.Location = new System.Drawing.Point(210, 315);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.OverrideDefault.Back.ColorAngle = 45F;
            this.btnDeleteClient.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.OverrideDefault.Border.ColorAngle = 45F;
            this.btnDeleteClient.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteClient.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteClient.OverrideDefault.Border.Rounding = 20;
            this.btnDeleteClient.OverrideDefault.Border.Width = 1;
            this.btnDeleteClient.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDeleteClient.Size = new System.Drawing.Size(104, 44);
            this.btnDeleteClient.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteClient.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteClient.StateCommon.Border.Rounding = 20;
            this.btnDeleteClient.StateCommon.Border.Width = 1;
            this.btnDeleteClient.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnDeleteClient.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnDeleteClient.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteClient.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeleteClient.StateCommon.Content.ShortText.ColorAngle = 135F;
            this.btnDeleteClient.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteClient.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.StatePressed.Back.ColorAngle = 135F;
            this.btnDeleteClient.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.StatePressed.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.StatePressed.Border.ColorAngle = 135F;
            this.btnDeleteClient.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteClient.StatePressed.Border.Rounding = 20;
            this.btnDeleteClient.StatePressed.Border.Width = 1;
            this.btnDeleteClient.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.StateTracking.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.StateTracking.Back.ColorAngle = 45F;
            this.btnDeleteClient.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeleteClient.StateTracking.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteClient.StateTracking.Border.ColorAngle = 45F;
            this.btnDeleteClient.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteClient.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteClient.StateTracking.Border.Rounding = 20;
            this.btnDeleteClient.StateTracking.Border.Width = 1;
            this.btnDeleteClient.TabIndex = 16;
            this.btnDeleteClient.Values.Text = "Delete";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::WinFormsCrud.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(269, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 50);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinFormsCrud.Properties.Resources._227_2271064_user_icon_hd_png_download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(38, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 223);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtExit
            // 
            this.txtExit.AutoSize = true;
            this.txtExit.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.Location = new System.Drawing.Point(26, 397);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(238, 33);
            this.txtExit.TabIndex = 18;
            this.txtExit.Text = "Do you want to log out?";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Palette = this.ClientPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette ClientPalette;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewClient;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditClient;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteClient;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label txtExit;
    }
}

