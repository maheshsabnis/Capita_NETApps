using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Models
{
    /// <summary>
    /// IdentityDbContext: Class uses the DbContext class from EntityFrameworkCore
    /// to establish connection and mapping with database (default is SQL Server)
    /// where application users, roles, claims, etc. Information is stored
    /// </summary>
    public class CapSecurityDbContext : IdentityDbContext
    {
        /// <summary>
        /// DbContextOptions will be used to read and inject the  CapSecurityDbContext
        /// object whihc is registered in DI Container of the application
        /// Thsi will support the Code-First Database Migrations to generate the database and tables
        /// </summary>
        /// <param name="options"></param>
        public CapSecurityDbContext(DbContextOptions<CapSecurityDbContext> options):base(options)
        {
        }
    }
}
