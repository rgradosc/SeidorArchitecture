using SeidorArchitecture.ECommerce.Application.DTO;
using SeidorArchitecture.ECommerce.Transversal.Common;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace UI.WinForms
{
    public partial class CustomersListForm : Form
    {
        private const string apiURL = "http://localhost:55168/api";
        private readonly HttpClient httpClient;
        public CustomersListForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            AllCustomers();
        }

        private async void AllCustomers()
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync($"{apiURL}/customers/getAsync");

            Response<IEnumerable<CustomerDTO>> response = await httpResponse.Content.ReadAsAsync<Response<IEnumerable<CustomerDTO>>>();

            if (response.IsSuccess)
            {
                List<CustomerDTO> customerDTOs = (List<CustomerDTO>)response.Data;
                customersGridView.DataSource = customerDTOs;

            }
        }
    }
}
