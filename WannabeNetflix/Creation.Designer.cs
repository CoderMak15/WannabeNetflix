namespace WannabeNetflix
{
    partial class Creation
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
            this.error_lbl = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.lName_txt = new System.Windows.Forms.TextBox();
            this.fName_txt = new System.Windows.Forms.TextBox();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.pw_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.lname_lbl = new System.Windows.Forms.Label();
            this.fname_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(92, 63);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 15);
            this.error_lbl.TabIndex = 25;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(319, 315);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 24;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(92, 315);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 23;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // pw_txt
            // 
            this.pw_txt.Location = new System.Drawing.Point(190, 249);
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.PasswordChar = '*';
            this.pw_txt.Size = new System.Drawing.Size(204, 23);
            this.pw_txt.TabIndex = 22;
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(190, 214);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(204, 23);
            this.mail_txt.TabIndex = 21;
            // 
            // gender_txt
            // 
            this.gender_txt.Location = new System.Drawing.Point(190, 178);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(204, 23);
            this.gender_txt.TabIndex = 20;
            // 
            // lName_txt
            // 
            this.lName_txt.Location = new System.Drawing.Point(190, 141);
            this.lName_txt.Name = "lName_txt";
            this.lName_txt.Size = new System.Drawing.Size(204, 23);
            this.lName_txt.TabIndex = 19;
            // 
            // fName_txt
            // 
            this.fName_txt.Location = new System.Drawing.Point(190, 104);
            this.fName_txt.Name = "fName_txt";
            this.fName_txt.Size = new System.Drawing.Size(204, 23);
            this.fName_txt.TabIndex = 18;
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Location = new System.Drawing.Point(92, 217);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(41, 15);
            this.mail_lbl.TabIndex = 17;
            this.mail_lbl.Text = "E-Mail";
            // 
            // pw_lbl
            // 
            this.pw_lbl.AutoSize = true;
            this.pw_lbl.Location = new System.Drawing.Point(92, 252);
            this.pw_lbl.Name = "pw_lbl";
            this.pw_lbl.Size = new System.Drawing.Size(57, 15);
            this.pw_lbl.TabIndex = 16;
            this.pw_lbl.Text = "Password";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(92, 181);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(45, 15);
            this.gender_lbl.TabIndex = 15;
            this.gender_lbl.Text = "Gender";
            // 
            // lname_lbl
            // 
            this.lname_lbl.AutoSize = true;
            this.lname_lbl.Location = new System.Drawing.Point(92, 144);
            this.lname_lbl.Name = "lname_lbl";
            this.lname_lbl.Size = new System.Drawing.Size(63, 15);
            this.lname_lbl.TabIndex = 14;
            this.lname_lbl.Text = "Last Name";
            // 
            // fname_lbl
            // 
            this.fname_lbl.AutoSize = true;
            this.fname_lbl.Location = new System.Drawing.Point(92, 107);
            this.fname_lbl.Name = "fname_lbl";
            this.fname_lbl.Size = new System.Drawing.Size(64, 15);
            this.fname_lbl.TabIndex = 13;
            this.fname_lbl.Text = "First Name";
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.pw_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.lName_txt);
            this.Controls.Add(this.fName_txt);
            this.Controls.Add(this.mail_lbl);
            this.Controls.Add(this.pw_lbl);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.lname_lbl);
            this.Controls.Add(this.fname_lbl);
            this.Name = "Creation";
            this.Text = "Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Label error_lbl;
        protected Button exit_btn;
        protected Button create_btn;
        protected TextBox pw_txt;
        protected TextBox mail_txt;
        protected TextBox gender_txt;
        protected TextBox lName_txt;
        protected TextBox fName_txt;
        protected Label mail_lbl;
        protected Label pw_lbl;
        protected Label gender_lbl;
        protected Label lname_lbl;
        protected Label fname_lbl;
    }
}