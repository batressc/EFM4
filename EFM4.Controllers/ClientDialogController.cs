using EFM4.Models.Entity;
using EFM4.Views;
using EFM4.Views.CustomExceptions;
using System;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador del diálogo de acciones de clientes
    /// </summary>
    public class ClientDialogController {
        public FormClientDialog View { get; private set; }

        /// <summary>
        /// Constructor para acción agregar
        /// </summary>
        public ClientDialogController() {
            View = new FormClientDialog {
                Text = "Agregar nuevo Cliente"
            };
            View.buttonAction.Text = "Agregar";
            View.buttonExit.Click += ButtonExit_Click;
            View.buttonAction.Click += ButtonAction_Click;
        }

        /// <summary>
        /// Constructor para acción editar
        /// </summary>
        /// <param name="data">Datos a editar</param>
        public ClientDialogController(Client data) : this() {
            View.Data = data;
            View.Text = "Editar Cliente";
            View.buttonAction.Text = "Editar";
            View.textBoxId.ReadOnly = true;
            // Cargando datos a editar en vista
            View.textBoxId.Text = data.Id.ToString();
            View.textBoxName.Text = data.Name;
            View.textBoxSurname.Text = data.Surname;
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
                View.textBoxSurname.Validate();
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
                View.Data = new Client(
                    int.Parse(View.textBoxId.Text),
                    View.textBoxName.Text,
                    View.textBoxSurname.Text
                );
            } else {
                View.Data.Name = View.textBoxName.Text;
                View.Data.Surname = View.textBoxSurname.Text;
            }
            View.DialogResult = DialogResult.OK;
        }
    }
}
