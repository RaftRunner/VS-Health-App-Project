﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthAppTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (username.Text=="usernametest" && password.Text=="passwordtest")
			{	
				//Opens up the next part of the application
				new App().Show();
				this.Hide();
			}
			else
			{
				//Message that pops up if the condition is triggered
				MessageBox.Show("The username or password is incorrect");
				//Clears the username and password then puts the cursor back into the username to retype
				username.Clear();
				password.Clear();
				username.Focus();
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void password_TextChanged(object sender, EventArgs e)
		{

		}

		private void label_exit_app_Click(object sender, EventArgs e)
		{
			//Shuts down the application
			Application.Exit();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//Clears the username and password then puts the cursor back into the username to retype
			username.Clear();
			password.Clear();
			username.Focus();
		}

		private void label3_Click_1(object sender, EventArgs e)
		{
			new Registration().Show();
			this.Hide();
		}
	}
}
