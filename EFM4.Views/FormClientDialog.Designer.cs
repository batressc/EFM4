using EFM4.Views.CustomControls;

namespace EFM4.Views {
    partial class FormClientDialog {
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
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new EFM4.Views.CustomControls.IntegerTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new EFM4.Views.CustomControls.StringTextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new EFM4.Views.CustomControls.StringTextBox();
            this.labelMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit.Location = new System.Drawing.Point(133, 232);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 37);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "&Regresar";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonAction
            // 
            this.buttonAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAction.Location = new System.Drawing.Point(226, 232);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(126, 37);
            this.buttonAction.TabIndex = 7;
            this.buttonAction.Text = "[Acción]";
            this.buttonAction.UseVisualStyleBackColor = true;
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nombres";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.FieldDataName = "\"Nombres\"";
            this.textBoxName.IsRequired = true;
            this.textBoxName.Location = new System.Drawing.Point(12, 82);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(460, 25);
            this.textBoxName.TabIndex = 3;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 115);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(62, 17);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Apellidos";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.FieldDataName = "\"Apellidos\"";
            this.textBoxSurname.IsRequired = true;
            this.textBoxSurname.Location = new System.Drawing.Point(12, 135);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(460, 25);
            this.textBoxSurname.TabIndex = 5;
            // 
            // labelMessages
            // 
            this.labelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessages.AutoEllipsis = true;
            this.labelMessages.ForeColor = System.Drawing.Color.IndianRed;
            this.labelMessages.Location = new System.Drawing.Point(12, 168);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(460, 39);
            this.labelMessages.TabIndex = 6;
            this.labelMessages.Text = "[Mensajes informativos para el usuario inidcando errores o acciones a ejecutar]";
            // 
            // FormClientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAction);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClientDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[TÍTULO DE ACCIÓN]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Button buttonAction;
        public IntegerTextBox textBoxId;
        public StringTextBox textBoxName;
        public StringTextBox textBoxSurname;
        public System.Windows.Forms.Label labelMessages;
    }
}