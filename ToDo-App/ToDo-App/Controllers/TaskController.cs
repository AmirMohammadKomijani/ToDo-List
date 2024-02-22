using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo_App.Model.DTO;
using ToDo_App.Model;
using ToDo_App.Repository.IRepository;

namespace ToDo_App.Controllers
{
    [Route("api/Task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _dbTasks;
        private readonly IMapper _mapper;

        public TaskController(ITaskRepository dbTasks, IMapper mapper)
        {
            _dbTasks = dbTasks;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tasks>>> getTasks()
        {
            IEnumerable<Tasks> TaskNumber = await _dbTasks.getAll();
            return Ok(_mapper.Map<List<TaskDTO>>(TaskNumber));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Tasks>> getTasks(int id)
        {
            Tasks taskNum = await _dbTasks.Get(u => u.Id == id);
            return Ok(_mapper.Map<TaskDTO>(taskNum));
        }

        [HttpPost]
        public async Task<ActionResult<Tasks>> CreateTasks([FromBody] TaskCreateDTO taskNumDto)
        {
            var taskNum = _mapper.Map<Tasks>(taskNumDto);
            await _dbTasks.Create(taskNum);
            return Ok(taskNum);
        }

        [HttpDelete]
        public async Task<ActionResult<Tasks>> DeleteTasks(int id)
        {
            var taskNum = await _dbTasks.Get(u => u.Id == id);
            await _dbTasks.Remove(taskNum);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<Tasks>> UpdateTasks([FromBody] TaskUpdateDTO taskNumDto)
        {
            var taskNum = _mapper.Map<Tasks>(taskNumDto);
            await _dbTasks.Update(taskNum);
            return Ok(taskNum);
        }
    }
}

