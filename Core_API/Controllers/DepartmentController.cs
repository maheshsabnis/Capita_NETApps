using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDataAccessService<Department, int> deptServ;

        /// <summary>
        /// Inject the IDataAccessService<Department,int> to Resolve DepartmentDataService
        /// </summary>
        public DepartmentController(IDataAccessService<Department, int> deptServ)
        {
            this.deptServ = deptServ;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await deptServ.GetAsync();
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await deptServ.GetAsync(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Department dept)
        {
            var response = await deptServ.CreateAsync(dept);   
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Department dept)
        {
            var response = await deptServ.UpdateAsync(id,dept);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await deptServ.DeleteAsync(id);
            return Ok(response);
        }
    }
}
