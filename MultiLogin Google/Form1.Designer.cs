namespace MultiLogin_Google
{
    partial class Form1
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
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRelogin = new System.Windows.Forms.Button();
            this.listBoxVideos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(129, 23);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(213, 26);
            this.textEmail.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(129, 71);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(213, 26);
            this.textPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(129, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Login";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRelogin
            // 
            this.btnRelogin.Location = new System.Drawing.Point(238, 130);
            this.btnRelogin.Name = "btnRelogin";
            this.btnRelogin.Size = new System.Drawing.Size(104, 35);
            this.btnRelogin.TabIndex = 5;
            this.btnRelogin.Text = "Relogin";
            this.btnRelogin.UseVisualStyleBackColor = true;
            this.btnRelogin.Click += new System.EventHandler(this.btnRelogin_Click);
            // 
            // listBoxVideos
            // 
            this.listBoxVideos.ItemHeight = 20;
            this.listBoxVideos.Location = new System.Drawing.Point(52, 212);
            this.listBoxVideos.Name = "listBoxVideos";
            this.listBoxVideos.Size = new System.Drawing.Size(693, 184);
            this.listBoxVideos.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(483, 23);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(213, 26);
            this.textSearch.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.listBoxVideos);
            this.Controls.Add(this.btnRelogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRelogin;
        private System.Windows.Forms.ListBox listBoxVideos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button1;
    }
}

