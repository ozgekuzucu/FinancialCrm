namespace FinancialCrm
{
	partial class FrmBilling
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnUpdateBill = new System.Windows.Forms.Button();
			this.btnRemoveBill = new System.Windows.Forms.Button();
			this.btnCreateBill = new System.Windows.Forms.Button();
			this.btnBillList = new System.Windows.Forms.Button();
			this.txtBillPeriod = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBillAmount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBillTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBillId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnSpendingsForm = new System.Windows.Forms.Button();
			this.btnBillsForm = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.btnCategoriesForm = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnUpdateBill);
			this.panel2.Controls.Add(this.btnRemoveBill);
			this.panel2.Controls.Add(this.btnCreateBill);
			this.panel2.Controls.Add(this.btnBillList);
			this.panel2.Controls.Add(this.txtBillPeriod);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtBillAmount);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtBillTitle);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtBillId);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(209, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(846, 263);
			this.panel2.TabIndex = 2;
			// 
			// btnUpdateBill
			// 
			this.btnUpdateBill.BackColor = System.Drawing.Color.Gray;
			this.btnUpdateBill.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateBill.ForeColor = System.Drawing.Color.White;
			this.btnUpdateBill.Location = new System.Drawing.Point(650, 195);
			this.btnUpdateBill.Name = "btnUpdateBill";
			this.btnUpdateBill.Size = new System.Drawing.Size(182, 42);
			this.btnUpdateBill.TabIndex = 11;
			this.btnUpdateBill.Text = "Ödeme Güncelle";
			this.btnUpdateBill.UseVisualStyleBackColor = false;
			this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
			// 
			// btnRemoveBill
			// 
			this.btnRemoveBill.BackColor = System.Drawing.Color.Gray;
			this.btnRemoveBill.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRemoveBill.ForeColor = System.Drawing.Color.White;
			this.btnRemoveBill.Location = new System.Drawing.Point(452, 195);
			this.btnRemoveBill.Name = "btnRemoveBill";
			this.btnRemoveBill.Size = new System.Drawing.Size(182, 42);
			this.btnRemoveBill.TabIndex = 10;
			this.btnRemoveBill.Text = "Ödeme Sil";
			this.btnRemoveBill.UseVisualStyleBackColor = false;
			this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
			// 
			// btnCreateBill
			// 
			this.btnCreateBill.BackColor = System.Drawing.Color.Gray;
			this.btnCreateBill.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateBill.ForeColor = System.Drawing.Color.White;
			this.btnCreateBill.Location = new System.Drawing.Point(254, 195);
			this.btnCreateBill.Name = "btnCreateBill";
			this.btnCreateBill.Size = new System.Drawing.Size(182, 42);
			this.btnCreateBill.TabIndex = 9;
			this.btnCreateBill.Text = "Yeni Ödeme";
			this.btnCreateBill.UseVisualStyleBackColor = false;
			this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
			// 
			// btnBillList
			// 
			this.btnBillList.BackColor = System.Drawing.Color.Gray;
			this.btnBillList.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillList.ForeColor = System.Drawing.Color.White;
			this.btnBillList.Location = new System.Drawing.Point(55, 195);
			this.btnBillList.Name = "btnBillList";
			this.btnBillList.Size = new System.Drawing.Size(182, 42);
			this.btnBillList.TabIndex = 8;
			this.btnBillList.Text = "Ödeme Listesi";
			this.btnBillList.UseVisualStyleBackColor = false;
			this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
			// 
			// txtBillPeriod
			// 
			this.txtBillPeriod.BackColor = System.Drawing.Color.Gainsboro;
			this.txtBillPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillPeriod.Location = new System.Drawing.Point(129, 143);
			this.txtBillPeriod.Name = "txtBillPeriod";
			this.txtBillPeriod.Size = new System.Drawing.Size(690, 32);
			this.txtBillPeriod.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(47, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Periyot:";
			// 
			// txtBillAmount
			// 
			this.txtBillAmount.BackColor = System.Drawing.Color.Gainsboro;
			this.txtBillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillAmount.Location = new System.Drawing.Point(129, 105);
			this.txtBillAmount.Name = "txtBillAmount";
			this.txtBillAmount.Size = new System.Drawing.Size(690, 32);
			this.txtBillAmount.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(51, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Miktar:";
			// 
			// txtBillTitle
			// 
			this.txtBillTitle.BackColor = System.Drawing.Color.Gainsboro;
			this.txtBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillTitle.Location = new System.Drawing.Point(129, 67);
			this.txtBillTitle.Name = "txtBillTitle";
			this.txtBillTitle.Size = new System.Drawing.Size(690, 32);
			this.txtBillTitle.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(58, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Başlık:";
			// 
			// txtBillId
			// 
			this.txtBillId.BackColor = System.Drawing.Color.Gainsboro;
			this.txtBillId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillId.Location = new System.Drawing.Point(129, 29);
			this.txtBillId.Name = "txtBillId";
			this.txtBillId.Size = new System.Drawing.Size(690, 32);
			this.txtBillId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ödeme ID:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.panel3.Location = new System.Drawing.Point(209, 269);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(846, 263);
			this.panel3.TabIndex = 3;
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
			this.dataGridView1.Size = new System.Drawing.Size(846, 263);
			this.dataGridView1.TabIndex = 0;
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
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(202, 585);
			this.panel1.TabIndex = 9;
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
			this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click_1);
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
			// FrmBilling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1055, 583);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Name = "FrmBilling";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ödeme & Fatura Formu";
			this.Load += new System.EventHandler(this.FrmBilling_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtBillId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnUpdateBill;
		private System.Windows.Forms.Button btnRemoveBill;
		private System.Windows.Forms.Button btnCreateBill;
		private System.Windows.Forms.Button btnBillList;
		private System.Windows.Forms.TextBox txtBillPeriod;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBillAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBillTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
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