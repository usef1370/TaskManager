using Cornea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cornea.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<AllTasks> AllTasks { get; set; }
        DbSet<Customers> Customers { get; set; }
        DbSet<Factors> Factors { get; set; }
        DbSet<Products> Products { get; set; }
        DbSet<LoginInfo> LoginInfo { get; set; }
        DbSet<Projects> Projects { get; set; }
        DbSet<Roles> Roles { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
