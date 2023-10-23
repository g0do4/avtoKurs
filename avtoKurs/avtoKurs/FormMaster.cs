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
	public partial class FormMaster : Form
	{
		public FormMaster()
		{
			InitializeComponent();
		}

		private void FormMaster_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.master". При необходимости она может быть перемещена или удалена.
			this.masterTableAdapter.Fill(this.dataSetAvtoKurs.master);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.work". При необходимости она может быть перемещена или удалена.
			this.workTableAdapter.Fill(this.dataSetAvtoKurs.work);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.FullMaster". При необходимости она может быть перемещена или удалена.
			this.fullMasterTableAdapter.Fill(this.dataSetAvtoKurs.FullMaster);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.master". При необходимости она может быть перемещена или удалена.
			
		}

		bool isSave = true;

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxName.Text == "" || textBoxAge.Text == "")
			{
				MessageBox.Show("Не все поля заполнены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DataSetAvtoKurs.workRow work = (DataSetAvtoKurs.workRow)dataSetAvtoKurs.work.Rows[comboBox1.SelectedIndex];

			dataSetAvtoKurs.master.AddmasterRow(work, textBoxName.Text, Convert.ToInt32(textBoxAge.Text));
			dataSetAvtoKurs.FullMaster.AddFullMasterRow(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), comboBox1.SelectedItem.ToString());
			
			isSave = false;
		}

		bool isDel = false;

		private void buttonDel_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("При удалении данной записи удалятся соответствующие записи из таблиц 'Мастера', 'Позиции' и 'Услуги'. Продилжить?", "Удаление", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			dataGridView2.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
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

			masterBindingSource.EndEdit();
			masterTableAdapter.Update(this.dataSetAvtoKurs);
			this.masterTableAdapter.Fill(this.dataSetAvtoKurs.master);
			//this.fullMasterTableAdapter.Fill(this.dataSetAvtoKurs.FullMaster);
			isSave = true;
			isDel = false;
		}

		private void buttonAgeUpdate_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells[2].Value = textBoxAge.Text;
			dataGridView2.Rows[this.dataGridView2.SelectedRows[0].Index].Cells[2].Value = textBoxAge.Text;
			isSave = false;
		}

		private void buttonFind_Click(object sender, EventArgs e)
		{
			int foundIndex =fullMasterBindingSource.Find("nameMaster", textBoxName.Text);
			fullMasterBindingSource.Position = foundIndex;
		}

		private void FormMaster_FormClosing(object sender, FormClosingEventArgs e)
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
