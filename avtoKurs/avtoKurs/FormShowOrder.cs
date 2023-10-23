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
	public partial class FormShowOrder : Form
	{
		public FormShowOrder()
		{
			InitializeComponent();
		}

		private void FormShowOrder_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.state". При необходимости она может быть перемещена или удалена.
			this.stateTableAdapter.Fill(this.dataSetAvtoKurs.state);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.AllPosition". При необходимости она может быть перемещена или удалена.
			this.allPositionTableAdapter.Fill(this.dataSetAvtoKurs.AllPosition);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.AllOrder". При необходимости она может быть перемещена или удалена.
			this.allOrderTableAdapter.Fill(this.dataSetAvtoKurs.AllOrder);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.position". При необходимости она может быть перемещена или удалена.
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataRowView dataRowView = (DataRowView)allOrderBindingSource.Current;
			allPositionBindingSource.Filter = "idOrder = " + Convert.ToInt32(dataRowView.Row["idOrder"]);
			textBoxName.Text = dataRowView.Row["nameClient"].ToString();
			textBoxPhone.Text = dataRowView.Row["phone"].ToString();
			textBoxSum.Text = dataRowView.Row["sumOfOrd"].ToString();
			textBoxMark.Text = dataRowView.Row["mark"].ToString();
			textBoxNumber.Text = dataRowView.Row["number"].ToString();
			textBoxDate.Text = Convert.ToDateTime(dataRowView.Row["dateBegin"]).ToString("dd:MM:yyyy");
			textBoxDateState.Text = Convert.ToDateTime(dataRowView.Row["dateState"]).ToString("dd:MM:yyyy");
			comboBox1.SelectedValue = dataRowView.Row["idState"];
			try
			{
				pictureBox1.Image = Image.FromFile(@dataRowView.Row["photo"].ToString());
			}
			catch (Exception)
			{ }
			button1.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@Properties.Settings.Default.conStr);
			con.Open();
			SqlCommand cmd;
			string cmdStr;
			cmdStr = "UPDATE [Order] SET idState = @status, dateState = @dateState WHERE idOrder = " + listBox1.SelectedValue;
			cmd = new SqlCommand(cmdStr, con);
			cmd.Parameters.AddWithValue("@status", comboBox1.SelectedValue);
			cmd.Parameters.AddWithValue("@dateState", DateTime.Now);
			cmd.ExecuteNonQuery();
			int curIndex = listBox1.SelectedIndex;
			this.allOrderTableAdapter.Fill(this.dataSetAvtoKurs.AllOrder);
			listBox1.SelectedIndex = curIndex;
			listBox1_SelectedIndexChanged(sender, e);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
