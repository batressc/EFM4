using EFM4.Models.Entity;
using System.Windows.Forms;

namespace EFM4.Views {
    public partial class FormProductDialog : Form {
        public Product Data { get; set; }

        public FormProductDialog() {
            InitializeComponent();
            labelMessages.Text = "";
        }
    }
}
