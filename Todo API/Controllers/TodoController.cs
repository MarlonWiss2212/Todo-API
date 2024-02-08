
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Todo_API.Data;
using Todo_API.DTO;
using Todo_API.Interfaces;
using Todo_API.Models;

namespace Todo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController(ITodoRepository todoRepository, IMapper mapper) : Controller
    {
        private readonly ITodoRepository _todoRepository = todoRepository;
        private readonly IMapper _mapper;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<TodoDTO>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult GetTodos()
        {
            ICollection<Todo> todos = _todoRepository.GetTodos();
            List<TodoDTO>? mappedTodos = _mapper.Map<List<TodoDTO>>(todos);

            if(mappedTodos == null)
            {
                return StatusCode(500);
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(mappedTodos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(TodoDTO))]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult GetTodo(int id)
        {
            Todo? todo = _todoRepository.GetTodo(id);

            if (todo == null)
            {
                return NotFound();
            }

            TodoDTO? mappedTodo = _mapper.Map<TodoDTO>(todo);

            if (mappedTodo == null)
            {
                return StatusCode(500);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(mappedTodo);

        }
    }
}
