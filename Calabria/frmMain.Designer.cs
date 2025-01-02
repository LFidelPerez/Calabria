namespace Calabria
{
	partial class frmMain
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnPeople = new System.Windows.Forms.Button();
			this.btn_Workshops = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(602, 351);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 55);
			this.button1.TabIndex = 0;
			this.button1.Text = "Stock";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btnPeople
			// 
			this.btnPeople.Location = new System.Drawing.Point(125, 351);
			this.btnPeople.Name = "btnPeople";
			this.btnPeople.Size = new System.Drawing.Size(123, 55);
			this.btnPeople.TabIndex = 1;
			this.btnPeople.Text = "Personas";
			this.btnPeople.UseVisualStyleBackColor = true;
			this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
			// 
			// btn_Workshops
			// 
			this.btn_Workshops.Location = new System.Drawing.Point(366, 351);
			this.btn_Workshops.Name = "btn_Workshops";
			this.btn_Workshops.Size = new System.Drawing.Size(123, 55);
			this.btn_Workshops.TabIndex = 2;
			this.btn_Workshops.Text = "Talleres";
			this.btn_Workshops.UseVisualStyleBackColor = true;
			this.btn_Workshops.Click += new System.EventHandler(this.btn_Workshops_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Workshops);
			this.Controls.Add(this.btnPeople);
			this.Controls.Add(this.button1);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnPeople;
		private System.Windows.Forms.Button btn_Workshops;
	}
}

