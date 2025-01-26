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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		private void btnSignIn_Click(object sender, EventArgs e)
		{
			var sorgu = from x in db.Admins where x.Username == txtUserName.Text && x.Password == txtPassword.Text select x;
			if (sorgu != null)
			{
				FrmDashboard frm = new FrmDashboard();
				frm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Hatalı Giriş");
			}
		}

		private void lblSignUp_Click(object sender, EventArgs e)
		{
			FrmRegister frm = new FrmRegister();
			frm.Show();
			this.Hide();
		}
	}
}
