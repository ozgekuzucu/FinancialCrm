using FinancialCrm.Models;
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
	public partial class FrmSpendings : Form
	{
		public FrmSpendings()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Spendings.ToList();
			dataGridView1.DataSource = values;
		}

		private void FrmSpendings_Load(object sender, EventArgs e)
		{
			var values = db.Spendings.ToList();
			dataGridView1.DataSource = values;

			var values2 = db.Categories.ToList();
			cmbCategoriId.DataSource = values2;
			cmbCategoriId.DisplayMember = "CategoryName";
			cmbCategoriId.ValueMember = "CategoryId";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string spendingTitle = txtSpendingTitle.Text;
			decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
			DateTime spendingDate = DateTime.Parse(dtpSpendingDate.Text);
			Spendings spendings = new Spendings();
			db.Spendings.Add(spendings);
			spendings.SpendingTitle = spendingTitle;
			spendings.SpendingAmount = spendingAmount;
			spendings.SpendingDate = spendingDate;
			spendings.CategoryId =int.Parse( cmbCategoriId.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Harcama Başarılı Bir Şekilde Sisteme Eklendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Spendings.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string spendingTitle = txtSpendingTitle.Text;
			decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
			DateTime spendingDate = DateTime.Parse(dtpSpendingDate.Text);
			int id = int.Parse(txtSpendingId.Text);
			var updatedValue = db.Spendings.Find(id);
			updatedValue.SpendingTitle = spendingTitle;
			updatedValue.SpendingAmount = spendingAmount;
			updatedValue.SpendingDate= spendingDate;
			updatedValue.CategoryId = int.Parse(cmbCategoriId.SelectedValue.ToString());
			db.SaveChanges();
			db.SaveChanges();
			MessageBox.Show("Harcama Başarılı Bir Şekilde Güncellendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values2 = db.Spendings.ToList();
			dataGridView1.DataSource = values2;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtSpendingId.Text);
			var removeValue = db.Spendings.Find(id);
			db.Spendings.Remove(removeValue);
			db.SaveChanges();
			MessageBox.Show("Harcama Başarılı Bir Şekilde Sistemden Silindi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Spendings.ToList();
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

		private void btnBillForm_Click(object sender, EventArgs e)
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

		private void btnCategories_Click_1(object sender, EventArgs e)
		{
			FrmCategories frm = new FrmCategories();
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
