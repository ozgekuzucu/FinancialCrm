namespace FinancialCrm
{
	partial class FrmRegister
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Banka Üye Ol";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.Location = new System.Drawing.Point(133, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(214, 30);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnSignIn
			// 
			this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSignIn.Location = new System.Drawing.Point(133, 136);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(158, 48);
			this.btnSignIn.TabIndex = 4;
			this.btnSignIn.Text = "Kayıt  Ol";
			this.btnSignIn.UseVisualStyleBackColor = true;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUserName.ForeColor = System.Drawing.Color.Black;
			this.txtUserName.Location = new System.Drawing.Point(133, 32);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(214, 30);
			this.txtUserName.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txtPassword);
			this.panel3.Controls.Add(this.btnSignIn);
			this.panel3.Controls.Add(this.txtUserName);
			this.panel3.Location = new System.Drawing.Point(238, 76);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(421, 220);
			this.panel3.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(74, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 24);
			this.label3.TabIndex = 15;
			this.label3.Text = "Şifre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(8, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 24);
			this.label2.TabIndex = 14;
			this.label2.Text = "Kullanıcı Adı:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(14)))), ((int)(((byte)(209)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(-1, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(215, 240);
			this.panel1.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 240);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(687, 55);
			this.panel2.TabIndex = 20;
			// 
			// FrmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 296);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "FrmRegister";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRegister";
			this.Load += new System.EventHandler(this.FrmRegister_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
	}
}