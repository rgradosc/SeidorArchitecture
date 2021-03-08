using System;
using System.Windows.Forms;

namespace SeidorArchitecture.DigitalB89.UI.WinForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            listadoClientesMenuItem.Click += ListadoClientesMenuItem_Click;
            registroClienteMenuItem.Click += RegistroClienteMenuItem_Click;
            abonoSaldoMenuItem.Click += AbonoSaldoMenuItem_Click;
        }

        private void AbonoSaldoMenuItem_Click(object sender, EventArgs e)
        {
            CreditCustomerForm form = new CreditCustomerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void RegistroClienteMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void ListadoClientesMenuItem_Click(object sender, EventArgs e)
        {
            CustomersListForm form = new CustomersListForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
