using System.Linq.Expressions;
using ToDo_App.Model;

namespace ToDo_App.Repository.IRepository
{
    public interface IListRepository :IRepository<Lists>
    {
        Task<Lists> Update(Lists entity);
    }
}
