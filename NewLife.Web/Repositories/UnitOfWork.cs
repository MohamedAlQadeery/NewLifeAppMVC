using Newlife.Web.Core.Interfaces;
using Newlife.Web.Core.Interfaces.Repositories;
using Newlife.Web.Core.Models;
using NewLife.Web.Data;

namespace Newlife.Web.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Coach> Coaches { get; private set; }
        public IBaseRepository<CoachAttachment> CoachesAttachments { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Coaches = new BaseRepository<Coach>(_context);
            CoachesAttachments = new BaseRepository<CoachAttachment>(_context);
        }

       

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
