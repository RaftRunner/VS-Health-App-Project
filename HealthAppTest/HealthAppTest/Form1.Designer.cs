﻿namespace HealthAppTest
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
			this.btn_login = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.username = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_login_title = new System.Windows.Forms.Label();
			this.label_exit_app = new System.Windows.Forms.Label();
			this.btn_clear_login = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_login.Location = new System.Drawing.Point(260, 296);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(118, 45);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "Submit";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.button1_Click);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(262, 242);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(231, 20);
			this.password.TabIndex = 1;
			this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(262, 163);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(231, 20);
			this.username.TabIndex = 2;
			this.username.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(290, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(290, 226);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lbl_login_title
			// 
			this.lbl_login_title.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.lbl_login_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_login_title.ForeColor = System.Drawing.Color.White;
			this.lbl_login_title.Location = new System.Drawing.Point(14, 144);
			this.lbl_login_title.Name = "lbl_login_title";
			this.lbl_login_title.Size = new System.Drawing.Size(218, 48);
			this.lbl_login_title.TabIndex = 7;
			this.lbl_login_title.Text = "Please Login";
			this.lbl_login_title.Click += new System.EventHandler(this.label3_Click);
			// 
			// label_exit_app
			// 
			this.label_exit_app.AutoSize = true;
			this.label_exit_app.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_exit_app.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_exit_app.ForeColor = System.Drawing.Color.White;
			this.label_exit_app.Location = new System.Drawing.Point(63, 209);
			this.label_exit_app.Name = "label_exit_app";
			this.label_exit_app.Size = new System.Drawing.Size(111, 18);
			this.label_exit_app.TabIndex = 9;
			this.label_exit_app.Text = "Exit App Here";
			this.label_exit_app.Click += new System.EventHandler(this.label_exit_app_Click);
			// 
			// btn_clear_login
			// 
			this.btn_clear_login.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear_login.Location = new System.Drawing.Point(380, 296);
			this.btn_clear_login.Name = "btn_clear_login";
			this.btn_clear_login.Size = new System.Drawing.Size(118, 45);
			this.btn_clear_login.TabIndex = 10;
			this.btn_clear_login.Text = "Clear";
			this.btn_clear_login.UseVisualStyleBackColor = true;
			this.btn_clear_login.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(237, 360);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "No account? Click here to make one";
			this.label3.Click += new System.EventHandler(this.label3_Click_1);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.pictureBox3.Image = global::HealthAppTest.Properties.Resources.health_hands;
			this.pictureBox3.Location = new System.Drawing.Point(48, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(148, 129);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::HealthAppTest.Properties.Resources._lock;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(262, 221);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 20);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::HealthAppTest.Properties.Resources.login1;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(262, 142);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 20);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumPurple;
			this.BackgroundImage = global::HealthAppTest.Properties.Resources.login_background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(751, 582);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_clear_login);
			this.Controls.Add(this.label_exit_app);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lbl_login_title);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.username);
			this.Controls.Add(this.password);
			this.Controls.Add(this.btn_login);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_login_title;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label_exit_app;
		private System.Windows.Forms.Button btn_clear_login;
		private System.Windows.Forms.Label label3;
	}
}

