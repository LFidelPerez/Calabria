namespace Calabria.People
{
    partial class eliminados
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMember = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.Names,
            this.Surnames,
            this.Age,
            this.Contacto,
            this.emergencyContact,
            this.isMember});
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Location = new System.Drawing.Point(-6, 97);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(812, 257);
            this.dgvList.TabIndex = 9;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
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
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(316, 68);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(56, 25);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(109, 68);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(182, 20);
            this.txt_search.TabIndex = 14;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(60, 102);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(43, 13);
            this.lbl_search.TabIndex = 19;
            this.lbl_search.Text = "Buscar:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(17, 63);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 25);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(688, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 46);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista de Personas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvList);
            this.Name = "eliminados";
            this.Text = "eliminados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surnames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContact;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMember;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}