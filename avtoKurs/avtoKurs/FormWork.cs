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
	public partial class FormWork : Form
	{
		public FormWork()
		{
			InitializeComponent();
		}

		private void FormWork_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.work". При необходимости она может быть перемещена или удалена.
			this.workTableAdapter.Fill(this.dataSetAvtoKurs.work);

		}

		bool isSave = true;

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxName.Text == "" || textBoxPrice.Text == "")
			{
				MessageBox.Show("Не все поля заполнены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dataSetAvtoKurs.work.AddworkRow(Convert.ToInt32(textBoxPrice.Text), textBoxName.Text);
			isSave = false;
		}

		bool isDel = false;
		private void buttonDel_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("При удалении данной записи удалятся соответствующие записи из таблиц 'Мастера', 'Позиции' и 'Услуги'. Продилжить?","Удаление" , MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
			isSave = false;
			isDel = true;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (isDel)
			{
				DialogResult dialogResult = MessageBox.Show("Подтвердите каскадное удаление из таблицы", "Удаление", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No)
				{
					MessageBox.Show("Для отмены действия удаления перезайдите на текущую форму форму");
					return;
				}
			}
			workBindingSource.EndEdit();
			workTableAdapter.Update(this.dataSetAvtoKurs);
			this.workTableAdapter.Fill(this.dataSetAvtoKurs.work);
			isSave = true;
			isDel = false;
		}

		private void buttonPriceUpdate_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells[2].Value = textBoxPrice.Text;
			isSave = false;
		}

		private void FormWork_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isSave)
			{
				DialogResult dialogResult = MessageBox.Show("Таблица не сохранена. Сохранить её?", "Сохранить", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
				{
					this.buttonSave_Click(sender, e);
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
