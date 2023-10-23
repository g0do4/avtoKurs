
namespace avtoKurs
{
	partial class FormMaster
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.Стаж = new System.Windows.Forms.Label();
			this.labelNameUser = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idMasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameMasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageOfWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetAvtoKurs = new avtoKurs.DataSetAvtoKurs();
			this.buttonAgeUpdate = new System.Windows.Forms.Button();
			this.fullMasterTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.FullMasterTableAdapter();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.workTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.workTableAdapter();
			this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.masterTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.masterTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonFind = new System.Windows.Forms.Button();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.textBoxAge = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fullMasterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBoxAge)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonSave.Location = new System.Drawing.Point(614, 332);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(121, 48);
			this.buttonSave.TabIndex = 47;
			this.buttonSave.Text = "Сохранить изменения";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonDel.Location = new System.Drawing.Point(614, 278);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(121, 48);
			this.buttonDel.TabIndex = 48;
			this.buttonDel.Text = "Удалить выделленное";
			this.buttonDel.UseVisualStyleBackColor = false;
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonAdd.Location = new System.Drawing.Point(487, 332);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(121, 48);
			this.buttonAdd.TabIndex = 46;
			this.buttonAdd.Text = "Добавить мастера";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxName.Location = new System.Drawing.Point(12, 291);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(225, 23);
			this.textBoxName.TabIndex = 44;
			// 
			// Стаж
			// 
			this.Стаж.AutoSize = true;
			this.Стаж.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Стаж.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Стаж.Location = new System.Drawing.Point(239, 264);
			this.Стаж.Margin = new System.Windows.Forms.Padding(0);
			this.Стаж.Name = "Стаж";
			this.Стаж.Size = new System.Drawing.Size(128, 24);
			this.Стаж.TabIndex = 43;
			this.Стаж.Text = "Стаж работы";
			this.Стаж.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNameUser
			// 
			this.labelNameUser.AutoSize = true;
			this.labelNameUser.BackColor = System.Drawing.Color.LightSteelBlue;
			this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNameUser.Location = new System.Drawing.Point(8, 264);
			this.labelNameUser.Margin = new System.Windows.Forms.Padding(0);
			this.labelNameUser.Name = "labelNameUser";
			this.labelNameUser.Size = new System.Drawing.Size(129, 24);
			this.labelNameUser.TabIndex = 42;
			this.labelNameUser.Text = "Имя Мастера";
			this.labelNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMasterDataGridViewTextBoxColumn,
            this.nameMasterDataGridViewTextBoxColumn,
            this.ageOfWorkDataGridViewTextBoxColumn,
            this.nameWorkDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.fullMasterBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(723, 233);
			this.dataGridView1.TabIndex = 41;
			// 
			// idMasterDataGridViewTextBoxColumn
			// 
			this.idMasterDataGridViewTextBoxColumn.DataPropertyName = "idMaster";
			this.idMasterDataGridViewTextBoxColumn.HeaderText = "ID мастера";
			this.idMasterDataGridViewTextBoxColumn.Name = "idMasterDataGridViewTextBoxColumn";
			this.idMasterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameMasterDataGridViewTextBoxColumn
			// 
			this.nameMasterDataGridViewTextBoxColumn.DataPropertyName = "nameMaster";
			this.nameMasterDataGridViewTextBoxColumn.HeaderText = "Имя мастера";
			this.nameMasterDataGridViewTextBoxColumn.Name = "nameMasterDataGridViewTextBoxColumn";
			this.nameMasterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ageOfWorkDataGridViewTextBoxColumn
			// 
			this.ageOfWorkDataGridViewTextBoxColumn.DataPropertyName = "ageOfWork";
			this.ageOfWorkDataGridViewTextBoxColumn.HeaderText = "Страж работы";
			this.ageOfWorkDataGridViewTextBoxColumn.Name = "ageOfWorkDataGridViewTextBoxColumn";
			this.ageOfWorkDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameWorkDataGridViewTextBoxColumn
			// 
			this.nameWorkDataGridViewTextBoxColumn.DataPropertyName = "nameWork";
			this.nameWorkDataGridViewTextBoxColumn.HeaderText = "Оказываемая услуга";
			this.nameWorkDataGridViewTextBoxColumn.Name = "nameWorkDataGridViewTextBoxColumn";
			this.nameWorkDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fullMasterBindingSource
			// 
			this.fullMasterBindingSource.DataMember = "FullMaster";
			this.fullMasterBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// dataSetAvtoKurs
			// 
			this.dataSetAvtoKurs.DataSetName = "DataSetAvtoKurs";
			this.dataSetAvtoKurs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// buttonAgeUpdate
			// 
			this.buttonAgeUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonAgeUpdate.Location = new System.Drawing.Point(228, 332);
			this.buttonAgeUpdate.Name = "buttonAgeUpdate";
			this.buttonAgeUpdate.Size = new System.Drawing.Size(182, 48);
			this.buttonAgeUpdate.TabIndex = 49;
			this.buttonAgeUpdate.Text = "Изменить стаж выбранного работника";
			this.buttonAgeUpdate.UseVisualStyleBackColor = false;
			this.buttonAgeUpdate.Click += new System.EventHandler(this.buttonAgeUpdate_Click);
			// 
			// fullMasterTableAdapter
			// 
			this.fullMasterTableAdapter.ClearBeforeFill = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.workBindingSource;
			this.comboBox1.DisplayMember = "nameWork";
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(408, 291);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(186, 25);
			this.comboBox1.TabIndex = 50;
			this.comboBox1.ValueMember = "idWork";
			// 
			// workBindingSource
			// 
			this.workBindingSource.DataMember = "work";
			this.workBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(404, 262);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 24);
			this.label1.TabIndex = 51;
			this.label1.Text = "Оказываемая услуга";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// workTableAdapter
			// 
			this.workTableAdapter.ClearBeforeFill = true;
			// 
			// masterBindingSource
			// 
			this.masterBindingSource.DataMember = "master";
			this.masterBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// masterTableAdapter
			// 
			this.masterTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dataGridView2.DataSource = this.masterBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(675, 68);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(45, 88);
			this.dataGridView2.TabIndex = 52;
			this.dataGridView2.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idMaster";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID мастера";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "nameMaster";
			this.dataGridViewTextBoxColumn2.HeaderText = "Имя мастера";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ageOfWork";
			this.dataGridViewTextBoxColumn3.HeaderText = "Страж работы";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// buttonFind
			// 
			this.buttonFind.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonFind.Location = new System.Drawing.Point(12, 332);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(182, 48);
			this.buttonFind.TabIndex = 53;
			this.buttonFind.Text = "Найти мастера по имени";
			this.buttonFind.UseVisualStyleBackColor = false;
			this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.BindingSource = this.fullMasterBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = null;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(747, 25);
			this.bindingNavigator1.TabIndex = 54;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// textBoxAge
			// 
			this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxAge.Location = new System.Drawing.Point(243, 291);
			this.textBoxAge.Name = "textBoxAge";
			this.textBoxAge.Size = new System.Drawing.Size(159, 23);
			this.textBoxAge.TabIndex = 55;
			// 
			// FormMaster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 398);
			this.Controls.Add(this.textBoxAge);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.buttonFind);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonDel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.Стаж);
			this.Controls.Add(this.labelNameUser);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonAgeUpdate);
			this.Controls.Add(this.dataGridView2);
			this.Name = "FormMaster";
			this.Text = "Автосервис. Мастера";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMaster_FormClosing);
			this.Load += new System.EventHandler(this.FormMaster_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fullMasterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBoxAge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label Стаж;
		private System.Windows.Forms.Label labelNameUser;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonAgeUpdate;
		private DataSetAvtoKurs dataSetAvtoKurs;
		private System.Windows.Forms.BindingSource fullMasterBindingSource;
		private DataSetAvtoKursTableAdapters.FullMasterTableAdapter fullMasterTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idMasterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameMasterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageOfWorkDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameWorkDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource workBindingSource;
		private DataSetAvtoKursTableAdapters.workTableAdapter workTableAdapter;
		private System.Windows.Forms.BindingSource masterBindingSource;
		private DataSetAvtoKursTableAdapters.masterTableAdapter masterTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.NumericUpDown textBoxAge;
	}
}