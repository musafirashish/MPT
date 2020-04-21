using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterData.Services.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MasterData.Services.Repository;
using MasterData.Services.Services;

namespace MasterData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerPoolController : ControllerBase
    {
        private readonly ICustomerPoolService _customerPoolService;
        public CustomerPoolController(ICustomerPoolService customerPoolService)
        {
            _customerPoolService = customerPoolService;
        }

        // GET: api/CustomerPool
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<CustomerPool> CustomerPools = _customerPoolService.GetAllCustomerPool();
            return Ok(CustomerPools);
        }

        // GET: api/CustomerPool/1
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            CustomerPool customerPool = _customerPoolService.GetCustomerPoolById(id);

            if (customerPool == null)
            {
                return NotFound("The CustomerPool record couldn't be found.");
            }
            return Ok(customerPool);
        }

        // POST: api/CustomerPool
        [HttpPost]
        public IActionResult Post([FromBody] CustomerPool customerpool)
        {
            if (customerpool == null)
            {
                return BadRequest("CustomerPool is null.");
            }

            _customerPoolService.Add(customerpool);
            return Ok();
        }

        // PUT: api/CustomerPool/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CustomerPool customerpool)
        {
            if (customerpool == null)
            {
                return BadRequest("Employee is null.");
            }

            CustomerPool customerpoolToUpdate = _customerPoolService.GetCustomerPoolById(id);
            if (customerpool == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _customerPoolService.Update(customerpool);
            return NoContent();
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CustomerPool customerpool = _customerPoolService.GetCustomerPoolById(id);
            if (customerpool == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _customerPoolService.Delete(customerpool);
            return NoContent();
        }

    }
}