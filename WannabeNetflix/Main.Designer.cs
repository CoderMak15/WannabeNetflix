namespace WannabeNetflix
{
    partial class Main
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
            this.clientDataGrid = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesDataGrid = new System.Windows.Forms.DataGridView();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.dc_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataGrid
            // 
            this.clientDataGrid.AllowUserToAddRows = false;
            this.clientDataGrid.AllowUserToDeleteRows = false;
            this.clientDataGrid.AllowUserToResizeColumns = false;
            this.clientDataGrid.AllowUserToResizeRows = false;
            this.clientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.LastName,
            this.Email});
            this.clientDataGrid.Location = new System.Drawing.Point(172, 12);
            this.clientDataGrid.Name = "clientDataGrid";
            this.clientDataGrid.ReadOnly = true;
            this.clientDataGrid.RowTemplate.Height = 25;
            this.clientDataGrid.Size = new System.Drawing.Size(500, 200);
            this.clientDataGrid.TabIndex = 0;
            this.clientDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGrid_CellContentClick);
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // moviesDataGrid
            // 
            this.moviesDataGrid.AllowUserToAddRows = false;
            this.moviesDataGrid.AllowUserToDeleteRows = false;
            this.moviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movie,
            this.Length,
            this.Categories});
            this.moviesDataGrid.Location = new System.Drawing.Point(172, 249);
            this.moviesDataGrid.Name = "moviesDataGrid";
            this.moviesDataGrid.ReadOnly = true;
            this.moviesDataGrid.RowTemplate.Height = 25;
            this.moviesDataGrid.Size = new System.Drawing.Size(500, 200);
            this.moviesDataGrid.TabIndex = 1;
            // 
            // Movie
            // 
            this.Movie.HeaderText = "Movie";
            this.Movie.Name = "Movie";
            this.Movie.ReadOnly = true;
            this.Movie.Width = 125;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 75;
            // 
            // Categories
            // 
            this.Categories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categories.HeaderText = "Categories";
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(47, 51);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 2;
            this.create_btn.Text = "Create ";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.Location = new System.Drawing.Point(47, 102);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(75, 23);
            this.modify_btn.TabIndex = 3;
            this.modify_btn.Text = "Modify";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // dc_btn
            // 
            this.dc_btn.Location = new System.Drawing.Point(47, 382);
            this.dc_btn.Name = "dc_btn";
            this.dc_btn.Size = new System.Drawing.Size(75, 23);
            this.dc_btn.TabIndex = 4;
            this.dc_btn.Text = "Log off";
            this.dc_btn.UseVisualStyleBackColor = true;
            this.dc_btn.Click += new System.EventHandler(this.dc_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(47, 153);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.dc_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.moviesDataGrid);
            this.Controls.Add(this.clientDataGrid);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView clientDataGrid;
        private DataGridView moviesDataGrid;
        private Button create_btn;
        private Button modify_btn;
        private Button delete_btn;
        private Button dc_btn;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Movie;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn Categories;
    }
}