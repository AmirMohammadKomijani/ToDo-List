using AutoMapper;
using ToDo_App.Model;
using ToDo_App.Model.DTO;
using ToDo_App.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDo_App.Controllers
{
    [Route("api/Lists")]
    [ApiController]
    public class ListsController : ControllerBase
    {
        private readonly IListRepository _dbLists;
        private readonly IMapper _mapper;

        public ListsController(IListRepository dbLists,IMapper mapper)
        {
            _dbLists = dbLists;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lists>>> getListss()
        {
            IEnumerable<Lists> listNumber = await _dbLists.getAll();
            return Ok(_mapper.Map<List<ListDTO>>(listNumber));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Lists>> getLists(int id)
        {
            Lists listNum = await _dbLists.Get(u => u.Id == id);
            return Ok(_mapper.Map<ListDTO>(listNum));
        }

        [HttpPost]
        public async Task<ActionResult<Lists>> CreateLists([FromBody] ListCreateDTO listNumDto)
        {
            var listNum = _mapper.Map<Lists>(listNumDto);
            await _dbLists.Create(listNum);
            return Ok(listNum);
        }

        [HttpDelete]
        public async Task<ActionResult<Lists>> DeleteLists(int id)
        {
            var listNum = await _dbLists.Get(u => u.Id == id);
            await _dbLists.Remove(listNum);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<Lists>> UpdateLists([FromBody] ListUpdateDTO listNumDto)
        {
            var listNum = _mapper.Map<Lists>(listNumDto);
            await _dbLists.Update(listNum);
            return Ok(listNum);
        }
    }
}
