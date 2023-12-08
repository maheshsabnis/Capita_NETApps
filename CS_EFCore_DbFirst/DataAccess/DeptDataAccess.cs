using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_EFCore_DbFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
namespace CS_EFCore_DbFirst.DataAccess
{
    internal class DeptDataAccess
    {
        UcompanyContext ctx;
        public DeptDataAccess()
        {
            ctx = new UcompanyContext();
        }

        public async Task<List<Department>> GetAsync()
        {
            var departments = await ctx.Departments.ToListAsync(); 
            return departments;
        }

        public async Task<Department> GetAsync(int id)
        {
            var department = await ctx.Departments.FindAsync(id);
            return department;
        }

        public async Task<Department> CreateAsync(Department dept)
        {
            // The AddAsync() method return the EntityEntry classs
            // that contains newly created entity
            var result = await ctx.Departments.AddAsync(dept);
            await ctx.SaveChangesAsync();
            // return new entity
            return result.Entity;
        }

        public async Task<Department> UpdateAsync(int id, Department dept)
        {
            // serach record
            var record = await ctx.Departments.FindAsync(id);
            if (record == null)
                throw new Exception("No record found");

            // update values of serached record based on the input parameter 
            record.DeptName = dept.DeptName;
            record.Location  = dept.Location;
            record.Capacity = dept.Capacity;
            
            // Commit Transacxxtion
            await ctx.SaveChangesAsync();
            // Return updated record
            return record;
        }

        public async Task<string> DeleteAsync(int id)
        {
            // serach record
            var record = await ctx.Departments.FindAsync(id);
            if (record == null)
                throw new Exception("No record found");

            // Delete 
            ctx.Departments.Remove(record);
            // Commit Transacxxtion
            await ctx.SaveChangesAsync();
            // Return updated record
            return "Record is delete ";
        }
    }
}
