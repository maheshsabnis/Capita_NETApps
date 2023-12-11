namespace Core_API.Models
{
    /// <summary>
    /// A Generic Single Response classs that will returned to CLient
    /// as A requet to Controller
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class ResponseObject<TEntity> where TEntity : EntityBase
    {
        public IEnumerable<TEntity>? Records { get; set; }
        public TEntity? Record { get; set; }
        public string? Message { get; set; }
        public int StatusCode { get; set; }
    }
}
