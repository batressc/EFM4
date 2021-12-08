using EFM4.Models.Entity;
using System.Windows.Forms;

namespace EFM4.Views {
    public partial class FormClientDialog : Form {
        public Client Data { get; set; }

        public FormClientDialog() {
            InitializeComponent();
            labelMessages.Text = "";
        }
    }
}
