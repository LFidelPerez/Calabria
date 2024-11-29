﻿namespace Calabria.Stock
{
	partial class frmStockItemList
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
			this.dgvIStockitems = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvIStockitems)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(286, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lista de Items";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dgvIStockitems
			// 
			this.dgvIStockitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIStockitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.ItemType,
            this.ItemDescription,
            this.Edit,
            this.Delete});
			this.dgvIStockitems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvIStockitems.Location = new System.Drawing.Point(0, 0);
			this.dgvIStockitems.Name = "dgvIStockitems";
			this.dgvIStockitems.RowHeadersWidth = 51;
			this.dgvIStockitems.RowTemplate.Height = 24;
			this.dgvIStockitems.Size = new System.Drawing.Size(1252, 450);
			this.dgvIStockitems.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1123, 382);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 56);
			this.button1.TabIndex = 3;
			this.button1.Text = "Cerrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ItemId
			// 
			this.ItemId.HeaderText = "Id";
			this.ItemId.MinimumWidth = 6;
			this.ItemId.Name = "ItemId";
			this.ItemId.Visible = false;
			this.ItemId.Width = 125;
			// 
			// ItemName
			// 
			this.ItemName.HeaderText = "Nombre";
			this.ItemName.MinimumWidth = 6;
			this.ItemName.Name = "ItemName";
			this.ItemName.Width = 125;
			// 
			// ItemType
			// 
			this.ItemType.HeaderText = "Tipo";
			this.ItemType.MinimumWidth = 6;
			this.ItemType.Name = "ItemType";
			this.ItemType.Width = 125;
			// 
			// ItemDescription
			// 
			this.ItemDescription.HeaderText = "Descripcion";
			this.ItemDescription.MinimumWidth = 6;
			this.ItemDescription.Name = "ItemDescription";
			this.ItemDescription.Width = 125;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "Editar";
			this.Edit.MinimumWidth = 6;
			this.Edit.Name = "Edit";
			this.Edit.Text = "Editar";
			this.Edit.UseColumnTextForButtonValue = true;
			this.Edit.Width = 125;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Eliminar";
			this.Delete.MinimumWidth = 6;
			this.Delete.Name = "Delete";
			this.Delete.Text = "Eliminar";
			this.Delete.ToolTipText = "Eliminar";
			this.Delete.Width = 125;
			// 
			// frmStockItemList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1252, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvIStockitems);
			this.Controls.Add(this.label1);
			this.Name = "frmStockItemList";
			this.Text = "StockItemList";
			this.Load += new System.EventHandler(this.FrmStockItemList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvIStockitems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvIStockitems;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}