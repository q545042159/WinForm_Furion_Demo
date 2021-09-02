using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [AppDbContext("Default", DbProvider.MySql)]
    public class DefaultDBContext : AppDbContext<DefaultDBContext>
    {
        public DefaultDBContext(DbContextOptions<DefaultDBContext> options) : base(options)
        {
        }
    }
}
