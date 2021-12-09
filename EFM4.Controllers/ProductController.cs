using EFM4.Models.Dao;
using EFM4.Models.Entity;
using EFM4.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador del mantenimiento de productos
    /// </summary>
    public class ProductController {
        private readonly DaoProduct _dao;

        public FormProduct View { get; set; }

        public ProductController() {
            _dao = new DaoProduct();
            View = new FormProduct();
            View.Shown += View_Shown;
            View.buttonRefresh.Click += ButtonRefresh_Click;
            View.buttonAdd.Click += ButtonAdd_Click;
            View.buttonEdit.Click += ButtonEdit_Click;
            View.buttonDelete.Click += ButtonDelete_Click;
        }

        /// <summary>
        /// Permite recargar los datos de los productos
        /// </summary>
        private void LoadProducts() {
            List<Product> products = _dao.GetAll();
            View.dataGridViewClients.DataSource = products;
        }

        /// <summary>
        /// Carga los datos existentes al iniciar la ventana
        /// </summary>
        private void View_Shown(object? sender, EventArgs e) {
            LoadProducts();
        }

        /// <summary>
        /// Acción de recargar datos
        /// </summary>
        private void ButtonRefresh_Click(object? sender, EventArgs e) {
            LoadProducts();
        }

        /// <summary>
        /// Acción para agregar un nuevo registro
        /// </summary>
        private void ButtonAdd_Click(object? sender, EventArgs e) {
            ProductDialogController dialogController = new ProductDialogController();
            DialogResult dialogResult = dialogController.View.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            try {
                if (_dao.Insert(dialogController.View.Data)) {
                    View.ShowMessage("Producto agregado exitosamente", MessageType.INFORMATION);
                    LoadProducts();
                } else {
                    View.ShowMessage("No se pudo agregar el nuevo producto. Favor intente nuevamente", MessageType.WARNING);
                }
            } catch (Exception ex) {
                _ = ex;
                View.ShowMessage("Ha ocurrido un error inesperado al tratar de agregar un nuevo producto. Favor intente nuevamente", MessageType.ERROR);
            }
        }

        /// <summary>
        /// Acción para modificar un registro
        /// </summary>
        private void ButtonEdit_Click(object? sender, EventArgs e) {
            if (View.dataGridViewClients.CurrentRow != null && 
                View.dataGridViewClients.CurrentRow.Cells[0].Value is string id &&
                View.dataGridViewClients.CurrentRow.Cells[1].Value is string name &&
                View.dataGridViewClients.CurrentRow.Cells[2].Value is string category &&
                View.dataGridViewClients.CurrentRow.Cells[3].Value is decimal unitPrice) {
                Product data = new Product(id, name, category, unitPrice);
                ProductDialogController dialogController = new ProductDialogController(data);
                DialogResult dialogResult = dialogController.View.ShowDialog();
                if (dialogResult != DialogResult.OK) return;
                try {
                    if (_dao.Update(dialogController.View.Data)) {
                        View.ShowMessage("Producto actualizado exitosamente", MessageType.INFORMATION);
                        LoadProducts();
                    } else {
                        View.ShowMessage("No se pudo editar el producto seleccionado. Favor intente nuevamente", MessageType.WARNING);
                    }
                } catch (Exception ex) {
                    _ = ex;
                    View.ShowMessage("Ha ocurrido un error inesperado al tratar de actualizar el producto seleccionado. Favor intente nuevamente", MessageType.ERROR);
                }
            }
        }

        /// <summary>
        /// Acción para borrar un registro
        /// </summary>
        private void ButtonDelete_Click(object? sender, EventArgs e) {
            if (View.dataGridViewClients.CurrentRow != null &&
                View.dataGridViewClients.CurrentRow.Cells[0].Value is string id) {
                try {
                    if (_dao.Delete(id)) {
                        View.ShowMessage("Producto eliminado exitosamente", MessageType.INFORMATION);
                        LoadProducts();
                    } else {
                        View.ShowMessage("No se pudo eliminar el producto seleccionado. Favor intente nuevamente", MessageType.WARNING);
                    }
                } catch (Exception ex) {
                    _ = ex;
                    View.ShowMessage("Ha ocurrido un error inesperado al tratar de actualizar el producto seleccionado. Favor intente nuevamente", MessageType.ERROR);
                }
            }
        }
    }
}
