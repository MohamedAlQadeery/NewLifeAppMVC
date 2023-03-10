using Newlife.Web.Core.Interfaces.Repositories;
using Newlife.Web.Core.Models;

namespace Newlife.Web.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBaseRepository<Coach> Coaches { get; }
        public IBaseRepository<CoachAttachment> CoachAttachments { get; }

        Task<int> SaveChanges();
    }
}
