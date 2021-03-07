using SeidorArchitecture.ECommerce.Application.DTO;
using SeidorArchitecture.ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Services.WebAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerApplication application;

        public CustomersController(ICustomerApplication application)
        {
            this.application = application;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var response = application.GetAll();

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet("get/{dni}")]
        public IActionResult Get(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return BadRequest();
            }

            var response = application.Get(dni);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpPost("post")]
        public IActionResult Post([FromBody] AddCustomerDTO addCustomerDTO)
        {
            if (addCustomerDTO == null)
            {
                return BadRequest();
            }

            var response = application.Insert(addCustomerDTO);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpPut("put")]
        public IActionResult Put([FromBody] CreditCustomerDTO creditCustomerDTO)
        {
            if (creditCustomerDTO == null)
            {
                return BadRequest();
            }

            var response = application.Update(creditCustomerDTO);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpDelete("delete/{dni}")]
        public IActionResult Delete(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return BadRequest();
            }

            var response = application.Delete(dni);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet("getAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await application.GetAllAsync();

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet("getAsync/{dni}")]
        public async Task<IActionResult> GetAsync(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return BadRequest(dni);
            }

            var response = await application.GetAsync(dni);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpPost("postAsync")]
        public async Task<IActionResult> PostAsync([FromBody] AddCustomerDTO addCustomerDTO)
        {
            if (addCustomerDTO == null)
            {
                return BadRequest();
            }

            var response = await application.InsertAsync(addCustomerDTO);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpPut("putAsync")]
        public async Task<IActionResult> PutAsync([FromBody] CreditCustomerDTO creditCustomerDTO)
        {
            if (creditCustomerDTO == null)
            {
                return BadRequest();
            }

            var response = await application.UpdateAsync(creditCustomerDTO);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpDelete("deleteAsync/{dni}")]
        public async Task<IActionResult> DeleteAsync(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return BadRequest();
            }

            var response = await application.DeleteAsync(dni);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }
    }
}
