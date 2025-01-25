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
	}
}
