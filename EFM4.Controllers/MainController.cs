using EFM4.Views;
using System.Windows.Forms;

namespace EFM4.Controllers {
    /// <summary>
    /// Controlador principal del proyecto
    /// </summary>
    public class MainController {
        public FormMain View { get; private set; }

        public MainController() {
            // Ocultando formulario principal, ya que solo es enlace para ejecución de login y ventana MDI
            View = new FormMain() {
                Visible = false,
                ShowInTaskbar = false,
                Opacity = 0
            };
            View.Shown += MainView_Shown;
        }

        /// <summary>
        /// Ejecuta la lógica de login => MDI al iniciar el formulario principal
        /// </summary>
        private void MainView_Shown(object? sender, System.EventArgs e) {
            LoginController loginController = new LoginController();
            DialogResult loginResult = loginController.View.ShowDialog();
            if (loginResult != DialogResult.OK) {
                View.Close();
                return;
            }
            MDIController mdiController = new MDIController();
            mdiController.View.Show();
            mdiController.View.FormClosed += MDIView_FormClosed;
        }

        /// <summary>
        /// Cierra la ventana principal si se cierra la ventana MDI
        /// </summary>
        private void MDIView_FormClosed(object sender, FormClosedEventArgs e) {
            View.Close();
        }
    }
}
