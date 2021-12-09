using EFM4.Views.CustomControls;

namespace EFM4.Views {
    partial class FormProductDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new EFM4.Views.CustomControls.StringTextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new EFM4.Views.CustomControls.StringTextBox();
            this.labelMessages = new System.Windows.Forms.Label();
            this.textBoxId = new EFM4.Views.CustomControls.StringTextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.numericUpDownUnitPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit.Location = new System.Drawing.Point(133, 272);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 37);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "&Regresar";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonAction
            // 
            this.buttonAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAction.Location = new System.Drawing.Point(226, 272);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(126, 37);
            this.buttonAction.TabIndex = 9;
            this.buttonAction.Text = "[Acción]";
            this.buttonAction.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.FieldDataName = "\"Nombre\"";
            this.textBoxName.IsRequired = true;
            this.textBoxName.Location = new System.Drawing.Point(12, 82);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(460, 25);
            this.textBoxName.TabIndex = 3;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 115);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 17);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Categoría";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCategory.FieldDataName = "\"Categoría\"";
            this.textBoxCategory.IsRequired = true;
            this.textBoxCategory.Location = new System.Drawing.Point(12, 135);
            this.textBoxCategory.MaxLength = 50;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(460, 25);
            this.textBoxCategory.TabIndex = 5;
            // 
            // labelMessages
            // 
            this.labelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessages.AutoEllipsis = true;
            this.labelMessages.ForeColor = System.Drawing.Color.IndianRed;
            this.labelMessages.Location = new System.Drawing.Point(12, 216);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(460, 39);
            this.labelMessages.TabIndex = 8;
            this.labelMessages.Text = "[Mensajes informativos para el usuario inidcando errores o acciones a ejecutar]";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.FieldDataName = "\"Identificador\"";
            this.textBoxId.IsRequired = true;
            this.textBoxId.Location = new System.Drawing.Point(12, 29);
            this.textBoxId.MaxLength = 10;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(460, 25);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(81, 17);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Identificador";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(12, 168);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(92, 17);
            this.labelUnitPrice.TabIndex = 6;
            this.labelUnitPrice.Text = "Precio unitario";
            // 
            // numericUpDownUnitPrice
            // 
            this.numericUpDownUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownUnitPrice.DecimalPlaces = 2;
            this.numericUpDownUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownUnitPrice.Location = new System.Drawing.Point(12, 188);
            this.numericUpDownUnitPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            131072});
            this.numericUpDownUnitPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownUnitPrice.Name = "numericUpDownUnitPrice";
            this.numericUpDownUnitPrice.Size = new System.Drawing.Size(460, 25);
            this.numericUpDownUnitPrice.TabIndex = 7;
            this.numericUpDownUnitPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // FormProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.numericUpDownUnitPrice);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAction);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[TÍTULO DE ACCIÓN]";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Button buttonAction;
        public StringTextBox textBoxName;
        public StringTextBox textBoxCategory;
        public System.Windows.Forms.Label labelMessages;
        public StringTextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelUnitPrice;
        public System.Windows.Forms.NumericUpDown numericUpDownUnitPrice;
    }
}