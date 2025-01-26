namespace FinancialCrm
{
	partial class FrmBankProcesses
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmbBankType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBankProcessType = new System.Windows.Forms.TextBox();
			this.dtpBankProcessDate = new System.Windows.Forms.DateTimePicker();
			this.txtBankProcessAmount = new System.Windows.Forms.TextBox();
			this.txtBankProcessDescription = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtBankProcessId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnSpendingsForm = new System.Windows.Forms.Button();
			this.btnBillsForm = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.btnCategoriesForm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(762, 259);
			this.dataGridView1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Location = new System.Drawing.Point(250, 334);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(762, 259);
			this.panel4.TabIndex = 15;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1056, 55);
			this.panel2.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Banka Hareketleri";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cmbBankType);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.txtBankProcessType);
			this.panel3.Controls.Add(this.dtpBankProcessDate);
			this.panel3.Controls.Add(this.txtBankProcessAmount);
			this.panel3.Controls.Add(this.txtBankProcessDescription);
			this.panel3.Controls.Add(this.btnDelete);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.btnAdd);
			this.panel3.Controls.Add(this.btnList);
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.txtBankProcessId);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(250, 87);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(762, 224);
			this.panel3.TabIndex = 15;
			// 
			// cmbBankType
			// 
			this.cmbBankType.FormattingEnabled = true;
			this.cmbBankType.Location = new System.Drawing.Point(166, 188);
			this.cmbBankType.Name = "cmbBankType";
			this.cmbBankType.Size = new System.Drawing.Size(281, 24);
			this.cmbBankType.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(97, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 24);
			this.label7.TabIndex = 17;
			this.label7.Text = "Banka:";
			// 
			// txtBankProcessType
			// 
			this.txtBankProcessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBankProcessType.Location = new System.Drawing.Point(168, 116);
			this.txtBankProcessType.Name = "txtBankProcessType";
			this.txtBankProcessType.Size = new System.Drawing.Size(279, 27);
			this.txtBankProcessType.TabIndex = 16;
			// 
			// dtpBankProcessDate
			// 
			this.dtpBankProcessDate.Location = new System.Drawing.Point(168, 85);
			this.dtpBankProcessDate.Name = "dtpBankProcessDate";
			this.dtpBankProcessDate.Size = new System.Drawing.Size(279, 22);
			this.dtpBankProcessDate.TabIndex = 16;
			// 
			// txtBankProcessAmount
			// 
			this.txtBankProcessAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBankProcessAmount.Location = new System.Drawing.Point(166, 152);
			this.txtBankProcessAmount.Name = "txtBankProcessAmount";
			this.txtBankProcessAmount.Size = new System.Drawing.Size(279, 27);
			this.txtBankProcessAmount.TabIndex = 12;
			// 
			// txtBankProcessDescription
			// 
			this.txtBankProcessDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBankProcessDescription.Location = new System.Drawing.Point(167, 46);
			this.txtBankProcessDescription.Name = "txtBankProcessDescription";
			this.txtBankProcessDescription.Size = new System.Drawing.Size(279, 27);
			this.txtBankProcessDescription.TabIndex = 11;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(512, 159);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(158, 35);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(65, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 24);
			this.label6.TabIndex = 10;
			this.label6.Text = "İşlem Türü:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(97, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Miktar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(57, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 24);
			this.label4.TabIndex = 9;
			this.label4.Text = "İşlem Tarihi:";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(512, 76);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(158, 35);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(512, 35);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(158, 35);
			this.btnList.TabIndex = 4;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(512, 117);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(158, 35);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtBankProcessId
			// 
			this.txtBankProcessId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBankProcessId.Location = new System.Drawing.Point(167, 10);
			this.txtBankProcessId.Name = "txtBankProcessId";
			this.txtBankProcessId.Size = new System.Drawing.Size(279, 27);
			this.txtBankProcessId.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(77, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Açıklama:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(30, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Banka İşlem ID:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(14)))), ((int)(((byte)(209)))));
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.btnSettings);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBankProcesses);
			this.panel1.Controls.Add(this.btnSpendingsForm);
			this.panel1.Controls.Add(this.btnBillsForm);
			this.panel1.Controls.Add(this.btnBanksForm);
			this.panel1.Controls.Add(this.btnCategoriesForm);
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(202, 585);
			this.panel1.TabIndex = 16;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(12, 468);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(182, 42);
			this.button6.TabIndex = 7;
			this.button6.Text = "Çıkış Yap";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.BackColor = System.Drawing.Color.Transparent;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSettings.ForeColor = System.Drawing.Color.White;
			this.btnSettings.Location = new System.Drawing.Point(12, 408);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(182, 42);
			this.btnSettings.TabIndex = 6;
			this.btnSettings.Text = "Ayarlar";
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.Location = new System.Drawing.Point(12, 348);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(182, 42);
			this.btnDashboard.TabIndex = 5;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.UseVisualStyleBackColor = false;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnBankProcesses
			// 
			this.btnBankProcesses.BackColor = System.Drawing.Color.Transparent;
			this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
			this.btnBankProcesses.Location = new System.Drawing.Point(12, 286);
			this.btnBankProcesses.Name = "btnBankProcesses";
			this.btnBankProcesses.Size = new System.Drawing.Size(182, 42);
			this.btnBankProcesses.TabIndex = 4;
			this.btnBankProcesses.Text = "Banka Hareketleri";
			this.btnBankProcesses.UseVisualStyleBackColor = false;
			this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
			// 
			// btnSpendingsForm
			// 
			this.btnSpendingsForm.BackColor = System.Drawing.Color.Transparent;
			this.btnSpendingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendingsForm.ForeColor = System.Drawing.Color.White;
			this.btnSpendingsForm.Location = new System.Drawing.Point(12, 221);
			this.btnSpendingsForm.Name = "btnSpendingsForm";
			this.btnSpendingsForm.Size = new System.Drawing.Size(182, 42);
			this.btnSpendingsForm.TabIndex = 3;
			this.btnSpendingsForm.Text = "Giderler";
			this.btnSpendingsForm.UseVisualStyleBackColor = false;
			this.btnSpendingsForm.Click += new System.EventHandler(this.btnSpendingsForm_Click);
			// 
			// btnBillsForm
			// 
			this.btnBillsForm.BackColor = System.Drawing.Color.Transparent;
			this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillsForm.ForeColor = System.Drawing.Color.White;
			this.btnBillsForm.Location = new System.Drawing.Point(12, 161);
			this.btnBillsForm.Name = "btnBillsForm";
			this.btnBillsForm.Size = new System.Drawing.Size(182, 42);
			this.btnBillsForm.TabIndex = 2;
			this.btnBillsForm.Text = "Faturalar";
			this.btnBillsForm.UseVisualStyleBackColor = false;
			this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
			// 
			// btnBanksForm
			// 
			this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
			this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanksForm.ForeColor = System.Drawing.Color.White;
			this.btnBanksForm.Location = new System.Drawing.Point(12, 99);
			this.btnBanksForm.Name = "btnBanksForm";
			this.btnBanksForm.Size = new System.Drawing.Size(182, 42);
			this.btnBanksForm.TabIndex = 1;
			this.btnBanksForm.Text = "Bankalar";
			this.btnBanksForm.UseVisualStyleBackColor = false;
			this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
			// 
			// btnCategoriesForm
			// 
			this.btnCategoriesForm.BackColor = System.Drawing.Color.Transparent;
			this.btnCategoriesForm.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCategoriesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategoriesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategoriesForm.ForeColor = System.Drawing.Color.White;
			this.btnCategoriesForm.Location = new System.Drawing.Point(12, 39);
			this.btnCategoriesForm.Name = "btnCategoriesForm";
			this.btnCategoriesForm.Size = new System.Drawing.Size(182, 42);
			this.btnCategoriesForm.TabIndex = 0;
			this.btnCategoriesForm.Text = "Kategoriler";
			this.btnCategoriesForm.UseVisualStyleBackColor = false;
			this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click);
			// 
			// FrmBankProcesses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 632);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Name = "FrmBankProcesses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmBankProcesses";
			this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtBankProcessType;
		private System.Windows.Forms.DateTimePicker dtpBankProcessDate;
		private System.Windows.Forms.TextBox txtBankProcessAmount;
		private System.Windows.Forms.TextBox txtBankProcessDescription;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtBankProcessId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbBankType;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnSpendingsForm;
		private System.Windows.Forms.Button btnBillsForm;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.Button btnCategoriesForm;
	}
}