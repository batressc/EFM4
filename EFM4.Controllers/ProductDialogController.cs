using EFM4.Models.Entity;
using EFM4.Views;
using EFM4.Views.CustomExceptions;
using System;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador del diálogo de acciones de producto
    /// </summary>
    public class ProductDialogController {
        public FormProductDialog View { get; private set; }

        /// <summary>
        /// Constructor para acción agregar
        /// </summary>
        public ProductDialogController() {
            View = new FormProductDialog {
                Text = "Agregar nuevo Producto"
            };
            View.buttonAction.Text = "Agregar";
            View.buttonExit.Click += ButtonExit_Click;
            View.buttonAction.Click += ButtonAction_Click;
        }

        /// <summary>
        /// Constructor para acción editar
        /// </summary>
        /// <param name="data">Datos a editar</param>
        public ProductDialogController(Product data) : this() {
            View.Data = data;
            View.Text = "Editar Producto";
            View.buttonAction.Text = "Editar";
            View.textBoxId.ReadOnly = true;
            // Cargando datos a editar en vista
            View.textBoxId.Text = data.Id;
            View.textBoxName.Text = data.Name;
            View.textBoxCategory.Text = data.Category;
            View.numericUpDownUnitPrice.Value = data.UnitPrice;
        }

        /// <summary>
        /// Cierra el cuadro de diálogo
        /// </summary>
        private void ButtonExit_Click(object? sender, EventArgs e) {
            View.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Realiza la validación de entrada de datos
        /// </summary>
        /// <returns>Indicador de éxito o fallo de la validación</returns>
        private bool ValidateInput() {
            try {
                View.textBoxId.Validate();
                View.textBoxName.Validate();
                View.textBoxCategory.Validate();
                if (View.numericUpDownUnitPrice.Value <= 0) {
                    View.labelMessages.Text = "El campo \"Precio unitario\" debe ser mayor que cero";
                    return false;
                }
                return true;
            } catch (CustomValidationException ve) {
                View.labelMessages.Text = ve.Message;
                return false;
            }
        }

        /// <summary>
        /// Ejecuta la acción
        /// </summary>
        private void ButtonAction_Click(object? sender, EventArgs e) {
            if (!ValidateInput()) return;
            if (View.Data == null) {
                View.Data = new Product(
                    View.textBoxId.Text,
                    View.textBoxName.Text,
                    View.textBoxCategory.Text,
                    View.numericUpDownUnitPrice.Value
                );
            } else {
                View.Data.Name = View.textBoxName.Text;
                View.Data.Category = View.textBoxCategory.Text;
                View.Data.UnitPrice = View.numericUpDownUnitPrice.Value;
            }
            View.DialogResult = DialogResult.OK;
        }
    }
}
