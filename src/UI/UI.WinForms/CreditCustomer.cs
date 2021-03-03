using SeidorArchitecture.ECommerce.Application.DTO;
using SeidorArchitecture.ECommerce.Transversal.Common;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;

namespace UI.WinForms
{
    public partial class CreditCustomerForm : Form
    {
        private const string apiURL = "http://localhost:55168/api";
        private readonly HttpClient httpClient;
        public CreditCustomerForm()
        {
            InitializeComponent();

            httpClient = new HttpClient();
        }

        private async void abonoButton_Click(object sender, EventArgs e)
        {
            var addCustomerDTO = new CreditCustomerDTO()
            {
                Abono = Convert.ToDouble(montoAbonoText.Text),
                DNI = documentoIdentidadText.Text,
            };

            var json = JsonConvert.SerializeObject(addCustomerDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await httpClient.PutAsync($"{apiURL}/customers/putAsync", content);

            Response<bool> response = await httpResponse.Content.ReadAsAsync<Response<bool>>();

            if (response.IsSuccess)
            {
                MessageBox.Show(response.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
