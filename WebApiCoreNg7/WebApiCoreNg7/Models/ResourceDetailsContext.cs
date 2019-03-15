using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiCoreNg7.Models
{
    public class ResourceDetailsContext : DbContext
    {

        public ResourceDetailsContext(DbContextOptions<ResourceDetailsContext> options) : base (options)
        {

        }
        public DbSet<ResourceDetails> ResourceDetails { get; set; }
    }
}
