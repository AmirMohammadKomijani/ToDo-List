using ToDo_App.Data;
using ToDo_App.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ToDo_App.Model;

namespace ToDo_App.Repository
{
    public class ListRepository : Repository<Lists>, IListRepository
    {
        private readonly ApplicationDbContext _db;

        public ListRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Lists> Update(Lists entity)
        {
            entity.Updated = DateTime.Now;
            _db.Lists.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
