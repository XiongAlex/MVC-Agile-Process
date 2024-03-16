using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Agile_Process.Models;

namespace MVC_Agile_Process.Data
{
    public class MVC_Agile_ProcessContext : DbContext
    {
        public MVC_Agile_ProcessContext (DbContextOptions<MVC_Agile_ProcessContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Agile_Process.Models.Movie> Movie { get; set; } = default!;
    }
}
