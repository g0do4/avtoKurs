
namespace avtoKurs
{
	partial class FormUser
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
			this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetAvtoKurs = new avtoKurs.DataSetAvtoKurs();
			this.userTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.userTableAdapter();
			this.labelNameUser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.allOrderTableAdapter1 = new avtoKurs.DataSetAvtoKursTableAdapters.AllOrderTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).BeginInit();
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
            this.iduserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.rightsDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(596, 233);
			this.dataGridView1.TabIndex = 0;
			// 
			// iduserDataGridViewTextBoxColumn
			// 
			this.iduserDataGridViewTextBoxColumn.DataPropertyName = "iduser";
			this.iduserDataGridViewTextBoxColumn.HeaderText = "ID пользователя";
			this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
			this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passDataGridViewTextBoxColumn
			// 
			this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
			this.passDataGridViewTextBoxColumn.HeaderText = "Пароль";
			this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
			this.passDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rightsDataGridViewTextBoxColumn
			// 
			this.rightsDataGridViewTextBoxColumn.DataPropertyName = "rights";
			this.rightsDataGridViewTextBoxColumn.HeaderText = "Права";
			this.rightsDataGridViewTextBoxColumn.Name = "rightsDataGridViewTextBoxColumn";
			this.rightsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataMember = "user";
			this.userBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// dataSetAvtoKurs
			// 
			this.dataSetAvtoKurs.DataSetName = "DataSetAvtoKurs";
			this.dataSetAvtoKurs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userTableAdapter
			// 
			this.userTableAdapter.ClearBeforeFill = true;
			// 
			// labelNameUser
			// 
			this.labelNameUser.AutoSize = true;
			this.labelNameUser.BackColor = System.Drawing.Color.LightSteelBlue;
			this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNameUser.Location = new System.Drawing.Point(8, 248);
			this.labelNameUser.Margin = new System.Windows.Forms.Padding(0);
			this.labelNameUser.Name = "labelNameUser";
			this.labelNameUser.Size = new System.Drawing.Size(64, 24);
			this.labelNameUser.TabIndex = 21;
			this.labelNameUser.Text = "Логин";
			this.labelNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 301);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "Пароль";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(171, 248);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 24);
			this.label2.TabIndex = 23;
			this.label2.Text = "Права";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBox1.Location = new System.Drawing.Point(12, 275);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(125, 23);
			this.textBox1.TabIndex = 24;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBox2.Location = new System.Drawing.Point(12, 328);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(125, 23);
			this.textBox2.TabIndex = 25;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Админ",
            "Менеджер"});
			this.comboBox1.Location = new System.Drawing.Point(175, 275);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 25);
			this.comboBox1.TabIndex = 26;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button2.Location = new System.Drawing.Point(175, 315);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 48);
			this.button2.TabIndex = 27;
			this.button2.Text = "Добавить пользователя";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button1.Location = new System.Drawing.Point(487, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 48);
			this.button1.TabIndex = 28;
			this.button1.Text = "Сохранить изменения";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button3.Location = new System.Drawing.Point(330, 315);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 48);
			this.button3.TabIndex = 29;
			this.button3.Text = "Удалить выделленное";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// allOrderTableAdapter1
			// 
			this.allOrderTableAdapter1.ClearBeforeFill = true;
			// 
			// FormUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(620, 372);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelNameUser);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.Name = "FormUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Автосервис. Пользователи";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
			this.Load += new System.EventHandler(this.FormUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private DataSetAvtoKurs dataSetAvtoKurs;
		private System.Windows.Forms.BindingSource userBindingSource;
		private DataSetAvtoKursTableAdapters.userTableAdapter userTableAdapter;
		private System.Windows.Forms.Label labelNameUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rightsDataGridViewTextBoxColumn;
		private DataSetAvtoKursTableAdapters.AllOrderTableAdapter allOrderTableAdapter1;
	}
}