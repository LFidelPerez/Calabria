namespace Calabria.Stock.Invoices
{
	partial class FrmCRUD
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.dgv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Proveedor";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(97, 328);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Guardar";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(178, 328);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Modificar";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(259, 328);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Eliminar";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// cmbType
			// 
			this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(122, 101);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(200, 24);
			this.cmbType.TabIndex = 2;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(340, 328);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(133, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(98, 29);
			this.lblTitle.TabIndex = 10;
			this.lblTitle.Text = "Factura";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(71, 45);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(45, 16);
			this.lblDate.TabIndex = 11;
			this.lblDate.Text = "Fecha";
			// 
			// dtpInvoiceDate
			// 
			this.dtpInvoiceDate.Location = new System.Drawing.Point(122, 45);
			this.dtpInvoiceDate.Name = "dtpInvoiceDate";
			this.dtpInvoiceDate.Size = new System.Drawing.Size(200, 22);
			this.dtpInvoiceDate.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Nº Factura";
			// 
			// txtInvoiceNumber
			// 
			this.txtInvoiceNumber.Location = new System.Drawing.Point(121, 73);
			this.txtInvoiceNumber.Name = "txtInvoiceNumber";
			this.txtInvoiceNumber.Size = new System.Drawing.Size(201, 22);
			this.txtInvoiceNumber.TabIndex = 14;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(371, 98);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(60, 22);
			this.numericUpDown1.TabIndex = 16;
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(13, 131);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(542, 150);
			this.dgv.TabIndex = 17;
			// 
			// FrmCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(590, 363);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.txtInvoiceNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpInvoiceDate);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label2);
			this.Name = "FrmCRUD";
			this.Text = "frmStockItem";
			this.Load += new System.EventHandler(this.FrmCRUDStock_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtInvoiceNumber;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DataGridView dgv;
	}
}