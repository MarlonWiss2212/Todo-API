
using Microsoft.AspNetCore.Mvc;
using Todo_API.DTO;
using Todo_API.Interfaces;
using Todo_API.Models;

namespace Todo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController(ITodoRepository todoRepository) : Controller
    {
        private readonly ITodoRepository _todoRepository = todoRepository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<TodoDTO>))]
        [ProducesResponseType(400)]
        public IActionResult GetTodos()
        {
            ICollection<Todo> todos = _todoRepository.GetTodos();
            List<TodoDTO> mappedTodos = [];

            foreach(Todo todo in todos)
            {
                mappedTodos.Add(new TodoDTO(todo));
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
        public IActionResult GetTodo(int id)
        {
            Todo? todo = _todoRepository.GetTodo(id);

            if (todo == null)
            {
                return NotFound();
            }


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TodoDTO dto = new(todo);
            return Ok(dto);

        }
    }
}
