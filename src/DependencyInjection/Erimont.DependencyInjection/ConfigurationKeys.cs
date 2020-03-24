using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace Erimont.DependencyInjection
{
    public static class ConfigurationKeys
    {
        public const string DatabaseConnectionKey = "DefaultConnection";

        public static Action<SqlServerDbContextOptionsBuilder> SqlServerOptionsAction = b => b.MigrationsAssembly("Erimont.Tools.Migrator");
    }
}