namespace Calabria.Workshop
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
			this.btn_Search = new System.Windows.Forms.Button();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.lbl_search = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tallerista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Instagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Resumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(406, 64);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(75, 31);
			this.btn_Search.TabIndex = 20;
			this.btn_Search.Text = "Buscar";
			this.btn_Search.UseVisualStyleBackColor = true;
			// 
			// txt_search
			// 
			this.txt_search.Location = new System.Drawing.Point(158, 68);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(242, 22);
			this.txt_search.TabIndex = 14;
			// 
			// lbl_search
			// 
			this.lbl_search.AutoSize = true;
			this.lbl_search.Location = new System.Drawing.Point(100, 71);
			this.lbl_search.Name = "lbl_search";
			this.lbl_search.Size = new System.Drawing.Size(52, 16);
			this.lbl_search.TabIndex = 19;
			this.lbl_search.Text = "Buscar:";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(12, 64);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 31);
			this.btn_add.TabIndex = 18;
			this.btn_add.Text = "Agregar";
			this.btn_add.UseVisualStyleBackColor = true;
			// 
			// btn_Close
			// 
			this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Close.Location = new System.Drawing.Point(978, 12);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(117, 56);
			this.btn_Close.TabIndex = 17;
			this.btn_Close.Text = "Cerrar";
			this.btn_Close.UseVisualStyleBackColor = true;
			// 
			// dgvList
			// 
			this.dgvList.AllowUserToAddRows = false;
			this.dgvList.AllowUserToDeleteRows = false;
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.Name,
            this.Time,
            this.Day,
            this.Age,
            this.Materials,
            this.StartDate,
            this.Classroom,
            this.Tallerista,
            this.Instagram,
            this.Resumen});
			this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvList.Location = new System.Drawing.Point(12, 122);
			this.dgvList.Name = "dgvList";
			this.dgvList.ReadOnly = true;
			this.dgvList.RowHeadersWidth = 51;
			this.dgvList.RowTemplate.Height = 24;
			this.dgvList.Size = new System.Drawing.Size(1083, 316);
			this.dgvList.TabIndex = 16;
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(12, 9);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(267, 39);
			this.lbl_Title.TabIndex = 15;
			this.lbl_Title.Text = "Lista de Talleres";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			// Name
			// 
			this.Name.HeaderText = "Nombre";
			this.Name.MinimumWidth = 6;
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			this.Name.Width = 125;
			// 
			// Time
			// 
			this.Time.HeaderText = "Horario";
			this.Time.MinimumWidth = 6;
			this.Time.Name = "Time";
			this.Time.ReadOnly = true;
			this.Time.Width = 125;
			// 
			// Day
			// 
			this.Day.HeaderText = "Dia";
			this.Day.MinimumWidth = 6;
			this.Day.Name = "Day";
			this.Day.ReadOnly = true;
			this.Day.Width = 125;
			// 
			// Age
			// 
			this.Age.HeaderText = "Edad";
			this.Age.MinimumWidth = 6;
			this.Age.Name = "Age";
			this.Age.ReadOnly = true;
			this.Age.Width = 125;
			// 
			// Materials
			// 
			this.Materials.HeaderText = "Materiales";
			this.Materials.MinimumWidth = 6;
			this.Materials.Name = "Materials";
			this.Materials.ReadOnly = true;
			this.Materials.Width = 125;
			// 
			// StartDate
			// 
			this.StartDate.HeaderText = "Fecha Inicio";
			this.StartDate.MinimumWidth = 6;
			this.StartDate.Name = "StartDate";
			this.StartDate.ReadOnly = true;
			this.StartDate.Width = 125;
			// 
			// Classroom
			// 
			this.Classroom.HeaderText = "Aula";
			this.Classroom.MinimumWidth = 6;
			this.Classroom.Name = "Classroom";
			this.Classroom.ReadOnly = true;
			this.Classroom.Width = 125;
			// 
			// Tallerista
			// 
			this.Tallerista.HeaderText = "Workshopper";
			this.Tallerista.MinimumWidth = 6;
			this.Tallerista.Name = "Tallerista";
			this.Tallerista.ReadOnly = true;
			this.Tallerista.Width = 125;
			// 
			// Instagram
			// 
			this.Instagram.HeaderText = "Instagram";
			this.Instagram.MinimumWidth = 6;
			this.Instagram.Name = "Instagram";
			this.Instagram.ReadOnly = true;
			this.Instagram.Width = 125;
			// 
			// Resumen
			// 
			this.Resumen.HeaderText = "Summary";
			this.Resumen.MinimumWidth = 6;
			this.Resumen.Name = "Resumen";
			this.Resumen.ReadOnly = true;
			this.Resumen.Width = 125;
			// 
			// frmList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 450);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.lbl_search);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.dgvList);
			this.Controls.Add(this.lbl_Title);
			this.Text = "frmList";
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Label lbl_search;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time;
		private System.Windows.Forms.DataGridViewTextBoxColumn Day;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Materials;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Classroom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tallerista;
		private System.Windows.Forms.DataGridViewTextBoxColumn Instagram;
		private System.Windows.Forms.DataGridViewTextBoxColumn Resumen;
	}
}