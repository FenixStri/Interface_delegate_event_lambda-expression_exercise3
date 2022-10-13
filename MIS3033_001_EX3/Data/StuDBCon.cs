using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS3033_001_EX3.Data
{
    public class StuDBCon:DbContext
    {
        public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=C:\OSVisualStudio\MIS3033_001_EX3_YourName\MIS3033_001_EX3\MIS3033_001_EX3\stu.db");
        }
    }
}
