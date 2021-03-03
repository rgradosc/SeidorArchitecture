
namespace UI.WinForms
{
    partial class CreditCustomerForm
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
            this.montoAbonoText = new System.Windows.Forms.TextBox();
            this.abonarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento de identidad:";
            // 
            // documentoIdentidadText
            // 
            this.documentoIdentidadText.Location = new System.Drawing.Point(182, 39);
            this.documentoIdentidadText.Name = "documentoIdentidadText";
            this.documentoIdentidadText.Size = new System.Drawing.Size(218, 26);
            this.documentoIdentidadText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto a abonar:";
            // 
            // montoAbonoText
            // 
            this.montoAbonoText.Location = new System.Drawing.Point(182, 88);
            this.montoAbonoText.Name = "montoAbonoText";
            this.montoAbonoText.Size = new System.Drawing.Size(218, 26);
            this.montoAbonoText.TabIndex = 3;
            // 
            // abonarButton
            // 
            this.abonarButton.Location = new System.Drawing.Point(182, 140);
            this.abonarButton.Name = "abonarButton";
            this.abonarButton.Size = new System.Drawing.Size(218, 53);
            this.abonarButton.TabIndex = 6;
            this.abonarButton.Text = "Abonar";
            this.abonarButton.UseVisualStyleBackColor = true;
            this.abonarButton.Click += new System.EventHandler(this.abonoButton_Click);
            // 
            // CreditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 240);
            this.Controls.Add(this.abonarButton);
            this.Controls.Add(this.montoAbonoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.documentoIdentidadText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CreditCustomerForm";
            this.Text = "Abono a cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox documentoIdentidadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montoAbonoText;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button abonarButton;
    }
}

