using ToDo_App.Model;

namespace ToDo_App.Repository.IRepository
{
    public interface ITaskRepository : IRepository<Tasks>
    {
        Task<Tasks> Update(Tasks entity);
    }
}
