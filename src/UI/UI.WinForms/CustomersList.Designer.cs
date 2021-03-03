
namespace UI.WinForms
{
    partial class CustomersListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.ClienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimientoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGridView
            // 
            this.customersGridView.AllowUserToAddRows = false;
            this.customersGridView.AllowUserToDeleteRows = false;
            this.customersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGridView.BackgroundColor = System.Drawing.Color.White;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteColumn,
            this.DNIColumn,
            this.FechaNacimientoColumn,
            this.SaldoColumn,
            this.PuntosColumn});
            this.customersGridView.Location = new System.Drawing.Point(12, 12);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.ReadOnly = true;
            this.customersGridView.RowTemplate.Height = 28;
            this.customersGridView.Size = new System.Drawing.Size(836, 443);
            this.customersGridView.TabIndex = 0;
            // 
            // ClienteColumn
            // 
            this.ClienteColumn.DataPropertyName = "Cliente";
            this.ClienteColumn.HeaderText = "Cliente";
            this.ClienteColumn.Name = "ClienteColumn";
            this.ClienteColumn.ReadOnly = true;
            this.ClienteColumn.Width = 250;
            // 
            // DNIColumn
            // 
            this.DNIColumn.DataPropertyName = "DNI";
            this.DNIColumn.HeaderText = "DNI";
            this.DNIColumn.Name = "DNIColumn";
            this.DNIColumn.ReadOnly = true;
            // 
            // FechaNacimientoColumn
            // 
            this.FechaNacimientoColumn.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle1.Format = "d";
            this.FechaNacimientoColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaNacimientoColumn.HeaderText = "Fecha nacimiento";
            this.FechaNacimientoColumn.Name = "FechaNacimientoColumn";
            this.FechaNacimientoColumn.ReadOnly = true;
            this.FechaNacimientoColumn.Width = 180;
            // 
            // SaldoColumn
            // 
            this.SaldoColumn.DataPropertyName = "Saldo";
            this.SaldoColumn.HeaderText = "Saldo";
            this.SaldoColumn.Name = "SaldoColumn";
            this.SaldoColumn.ReadOnly = true;
            this.SaldoColumn.Width = 120;
            // 
            // PuntosColumn
            // 
            this.PuntosColumn.DataPropertyName = "Puntos";
            this.PuntosColumn.HeaderText = "Puntos";
            this.PuntosColumn.Name = "PuntosColumn";
            this.PuntosColumn.ReadOnly = true;
            this.PuntosColumn.Width = 120;
            // 
            // CustomersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 467);
            this.Controls.Add(this.customersGridView);
            this.Name = "CustomersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reporte de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimientoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosColumn;
    }
}

