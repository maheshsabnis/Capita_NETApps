using Core_API.CustomActionFilters;
using Core_API.Models;
using Core_API.Services;
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
    [Route("api/[controller]/[action]")]
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
        /// <summary>
        /// Filter At Action Method Level
        /// </summary>
        /// <returns></returns>
       // [LogFilter]
        [HttpGet]
        [ActionName("get")]
        public async Task<IActionResult> Get()
        {
            var response = await deptServ.GetAsync();
            return Ok(response);
        }
        [HttpGet("{id}")]
        [ActionName("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await deptServ.GetAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [ActionName("post")]
        public async Task<IActionResult> Post(Department dept)
        {
            //try
            //{
                /// ModelState is used to validate the Model e.g. Department object
                /// based on Rules for Annotations applied on each property of Department class
                if (ModelState.IsValid)
                {
                    // check if DeptName already exist
                    // An Explicit Data Validations
                    if (!await IsDeptNameExist(dept.DeptName))
                    {
                        var response = await deptServ.CreateAsync(dept);
                        return Ok(response);
                    }
                    var errorResponse = new ResponseObject<Department>();
                    errorResponse.Message = $"Department with DeptNaame : {dept.DeptName} is already exist";
                    errorResponse.StatusCode = 500;
                    return BadRequest(errorResponse);
                }

            //}
            //catch (Exception ex)
            //{
            //    // Code for Logging
            //    var errorResponse = new ResponseObject<Department>();
            //    errorResponse.Message = $"Error Occurred : {ex.Message}";
            //    errorResponse.StatusCode = 500;
            //    return BadRequest(errorResponse);
            //}
             return BadRequest(ModelState);

        }
        [HttpPut("{id}")]
        [ActionName("put")]
        public async Task<IActionResult> Put(int id, Department dept)
        {
            if (id == 0) throw new Exception($"ID : {id} Can not be zero");
            var response = await deptServ.UpdateAsync(id,dept);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await deptServ.DeleteAsync(id);
            return Ok(response);
        }


        /// <summary>
        /// Explicit Data VAlidation Check
        /// </summary>
        /// <param name="dname"></param>
        /// <returns></returns>
        private async Task<bool> IsDeptNameExist(string dname)
        {
            bool isExist = true;
           // LINQ Query that eill check if there exist a Department with DeptName
           // Received from the client
            var dept = (from d in  (await deptServ.GetAsync()).Records
                       where d.DeptName.Trim() == dname.Trim() 
                       select d).FirstOrDefault();
            if(dept == null)
                isExist = false;
            return isExist;
        }
    }
}
