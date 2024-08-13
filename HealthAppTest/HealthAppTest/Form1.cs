using System;
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
				new Form2().Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("The username or password is incorrect");
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
			Application.Exit();
		}
	}
}
