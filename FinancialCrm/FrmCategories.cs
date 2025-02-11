﻿using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
	public partial class FrmCategories : Form
	{
		public FrmCategories()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		private void FrmCategories_Load(object sender, EventArgs e)
		{
			var values = db.Categories.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Categories.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string categoryName =txtCategoryName.Text;
			Categories categories = new Categories();
			categories.CategoryName = categoryName;
			db.Categories.Add(categories);
			db.SaveChanges();
			MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Categories.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string categoryName = txtCategoryName.Text;
			int id = int.Parse(txtCategoryId.Text);
			var values = db.Categories.Find(id);
			values.CategoryName = categoryName;
			db.SaveChanges();
			MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values2 = db.Categories.ToList();
			dataGridView1.DataSource = values2;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var removeValue= db.Categories.Find(id);
			db.Categories.Remove(removeValue);
			db.SaveChanges();
			MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemden Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Categories.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frm = new FrmCategories();
			frm.Show();
			this.Hide();
		}

		private void btnBanksForm_Click(object sender, EventArgs e)
		{
			FrmBanks frm = new FrmBanks();
			frm.Show();
			this.Hide();
		}

		private void btnBillsForm_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling();	
			frm.Show();
			this.Hide();
		}

		private void btnSpendings_Click(object sender, EventArgs e)
		{
			FrmSpendings frm = new FrmSpendings();
			frm.Show();
			this.Hide();
		}

		private void btnBankProcesses_Click(object sender, EventArgs e)
		{
			FrmBankProcesses frm = new FrmBankProcesses();
			frm.Show();
			this.Hide();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard();
			frm.Show();
			this.Hide();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			FrmSettings frm = new FrmSettings();	
			frm.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmLogin frm = new FrmLogin();
			frm.Show();
		}
	}
}
