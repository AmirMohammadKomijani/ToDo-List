using ToDo_App.Data;
using ToDo_App.Model;
using ToDo_App.Repository.IRepository;

namespace ToDo_App.Repository
{
    public class TaskRepository: Repository<Tasks>, ITaskRepository
    {
        private readonly ApplicationDbContext _db;

        public TaskRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Tasks> Update(Tasks entity)
        {
            entity.Updated = DateTime.Now;
            _db.Tasks.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
