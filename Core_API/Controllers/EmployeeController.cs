using Core_API.CustomActionFilters;
using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    /// <summary>
    /// The Route is responsible to Provide the Information of the
    /// Current ControllerName and its Action Method that is being under execution
    /// RouteAttribute class has the 'Values' property of the Type 'RouteDataDictionary'
    /// using which we can access the Current Controller name using 'controller' and action name using 'action' 
    /// </summary>
    /// 
    /// Filter At Controller Level
    // [LogFilter]

    // An Attribute to Authenticate the User and then Authorize it
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IDataAccessService<Employee, int> empServ;

        /// <summary>
        /// Inject the IDataAccessService<Employee,int> to Resolve EmployeeDataService
        /// </summary>
        public EmployeeController(IDataAccessService<Employee, int> empServ)
        {
            this.empServ = empServ;
        }
        /// <summary>
        /// Filter At Action Method Level
        /// </summary>
        /// <returns></returns>
        // [LogFilter]

        // [Authorize(Roles ="Manager,Clerk,Operator")]
        [Authorize(Policy = "readpolicy")]
        [HttpGet]
        [ActionName("get")]
        public async Task<IActionResult> Get()
        {
            var response = await empServ.GetAsync();
            return Ok(response);
        }
        [Authorize(Policy = "readpolicy")]
        //[Authorize(Roles = "Manager,Clerk,Operator")]
        [HttpGet("{id}")]
        [ActionName("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await empServ.GetAsync(id);
            return Ok(response);
        }
        [Authorize(Policy = "addeditpolicy")]
       // [Authorize(Roles = "Manager,Clerk")]
        [HttpPost]
        [ActionName("post")]
        public async Task<IActionResult> Post(Employee emp)
        {
                  
           var response = await empServ.CreateAsync(emp);
           return Ok(response);
        }
        //[Authorize(Roles = "Manager,Clerk")]
        [Authorize(Policy = "addeditpolicy")]
        [HttpPut("{id}")]
        [ActionName("put")]
        public async Task<IActionResult> Put(int id, Employee emp)
        {
            if (id == 0) throw new Exception($"ID : {id} Can not be zero");
            var response = await empServ.UpdateAsync(id,emp);
            return Ok(response);
        }
        [Authorize(Policy = "deletepolicy")]
        //[Authorize(Roles = "Manager")]
        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await empServ.DeleteAsync(id);
            return Ok(response);
        }


       
    }
}
