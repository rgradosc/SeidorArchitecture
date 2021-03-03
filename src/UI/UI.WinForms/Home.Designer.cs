
namespace UI.WinForms
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listadoClientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonoSaldoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoClientesMenuItem,
            this.registroClienteMenuItem,
            this.abonoSaldoMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listadoClientesMenuItem
            // 
            this.listadoClientesMenuItem.Name = "listadoClientesMenuItem";
            this.listadoClientesMenuItem.Size = new System.Drawing.Size(133, 23);
            this.listadoClientesMenuItem.Text = "Listado de clientes";
            // 
            // registroClienteMenuItem
            // 
            this.registroClienteMenuItem.Name = "registroClienteMenuItem";
            this.registroClienteMenuItem.Size = new System.Drawing.Size(118, 23);
            this.registroClienteMenuItem.Text = "Registrar cliente";
            // 
            // abonoSaldoMenuItem
            // 
            this.abonoSaldoMenuItem.Name = "abonoSaldoMenuItem";
            this.abonoSaldoMenuItem.Size = new System.Drawing.Size(102, 23);
            this.abonoSaldoMenuItem.Text = "Abonar saldo";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 467);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Digital B89 ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listadoClientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonoSaldoMenuItem;
    }
}

