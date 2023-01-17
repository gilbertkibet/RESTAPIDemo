using Microsoft.EntityFrameworkCore;
using RESTAPIDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIDemo.ApiContext
{
    public class AppDbContext:DbContext
    {
     public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> tblemployees { get; set; }
    }
}
