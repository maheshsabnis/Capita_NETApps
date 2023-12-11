using Core_API.Models;

namespace Core_API.Services
{
    public class EmployeeDataService : IDataAccessService<Employee, int>
    {
        Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IDataAccessService<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
