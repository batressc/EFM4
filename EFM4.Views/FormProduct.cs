using System.Windows.Forms;

namespace EFM4.Views {
    public partial class FormProduct : Form {
        public FormProduct() {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra mensajes hacia el usuario
        /// </summary>
        /// <param name="message">Mensaje a mostrar</param>
        /// <param name="type">Tipo de mensaje</param>
        public void ShowMessage(string message, MessageType type) {
            switch (type) {
                case MessageType.WARNING:
                    MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageType.ERROR:
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
