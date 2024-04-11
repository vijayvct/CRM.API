using CRM.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace CRM.API.Data
{
    public class CRMAPIContext:DbContext
    {
        public CRMAPIContext(DbContextOptions<CRMAPIContext> options)
            :base(options)
        {
            
        }

        public DbSet<Feedback> Feedback { get; set; }
    }
}
