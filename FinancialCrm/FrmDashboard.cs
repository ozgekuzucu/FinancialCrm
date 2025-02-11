﻿using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmDashboard : Form
	{
		public FrmDashboard()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		int count = 0;

		private void FrmDashboard_Load(object sender, EventArgs e)
		{
			var totalBalance = db.Banks.Sum(x=>x.BankBalance);
			lblTotalBalance.Text = totalBalance.ToString()+" ₺";

			var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).Select(y=>y.Amount).FirstOrDefault(); ;
			lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

			//chart1 kodları
			var bankData = db.Banks.Select(x => new
			{
				x.BankTitle,
				x.BankBalance
			}).ToList();
			chart1.Series.Clear();
			var series = chart1.Series.Add("Series1");
			foreach (var item in bankData)
			{
				series.Points.AddXY(item.BankTitle, item.BankBalance);
			}

			//chart2 kodları

			var billData = db.Bills.Select(x => new
			{
				x.BillTitle,
				x.BillAmount
			}).ToList();
			chart2.Series.Clear();
			var series2 = chart2.Series.Add("Faturalar");
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
			foreach(var item in billData)
			{
				series2.Points.AddXY(item.BillTitle, item.BillAmount);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count++;
			if (count % 4 == 1)
			{
				var billTitle = db.Bills.Where(x=>x.BillTitle=="Elektrik Faturası").Select(y=>y.BillAmount).FirstOrDefault();
				lblBillTitle.Text = "Elektrik Faturası";
				lblBillAmount.Text = billTitle.ToString() + " ₺";
			}
			if (count % 4 == 2)
			{
				var billTitle = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBillTitle.Text = "Doğalgaz Faturası";
				lblBillAmount.Text = billTitle.ToString() + " ₺";
			}
			if (count % 4 == 3)
			{
				var billTitle = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBillTitle.Text = "Su Faturası";
				lblBillAmount.Text = billTitle.ToString() + " ₺";
			}
			if (count % 4 == 0)
			{
				var billTitle = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBillTitle.Text = "İnternet Faturası";
				lblBillAmount.Text = billTitle.ToString() + " ₺";
			}
			
		}

		private void btnBanksForm_Click(object sender, EventArgs e)
		{
			FrmBanks frm = new FrmBanks();
			frm.Show();
			this.Hide();
		}

		private void btnCategoriesForm_Click(object sender, EventArgs e)
		{
			FrmCategories frm = new FrmCategories();
			frm.Show();
			this.Hide();

		}

		private void btnBillsForm_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling();
			frm.Show();
			this.Hide();
		}

		private void btnSpendingsForm_Click(object sender, EventArgs e)
		{
			FrmSpendings frm = new FrmSpendings();
			frm.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			FrmBankProcesses frm = new FrmBankProcesses();
			frm.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
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

		private void btnSignOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmLogin frm = new FrmLogin();
			frm.Show();
		}
	}
}
