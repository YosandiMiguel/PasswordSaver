
namespace PasswordSaver2._0.View
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.DgvPasswords = new System.Windows.Forms.DataGridView();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LblIcon4 = new System.Windows.Forms.Label();
            this.LblIcon3 = new System.Windows.Forms.Label();
            this.LblIcon2 = new System.Windows.Forms.Label();
            this.LblIcon1 = new System.Windows.Forms.Label();
            this.PcbLogOut = new System.Windows.Forms.PictureBox();
            this.PcbSetting = new System.Windows.Forms.PictureBox();
            this.PcbSchedule = new System.Windows.Forms.PictureBox();
            this.PcbPasswords = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PcbExit = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PcbMinimized = new System.Windows.Forms.PictureBox();
            this.PcbMaximized = new System.Windows.Forms.PictureBox();
            this.LblMail = new System.Windows.Forms.Label();
            this.PcbPhoto = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxbSerch = new System.Windows.Forms.TextBox();
            this.PcbSerchIcon = new System.Windows.Forms.PictureBox();
            this.PcbMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPasswords)).BeginInit();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPasswords)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSerchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPasswords
            // 
            this.DgvPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPasswords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.DgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPasswords.Location = new System.Drawing.Point(231, 149);
            this.DgvPasswords.MaximumSize = new System.Drawing.Size(1015, 990);
            this.DgvPasswords.Name = "DgvPasswords";
            this.DgvPasswords.Size = new System.Drawing.Size(519, 272);
            this.DgvPasswords.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.LeftPanel.Controls.Add(this.PcbMenu);
            this.LeftPanel.Controls.Add(this.LblIcon4);
            this.LeftPanel.Controls.Add(this.LblIcon3);
            this.LeftPanel.Controls.Add(this.LblIcon2);
            this.LeftPanel.Controls.Add(this.LblIcon1);
            this.LeftPanel.Controls.Add(this.PcbLogOut);
            this.LeftPanel.Controls.Add(this.PcbSetting);
            this.LeftPanel.Controls.Add(this.PcbSchedule);
            this.LeftPanel.Controls.Add(this.PcbPasswords);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 54);
            this.LeftPanel.MaximumSize = new System.Drawing.Size(213, 940);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(213, 396);
            this.LeftPanel.TabIndex = 2;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // LblIcon4
            // 
            this.LblIcon4.AutoSize = true;
            this.LblIcon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcon4.Location = new System.Drawing.Point(74, 330);
            this.LblIcon4.Name = "LblIcon4";
            this.LblIcon4.Size = new System.Drawing.Size(27, 13);
            this.LblIcon4.TabIndex = 8;
            this.LblIcon4.Text = "Salir";
            this.LblIcon4.Click += new System.EventHandler(this.TxtIcon4_Click);
            // 
            // LblIcon3
            // 
            this.LblIcon3.AutoSize = true;
            this.LblIcon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcon3.Location = new System.Drawing.Point(74, 245);
            this.LblIcon3.Name = "LblIcon3";
            this.LblIcon3.Size = new System.Drawing.Size(83, 13);
            this.LblIcon3.TabIndex = 7;
            this.LblIcon3.Text = "Configuraciones";
            this.LblIcon3.Click += new System.EventHandler(this.TxtIcon3_Click);
            // 
            // LblIcon2
            // 
            this.LblIcon2.AutoSize = true;
            this.LblIcon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcon2.Location = new System.Drawing.Point(74, 160);
            this.LblIcon2.Name = "LblIcon2";
            this.LblIcon2.Size = new System.Drawing.Size(41, 13);
            this.LblIcon2.TabIndex = 6;
            this.LblIcon2.Text = "Horario";
            this.LblIcon2.Click += new System.EventHandler(this.TxtIcon2_Click);
            // 
            // LblIcon1
            // 
            this.LblIcon1.AutoSize = true;
            this.LblIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcon1.Location = new System.Drawing.Point(74, 75);
            this.LblIcon1.Name = "LblIcon1";
            this.LblIcon1.Size = new System.Drawing.Size(66, 13);
            this.LblIcon1.TabIndex = 5;
            this.LblIcon1.Text = "Contraseñas";
            this.LblIcon1.Click += new System.EventHandler(this.TxtIcon1_Click);
            // 
            // PcbLogOut
            // 
            this.PcbLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.PcbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbLogOut.Image = ((System.Drawing.Image)(resources.GetObject("PcbLogOut.Image")));
            this.PcbLogOut.Location = new System.Drawing.Point(6, 310);
            this.PcbLogOut.Name = "PcbLogOut";
            this.PcbLogOut.Size = new System.Drawing.Size(53, 53);
            this.PcbLogOut.TabIndex = 4;
            this.PcbLogOut.TabStop = false;
            this.PcbLogOut.Click += new System.EventHandler(this.PcbIcon4_Click);
            // 
            // PcbSetting
            // 
            this.PcbSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.PcbSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbSetting.Image = ((System.Drawing.Image)(resources.GetObject("PcbSetting.Image")));
            this.PcbSetting.Location = new System.Drawing.Point(6, 225);
            this.PcbSetting.Name = "PcbSetting";
            this.PcbSetting.Size = new System.Drawing.Size(53, 53);
            this.PcbSetting.TabIndex = 3;
            this.PcbSetting.TabStop = false;
            this.PcbSetting.Click += new System.EventHandler(this.PcbIcon3_Click);
            // 
            // PcbSchedule
            // 
            this.PcbSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.PcbSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbSchedule.Image = ((System.Drawing.Image)(resources.GetObject("PcbSchedule.Image")));
            this.PcbSchedule.Location = new System.Drawing.Point(6, 140);
            this.PcbSchedule.Name = "PcbSchedule";
            this.PcbSchedule.Size = new System.Drawing.Size(53, 53);
            this.PcbSchedule.TabIndex = 2;
            this.PcbSchedule.TabStop = false;
            this.PcbSchedule.Click += new System.EventHandler(this.PcbIcon2_Click);
            // 
            // PcbPasswords
            // 
            this.PcbPasswords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.PcbPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbPasswords.Image = ((System.Drawing.Image)(resources.GetObject("PcbPasswords.Image")));
            this.PcbPasswords.Location = new System.Drawing.Point(6, 55);
            this.PcbPasswords.Name = "PcbPasswords";
            this.PcbPasswords.Size = new System.Drawing.Size(53, 53);
            this.PcbPasswords.TabIndex = 1;
            this.PcbPasswords.TabStop = false;
            this.PcbPasswords.Click += new System.EventHandler(this.PcbIcon1_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(165)))), ((int)(((byte)(200)))));
            this.TopPanel.Controls.Add(this.PcbExit);
            this.TopPanel.Controls.Add(this.LblTitle);
            this.TopPanel.Controls.Add(this.PcbMinimized);
            this.TopPanel.Controls.Add(this.PcbMaximized);
            this.TopPanel.Controls.Add(this.LblMail);
            this.TopPanel.Controls.Add(this.PcbPhoto);
            this.TopPanel.Controls.Add(this.LblName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(777, 54);
            this.TopPanel.TabIndex = 3;
            // 
            // PcbExit
            // 
            this.PcbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbExit.BackColor = System.Drawing.Color.White;
            this.PcbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbExit.Image = ((System.Drawing.Image)(resources.GetObject("PcbExit.Image")));
            this.PcbExit.Location = new System.Drawing.Point(742, 9);
            this.PcbExit.Name = "PcbExit";
            this.PcbExit.Size = new System.Drawing.Size(29, 29);
            this.PcbExit.TabIndex = 6;
            this.PcbExit.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(165)))), ((int)(((byte)(200)))));
            this.LblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(326, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(265, 20);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Ventana donde me encuentro ";
            this.LblTitle.Click += new System.EventHandler(this.TxtTitle_Click);
            // 
            // PcbMinimized
            // 
            this.PcbMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbMinimized.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PcbMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbMinimized.Image = ((System.Drawing.Image)(resources.GetObject("PcbMinimized.Image")));
            this.PcbMinimized.Location = new System.Drawing.Point(662, 9);
            this.PcbMinimized.Name = "PcbMinimized";
            this.PcbMinimized.Size = new System.Drawing.Size(29, 29);
            this.PcbMinimized.TabIndex = 4;
            this.PcbMinimized.TabStop = false;
            this.PcbMinimized.Click += new System.EventHandler(this.PcbMinimized_Click);
            // 
            // PcbMaximized
            // 
            this.PcbMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbMaximized.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PcbMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbMaximized.Image = ((System.Drawing.Image)(resources.GetObject("PcbMaximized.Image")));
            this.PcbMaximized.Location = new System.Drawing.Point(702, 9);
            this.PcbMaximized.Name = "PcbMaximized";
            this.PcbMaximized.Size = new System.Drawing.Size(29, 29);
            this.PcbMaximized.TabIndex = 2;
            this.PcbMaximized.TabStop = false;
            this.PcbMaximized.Click += new System.EventHandler(this.PcbMaximized_Click);
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(165)))), ((int)(((byte)(200)))));
            this.LblMail.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMail.Location = new System.Drawing.Point(65, 32);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(44, 14);
            this.LblMail.TabIndex = 1;
            this.LblMail.Text = "Correo";
            // 
            // PcbPhoto
            // 
            this.PcbPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PcbPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PcbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("PcbPhoto.Image")));
            this.PcbPhoto.Location = new System.Drawing.Point(0, 0);
            this.PcbPhoto.Name = "PcbPhoto";
            this.PcbPhoto.Size = new System.Drawing.Size(54, 54);
            this.PcbPhoto.TabIndex = 1;
            this.PcbPhoto.TabStop = false;
            this.PcbPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(165)))), ((int)(((byte)(200)))));
            this.LblName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblName.Location = new System.Drawing.Point(65, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 14);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            this.LblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxbSerch
            // 
            this.TxbSerch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSerch.Location = new System.Drawing.Point(256, 127);
            this.TxbSerch.MaximumSize = new System.Drawing.Size(990, 400);
            this.TxbSerch.Name = "TxbSerch";
            this.TxbSerch.Size = new System.Drawing.Size(494, 20);
            this.TxbSerch.TabIndex = 4;
            this.TxbSerch.Text = "Serch";
            // 
            // PcbSerchIcon
            // 
            this.PcbSerchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.PcbSerchIcon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PcbSerchIcon.Image = ((System.Drawing.Image)(resources.GetObject("PcbSerchIcon.Image")));
            this.PcbSerchIcon.Location = new System.Drawing.Point(231, 127);
            this.PcbSerchIcon.Name = "PcbSerchIcon";
            this.PcbSerchIcon.Size = new System.Drawing.Size(19, 19);
            this.PcbSerchIcon.TabIndex = 5;
            this.PcbSerchIcon.TabStop = false;
            this.PcbSerchIcon.Tag = "Buscar";
            this.PcbSerchIcon.UseWaitCursor = true;
            this.PcbSerchIcon.Click += new System.EventHandler(this.PcbSerchIcon_Click);
            // 
            // PcbMenu
            // 
            this.PcbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.PcbMenu.Image = ((System.Drawing.Image)(resources.GetObject("PcbMenu.Image")));
            this.PcbMenu.Location = new System.Drawing.Point(171, 6);
            this.PcbMenu.Name = "PcbMenu";
            this.PcbMenu.Size = new System.Drawing.Size(39, 39);
            this.PcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbMenu.TabIndex = 6;
            this.PcbMenu.TabStop = false;
            this.PcbMenu.Click += new System.EventHandler(this.PcbMenu_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.PcbSerchIcon);
            this.Controls.Add(this.TxbSerch);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.DgvPasswords);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPasswords)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPasswords)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSerchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvPasswords;
        public System.Windows.Forms.Label LblName;
        public System.Windows.Forms.PictureBox PcbPhoto;
        public System.Windows.Forms.Label LblMail;
        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.PictureBox PcbMinimized;
        public System.Windows.Forms.PictureBox PcbMaximized;
        public System.Windows.Forms.Label LblIcon4;
        public System.Windows.Forms.Label LblIcon3;
        public System.Windows.Forms.Label LblIcon2;
        public System.Windows.Forms.Label LblIcon1;
        public System.Windows.Forms.PictureBox PcbLogOut;
        public System.Windows.Forms.PictureBox PcbSetting;
        public System.Windows.Forms.PictureBox PcbSchedule;
        public System.Windows.Forms.PictureBox PcbPasswords;
        public System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.TextBox TxbSerch;
        public System.Windows.Forms.PictureBox PcbSerchIcon;
        public System.Windows.Forms.PictureBox PcbExit;
        public System.Windows.Forms.PictureBox PcbMenu;
    }
}