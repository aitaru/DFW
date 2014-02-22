using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DFW;

namespace DataAccessLayer
{
    public class DfwContext : DbContext
    {
        public DbSet<Concern> Concerns { get; set; }
    }
}
