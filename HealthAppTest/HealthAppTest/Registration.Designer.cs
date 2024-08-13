namespace HealthAppTest
{
	partial class Registration
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
			this.register_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// register_title
			// 
			this.register_title.BackColor = System.Drawing.Color.Transparent;
			this.register_title.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_title.ForeColor = System.Drawing.Color.White;
			this.register_title.Location = new System.Drawing.Point(12, 18);
			this.register_title.Name = "register_title";
			this.register_title.Size = new System.Drawing.Size(364, 61);
			this.register_title.TabIndex = 0;
			this.register_title.Text = "Register An Account";
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateBlue;
			this.BackgroundImage = global::HealthAppTest.Properties.Resources.register_background1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1002, 582);
			this.Controls.Add(this.register_title);
			this.DoubleBuffered = true;
			this.Name = "Registration";
			this.Text = "Registration";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label register_title;
	}
}