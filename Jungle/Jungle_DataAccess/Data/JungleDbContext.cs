using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Data
{
    /*public*/ internal class JungleDbContext : DbContext
    {
        public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)

        {

        }
    }
}
