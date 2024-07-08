using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NishilPort.Authorization.Roles;
using NishilPort.Authorization.Users;
using NishilPort.MultiTenancy;

namespace NishilPort.EntityFrameworkCore
{
    public class NishilPortDbContext : AbpZeroDbContext<Tenant, Role, User, NishilPortDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NishilPortDbContext(DbContextOptions<NishilPortDbContext> options)
            : base(options)
        {
        }
    }
}
