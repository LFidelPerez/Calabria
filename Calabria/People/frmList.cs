using Calabria.Base.Forms;
using Calabria.Models;
using Calabria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.People
{
	public partial class frmList : BaseForm
	{
		private frmCRUD _frmCRUD;
		private readonly PersonDataService _dataService = new PersonDataService();
		private People.eliminados _Eliminados;
		public frmList()
		{
			InitializeComponent();
			Eliminados.Click += new EventHandler(Eliminados_Click);

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			_frmCRUD = new frmCRUD(CRUDStateEnum.Create, null, _dataService);
			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList(null);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmList_Load(object sender, EventArgs e)
		{
			LoadDataList(null);
		}

		private void LoadDataList(List<Person> dataList)
		{
			dgvList.Rows.Clear();

			if (dataList == null)
			{
				dataList = _dataService.GetDataListItems();
			}

			foreach (Person item in dataList)
			{
				if (!item.IsDeleted)
				{
					dgvList.Rows.Add(
						item.Id,
						item.Names,
						item.Surnames,
						item.Age,
						item.Phone,
						item.EmergencyContact,
						item.IsMember
					);
				}
			}
		}

		private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var item = dgvList.Rows[e.RowIndex];
			var id = int.Parse(item.Cells[0].Value.ToString());
			var person = _dataService.FindItemInList(id);

			_frmCRUD = new frmCRUD(CRUDStateEnum.Update, person, _dataService);

			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList(null);
			}
		}

		private void FilterBySearch()
		{
			if (txt_search.Text.Length >= 3)
			{
				var filteredList = _dataService.FilterItemsByNames(txt_search.Text);
				LoadDataList(filteredList);
			}
			else
			{
				LoadDataList(null);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FilterBySearch();
		}

		private void txt_search_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				FilterBySearch();
			}
		}

		
		

        private void Eliminados_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            dgvList.Rows.Clear();

            //traer las lista de  datos del servicio
            var dataList = _dataService.GetDataListItems();


            // Si la lista de datos sigue siendo nula o está vacía, mostrar un mensaje de información
            if (dataList == null || dataList.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Iterar sobre cada elemento en la lista de datos
            foreach (Person item in dataList)
            {
                // Si el elemento está marcado como eliminado, agregarlo al DataGridView
                if (item.IsDeleted)
                {
                    dgvList.Rows.Add(
                        item.Id,                // Agregar ID
                        item.Names,             // Agregar Nombres
                        item.Surnames,          // Agregar Apellidos
                        item.Age,               // Agregar Edad
                        item.Phone,             // Agregar Teléfono
                        item.EmergencyContact,  // Agregar Contacto de Emergencia
                        item.IsMember           // Agregar si es Miembro
                    );
                }
            }
        }
    }
}