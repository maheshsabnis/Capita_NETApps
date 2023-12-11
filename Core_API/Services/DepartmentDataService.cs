using Core_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Services
{
    public class DepartmentDataService : IDataAccessService<Department, int>
    {
        UcompanyContext ctx;
        ResponseObject<Department> response;

        /// <summary>
        /// Inject the UcompanyContext from DI to this class
        /// </summary>
        public DepartmentDataService(UcompanyContext ctx)
        {
            this.ctx = ctx;
            response = new ResponseObject<Department>();
        }

        async Task<ResponseObject<Department>> IDataAccessService<Department, int>.CreateAsync(Department entity)
        {
            var result = await ctx.Departments.AddAsync(entity);
            await ctx.SaveChangesAsync();
            response.Record = result.Entity;
            response.Message = "new Record is created";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Department>> IDataAccessService<Department, int>.DeleteAsync(int id)
        {
            response.Record = await ctx.Departments.FindAsync(id);
            if (response.Record == null)
            {
                response.Message = "Record is no found";
                response.StatusCode = 400;
            }
            else
            {
                ctx.Departments.Remove(response.Record);
                await ctx.SaveChangesAsync();
                response.Message = "Record is  deleted";
                response.StatusCode = 200;
            }

            return response;
        }

        async Task<ResponseObject<Department>> IDataAccessService<Department, int>.GetAsync()
        {
            response.Records = await ctx.Departments.ToListAsync();
            response.Message = "Records are read";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Department>> IDataAccessService<Department, int>.GetAsync(int id)
        {
            response.Record = await ctx.Departments.FindAsync(id);
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

        async Task<ResponseObject<Department>> IDataAccessService<Department, int>.UpdateAsync(int id, Department entity)
        {
            response.Record = await ctx.Departments.FindAsync(id);
            if (response.Record == null)
            {
                response.Message = "Record is no found";
                response.StatusCode = 400;
            }
            else
            {
                response.Record.DeptName = entity.DeptName;
                response.Record.Capacity = entity.Capacity;
                response.Record.Location = entity.Location;
                await ctx.SaveChangesAsync();
                response.Message = "Record is  found";
                response.StatusCode = 200;
            }

            return response; ;
        }
    }
}
