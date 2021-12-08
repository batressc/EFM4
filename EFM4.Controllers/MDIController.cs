using EFM4.Views;
using System;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador para lógica de ventana MDI
    /// </summary>
    public class MDIController {
        public FormMDI View { get; private set; }

        public MDIController() {
            View = new FormMDI();
            View.toolStripMenuItemClients.Click += ToolStripMenuItemClients_Click;
        }

        /// <summary>
        /// Realiza la carga de formularios adentro de la ventana MDI
        /// </summary>
        /// <param name="winForm"></param>
        private void ShowInsideMDI(Form winForm) {
            winForm.MdiParent = View;
            winForm.Show();
        }

        /// <summary>
        /// Lanza el mantenimiento de clientes
        /// </summary>
        private void ToolStripMenuItemClients_Click(object? sender, EventArgs e) {
            ClientController clientController = new ClientController();
            ShowInsideMDI(clientController.View);
        }
    }
}
