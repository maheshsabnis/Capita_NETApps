using Core_API.Models;

namespace Core_API.Services
{
    /// <summary>
    /// TENtity will be any derived type of EntityBase
    /// The 'in' means TPk will always be an Input parameterto methdos of Interface 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDataAccessService<TEntity, in TPk> where TEntity : EntityBase
    {
        Task<ResponseObject<TEntity>> GetAsync();
        Task<ResponseObject<TEntity>> GetAsync(TPk id);
        Task<ResponseObject<TEntity>> CreateAsync(TEntity entity);
        Task<ResponseObject<TEntity>> UpdateAsync(TPk id, TEntity entity);
        Task<ResponseObject<TEntity>> DeleteAsync(TPk id);
    }
}
