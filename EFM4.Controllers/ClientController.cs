using EFM4.Models.Dao;
using EFM4.Models.Entity;
using EFM4.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador del mantenimiento de Clientes
    /// </summary>
    public class ClientController {
        private readonly DaoClient _dao;

        public FormClient View { get; set; }

        public ClientController() {
            _dao = new DaoClient();
            View = new FormClient();
            View.Shown += View_Shown;
            View.buttonRefresh.Click += ButtonRefresh_Click;
            View.buttonAdd.Click += ButtonAdd_Click;
            View.buttonEdit.Click += ButtonEdit_Click;
            View.buttonDelete.Click += ButtonDelete_Click;
        }

        /// <summary>
        /// Permite recargar los datos de los clientes
        /// </summary>
        private void LoadClients() {
            List<Client> clients = _dao.GetAll();
            View.dataGridViewClients.DataSource = clients;
        }

        /// <summary>
        /// Carga los datos existentes al iniciar la ventana
        /// </summary>
        private void View_Shown(object? sender, EventArgs e) {
            LoadClients();
        }

        /// <summary>
        /// Acción de recargar datos
        /// </summary>
        private void ButtonRefresh_Click(object? sender, EventArgs e) {
            LoadClients();
        }

        /// <summary>
        /// Acción para agregar un nuevo registro
        /// </summary>
        private void ButtonAdd_Click(object? sender, EventArgs e) {
            ClientDialogController dialogController = new ClientDialogController();
            DialogResult dialogResult = dialogController.View.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            try {
                if (_dao.Insert(dialogController.View.Data)) {
                    View.ShowMessage("Cliente agregado exitosamente", MessageType.INFORMATION);
                    LoadClients();
                }
            } catch (Exception ex) {
                _ = ex;
                View.ShowMessage("Ha ocurrido un error inesperado al tratar de agregar un nuevo cliente. Favor intente nuevamente", MessageType.ERROR);
            }
        }

        /// <summary>
        /// Acción para modificar un registro
        /// </summary>
        private void ButtonEdit_Click(object? sender, EventArgs e) {
            if (View.dataGridViewClients.CurrentRow != null && 
                View.dataGridViewClients.CurrentRow.Cells[0].Value is int id &&
                View.dataGridViewClients.CurrentRow.Cells[1].Value is string name &&
                View.dataGridViewClients.CurrentRow.Cells[2].Value is string surname) {
                Client data = new Client(id, name, surname);
                ClientDialogController dialogController = new ClientDialogController(data);
                DialogResult dialogResult = dialogController.View.ShowDialog();
                if (dialogResult != DialogResult.OK) return;
                try {
                    if (_dao.Update(dialogController.View.Data)) {
                        View.ShowMessage("Cliente actualizado exitosamente", MessageType.INFORMATION);
                        LoadClients();
                    }
                } catch (Exception ex) {
                    _ = ex;
                    View.ShowMessage("Ha ocurrido un error inesperado al tratar de actualizar el cliente seleccionado. Favor intente nuevamente", MessageType.ERROR);
                }
            }
        }

        /// <summary>
        /// Acción para borrar un registro
        /// </summary>
        private void ButtonDelete_Click(object? sender, EventArgs e) {
            if (View.dataGridViewClients.CurrentRow != null &&
                View.dataGridViewClients.CurrentRow.Cells[0].Value is int id) {
                try {
                    if (_dao.Delete(id)) {
                        View.ShowMessage("Cliente eliminado exitosamente", MessageType.INFORMATION);
                        LoadClients();
                    }
                } catch (Exception ex) {
                    _ = ex;
                    View.ShowMessage("Ha ocurrido un error inesperado al tratar de actualizar el cliente seleccionado. Favor intente nuevamente", MessageType.ERROR);
                }
            }
        }
    }
}
