namespace FinancialCrm
{
	partial class FrmSpendings
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtSpendingId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dtpSpendingDate = new System.Windows.Forms.DateTimePicker();
			this.cmbCategoriId = new System.Windows.Forms.ComboBox();
			this.txtSpendingAmount = new System.Windows.Forms.TextBox();
			this.txtSpendingTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnBillForm = new System.Windows.Forms.Button();
			this.btnBillsForm = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
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
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(498, 136);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(158, 35);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(498, 53);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(158, 35);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(498, 94);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(158, 35);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(498, 12);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(158, 35);
			this.btnList.TabIndex = 4;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtSpendingId
			// 
			this.txtSpendingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingId.Location = new System.Drawing.Point(180, 15);
			this.txtSpendingId.Name = "txtSpendingId";
			this.txtSpendingId.Size = new System.Drawing.Size(279, 27);
			this.txtSpendingId.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(103, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Başlık:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(56, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Harcama ID:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Location = new System.Drawing.Point(250, 299);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(762, 259);
			this.panel4.TabIndex = 15;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dtpSpendingDate);
			this.panel3.Controls.Add(this.cmbCategoriId);
			this.panel3.Controls.Add(this.txtSpendingAmount);
			this.panel3.Controls.Add(this.txtSpendingTitle);
			this.panel3.Controls.Add(this.btnDelete);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.btnAdd);
			this.panel3.Controls.Add(this.btnList);
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.txtSpendingId);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(250, 87);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(762, 188);
			this.panel3.TabIndex = 14;
			// 
			// dtpSpendingDate
			// 
			this.dtpSpendingDate.Location = new System.Drawing.Point(180, 118);
			this.dtpSpendingDate.Name = "dtpSpendingDate";
			this.dtpSpendingDate.Size = new System.Drawing.Size(279, 22);
			this.dtpSpendingDate.TabIndex = 16;
			// 
			// cmbCategoriId
			// 
			this.cmbCategoriId.FormattingEnabled = true;
			this.cmbCategoriId.Location = new System.Drawing.Point(181, 146);
			this.cmbCategoriId.Name = "cmbCategoriId";
			this.cmbCategoriId.Size = new System.Drawing.Size(278, 24);
			this.cmbCategoriId.TabIndex = 15;
			// 
			// txtSpendingAmount
			// 
			this.txtSpendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingAmount.Location = new System.Drawing.Point(180, 84);
			this.txtSpendingAmount.Name = "txtSpendingAmount";
			this.txtSpendingAmount.Size = new System.Drawing.Size(279, 27);
			this.txtSpendingAmount.TabIndex = 12;
			// 
			// txtSpendingTitle
			// 
			this.txtSpendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingTitle.Location = new System.Drawing.Point(180, 51);
			this.txtSpendingTitle.Name = "txtSpendingTitle";
			this.txtSpendingTitle.Size = new System.Drawing.Size(279, 27);
			this.txtSpendingTitle.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(82, 139);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 24);
			this.label6.TabIndex = 10;
			this.label6.Text = "Kategori:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(56, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 24);
			this.label4.TabIndex = 9;
			this.label4.Text = "İşlem Tarihi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(96, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Miktar:";
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
			this.label1.Size = new System.Drawing.Size(258, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Harcamalar/Giderler";
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
			// btnBillForm
			// 
			this.btnBillForm.BackColor = System.Drawing.Color.Transparent;
			this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillForm.ForeColor = System.Drawing.Color.White;
			this.btnBillForm.Location = new System.Drawing.Point(12, 221);
			this.btnBillForm.Name = "btnBillForm";
			this.btnBillForm.Size = new System.Drawing.Size(182, 42);
			this.btnBillForm.TabIndex = 3;
			this.btnBillForm.Text = "Giderler";
			this.btnBillForm.UseVisualStyleBackColor = false;
			this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
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
			// btnCategories
			// 
			this.btnCategories.BackColor = System.Drawing.Color.Transparent;
			this.btnCategories.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategories.ForeColor = System.Drawing.Color.White;
			this.btnCategories.Location = new System.Drawing.Point(12, 39);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Size = new System.Drawing.Size(182, 42);
			this.btnCategories.TabIndex = 0;
			this.btnCategories.Text = "Kategoriler";
			this.btnCategories.UseVisualStyleBackColor = false;
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(14)))), ((int)(((byte)(209)))));
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.btnSettings);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBankProcesses);
			this.panel1.Controls.Add(this.btnBillForm);
			this.panel1.Controls.Add(this.btnBillsForm);
			this.panel1.Controls.Add(this.btnBanksForm);
			this.panel1.Controls.Add(this.btnCategories);
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(-1, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(202, 585);
			this.panel1.TabIndex = 12;
			// 
			// FrmSpendings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 632);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmSpendings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmSpendings";
			this.Load += new System.EventHandler(this.FrmSpendings_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtSpendingId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnBillForm;
		private System.Windows.Forms.Button btnBillsForm;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtSpendingAmount;
		private System.Windows.Forms.TextBox txtSpendingTitle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbCategoriId;
		private System.Windows.Forms.DateTimePicker dtpSpendingDate;
	}
}