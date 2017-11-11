using System;
using System.Threading.Tasks;
using AspCoreBlog.core.ef_core_extension;
using AspCoreBlog.Data;
using AspCoreBlog.Data.Models;

namespace AspCoreBlog.core.repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private IEfCoreRepository<Blog> _blog = null;
        private IEfCoreRepository<PostTag> _postTag = null;

        private IEfCoreRepository<Post> _post = null;

        private IEfCoreRepository<Tags> _tags = null;

        private IEfCoreRepository<Comment> _comment = null;

        private readonly BlogDbContext _dbContext;

        public UnitOfWork(BlogDbContext ctx)
        {
            _dbContext = ctx;
        }




        public IEfCoreRepository<Tags> Tags
        {
            get
            {
                if (this._tags == null)

                {
                    this._tags = new EfCoreRepository<Tags>(_dbContext);
                }
                return this._tags;
            }
        }
        public IEfCoreRepository<Comment> Comment
        {
            get
            {
                if (this._comment == null)

                {
                    this._comment = new EfCoreRepository<Comment>(_dbContext);
                }
                return this._comment;
            }
        }
        public IEfCoreRepository<Blog> Blog
        {
            get
            {
                if (this._blog == null)

                {
                    this._blog = new EfCoreRepository<Blog>(_dbContext);
                }
                return this._blog;
            }
        }
        public IEfCoreRepository<PostTag> PostTag
        {
            get
            {
                if (this._postTag == null)

                {
                    this._postTag = new EfCoreRepository<PostTag>(_dbContext);
                }
                return this._postTag;
            }
        }

        public IEfCoreRepository<Post> Post
        {
            get
            {
                if (this._post == null)

                {
                    this._post = new EfCoreRepository<Post>(_dbContext);
                }
                return this._post;
            }
        }
        /// <summary>
        /// saving all changes to database 
        /// </summary>

        public void SaveChanges()
        {
            this._dbContext.SaveChanges();
        }

        /// <summary>
        /// saving to database synchronously
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            this._dbContext?.Dispose();
        }
    }
}