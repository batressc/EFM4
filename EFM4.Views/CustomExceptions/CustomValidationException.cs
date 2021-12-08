using System;

namespace EFM4.Views.CustomExceptions {
    /// <summary>
    /// Excepcion personalizada para validación de errores
    /// </summary>
    public class CustomValidationException : Exception {
        public CustomValidationException(string message) : base(message) { }
    }
}
