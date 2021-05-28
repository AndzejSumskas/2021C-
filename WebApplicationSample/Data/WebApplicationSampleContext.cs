using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationSample.Model;

namespace WebApplicationSample.Data
{
    public class WebApplicationSampleContext : DbContext
    {
        public WebApplicationSampleContext (DbContextOptions<WebApplicationSampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationSample.Model.Student> Student { get; set; }
    }
}
