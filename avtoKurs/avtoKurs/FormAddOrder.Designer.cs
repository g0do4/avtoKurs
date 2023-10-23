
namespace avtoKurs
{
	partial class FormAddOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panelAddClient = new System.Windows.Forms.Panel();
			this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxClientName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panelClient = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxClient = new System.Windows.Forms.ComboBox();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetAvtoKurs = new avtoKurs.DataSetAvtoKurs();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButtonClient2 = new System.Windows.Forms.RadioButton();
			this.radioButtonClient1 = new System.Windows.Forms.RadioButton();
			this.clientTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.clientTableAdapter();
			this.panelCar = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxMark = new System.Windows.Forms.ComboBox();
			this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.radioButtonCar2 = new System.Windows.Forms.RadioButton();
			this.radioButtonCar1 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.panelAddCar = new System.Windows.Forms.Panel();
			this.textBoxNumber = new System.Windows.Forms.MaskedTextBox();
			this.buttonAddPhoto = new System.Windows.Forms.Button();
			this.textBoxMark = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.carTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.carTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxPhoto = new System.Windows.Forms.TextBox();
			this.listBoxWork = new System.Windows.Forms.ListBox();
			this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.workTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.workTableAdapter();
			this.label11 = new System.Windows.Forms.Label();
			this.listBoxMaster = new System.Windows.Forms.ListBox();
			this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.masterTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.masterTableAdapter();
			this.label12 = new System.Windows.Forms.Label();
			this.listBoxPosition = new System.Windows.Forms.ListBox();
			this.allPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.allPositionTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.AllPositionTableAdapter();
			this.buttonAddOrd = new System.Windows.Forms.Button();
			this.buttonAddPos = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxSum = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonDox = new System.Windows.Forms.Button();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panelAddClient.SuspendLayout();
			this.panelClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).BeginInit();
			this.panel1.SuspendLayout();
			this.panelCar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
			this.panel3.SuspendLayout();
			this.panelAddCar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allPositionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelAddClient
			// 
			this.panelAddClient.Controls.Add(this.textBoxPhone);
			this.panelAddClient.Controls.Add(this.label4);
			this.panelAddClient.Controls.Add(this.textBoxClientName);
			this.panelAddClient.Controls.Add(this.label3);
			this.panelAddClient.Location = new System.Drawing.Point(10, 33);
			this.panelAddClient.Name = "panelAddClient";
			this.panelAddClient.Size = new System.Drawing.Size(235, 176);
			this.panelAddClient.TabIndex = 0;
			this.panelAddClient.Visible = false;
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.textBoxPhone.Location = new System.Drawing.Point(14, 109);
			this.textBoxPhone.Mask = "+7 (000) 000 00-00";
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(208, 29);
			this.textBoxPhone.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(10, 82);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 24);
			this.label4.TabIndex = 25;
			this.label4.Text = "Телефон";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxClientName
			// 
			this.textBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxClientName.Location = new System.Drawing.Point(14, 36);
			this.textBoxClientName.Name = "textBoxClientName";
			this.textBoxClientName.Size = new System.Drawing.Size(208, 29);
			this.textBoxClientName.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(10, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 24);
			this.label3.TabIndex = 23;
			this.label3.Text = "ФИО";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelClient
			// 
			this.panelClient.Controls.Add(this.label2);
			this.panelClient.Controls.Add(this.comboBoxClient);
			this.panelClient.Location = new System.Drawing.Point(10, 33);
			this.panelClient.Name = "panelClient";
			this.panelClient.Size = new System.Drawing.Size(235, 176);
			this.panelClient.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(10, 33);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 24);
			this.label2.TabIndex = 22;
			this.label2.Text = "ФИО";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxClient
			// 
			this.comboBoxClient.DataSource = this.clientBindingSource;
			this.comboBoxClient.DisplayMember = "nameClient";
			this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.comboBoxClient.FormattingEnabled = true;
			this.comboBoxClient.Location = new System.Drawing.Point(14, 60);
			this.comboBoxClient.Name = "comboBoxClient";
			this.comboBoxClient.Size = new System.Drawing.Size(218, 25);
			this.comboBoxClient.TabIndex = 2;
			this.comboBoxClient.ValueMember = "idClient";
			this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataMember = "client";
			this.clientBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// dataSetAvtoKurs
			// 
			this.dataSetAvtoKurs.DataSetName = "DataSetAvtoKurs";
			this.dataSetAvtoKurs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 24);
			this.label1.TabIndex = 21;
			this.label1.Text = "Клиент";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButtonClient2);
			this.panel1.Controls.Add(this.radioButtonClient1);
			this.panel1.Location = new System.Drawing.Point(13, 212);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 51);
			this.panel1.TabIndex = 22;
			// 
			// radioButtonClient2
			// 
			this.radioButtonClient2.AutoSize = true;
			this.radioButtonClient2.Location = new System.Drawing.Point(3, 26);
			this.radioButtonClient2.Name = "radioButtonClient2";
			this.radioButtonClient2.Size = new System.Drawing.Size(133, 17);
			this.radioButtonClient2.TabIndex = 24;
			this.radioButtonClient2.Text = "Новый пользователь";
			this.radioButtonClient2.UseVisualStyleBackColor = true;
			this.radioButtonClient2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButtonClient1
			// 
			this.radioButtonClient1.AutoSize = true;
			this.radioButtonClient1.Checked = true;
			this.radioButtonClient1.Location = new System.Drawing.Point(3, 3);
			this.radioButtonClient1.Name = "radioButtonClient1";
			this.radioButtonClient1.Size = new System.Drawing.Size(177, 17);
			this.radioButtonClient1.TabIndex = 23;
			this.radioButtonClient1.TabStop = true;
			this.radioButtonClient1.Text = "Существующий пользователь";
			this.radioButtonClient1.UseVisualStyleBackColor = true;
			this.radioButtonClient1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// clientTableAdapter
			// 
			this.clientTableAdapter.ClearBeforeFill = true;
			// 
			// panelCar
			// 
			this.panelCar.Controls.Add(this.label5);
			this.panelCar.Controls.Add(this.comboBoxMark);
			this.panelCar.Location = new System.Drawing.Point(251, 33);
			this.panelCar.Name = "panelCar";
			this.panelCar.Size = new System.Drawing.Size(239, 176);
			this.panelCar.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(10, 33);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 24);
			this.label5.TabIndex = 22;
			this.label5.Text = "Номер машины";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxMark
			// 
			this.comboBoxMark.DataSource = this.carBindingSource;
			this.comboBoxMark.DisplayMember = "number";
			this.comboBoxMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.comboBoxMark.FormattingEnabled = true;
			this.comboBoxMark.Location = new System.Drawing.Point(14, 60);
			this.comboBoxMark.Name = "comboBoxMark";
			this.comboBoxMark.Size = new System.Drawing.Size(204, 25);
			this.comboBoxMark.TabIndex = 2;
			this.comboBoxMark.ValueMember = "idCar";
			// 
			// carBindingSource
			// 
			this.carBindingSource.DataMember = "car";
			this.carBindingSource.DataSource = this.dataSetAvtoKurs;
			this.carBindingSource.Filter = "idClient = 0";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.radioButtonCar2);
			this.panel3.Controls.Add(this.radioButtonCar1);
			this.panel3.Location = new System.Drawing.Point(251, 212);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 51);
			this.panel3.TabIndex = 26;
			// 
			// radioButtonCar2
			// 
			this.radioButtonCar2.AutoSize = true;
			this.radioButtonCar2.Location = new System.Drawing.Point(3, 26);
			this.radioButtonCar2.Name = "radioButtonCar2";
			this.radioButtonCar2.Size = new System.Drawing.Size(102, 17);
			this.radioButtonCar2.TabIndex = 24;
			this.radioButtonCar2.Text = "Новый машина";
			this.radioButtonCar2.UseVisualStyleBackColor = true;
			this.radioButtonCar2.CheckedChanged += new System.EventHandler(this.radioButtonCar1_CheckedChanged);
			// 
			// radioButtonCar1
			// 
			this.radioButtonCar1.AutoSize = true;
			this.radioButtonCar1.Checked = true;
			this.radioButtonCar1.Location = new System.Drawing.Point(3, 3);
			this.radioButtonCar1.Name = "radioButtonCar1";
			this.radioButtonCar1.Size = new System.Drawing.Size(146, 17);
			this.radioButtonCar1.TabIndex = 23;
			this.radioButtonCar1.TabStop = true;
			this.radioButtonCar1.Text = "Существующая машина";
			this.radioButtonCar1.UseVisualStyleBackColor = true;
			this.radioButtonCar1.CheckedChanged += new System.EventHandler(this.radioButtonCar1_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(261, 6);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 24);
			this.label6.TabIndex = 25;
			this.label6.Text = "Машина";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelAddCar
			// 
			this.panelAddCar.Controls.Add(this.textBoxNumber);
			this.panelAddCar.Controls.Add(this.buttonAddPhoto);
			this.panelAddCar.Controls.Add(this.textBoxMark);
			this.panelAddCar.Controls.Add(this.label7);
			this.panelAddCar.Controls.Add(this.label8);
			this.panelAddCar.Location = new System.Drawing.Point(251, 33);
			this.panelAddCar.Name = "panelAddCar";
			this.panelAddCar.Size = new System.Drawing.Size(239, 176);
			this.panelAddCar.TabIndex = 23;
			this.panelAddCar.Visible = false;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.textBoxNumber.Location = new System.Drawing.Point(13, 36);
			this.textBoxNumber.Mask = "000 L000LL";
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(167, 29);
			this.textBoxNumber.TabIndex = 28;
			this.toolTip1.SetToolTip(this.textBoxNumber, "Пример номера: 161 у143еу");
			// 
			// buttonAddPhoto
			// 
			this.buttonAddPhoto.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonAddPhoto.Location = new System.Drawing.Point(13, 130);
			this.buttonAddPhoto.Name = "buttonAddPhoto";
			this.buttonAddPhoto.Size = new System.Drawing.Size(167, 40);
			this.buttonAddPhoto.TabIndex = 27;
			this.buttonAddPhoto.Text = "Добавить изображение";
			this.buttonAddPhoto.UseVisualStyleBackColor = false;
			this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
			// 
			// textBoxMark
			// 
			this.textBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxMark.Location = new System.Drawing.Point(14, 95);
			this.textBoxMark.Name = "textBoxMark";
			this.textBoxMark.Size = new System.Drawing.Size(166, 29);
			this.textBoxMark.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(10, 68);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 24);
			this.label7.TabIndex = 25;
			this.label7.Text = "Марка";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(10, 9);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(146, 24);
			this.label8.TabIndex = 23;
			this.label8.Text = "Номер машины";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// carTableAdapter
			// 
			this.carTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(496, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 211);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(494, 6);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(171, 24);
			this.label9.TabIndex = 28;
			this.label9.Text = "Фото автомобиля";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPhoto
			// 
			this.textBoxPhoto.Location = new System.Drawing.Point(515, 98);
			this.textBoxPhoto.Name = "textBoxPhoto";
			this.textBoxPhoto.Size = new System.Drawing.Size(100, 20);
			this.textBoxPhoto.TabIndex = 29;
			this.textBoxPhoto.Visible = false;
			// 
			// listBoxWork
			// 
			this.listBoxWork.DataSource = this.workBindingSource;
			this.listBoxWork.DisplayMember = "nameWork";
			this.listBoxWork.FormattingEnabled = true;
			this.listBoxWork.Location = new System.Drawing.Point(13, 299);
			this.listBoxWork.Name = "listBoxWork";
			this.listBoxWork.Size = new System.Drawing.Size(229, 147);
			this.listBoxWork.TabIndex = 30;
			this.listBoxWork.ValueMember = "idWork";
			this.listBoxWork.SelectedIndexChanged += new System.EventHandler(this.listBoxWork_SelectedIndexChanged);
			// 
			// workBindingSource
			// 
			this.workBindingSource.DataMember = "work";
			this.workBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(12, 272);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 24);
			this.label10.TabIndex = 31;
			this.label10.Text = "Услуги";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// workTableAdapter
			// 
			this.workTableAdapter.ClearBeforeFill = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(247, 272);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 24);
			this.label11.TabIndex = 33;
			this.label11.Text = "Мастера";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBoxMaster
			// 
			this.listBoxMaster.DataSource = this.masterBindingSource;
			this.listBoxMaster.DisplayMember = "nameMaster";
			this.listBoxMaster.FormattingEnabled = true;
			this.listBoxMaster.Location = new System.Drawing.Point(251, 299);
			this.listBoxMaster.Name = "listBoxMaster";
			this.listBoxMaster.Size = new System.Drawing.Size(239, 212);
			this.listBoxMaster.TabIndex = 32;
			this.listBoxMaster.ValueMember = "idMaster";
			// 
			// masterBindingSource
			// 
			this.masterBindingSource.DataMember = "master";
			this.masterBindingSource.DataSource = this.dataSetAvtoKurs;
			this.masterBindingSource.Filter = "idWork = 0";
			// 
			// masterTableAdapter
			// 
			this.masterTableAdapter.ClearBeforeFill = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(734, 6);
			this.label12.Margin = new System.Windows.Forms.Padding(0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(176, 24);
			this.label12.TabIndex = 36;
			this.label12.Text = "Выбранные услуги";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBoxPosition
			// 
			this.listBoxPosition.DataSource = this.allPositionBindingSource;
			this.listBoxPosition.DisplayMember = "nameWork";
			this.listBoxPosition.FormattingEnabled = true;
			this.listBoxPosition.Location = new System.Drawing.Point(749, 35);
			this.listBoxPosition.Name = "listBoxPosition";
			this.listBoxPosition.Size = new System.Drawing.Size(229, 316);
			this.listBoxPosition.TabIndex = 35;
			this.listBoxPosition.ValueMember = "idPosition";
			// 
			// allPositionBindingSource
			// 
			this.allPositionBindingSource.DataMember = "AllPosition";
			this.allPositionBindingSource.DataSource = this.dataSetAvtoKurs;
			this.allPositionBindingSource.Filter = "idOrder = 0";
			// 
			// allPositionTableAdapter
			// 
			this.allPositionTableAdapter.ClearBeforeFill = true;
			// 
			// buttonAddOrd
			// 
			this.buttonAddOrd.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonAddOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.buttonAddOrd.Location = new System.Drawing.Point(524, 272);
			this.buttonAddOrd.Name = "buttonAddOrd";
			this.buttonAddOrd.Size = new System.Drawing.Size(167, 70);
			this.buttonAddOrd.TabIndex = 37;
			this.buttonAddOrd.Text = "Создать новый заказ";
			this.buttonAddOrd.UseVisualStyleBackColor = false;
			this.buttonAddOrd.Click += new System.EventHandler(this.buttonAddOrd_Click);
			// 
			// buttonAddPos
			// 
			this.buttonAddPos.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonAddPos.Enabled = false;
			this.buttonAddPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.buttonAddPos.Location = new System.Drawing.Point(524, 364);
			this.buttonAddPos.Name = "buttonAddPos";
			this.buttonAddPos.Size = new System.Drawing.Size(167, 70);
			this.buttonAddPos.TabIndex = 38;
			this.buttonAddPos.Text = "Добавить услугу";
			this.buttonAddPos.UseVisualStyleBackColor = false;
			this.buttonAddPos.Click += new System.EventHandler(this.buttonAddPos_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button4.Location = new System.Drawing.Point(915, 502);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(63, 25);
			this.button4.TabIndex = 39;
			this.button4.Text = "Выход";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Enabled = false;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.button5.Location = new System.Drawing.Point(781, 354);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(167, 40);
			this.button5.TabIndex = 40;
			this.button5.Text = "Удалить услугу";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(799, 423);
			this.label13.Margin = new System.Windows.Forms.Padding(0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(132, 24);
			this.label13.TabIndex = 41;
			this.label13.Text = "Сумма заказа";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxSum
			// 
			this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSum.Location = new System.Drawing.Point(803, 452);
			this.textBoxSum.Name = "textBoxSum";
			this.textBoxSum.ReadOnly = true;
			this.textBoxSum.Size = new System.Drawing.Size(120, 29);
			this.textBoxSum.TabIndex = 42;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonDox
			// 
			this.buttonDox.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonDox.Enabled = false;
			this.buttonDox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.buttonDox.Location = new System.Drawing.Point(524, 457);
			this.buttonDox.Name = "buttonDox";
			this.buttonDox.Size = new System.Drawing.Size(167, 70);
			this.buttonDox.TabIndex = 43;
			this.buttonDox.Text = "Создать договор";
			this.buttonDox.UseVisualStyleBackColor = false;
			this.buttonDox.Click += new System.EventHandler(this.buttonDox_Click);
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPrice.Location = new System.Drawing.Point(73, 482);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(120, 29);
			this.textBoxPrice.TabIndex = 45;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(69, 453);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(117, 24);
			this.label14.TabIndex = 44;
			this.label14.Text = "Цена услуги";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormAddOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(990, 539);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.buttonDox);
			this.Controls.Add(this.textBoxSum);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.buttonAddPos);
			this.Controls.Add(this.buttonAddOrd);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.panelCar);
			this.Controls.Add(this.listBoxPosition);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.listBoxMaster);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.listBoxWork);
			this.Controls.Add(this.textBoxPhoto);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelAddCar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelClient);
			this.Controls.Add(this.panelAddClient);
			this.MaximizeBox = false;
			this.Name = "FormAddOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Автосервис. Оформить заказ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddOrder_FormClosing);
			this.Load += new System.EventHandler(this.FormAddOrder_Load);
			this.panelAddClient.ResumeLayout(false);
			this.panelAddClient.PerformLayout();
			this.panelClient.ResumeLayout(false);
			this.panelClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelCar.ResumeLayout(false);
			this.panelCar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panelAddCar.ResumeLayout(false);
			this.panelAddCar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allPositionBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelAddClient;
		private System.Windows.Forms.Panel panelClient;
		private System.Windows.Forms.ComboBox comboBoxClient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxClientName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButtonClient2;
		private System.Windows.Forms.RadioButton radioButtonClient1;
		private DataSetAvtoKurs dataSetAvtoKurs;
		private System.Windows.Forms.BindingSource clientBindingSource;
		private DataSetAvtoKursTableAdapters.clientTableAdapter clientTableAdapter;
		private System.Windows.Forms.Panel panelCar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxMark;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton radioButtonCar2;
		private System.Windows.Forms.RadioButton radioButtonCar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panelAddCar;
		private System.Windows.Forms.TextBox textBoxMark;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.BindingSource carBindingSource;
		private DataSetAvtoKursTableAdapters.carTableAdapter carTableAdapter;
		private System.Windows.Forms.Button buttonAddPhoto;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxPhoto;
		private System.Windows.Forms.ListBox listBoxWork;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.BindingSource workBindingSource;
		private DataSetAvtoKursTableAdapters.workTableAdapter workTableAdapter;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ListBox listBoxMaster;
		private System.Windows.Forms.BindingSource masterBindingSource;
		private DataSetAvtoKursTableAdapters.masterTableAdapter masterTableAdapter;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ListBox listBoxPosition;
		private System.Windows.Forms.BindingSource allPositionBindingSource;
		private DataSetAvtoKursTableAdapters.AllPositionTableAdapter allPositionTableAdapter;
		private System.Windows.Forms.Button buttonAddOrd;
		private System.Windows.Forms.Button buttonAddPos;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonDox;
		private System.Windows.Forms.MaskedTextBox textBoxPhone;
		private System.Windows.Forms.MaskedTextBox textBoxNumber;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}