
namespace avtoKurs
{
	partial class FormWork
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelNameUser = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetAvtoKurs = new avtoKurs.DataSetAvtoKurs();
			this.workTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.workTableAdapter();
			this.buttonPriceUpdate = new System.Windows.Forms.Button();
			this.textBoxPrice = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonSave.Location = new System.Drawing.Point(487, 314);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(121, 48);
			this.buttonSave.TabIndex = 38;
			this.buttonSave.Text = "Сохранить изменения";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonDel.Location = new System.Drawing.Point(487, 260);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(121, 48);
			this.buttonDel.TabIndex = 39;
			this.buttonDel.Text = "Удалить выделленное";
			this.buttonDel.UseVisualStyleBackColor = false;
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonAdd.Location = new System.Drawing.Point(12, 314);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(121, 48);
			this.buttonAdd.TabIndex = 37;
			this.buttonAdd.Text = "Добавить услугу";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxName.Location = new System.Drawing.Point(12, 275);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(187, 23);
			this.textBoxName.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(217, 248);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 24);
			this.label1.TabIndex = 32;
			this.label1.Text = "Цена";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNameUser
			// 
			this.labelNameUser.AutoSize = true;
			this.labelNameUser.BackColor = System.Drawing.Color.LightSteelBlue;
			this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNameUser.Location = new System.Drawing.Point(8, 248);
			this.labelNameUser.Margin = new System.Windows.Forms.Padding(0);
			this.labelNameUser.Name = "labelNameUser";
			this.labelNameUser.Size = new System.Drawing.Size(160, 24);
			this.labelNameUser.TabIndex = 31;
			this.labelNameUser.Text = "Название услуги";
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
            this.idWorkDataGridViewTextBoxColumn,
            this.nameWorkDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.workBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(596, 233);
			this.dataGridView1.TabIndex = 30;
			// 
			// idWorkDataGridViewTextBoxColumn
			// 
			this.idWorkDataGridViewTextBoxColumn.DataPropertyName = "idWork";
			this.idWorkDataGridViewTextBoxColumn.HeaderText = "ID услуги";
			this.idWorkDataGridViewTextBoxColumn.Name = "idWorkDataGridViewTextBoxColumn";
			this.idWorkDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameWorkDataGridViewTextBoxColumn
			// 
			this.nameWorkDataGridViewTextBoxColumn.DataPropertyName = "nameWork";
			this.nameWorkDataGridViewTextBoxColumn.HeaderText = "Назавние услуги";
			this.nameWorkDataGridViewTextBoxColumn.Name = "nameWorkDataGridViewTextBoxColumn";
			this.nameWorkDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// workBindingSource
			// 
			this.workBindingSource.DataMember = "work";
			this.workBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// dataSetAvtoKurs
			// 
			this.dataSetAvtoKurs.DataSetName = "DataSetAvtoKurs";
			this.dataSetAvtoKurs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// workTableAdapter
			// 
			this.workTableAdapter.ClearBeforeFill = true;
			// 
			// buttonPriceUpdate
			// 
			this.buttonPriceUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.buttonPriceUpdate.Location = new System.Drawing.Point(186, 314);
			this.buttonPriceUpdate.Name = "buttonPriceUpdate";
			this.buttonPriceUpdate.Size = new System.Drawing.Size(182, 48);
			this.buttonPriceUpdate.TabIndex = 40;
			this.buttonPriceUpdate.Text = "Изменить цену выделенной услуги";
			this.buttonPriceUpdate.UseVisualStyleBackColor = false;
			this.buttonPriceUpdate.Click += new System.EventHandler(this.buttonPriceUpdate_Click);
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxPrice.Location = new System.Drawing.Point(221, 275);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(167, 23);
			this.textBoxPrice.TabIndex = 41;
			// 
			// FormWork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(623, 374);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.buttonPriceUpdate);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonDel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelNameUser);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.Name = "FormWork";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Автосервис. Услуги";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWork_FormClosing);
			this.Load += new System.EventHandler(this.FormWork_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelNameUser;
		private System.Windows.Forms.DataGridView dataGridView1;
		private DataSetAvtoKurs dataSetAvtoKurs;
		private System.Windows.Forms.BindingSource workBindingSource;
		private DataSetAvtoKursTableAdapters.workTableAdapter workTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idWorkDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameWorkDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buttonPriceUpdate;
		private System.Windows.Forms.NumericUpDown textBoxPrice;
	}
}