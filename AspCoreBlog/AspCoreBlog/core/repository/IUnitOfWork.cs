using System.Threading.Tasks;
using AspCoreBlog.core.ef_core_extension;
using AspCoreBlog.Data.Models;

namespace AspCoreBlog.core.repository
{
    public interface IUnitOfWork
    {
        IEfCoreRepository<Blog> Blog { get; }
        IEfCoreRepository<Comment> Comment { get; }
        IEfCoreRepository<Post> Post { get; }
        IEfCoreRepository<PostTag> PostTag { get; }
        IEfCoreRepository<Tags> Tags { get; }

        void Dispose();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}