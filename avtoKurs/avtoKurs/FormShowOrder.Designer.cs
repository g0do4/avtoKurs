
namespace avtoKurs
{
	partial class FormShowOrder
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.allOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetAvtoKurs = new avtoKurs.DataSetAvtoKurs();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.allPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.allOrderTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.AllOrderTableAdapter();
			this.allPositionTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.AllPositionTableAdapter();
			this.stateTableAdapter = new avtoKurs.DataSetAvtoKursTableAdapters.stateTableAdapter();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxSum = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxMark = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxDateState = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.allOrderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allPositionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.DataSource = this.allOrderBindingSource;
			this.listBox1.DisplayMember = "idOrder";
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 17;
			this.listBox1.Location = new System.Drawing.Point(9, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(84, 191);
			this.listBox1.TabIndex = 0;
			this.listBox1.ValueMember = "idOrder";
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(6, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Номер заказа";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listBox2
			// 
			this.listBox2.DataSource = this.allPositionBindingSource;
			this.listBox2.DisplayMember = "nameWork";
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 17;
			this.listBox2.Location = new System.Drawing.Point(148, 36);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(348, 174);
			this.listBox2.TabIndex = 3;
			// 
			// allPositionBindingSource
			// 
			this.allPositionBindingSource.DataMember = "AllPosition";
			this.allPositionBindingSource.DataSource = this.dataSetAvtoKurs;
			this.allPositionBindingSource.Filter = "idOrder = 0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(239, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Состав заказа";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(144, 216);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Сведения о заказе";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(519, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(224, 201);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(567, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Фото автомобиля";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.stateBindingSource;
			this.comboBox1.DisplayMember = "nameState";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(507, 319);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(199, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.ValueMember = "idState";
			// 
			// stateBindingSource
			// 
			this.stateBindingSource.DataMember = "state";
			this.stateBindingSource.DataSource = this.dataSetAvtoKurs;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(540, 275);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 24);
			this.label5.TabIndex = 10;
			this.label5.Text = "Статус заказа";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.button1.Location = new System.Drawing.Point(519, 346);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 33);
			this.button1.TabIndex = 11;
			this.button1.Text = "Изменить статус";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.button2.Location = new System.Drawing.Point(680, 422);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(63, 25);
			this.button2.TabIndex = 12;
			this.button2.Text = "Выход";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// allOrderTableAdapter
			// 
			this.allOrderTableAdapter.ClearBeforeFill = true;
			// 
			// allPositionTableAdapter
			// 
			this.allPositionTableAdapter.ClearBeforeFill = true;
			// 
			// stateTableAdapter
			// 
			this.stateTableAdapter.ClearBeforeFill = true;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(1, 248);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(223, 24);
			this.label6.TabIndex = 13;
			this.label6.Text = "ФИО Клиента";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxName.Location = new System.Drawing.Point(227, 248);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(269, 23);
			this.textBoxName.TabIndex = 14;
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxPhone.Location = new System.Drawing.Point(227, 277);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.ReadOnly = true;
			this.textBoxPhone.Size = new System.Drawing.Size(269, 23);
			this.textBoxPhone.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(1, 277);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(222, 24);
			this.label7.TabIndex = 15;
			this.label7.Text = "Телефон";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxSum
			// 
			this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxSum.Location = new System.Drawing.Point(227, 306);
			this.textBoxSum.Name = "textBoxSum";
			this.textBoxSum.ReadOnly = true;
			this.textBoxSum.Size = new System.Drawing.Size(269, 23);
			this.textBoxSum.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(1, 306);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(221, 24);
			this.label8.TabIndex = 17;
			this.label8.Text = "Сумма заказа";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxMark
			// 
			this.textBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxMark.Location = new System.Drawing.Point(227, 334);
			this.textBoxMark.Name = "textBoxMark";
			this.textBoxMark.ReadOnly = true;
			this.textBoxMark.Size = new System.Drawing.Size(269, 23);
			this.textBoxMark.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(1, 334);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(222, 24);
			this.label9.TabIndex = 19;
			this.label9.Text = "Марка машины";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxNumber.Location = new System.Drawing.Point(227, 363);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.ReadOnly = true;
			this.textBoxNumber.Size = new System.Drawing.Size(269, 23);
			this.textBoxNumber.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(1, 363);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(222, 24);
			this.label10.TabIndex = 21;
			this.label10.Text = "Номер машины";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxDate
			// 
			this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxDate.Location = new System.Drawing.Point(227, 392);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.ReadOnly = true;
			this.textBoxDate.Size = new System.Drawing.Size(269, 23);
			this.textBoxDate.TabIndex = 24;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(1, 392);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(223, 24);
			this.label11.TabIndex = 23;
			this.label11.Text = "Дата оформления";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxDateState
			// 
			this.textBoxDateState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.textBoxDateState.Location = new System.Drawing.Point(227, 420);
			this.textBoxDateState.Name = "textBoxDateState";
			this.textBoxDateState.ReadOnly = true;
			this.textBoxDateState.Size = new System.Drawing.Size(269, 23);
			this.textBoxDateState.TabIndex = 26;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(1, 420);
			this.label12.Margin = new System.Windows.Forms.Padding(0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(222, 24);
			this.label12.TabIndex = 25;
			this.label12.Text = "Дата смены состояния";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormShowOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(755, 459);
			this.Controls.Add(this.textBoxDateState);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBoxDate);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBoxMark);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxSum);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.MaximizeBox = false;
			this.Name = "FormShowOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Просмотр заказов";
			this.Load += new System.EventHandler(this.FormShowOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.allOrderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAvtoKurs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allPositionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private DataSetAvtoKurs dataSetAvtoKurs;
		private System.Windows.Forms.BindingSource allOrderBindingSource;
		private DataSetAvtoKursTableAdapters.AllOrderTableAdapter allOrderTableAdapter;
		private System.Windows.Forms.BindingSource allPositionBindingSource;
		private DataSetAvtoKursTableAdapters.AllPositionTableAdapter allPositionTableAdapter;
		private System.Windows.Forms.BindingSource stateBindingSource;
		private DataSetAvtoKursTableAdapters.stateTableAdapter stateTableAdapter;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxMark;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxDate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxDateState;
		private System.Windows.Forms.Label label12;
	}
}