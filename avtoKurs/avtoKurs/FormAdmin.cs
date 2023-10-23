using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoKurs
{
	public partial class FormAdmin : Form
	{
		public FormAdmin()
		{
			InitializeComponent();
		}

		public void SetLableText(string login)
		{
			labelNameUser.Text = login;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			FormUser formUser = new FormUser();
			this.Hide();
			formUser.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FormWork formWork = new FormWork();
			this.Hide();
			formWork.ShowDialog();
			this.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FormMaster formMaster = new FormMaster();
			this.Hide();
			formMaster.ShowDialog();
			this.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormOrd formOrd = new FormOrd();
			this.Hide();
			formOrd.ShowDialog();
			this.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox1 = new AboutBox1();
			this.Hide();
			aboutBox1.ShowDialog();
			this.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, @"..\..\source\helpInfo\helpProject.chm");
		}
	}
}
