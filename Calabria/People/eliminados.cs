using Calabria.Base.Forms;
using Calabria.Models;
using Calabria.Services.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.People
{

    public partial class eliminados : BaseForm
    {
        private frmCRUD _frmCRUD;
        private readonly PersonDataService _dataService = new PersonDataService();
        public eliminados()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDataList(null); // Cargar datos al iniciar el formulario
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataList(List<Person> dataList)
        {
            // Limpiar todas las filas del DataGridView
            dgvList.Rows.Clear();

            // Si la lista de datos es nula, obtener los datos del servicio de datos
            if (dataList == null)
            {
                dataList = _dataService.GetDataListItems();
            }

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
        private void InitializeDataGridView()
        {
            dgvList.Columns.Clear();
            dgvList.Columns.Add("Id", "ID");
            dgvList.Columns.Add("Names", "Nombres");
            dgvList.Columns.Add("Surnames", "Apellidos");
            dgvList.Columns.Add("Age", "Edad");
            dgvList.Columns.Add("Phone", "Teléfono");
            dgvList.Columns.Add("EmergencyContact", "Contacto de Emergencia");
            dgvList.Columns.Add("IsMember", "Es Miembro");
        }

    }
}
