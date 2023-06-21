
namespace PasswordSaver2._0.View.Children
{
    partial class Passwords
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

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passwords));
            this.DgvPasswords = new System.Windows.Forms.DataGridView();
            this.TxbSerch = new System.Windows.Forms.TextBox();
            this.PcbSerchIcon = new System.Windows.Forms.PictureBox();

            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();


            ((System.ComponentModel.ISupportInitialize)(this.DgvPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSerchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPasswords
            // 

            this.DgvPasswords.AllowUserToAddRows = false;
            this.DgvPasswords.AllowUserToDeleteRows = false;
            this.DgvPasswords.AllowUserToOrderColumns = true;
            this.DgvPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPasswords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPasswords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DgvPasswords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPasswords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPasswords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPasswords.Location = new System.Drawing.Point(37, 55);
            this.DgvPasswords.MaximumSize = new System.Drawing.Size(1015, 1015);
            this.DgvPasswords.Name = "DgvPasswords";
            this.DgvPasswords.ReadOnly = true;
            this.DgvPasswords.Size = new System.Drawing.Size(643, 318);
            this.DgvPasswords.TabIndex = 1;
            this.DgvPasswords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPasswords_CellContentClick);

            this.DgvPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPasswords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.DgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPasswords.Location = new System.Drawing.Point(12, 38);
            this.DgvPasswords.MaximumSize = new System.Drawing.Size(1015, 990);
            this.DgvPasswords.Name = "DgvPasswords";
            this.DgvPasswords.Size = new System.Drawing.Size(688, 368);
            this.DgvPasswords.TabIndex = 1;

            // 
            // TxbSerch
            // 
            this.TxbSerch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));

            this.TxbSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxbSerch.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSerch.ForeColor = System.Drawing.Color.DimGray;
            this.TxbSerch.Location = new System.Drawing.Point(37, 12);
            this.TxbSerch.MaximumSize = new System.Drawing.Size(990, 400);
            this.TxbSerch.Name = "TxbSerch";
            this.TxbSerch.Size = new System.Drawing.Size(643, 23);

            this.TxbSerch.Location = new System.Drawing.Point(30, 12);
            this.TxbSerch.MaximumSize = new System.Drawing.Size(990, 400);
            this.TxbSerch.Name = "TxbSerch";
            this.TxbSerch.Size = new System.Drawing.Size(670, 20);

            this.TxbSerch.TabIndex = 5;
            this.TxbSerch.Text = "Serch";
            // 
            // PcbSerchIcon
            // 

            this.PcbSerchIcon.BackColor = System.Drawing.Color.DimGray;

            this.PcbSerchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));

            this.PcbSerchIcon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PcbSerchIcon.Image = ((System.Drawing.Image)(resources.GetObject("PcbSerchIcon.Image")));
            this.PcbSerchIcon.Location = new System.Drawing.Point(12, 13);
            this.PcbSerchIcon.Name = "PcbSerchIcon";
            this.PcbSerchIcon.Size = new System.Drawing.Size(19, 19);
            this.PcbSerchIcon.TabIndex = 6;
            this.PcbSerchIcon.TabStop = false;
            this.PcbSerchIcon.Tag = "Buscar";
            this.PcbSerchIcon.UseWaitCursor = true;
            // 

            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.BackColor = System.Drawing.Color.DimGray;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShow.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(706, 127);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(122, 32);
            this.btnShow.TabIndex = 7;
            this.btnShow.Tag = "Show/Hide Passwords";
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(706, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModify.BackColor = System.Drawing.Color.DimGray;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnModify.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Black;
            this.btnModify.Location = new System.Drawing.Point(706, 272);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(122, 32);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(706, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;



            // 
            // Passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(840, 418);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);

            this.ClientSize = new System.Drawing.Size(840, 418);


            this.Controls.Add(this.PcbSerchIcon);
            this.Controls.Add(this.TxbSerch);
            this.Controls.Add(this.DgvPasswords);
            this.Cursor = System.Windows.Forms.Cursors.Default;

            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passwords";
            this.Opacity = 0.9D;
            this.Text = " ";

            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.Name = "Passwords";
            this.Text = "Passwords";

            ((System.ComponentModel.ISupportInitialize)(this.DgvPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSerchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvPasswords;
        public System.Windows.Forms.TextBox TxbSerch;
        public System.Windows.Forms.PictureBox PcbSerchIcon;

        public System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.Button btnAdd;



    }
}