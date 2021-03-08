using SeidorArchitecture.DigitalB89.Application.DTO;
using SeidorArchitecture.DigitalB89.Transversal.Common;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;

namespace SeidorArchitecture.DigitalB89.UI.WinForms
{
    public partial class AddCustomerForm : Form
    {
        private const string apiURL = "http://localhost:55168/api";
        private readonly HttpClient httpClient;
        public AddCustomerForm()
        {
            InitializeComponent();

            httpClient = new HttpClient();
        }

        private async void guardarButton_Click(object sender, EventArgs e)
        {
            var addCustomerDTO = new AddCustomerDTO()
            {
                Cliente = nombreClienteText.Text,
                DNI = documentoIdentidadText.Text,
                FechaNacimiento = fecchaNacimientoDateTime.Value,
            };

            var json = JsonConvert.SerializeObject(addCustomerDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await httpClient.PostAsync($"{apiURL}/customers/postAsync", content);

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
