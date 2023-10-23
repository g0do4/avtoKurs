using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoKurs
{
	public partial class FormOrd : Form
	{
		public FormOrd()
		{
			InitializeComponent();
		}

		private void FormOrd_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.AllPosition". При необходимости она может быть перемещена или удалена.
			this.allPositionTableAdapter.Fill(this.dataSetAvtoKurs.AllPosition);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.AllOrder". При необходимости она может быть перемещена или удалена.
			this.allOrderTableAdapter.Fill(this.dataSetAvtoKurs.AllOrder);

		}

		private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
		{
			allPositionBindingSource.Filter = "idOrder = " + ((DataRowView)allOrderBindingSource.Current).Row["idOrder"];
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Поддтвердить удаление записей?","Удаление", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			SqlConnection conn = new SqlConnection(@Properties.Settings.Default.conStr);
			conn.Open();
			SqlCommand Comm = conn.CreateCommand();
			Comm.CommandText = "delete from [order] where dateBegin < @date";
			Comm.Parameters.AddWithValue("@date", dateTimePicker1.Value);
			Comm.ExecuteNonQuery();
			FormOrd_Load(sender, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Поддтвердить удаление записей? При этом удаляться все заказы.", "Удаление", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			SqlConnection conn = new SqlConnection(@Properties.Settings.Default.conStr);
			conn.Open();
			SqlCommand Comm = conn.CreateCommand();
			Comm.CommandText = "delete from [client]";
			Comm.ExecuteNonQuery();
			FormOrd_Load(sender, e);

		}
	}
}
