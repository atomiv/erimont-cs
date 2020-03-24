using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;

namespace Erimont.Infrastructure.Persistence
{
    public class Repository : Repository<DatabaseContext>
    {
        public Repository(DatabaseContext context) : base(context)
        {
        }
    }
}
