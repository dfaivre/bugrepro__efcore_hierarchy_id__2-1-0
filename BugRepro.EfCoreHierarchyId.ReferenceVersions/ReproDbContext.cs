using System;
using Microsoft.EntityFrameworkCore;

namespace BugRepro.EfCoreHierarchyId.ReferenceVersions
{
    public class ReproDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(opts => opts.UseHierarchyId());
        }
    }
}