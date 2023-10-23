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
	public partial class FormMenedger : Form
	{
		public FormMenedger()
		{
			InitializeComponent();
		}

		public void SetLableText(string login)
		{
			labelNameUser.Text = login;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormShowOrder formShowOrder = new FormShowOrder();
			this.Hide();
			formShowOrder.ShowDialog();
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

		private void button6_Click(object sender, EventArgs e)
		{
			FormAddOrder formAddOrder = new FormAddOrder();
			this.Hide();
			formAddOrder.ShowDialog();
			this.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox1 = new AboutBox1();
			this.Hide();
			aboutBox1.ShowDialog();
			this.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, @"..\..\source\helpInfo\helpProject.chm");
		}
	}
}
