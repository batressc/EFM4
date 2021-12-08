using EFM4.Models.Dao;
using EFM4.Models.Domain;
using EFM4.Views;
using EFM4.Views.CustomExceptions;
using System;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador para login a la aplicación
    /// </summary>
    public class LoginController {
        private readonly DaoLogin _dao;
        private readonly MD5Helper _md5;

        public FormLogin View { get; private set; }

        public LoginController() {
            _dao = new DaoLogin();
            _md5 = new MD5Helper();
            View = new FormLogin();
            View.buttonExit.Click += ButtonExit_Click;
            View.buttonLogin.Click += ButtonLogin_Click;
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        private void ButtonExit_Click(object? sender, EventArgs e) {
            View.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Realiza la lógica de validación de entradas de datos y muestra los mensajes a los usuarios
        /// </summary>
        /// <returns>Indicador de éxito o fallo de la validación</returns>
        private bool ValidateInput() {
            try {
                View.textBoxLogin.Validate();
                View.textBoxPassword.Validate();
                return true;
            } catch (CustomValidationException cve) {
                View.labelMessages.Text = cve.Message;
                return false;
            }
        }

        /// <summary>
        /// Realiza la validación entre hashes MD5 (el ingresado vs el de base de datos)
        /// </summary>
        /// <returns>-1 = usuario no existente, 0 = contraseña incorrecta, 1 = contraseña correcta</returns>
        private int ValidateUser() {
            byte[]? databasePassword = _dao.GetPasswordData(View.textBoxLogin.Text);
            if (databasePassword == null) return -1;
            byte[] passwordBytes = _md5.GenerateMD5(View.textBoxPassword.Text);
            return _md5.ValidateHashes(passwordBytes, databasePassword) ? 1 : 0;
        }

        /// <summary>
        /// Realiza la validación de usuario y contraseña
        /// </summary>
        private void ButtonLogin_Click(object? sender, EventArgs e) {
            if (!ValidateInput()) return;
            try {
                switch (ValidateUser()) {
                    case 0:
                        View.labelMessages.Text = "Contraseña incorrecta";
                        break;
                    case 1:
                        View.DialogResult = DialogResult.OK;
                        break;
                    default:
                        View.labelMessages.Text = "Usuario no registrado";
                        break;
                }
            } catch (Exception ex) {
                _ = ex;
                View.labelMessages.Text = "Ha ocurrido un error inesperado al acceder a la aplicación. Por favor intente nuevamente";
            }
        }
    }
}
