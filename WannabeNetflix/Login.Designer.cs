namespace WannabeNetflix
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_field = new System.Windows.Forms.TextBox();
            this.pw_field = new System.Windows.Forms.TextBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.user_lbl = new System.Windows.Forms.Label();
            this.pw_lbl = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_field
            // 
            this.user_field.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_field.Location = new System.Drawing.Point(265, 128);
            this.user_field.Name = "user_field";
            this.user_field.Size = new System.Drawing.Size(173, 23);
            this.user_field.TabIndex = 0;
            // 
            // pw_field
            // 
            this.pw_field.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pw_field.Location = new System.Drawing.Point(265, 214);
            this.pw_field.Name = "pw_field";
            this.pw_field.PasswordChar = '*';
            this.pw_field.Size = new System.Drawing.Size(173, 23);
            this.pw_field.TabIndex = 1;
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(300, 282);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(106, 38);
            this.log_btn.TabIndex = 2;
            this.log_btn.Text = "Login";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(174, 131);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(60, 15);
            this.user_lbl.TabIndex = 3;
            this.user_lbl.Text = "Username";
            // 
            // pw_lbl
            // 
            this.pw_lbl.AutoSize = true;
            this.pw_lbl.Location = new System.Drawing.Point(177, 217);
            this.pw_lbl.Name = "pw_lbl";
            this.pw_lbl.Size = new System.Drawing.Size(57, 15);
            this.pw_lbl.TabIndex = 4;
            this.pw_lbl.Text = "Password";
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(300, 85);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 15);
            this.error_lbl.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.pw_lbl);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.pw_field);
            this.Controls.Add(this.user_field);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox user_field;
        private TextBox pw_field;
        private Button log_btn;
        private Label user_lbl;
        private Label pw_lbl;
        private Label error_lbl;
    }
}