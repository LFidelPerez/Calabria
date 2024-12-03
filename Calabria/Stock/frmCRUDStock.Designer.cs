namespace Calabria.Stock
{
	partial class FrmCRUDStock
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(121, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(192, 22);
			this.txtName.TabIndex = 1;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(121, 58);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(192, 22);
			this.txtType.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tipo:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(121, 86);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(192, 22);
			this.txtDescription.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Descripción:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(76, 114);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Guardar";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(157, 114);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Modificar";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(238, 114);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Eliminar";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmCRUDStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 181);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "frmCRUDStock";
			this.Text = "frmStockItem";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
	}
}