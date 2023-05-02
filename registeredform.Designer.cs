namespace User_Authentication_System
{
    partial class registeredform
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
            this.btnsgnup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtrepassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsgnup
            // 
            this.btnsgnup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsgnup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsgnup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsgnup.Location = new System.Drawing.Point(55, 257);
            this.btnsgnup.Name = "btnsgnup";
            this.btnsgnup.Size = new System.Drawing.Size(92, 41);
            this.btnsgnup.TabIndex = 2;
            this.btnsgnup.Text = "Sign Up";
            this.btnsgnup.UseVisualStyleBackColor = false;
            this.btnsgnup.Click += new System.EventHandler(this.btnsgnup_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::User_Authentication_System.Properties.Resources.images;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(271, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 28);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.ForeColor = System.Drawing.Color.Silver;
            this.txtusername.Location = new System.Drawing.Point(12, 68);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(184, 22);
            this.txtusername.TabIndex = 4;
            this.txtusername.Text = "Username";
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // txtrepassword
            // 
            this.txtrepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtrepassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrepassword.ForeColor = System.Drawing.Color.Silver;
            this.txtrepassword.Location = new System.Drawing.Point(12, 143);
            this.txtrepassword.Name = "txtrepassword";
            this.txtrepassword.Size = new System.Drawing.Size(184, 22);
            this.txtrepassword.TabIndex = 5;
            this.txtrepassword.Text = "rePassword";
            this.txtrepassword.Enter += new System.EventHandler(this.txtrepassword_Enter);
            this.txtrepassword.Leave += new System.EventHandler(this.txtrepassword_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.ForeColor = System.Drawing.Color.Silver;
            this.txtemail.Location = new System.Drawing.Point(12, 180);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(184, 22);
            this.txtemail.TabIndex = 6;
            this.txtemail.Text = "email";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.ForeColor = System.Drawing.Color.Silver;
            this.txtpassword.Location = new System.Drawing.Point(12, 106);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(184, 22);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.ForeColor = System.Drawing.Color.Silver;
            this.txtphone.Location = new System.Drawing.Point(12, 218);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(184, 22);
            this.txtphone.TabIndex = 8;
            this.txtphone.Text = "phone";
            this.txtphone.Enter += new System.EventHandler(this.txtphone_Enter);
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // registeredform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Authentication_System.Properties.Resources.LOGIN_PANEL1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 346);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtrepassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsgnup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registeredform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registeredform";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registeredform_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registeredform_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.registeredform_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsgnup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtrepassword;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtphone;
    }
}