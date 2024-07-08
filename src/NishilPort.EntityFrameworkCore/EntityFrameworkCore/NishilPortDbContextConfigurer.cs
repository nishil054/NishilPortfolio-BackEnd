using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NishilPort.EntityFrameworkCore
{
    public static class NishilPortDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NishilPortDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NishilPortDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
