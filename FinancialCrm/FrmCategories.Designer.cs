namespace FinancialCrm
{
	partial class FrmCategories
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCategories = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.btnBillsForm = new System.Windows.Forms.Button();
			this.btnSpendings = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kategoriler Formu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1056, 55);
			this.panel2.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnDelete);
			this.panel3.Controls.Add(this.btnAdd);
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.btnList);
			this.panel3.Controls.Add(this.txtCategoryName);
			this.panel3.Controls.Add(this.txtCategoryId);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(250, 87);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(762, 188);
			this.panel3.TabIndex = 10;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(546, 122);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(145, 43);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(217, 122);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(145, 43);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(379, 122);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(145, 43);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(50, 122);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(145, 43);
			this.btnList.TabIndex = 4;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategoryName.Location = new System.Drawing.Point(169, 72);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(522, 30);
			this.txtCategoryName.TabIndex = 3;
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategoryId.Location = new System.Drawing.Point(169, 33);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(522, 30);
			this.txtCategoryId.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(46, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Kategori Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(57, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kategori ID:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Location = new System.Drawing.Point(250, 299);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(762, 259);
			this.panel4.TabIndex = 11;
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
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
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
			// btnSpendings
			// 
			this.btnSpendings.BackColor = System.Drawing.Color.Transparent;
			this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendings.ForeColor = System.Drawing.Color.White;
			this.btnSpendings.Location = new System.Drawing.Point(12, 221);
			this.btnSpendings.Name = "btnSpendings";
			this.btnSpendings.Size = new System.Drawing.Size(182, 42);
			this.btnSpendings.TabIndex = 3;
			this.btnSpendings.Text = "Giderler";
			this.btnSpendings.UseVisualStyleBackColor = false;
			this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(14)))), ((int)(((byte)(209)))));
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.btnSettings);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBankProcesses);
			this.panel1.Controls.Add(this.btnSpendings);
			this.panel1.Controls.Add(this.btnBillsForm);
			this.panel1.Controls.Add(this.btnBanksForm);
			this.panel1.Controls.Add(this.btnCategories);
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(-1, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(202, 585);
			this.panel1.TabIndex = 8;
			// 
			// FrmCategories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 632);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmCategories";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCategories";
			this.Load += new System.EventHandler(this.FrmCategories_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.Button btnBillsForm;
		private System.Windows.Forms.Button btnSpendings;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel1;
	}
}