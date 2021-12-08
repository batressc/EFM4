using EFM4.Views.CustomExceptions;
using System.Windows.Forms;

namespace EFM4.Views.CustomControls {
    /// <summary>
    /// TextBox con control de enteros
    /// </summary>
    public class IntegerTextBox : TextBox {
        /// <summary>
        /// Nombre del campo para el usuario
        /// </summary>
        public string FieldDataName { get; set; }
        /// <summary>
        /// Especifica si el campo es requerido
        /// </summary>
        public bool IsRequired { get; set; } = true;

        /// <summary>
        /// Ejecuta las validaciones personalizadas
        /// </summary>
        /// <exception cref="CustomValidationException">Verificación de datos correctos</exception>
        public void Validate() {
            if (IsRequired && string.IsNullOrWhiteSpace(Text)) {
                throw new CustomValidationException($"El campo {FieldDataName} es obligatoro");
            }
            if (!int.TryParse(Text, out _)) {
                throw new CustomValidationException($"El campo {FieldDataName} debe ser un número entero");
            }
        }
    }
}
