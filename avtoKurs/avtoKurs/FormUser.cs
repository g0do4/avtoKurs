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
	public partial class FormUser : Form
	{
		public FormUser()
		{
			InitializeComponent();
		}

		private void FormUser_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.user". При необходимости она может быть перемещена или удалена.
			this.userTableAdapter.Fill(this.dataSetAvtoKurs.user);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex < 0)
			{
				MessageBox.Show("Не все поля заполнены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			userBindingSource.Filter = "login = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'";
			if (userBindingSource.Count != 0)
			{
				userBindingSource.Filter = "";
				MessageBox.Show("Такой пользователь уже существует", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			userBindingSource.Filter = "";

			dataSetAvtoKurs.user.AdduserRow(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString());
			isSave = false;
		}

		bool isSave = true;

		private void button1_Click(object sender, EventArgs e)
		{
			userBindingSource.EndEdit();
			userTableAdapter.Update(this.dataSetAvtoKurs);
			this.userTableAdapter.Fill(this.dataSetAvtoKurs.user);
			isSave = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
			isSave = false;

		}

		private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isSave)
			{
				DialogResult dialogResult = MessageBox.Show("Таблица не сохранена. Сохранить её?", "Сохранить", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
				{
					this.button1_Click(sender, e);
				}
				if (dialogResult == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
			}
		}
	}
}
