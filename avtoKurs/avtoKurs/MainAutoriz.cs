using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoKurs
{
	public partial class MainAutoriz : Form
	{
		public MainAutoriz()
		{
			InitializeComponent();
		}

		List<User> users = new List<User>();

		private void button1_Click(object sender, EventArgs e)
		{
			bool autoriz = false;
			for (int i = 0; i < users.Count; i++)
			{
				if (users[i].Login == textBoxLogin.Text && users[i].Pass == textBoxPass.Text)
				{
					autoriz = true;
					switch (users[i].Rights)
					{
						case "Админ":
							FormAdmin formAdmin = new FormAdmin();
							this.Hide();
							formAdmin.SetLableText(users[i].Login);
							formAdmin.ShowDialog();
							this.Show();
							break;
						case "Менеджер":
							FormMenedger formMenedger = new FormMenedger();
							this.Hide();
							formMenedger.SetLableText(users[i].Login);
							formMenedger.ShowDialog();
							this.Show();
							break;
					}
					MainAutoriz_Load(sender, e);
					break;
				}
			}
			if (!autoriz)
			{
				MessageBox.Show("Введён неправильный логин или пароль");
			}
		}

		private void MainAutoriz_Load(object sender, EventArgs e)
		{
			textBoxPass.UseSystemPasswordChar = true;

			try
			{
				users.Clear();
				SqlConnection conn = new SqlConnection(@Properties.Settings.Default.conStr);
				conn.Open();
				SqlCommand Comm = conn.CreateCommand();
				Comm.CommandText = "SELECT * from dbo.[user]";
				SqlDataReader reader = Comm.ExecuteReader();

				while (reader.Read())
				{
					users.Add(new User(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
				}
				conn.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка подключения. Не удалось установить соединение с базой данных. Программа будет закрыта, обратитесь к администратору для решения проблемы.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox1 = new AboutBox1();
			this.Hide();
			aboutBox1.ShowDialog();
			this.Show();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				textBoxPass.UseSystemPasswordChar = false;
			}
			else
			{
				textBoxPass.UseSystemPasswordChar = true;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, @"..\..\source\helpInfo\helpProject.chm");
		}
	}
}
