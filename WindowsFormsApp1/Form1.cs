using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((comboBox1.Text == "admin") && (textBox1.Text == "1234"))
			{
				Form2 frm2 = new Form2();
				frm2.Show();
			}

			else 
			{
				MessageBox.Show("пароль не верен,попробуйте еще раз");
			}

			if ((comboBox1.Text == "user") && (textBox1.Text == "14789"))
			{
				Form3 frm3 = new Form3();
				frm3.Show();
			}

			else
			{
				MessageBox.Show("пароль не верен,попробуйте еще раз");
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
  