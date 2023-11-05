namespace WannabeNetflix
{
    partial class Modify
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
            this.fname_lbl = new System.Windows.Forms.Label();
            this.lname_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.pw_lbl = new System.Windows.Forms.Label();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.fName_txt = new System.Windows.Forms.TextBox();
            this.lName_txt = new System.Windows.Forms.TextBox();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fname_lbl
            // 
            this.fname_lbl.AutoSize = true;
            this.fname_lbl.Location = new System.Drawing.Point(111, 101);
            this.fname_lbl.Name = "fname_lbl";
            this.fname_lbl.Size = new System.Drawing.Size(64, 15);
            this.fname_lbl.TabIndex = 0;
            this.fname_lbl.Text = "First Name";
            // 
            // lname_lbl
            // 
            this.lname_lbl.AutoSize = true;
            this.lname_lbl.Location = new System.Drawing.Point(111, 138);
            this.lname_lbl.Name = "lname_lbl";
            this.lname_lbl.Size = new System.Drawing.Size(63, 15);
            this.lname_lbl.TabIndex = 1;
            this.lname_lbl.Text = "Last Name";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(111, 175);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(45, 15);
            this.gender_lbl.TabIndex = 2;
            this.gender_lbl.Text = "Gender";
            // 
            // pw_lbl
            // 
            this.pw_lbl.AutoSize = true;
            this.pw_lbl.Location = new System.Drawing.Point(111, 246);
            this.pw_lbl.Name = "pw_lbl";
            this.pw_lbl.Size = new System.Drawing.Size(57, 15);
            this.pw_lbl.TabIndex = 3;
            this.pw_lbl.Text = "Password";
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Location = new System.Drawing.Point(111, 211);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(41, 15);
            this.mail_lbl.TabIndex = 4;
            this.mail_lbl.Text = "E-Mail";
            // 
            // fName_txt
            // 
            this.fName_txt.Location = new System.Drawing.Point(209, 98);
            this.fName_txt.Name = "fName_txt";
            this.fName_txt.Size = new System.Drawing.Size(204, 23);
            this.fName_txt.TabIndex = 5;
            // 
            // lName_txt
            // 
            this.lName_txt.Location = new System.Drawing.Point(209, 135);
            this.lName_txt.Name = "lName_txt";
            this.lName_txt.Size = new System.Drawing.Size(204, 23);
            this.lName_txt.TabIndex = 6;
            // 
            // gender_txt
            // 
            this.gender_txt.Location = new System.Drawing.Point(209, 172);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(204, 23);
            this.gender_txt.TabIndex = 7;
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(209, 208);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(204, 23);
            this.mail_txt.TabIndex = 8;
            // 
            // pw_txt
            // 
            this.pw_txt.Location = new System.Drawing.Point(209, 243);
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.PasswordChar = '*';
            this.pw_txt.Size = new System.Drawing.Size(204, 23);
            this.pw_txt.TabIndex = 9;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(137, 317);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(306, 317);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(111, 57);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 15);
            this.error_lbl.TabIndex = 12;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 399);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
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
            this.Name = "Modify";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fname_lbl;
        private Label lname_lbl;
        private Label gender_lbl;
        private Label pw_lbl;
        private Label mail_lbl;
        private TextBox fName_txt;
        private TextBox lName_txt;
        private TextBox gender_txt;
        private TextBox mail_txt;
        private TextBox pw_txt;
        private Button save_btn;
        private Button cancel_btn;
        private Label error_lbl;
    }
}