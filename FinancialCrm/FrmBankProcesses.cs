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
	public partial class FrmBankProcesses : Form
	{
		public FrmBankProcesses()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		private void FrmBankProcesses_Load(object sender, EventArgs e)
		{
			var values = db.BankProcesses.ToList();
			dataGridView1.DataSource = values;

			var values2 = db.Banks.ToList();
			cmbBankType.DataSource = values2;
			cmbBankType.DisplayMember = "BankTitle";
			cmbBankType.ValueMember = "BankaId";
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.BankProcesses.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string descriptipn = txtBankProcessDescription.Text;
			DateTime processDate = DateTime.Parse(dtpBankProcessDate.Text);
			string processType = txtBankProcessType.Text;
			decimal amount = decimal.Parse(txtBankProcessAmount.Text);	
			BankProcesses bankProcesses = new BankProcesses();
			db.BankProcesses.Add(bankProcesses);
			bankProcesses.Description = descriptipn;
			bankProcesses.ProcessDate = processDate;
			bankProcesses.ProcessType = processType;
			bankProcesses.Amount = amount;
			bankProcesses.BankId = int.Parse(cmbBankType.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Banka Harekeeti Başarılı Bir Şekilde Sisteme Eklendi", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.BankProcesses.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string descriptipn = txtBankProcessDescription.Text;
			DateTime processDate = DateTime.Parse(dtpBankProcessDate.Text);
			string processType = txtBankProcessType.Text;
			decimal amount = decimal.Parse(txtBankProcessAmount.Text);

			int id = int.Parse(txtBankProcessId.Text);
			var updatedValue = db.BankProcesses.Find(id);
			updatedValue.Description = descriptipn;
			updatedValue.ProcessDate = processDate;
			updatedValue.ProcessType = processType;
			updatedValue.Amount = amount;
			updatedValue.BankId = int.Parse(cmbBankType.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Banka Hareketi Başarılı Bir Şekilde Güncellendi", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values2 = db.BankProcesses.ToList();
			dataGridView1.DataSource = values2;
		}
	}
}
