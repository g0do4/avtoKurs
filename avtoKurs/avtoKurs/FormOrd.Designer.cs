
namespace avtoKurs
{
	partial class FormOrd
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sumOfOrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.allOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetAvtoKurs = new avtoKurs.DataSetAvtoKurs();
			this.allOrderTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.AllOrderTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.allPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.allPositionTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.AllPositionTableAdapter();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.idPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allOrderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allPositionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.sumOfOrdDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateStateDataGridViewTextBoxColumn,
            this.nameStateDataGridViewTextBoxColumn,
            this.nameClientDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.allOrderBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(762, 156);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
			// 
			// idOrderDataGridViewTextBoxColumn
			// 
			this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "idOrder";
			this.idOrderDataGridViewTextBoxColumn.HeaderText = "ID заказа";
			this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
			this.idOrderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sumOfOrdDataGridViewTextBoxColumn
			// 
			this.sumOfOrdDataGridViewTextBoxColumn.DataPropertyName = "sumOfOrd";
			this.sumOfOrdDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
			this.sumOfOrdDataGridViewTextBoxColumn.Name = "sumOfOrdDataGridViewTextBoxColumn";
			this.sumOfOrdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateBeginDataGridViewTextBoxColumn
			// 
			this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "dateBegin";
			this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Дата начала";
			this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateStateDataGridViewTextBoxColumn
			// 
			this.dateStateDataGridViewTextBoxColumn.DataPropertyName = "dateState";
			this.dateStateDataGridViewTextBoxColumn.HeaderText = "Дата смены состояния";
			this.dateStateDataGridViewTextBoxColumn.Name = "dateStateDataGridViewTextBoxColumn";
			this.dateStateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameStateDataGridViewTextBoxColumn
			// 
			this.nameStateDataGridViewTextBoxColumn.DataPropertyName = "nameState";
			this.nameStateDataGridViewTextBoxColumn.HeaderText = "Наименование состояния";
			this.nameStateDataGridViewTextBoxColumn.Name = "nameStateDataGridViewTextBoxColumn";
			this.nameStateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameClientDataGridViewTextBoxColumn
			// 
			this.nameClientDataGridViewTextBoxColumn.DataPropertyName = "nameClient";
			this.nameClientDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
			this.nameClientDataGridViewTextBoxColumn.Name = "nameClientDataGridViewTextBoxColumn";
			this.nameClientDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон клиента";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// markDataGridViewTextBoxColumn
			// 
			this.markDataGridViewTextBoxColumn.DataPropertyName = "mark";
			this.markDataGridViewTextBoxColumn.HeaderText = "Марка машины";
			this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
			this.markDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numberDataGridViewTextBoxColumn
			// 
			this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
			this.numberDataGridViewTextBoxColumn.HeaderText = "Номер машины";
			this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
			this.numberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// allOrderBindingSource
			// 
			this.allOrderBindingSource.DataMember = "AllOrder";
			this.allOrderBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// dataSetAvtoKurs
			// 
			this.dataSetAvtoKurs.DataSetName = "DataSetAvtoKurs";
			this.dataSetAvtoKurs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// allOrderTableAdapter
			// 
			this.allOrderTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPosition,
            this.nameMaster,
            this.ageOfWork,
            this.nameWork,
            this.price});
			this.dataGridView2.DataSource = this.allPositionBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(12, 184);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(762, 156);
			this.dataGridView2.TabIndex = 2;
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
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 346);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button2.Location = new System.Drawing.Point(12, 372);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(213, 48);
			this.button2.TabIndex = 28;
			this.button2.Text = "Удалить заказы созданные до выбранной даты";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// idPosition
			// 
			this.idPosition.DataPropertyName = "idPosition";
			this.idPosition.HeaderText = "ID позиции";
			this.idPosition.Name = "idPosition";
			this.idPosition.ReadOnly = true;
			// 
			// nameMaster
			// 
			this.nameMaster.DataPropertyName = "nameMaster";
			this.nameMaster.HeaderText = "Имя мастера";
			this.nameMaster.Name = "nameMaster";
			this.nameMaster.ReadOnly = true;
			// 
			// ageOfWork
			// 
			this.ageOfWork.DataPropertyName = "ageOfWork";
			this.ageOfWork.HeaderText = "Стаж работы";
			this.ageOfWork.Name = "ageOfWork";
			this.ageOfWork.ReadOnly = true;
			// 
			// nameWork
			// 
			this.nameWork.DataPropertyName = "nameWork";
			this.nameWork.HeaderText = "Назавние услуги";
			this.nameWork.Name = "nameWork";
			this.nameWork.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price";
			this.price.HeaderText = "Цена";
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button1.Location = new System.Drawing.Point(514, 346);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(207, 74);
			this.button1.TabIndex = 29;
			this.button1.Text = "Отчистить таблицу клиентов";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormOrd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 426);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormOrd";
			this.Text = "Автосервис. Заказы";
			this.Load += new System.EventHandler(this.FormOrd_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allOrderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allPositionBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private DataSetAvtoKurs dataSetAvtoKurs;
		private System.Windows.Forms.BindingSource allOrderBindingSource;
		private DataSetAvtoKursTableAdapters.AllOrderTableAdapter allOrderTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sumOfOrdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateStateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameStateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource allPositionBindingSource;
		private DataSetAvtoKursTableAdapters.AllPositionTableAdapter allPositionTableAdapter;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPosition;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameMaster;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageOfWork;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameWork;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.Button button1;
	}
}