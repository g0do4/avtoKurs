using System;
using Word = Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace avtoKurs
{
	public partial class FormAddOrder : Form
	{
		public FormAddOrder()
		{
			InitializeComponent();
		}

		private void FormAddOrder_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.AllPosition". При необходимости она может быть перемещена или удалена.
			this.allPositionTableAdapter.Fill(this.dataSetAvtoKurs.AllPosition);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.master". При необходимости она может быть перемещена или удалена.
			this.masterTableAdapter.Fill(this.dataSetAvtoKurs.master);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.work". При необходимости она может быть перемещена или удалена.
			this.workTableAdapter.Fill(this.dataSetAvtoKurs.work);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.car". При необходимости она может быть перемещена или удалена.
			this.carTableAdapter.Fill(this.dataSetAvtoKurs.car);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAvtoKurs.client". При необходимости она может быть перемещена или удалена.
			this.clientTableAdapter.Fill(this.dataSetAvtoKurs.client);

		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			switch (((RadioButton)sender).Name)
			{
				case "radioButtonClient1":
					panelClient.Visible = true;
					panelAddClient.Visible = false;
					radioButtonCar1.Enabled = true;
					break;
				case "radioButtonClient2":
					panelClient.Visible = false;
					panelAddClient.Visible = true;
					radioButtonCar2.Checked = true;
					radioButtonCar1.Enabled = false;
					break;
			}
		}


		private void radioButtonCar1_CheckedChanged(object sender, EventArgs e)
		{
			switch (((RadioButton)sender).Name)
			{
				case "radioButtonCar1":
					panelCar.Visible = true;
					panelAddCar.Visible = false;
					break;
				case "radioButtonCar2":
					panelCar.Visible = false;
					panelAddCar.Visible = true;
					break;
			}
		}

		private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
		{
			carBindingSource.Filter = "idClient = " + comboBoxClient.SelectedValue.ToString();
		}

		private void listBoxWork_SelectedIndexChanged(object sender, EventArgs e)
		{
			masterBindingSource.Filter = "idWork = " + listBoxWork.SelectedValue.ToString();

			textBoxPrice.Text = ((DataRowView)workBindingSource.Current).Row["price"].ToString();
		}


		private void buttonAddOrd_Click(object sender, EventArgs e)
		{
			if (radioButtonClient2.Checked && (textBoxClientName.Text == "" || textBoxPhone.Text.Length != 18))
			{
				MessageBox.Show("Не заполнены поля для добавления нового клиента", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (radioButtonCar2.Checked && (textBoxMark.Text == "" || textBoxNumber.Text.Length != 10))
			{
				MessageBox.Show("Не заполнены поля для добавления нового автомобиля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (radioButtonCar1.Checked && (comboBoxMark.Items.Count == 0 || comboBoxMark.SelectedIndex == -1))
			{
				MessageBox.Show("Не выбрана машина или у данного клиента нет машины", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!listBoxMaster.Enabled || listBoxMaster.Items.Count < 1)
			{
				MessageBox.Show("Не выбрана услуга или данную услегу не осуществляет ни один мастер", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (buttonAddPos.Enabled)
			{
				DialogResult dialogResult = MessageBox.Show("При создании нового заказа вы не будите иметь возможности редактировать текущий. Продолжить?", "Создать заказ", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.No)
				{
					return;
				}
				else if (dialogResult == DialogResult.Yes)
				{
					dialogResult = MessageBox.Show("Создать договор для текущего заказа?", "Договор", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						buttonDox_Click(sender, e);
					}
				}
			}

			SqlConnection con = new SqlConnection(@Properties.Settings.Default.conStr);
			con.Open();
			SqlCommand cmd;
			string cmdStr;
			if (radioButtonClient2.Checked)
			{
				try
				{
					cmdStr = "INSERT INTO client VALUES (@nameClient,@phone)";
					cmd = new SqlCommand(cmdStr, con);
					cmd.Parameters.AddWithValue("@nameClient", textBoxClientName.Text);
					cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
					cmd.ExecuteNonQuery();
				}
				catch (Exception)
				{
					MessageBox.Show("Ошибка подключения. Не удалось установить соединение с базой данных. Программа будет закрыта, обратитесь к администратору для решения проблемы.", "Ошибка Подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}
				this.clientTableAdapter.Fill(this.dataSetAvtoKurs.client);
				comboBoxClient.SelectedIndex = comboBoxClient.Items.Count - 1;
			}
			idClient = (int)comboBoxClient.SelectedValue;
			comboBoxClient.SelectedValue = idClient;


			if (radioButtonCar2.Checked)
			{
				try
				{
					cmdStr = "INSERT INTO car VALUES (@idClient,@mark,@number,@photo)";
					cmd = new SqlCommand(cmdStr, con);
					cmd.Parameters.AddWithValue("@idClient", idClient);
					cmd.Parameters.AddWithValue("@mark", textBoxMark.Text);
					cmd.Parameters.AddWithValue("@number", textBoxNumber.Text);
					cmd.Parameters.AddWithValue("@photo", textBoxPhoto.Text);
					cmd.ExecuteNonQuery();
				}
				catch (Exception)
				{
					MessageBox.Show("Ошибка подключения. Не удалось установить соединение с базой данных. Программа будет закрыта, обратитесь к администратору для решения проблемы.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}
				this.carTableAdapter.Fill(this.dataSetAvtoKurs.car);
				comboBoxMark.SelectedIndex = comboBoxMark.Items.Count - 1;

				if (!File.Exists(textBoxPhoto.Text) && textBoxPhoto.Text != "")
				{
					File.Copy(@pathImg, textBoxPhoto.Text);
				}
			}

			if (comboBoxMark.Items.Count > 0)
				idCar = (int)comboBoxMark.SelectedValue;

			try
			{
				cmdStr = "INSERT INTO [order] VALUES (@idState,@sumOdOrd,@dateBegin,@dateState,@idCar);" +
					"SELECT top 1 * FROM [order] ORDER BY idOrder DESC";
				cmd = new SqlCommand(cmdStr, con);
				cmd.Parameters.AddWithValue("@idState", 1);
				cmd.Parameters.AddWithValue("@sumOdOrd", 0);
				cmd.Parameters.AddWithValue("@dateBegin", DateTime.Now);
				cmd.Parameters.AddWithValue("@dateState", DateTime.Now);
				cmd.Parameters.AddWithValue("@idCar", idCar);
				idOrder = (int)cmd.ExecuteScalar();
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка подключения. Не удалось установить соединение с базой данных. Программа будет закрыта, обратитесь к администратору для решения проблемы.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}

			allPositionBindingSource.Filter = "idOrder = " + idOrder;
			con.Close();

			buttonAddPos_Click(sender, e);

			buttonAddPos.Enabled = true;
			buttonDox.Enabled = true;
			MessageBox.Show("Заказ успешно создан, его номер " + idOrder);
		}

		int idOrder = 0;
		int idCar = 0;
		int idClient = 0;

		private void buttonAddPos_Click(object sender, EventArgs e)
		{
			int curSum = 0;
			SqlConnection con = new SqlConnection(@Properties.Settings.Default.conStr);
			con.Open();
			SqlCommand cmd;
			string cmdStr;
			try
			{

				cmdStr = "INSERT INTO [position] VALUES (@idOrder,@idMaster)";
				cmd = new SqlCommand(cmdStr, con);
				cmd.Parameters.AddWithValue("@idOrder", idOrder);
				cmd.Parameters.AddWithValue("@idMaster", listBoxMaster.SelectedValue);
				cmd.ExecuteNonQuery();
				this.allPositionTableAdapter.Fill(this.dataSetAvtoKurs.AllPosition);

				cmdStr = "select sumOfOrd from [order] where idOrder = " + idOrder;
				cmd = new SqlCommand(cmdStr, con);
				curSum = Convert.ToInt32(cmd.ExecuteScalar());


				cmdStr = "UPDATE [order] SET sumOfOrd = @sum WHERE idOrder = " + idOrder;
				cmd = new SqlCommand(cmdStr, con);
				cmd.Parameters.AddWithValue("@sum", curSum + Convert.ToInt32(((DataRowView)workBindingSource.Current).Row["price"]));
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка подключения. Не удалось установить соединение с базой данных. Программа будет закрыта, обратитесь к администратору для решения проблемы.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}

			textBoxSum.Text = (curSum + Convert.ToInt32(((DataRowView)workBindingSource.Current).Row["price"])).ToString();

			con.Close();

			button5.Enabled = true;
			MessageBox.Show("Товар добавлен в заказ");
		}

		string pathImg;

		private void buttonAddPhoto_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "(*.JPG;*.PNG)|*.JPG;*.PNG";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
				pathImg = openFileDialog1.FileName;
				textBoxPhoto.Text = "../../source/imgDB/" + openFileDialog1.SafeFileName;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int curSum;
			SqlConnection con = new SqlConnection(@Properties.Settings.Default.conStr);
			con.Open();
			SqlCommand cmd;
			string cmdStr;

			cmdStr = "UPDATE [order] SET sumOfOrd = @sum WHERE idOrder = " + idOrder;
			cmd = new SqlCommand(cmdStr, con);
			cmd.Parameters.AddWithValue("@sum", Convert.ToInt32(textBoxSum.Text) - Convert.ToInt32(((DataRowView)allPositionBindingSource.Current).Row["price"]));
			cmd.ExecuteNonQuery();

			textBoxSum.Text = (Convert.ToInt32(textBoxSum.Text) - Convert.ToInt32(((DataRowView)allPositionBindingSource.Current).Row["price"])).ToString();

			cmdStr = "delete from [position] where idPosition = @idPosition";
			cmd = new SqlCommand(cmdStr, con);
			cmd.Parameters.AddWithValue("@idPosition", listBoxPosition.SelectedValue);
			cmd.ExecuteNonQuery();
			this.allPositionTableAdapter.Fill(this.dataSetAvtoKurs.AllPosition);



		}

		private void buttonDox_Click(object sender, EventArgs e)
		{
			try
			{

				comboBoxClient.SelectedValue = idClient;
				comboBoxMark.SelectedValue = idCar;

				Word._Application appw;
				appw = new Word.Application();
				appw.Visible = true;
				Word._Document dw;
				dw = appw.Documents.Add(typeof(Program).Assembly.Location.ToString() + @"/../../../source/tempDoc/" + "temp1.docx", Visible: true);

				dw.Bookmarks["id"].Range.Text = idOrder.ToString();
				dw.Bookmarks["fio"].Range.Text = ((DataRowView)clientBindingSource.Current).Row["nameClient"].ToString();
				dw.Bookmarks["phone"].Range.Text = ((DataRowView)clientBindingSource.Current).Row["phone"].ToString();
				dw.Bookmarks["number"].Range.Text = ((DataRowView)carBindingSource.Current).Row["number"].ToString();
				dw.Bookmarks["mark"].Range.Text = ((DataRowView)carBindingSource.Current).Row["mark"].ToString();

				var tableRange = dw.Bookmarks["teble"].Range;
				appw.ActiveDocument.Tables.Add(tableRange, listBoxPosition.Items.Count + 1, 3);

				var table = appw.ActiveDocument.Tables[appw.ActiveDocument.Tables.Count];
				table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
				table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

				table.Range.Font.Size = 12;

				table.Cell(1, 1).Range.Text = "Услуга";
				table.Cell(1, 2).Range.Text = "Мастер";
				table.Cell(1, 3).Range.Text = "Цена";

				int j = 2;
				listBoxPosition.SelectedIndex = 0;
				for (int i = 0; i < listBoxPosition.Items.Count; i++)
				{
					table.Cell(j, 1).Range.Text = ((DataRowView)allPositionBindingSource.Current).Row["nameWork"].ToString();
					table.Cell(j, 2).Range.Text = ((DataRowView)allPositionBindingSource.Current).Row["nameMaster"].ToString();
					table.Cell(j, 3).Range.Text = ((DataRowView)allPositionBindingSource.Current).Row["price"].ToString();
					if (i != listBoxPosition.Items.Count - 1)
					{
						listBoxPosition.SelectedIndex++;
						j++;
					}
				}

				dw.Bookmarks["sum"].Range.Text = textBoxSum.Text;

			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка экспорта. Не удалось экспортировать данные в ворд. Возможно он отсутствует на утсройтсе. Обратитесь к администратору для решения проблемы.", "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FormAddOrder_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!buttonAddPos.Enabled)
			{
				return;
			}
			DialogResult dialogResult = MessageBox.Show("После закрытия текущей формы вы не сможете редктировать текущий заказ. Продолжить?", "Завершение работы", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.No)
			{
				e.Cancel = true;
			}
			else if (dialogResult == DialogResult.Yes)
			{
				dialogResult = MessageBox.Show("Создать договор для текущего заказа?", "Договор", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					buttonDox_Click(sender, e);
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
