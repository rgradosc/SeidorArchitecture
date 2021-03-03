
namespace UI.WinForms
{
    partial class AddCustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.documentoIdentidadText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreClienteText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecchaNacimientoDateTime = new System.Windows.Forms.DateTimePicker();
            this.guardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento de identidad:";
            // 
            // documentoIdentidadText
            // 
            this.documentoIdentidadText.Location = new System.Drawing.Point(182, 45);
            this.documentoIdentidadText.Name = "documentoIdentidadText";
            this.documentoIdentidadText.Size = new System.Drawing.Size(218, 26);
            this.documentoIdentidadText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del cliente:";
            // 
            // nombreClienteText
            // 
            this.nombreClienteText.Location = new System.Drawing.Point(182, 94);
            this.nombreClienteText.Name = "nombreClienteText";
            this.nombreClienteText.Size = new System.Drawing.Size(218, 26);
            this.nombreClienteText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // fecchaNacimientoDateTime
            // 
            this.fecchaNacimientoDateTime.Location = new System.Drawing.Point(182, 144);
            this.fecchaNacimientoDateTime.Name = "fecchaNacimientoDateTime";
            this.fecchaNacimientoDateTime.Size = new System.Drawing.Size(218, 26);
            this.fecchaNacimientoDateTime.TabIndex = 5;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(182, 204);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(218, 53);
            this.guardarButton.TabIndex = 6;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 294);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.fecchaNacimientoDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreClienteText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.documentoIdentidadText);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "Registrar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox documentoIdentidadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreClienteText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecchaNacimientoDateTime;
        private System.Windows.Forms.Button guardarButton;
    }
}

