using Core_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Services
{
    public class EmployeeDataService : IDataAccessService<Employee, int>
    {
        UcompanyContext ctx;
        ResponseObject<Employee> response;

        /// <summary>
        /// Inject the UcompanyContext from DI to this class
        /// </summary>
        public EmployeeDataService(UcompanyContext ctx)
        {
            this.ctx = ctx;
            response = new ResponseObject<Employee>();
        }

        async Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.CreateAsync(Employee entity)
        {
            var result = await ctx.Employees.AddAsync(entity);
            await ctx.SaveChangesAsync();
            response.Record = result.Entity;
            response.Message = "new Record is created";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.DeleteAsync(int id)
        {
            response.Record = await ctx.Employees.FindAsync(id);
            if (response.Record == null)
            {
                response.Message = "Record is no found";
                response.StatusCode = 400;
            }
            else
            {
                ctx.Employees.Remove(response.Record);
                await ctx.SaveChangesAsync();
                response.Message = "Record is  deleted";
                response.StatusCode = 200;
            }

            return response;
        }

        async Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.GetAsync()
        {
            response.Records = await ctx.Employees.ToListAsync();
            response.Message = "Records are read";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.GetAsync(int id)
        {
            response.Record = await ctx.Employees.FindAsync(id);
            if (response.Record == null)
            {
                response.Message = "Record is no found";
                response.StatusCode = 400;
            }
            else
            {
                response.Message = "Record is  found";
                response.StatusCode = 200;
            }
          
            return response;
        }

        async Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            response.Record = await ctx.Employees.FindAsync(id);
            if (response.Record == null)
            {
                response.Message = "Record is no found";
                response.StatusCode = 400;
            }
            else
            {
                response.Record.EmpName = entity.EmpName;
                response.Record.Designation = entity.Designation;
                response.Record.DeptNo = entity.DeptNo;
                await ctx.SaveChangesAsync();
                response.Message = "Record is  found";
                response.StatusCode = 200;
            }

            return response; ;
        }
    }
}
