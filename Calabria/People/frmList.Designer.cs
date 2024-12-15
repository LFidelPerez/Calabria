namespace Calabria.People
{
	partial class frmList
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
			this.txt_search = new System.Windows.Forms.TextBox();
			this.lbl_search = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.view = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Surnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emergencyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isMember = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.socialFeeExemption = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.discountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_search
			// 
			this.txt_search.Location = new System.Drawing.Point(158, 68);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(242, 22);
			this.txt_search.TabIndex = 12;
			// 
			// lbl_search
			// 
			this.lbl_search.AutoSize = true;
			this.lbl_search.Location = new System.Drawing.Point(100, 71);
			this.lbl_search.Name = "lbl_search";
			this.lbl_search.Size = new System.Drawing.Size(52, 16);
			this.lbl_search.TabIndex = 11;
			this.lbl_search.Text = "Buscar:";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(12, 64);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 31);
			this.btn_add.TabIndex = 10;
			this.btn_add.Text = "Agregar";
			this.btn_add.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(1464, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(117, 56);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Cerrar";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// dgvList
			// 
			this.dgvList.AllowUserToAddRows = false;
			this.dgvList.AllowUserToDeleteRows = false;
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view,
            this.ItemId,
            this.Names,
            this.Surnames,
            this.Age,
            this.email,
            this.Contacto,
            this.emergencyContact,
            this.birthday,
            this.isMember,
            this.socialFeeExemption,
            this.discountPercent,
            this.Edit});
			this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvList.Location = new System.Drawing.Point(12, 122);
			this.dgvList.Name = "dgvList";
			this.dgvList.ReadOnly = true;
			this.dgvList.RowHeadersWidth = 51;
			this.dgvList.RowTemplate.Height = 24;
			this.dgvList.Size = new System.Drawing.Size(1569, 316);
			this.dgvList.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 39);
			this.label1.TabIndex = 7;
			this.label1.Text = "Lista de Personas";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// view
			// 
			this.view.HeaderText = "Ver";
			this.view.MinimumWidth = 6;
			this.view.Name = "view";
			this.view.ReadOnly = true;
			this.view.Width = 125;
			// 
			// ItemId
			// 
			this.ItemId.HeaderText = "Id";
			this.ItemId.MinimumWidth = 6;
			this.ItemId.Name = "ItemId";
			this.ItemId.ReadOnly = true;
			this.ItemId.Visible = false;
			this.ItemId.Width = 125;
			// 
			// Names
			// 
			this.Names.HeaderText = "Nombres";
			this.Names.MinimumWidth = 6;
			this.Names.Name = "Names";
			this.Names.ReadOnly = true;
			this.Names.Width = 125;
			// 
			// Surnames
			// 
			this.Surnames.HeaderText = "Apellidos";
			this.Surnames.MinimumWidth = 6;
			this.Surnames.Name = "Surnames";
			this.Surnames.ReadOnly = true;
			this.Surnames.Width = 125;
			// 
			// Age
			// 
			this.Age.HeaderText = "Edad";
			this.Age.MinimumWidth = 6;
			this.Age.Name = "Age";
			this.Age.ReadOnly = true;
			this.Age.Width = 125;
			// 
			// email
			// 
			this.email.HeaderText = "E-Mail";
			this.email.MinimumWidth = 6;
			this.email.Name = "email";
			this.email.ReadOnly = true;
			this.email.Width = 125;
			// 
			// Contacto
			// 
			this.Contacto.HeaderText = "Contact";
			this.Contacto.MinimumWidth = 6;
			this.Contacto.Name = "Contacto";
			this.Contacto.ReadOnly = true;
			this.Contacto.Width = 125;
			// 
			// emergencyContact
			// 
			this.emergencyContact.HeaderText = "Nº Emergencia";
			this.emergencyContact.MinimumWidth = 6;
			this.emergencyContact.Name = "emergencyContact";
			this.emergencyContact.ReadOnly = true;
			this.emergencyContact.Width = 125;
			// 
			// birthday
			// 
			this.birthday.HeaderText = "Fecha de Nacimiento";
			this.birthday.MinimumWidth = 6;
			this.birthday.Name = "birthday";
			this.birthday.ReadOnly = true;
			this.birthday.Width = 125;
			// 
			// isMember
			// 
			this.isMember.HeaderText = "Socio";
			this.isMember.MinimumWidth = 6;
			this.isMember.Name = "isMember";
			this.isMember.ReadOnly = true;
			this.isMember.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.isMember.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.isMember.Width = 125;
			// 
			// socialFeeExemption
			// 
			this.socialFeeExemption.HeaderText = "Excento Cuota Social";
			this.socialFeeExemption.MinimumWidth = 6;
			this.socialFeeExemption.Name = "socialFeeExemption";
			this.socialFeeExemption.ReadOnly = true;
			this.socialFeeExemption.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.socialFeeExemption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.socialFeeExemption.Width = 125;
			// 
			// discountPercent
			// 
			this.discountPercent.HeaderText = "% Descuento";
			this.discountPercent.MinimumWidth = 6;
			this.discountPercent.Name = "discountPercent";
			this.discountPercent.ReadOnly = true;
			this.discountPercent.Width = 125;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "Editar";
			this.Edit.MinimumWidth = 6;
			this.Edit.Name = "Edit";
			this.Edit.ReadOnly = true;
			this.Edit.Text = "Editar";
			this.Edit.UseColumnTextForButtonValue = true;
			this.Edit.Width = 125;
			// 
			// frmList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1601, 450);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.lbl_search);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvList);
			this.Controls.Add(this.label1);
			this.Name = "frmList";
			this.Text = "frmList";
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Label lbl_search;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewButtonColumn view;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Names;
		private System.Windows.Forms.DataGridViewTextBoxColumn Surnames;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
		private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContact;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isMember;
		private System.Windows.Forms.DataGridViewCheckBoxColumn socialFeeExemption;
		private System.Windows.Forms.DataGridViewTextBoxColumn discountPercent;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
	}
}