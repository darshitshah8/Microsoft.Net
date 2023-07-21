using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TodoLibrary.DataAccess;
using TodoLibrary.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoData _data;
        private readonly ILogger<TodosController> _logger;

        public TodosController(ITodoData data,ILogger<TodosController> logger)
        {
            _data = data;
            _logger = logger;
        }
        private int GetUserId()
        {
            var userIdText = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            return int.Parse(userIdText);

        }
        // GET: api/Todos
        [HttpGet(Name = "GetAllTodos")]
        public async Task<ActionResult<List<TodoModel>>> Get()
        {
            _logger.LogInformation("GET api/todos");
            try
            {
                var output = await _data.GetAllAssigned(GetUserId());
                return Ok(output);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "The call to GET api/Todos Failed.");
                return BadRequest(ex.Message);
            }
        }

        // GET api/Todos/5
        [HttpGet("{todoId}", Name ="GetOneTodo")]
        public async Task<ActionResult<TodoModel>> Get(int todoId)
        {
            _logger.LogInformation("GET api/todos/{todoId}",todoId);
            try
            {
                var output = await _data.GetOneAssigned(GetUserId(), todoId);
                return Ok(output);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "The call to {ApiPath} Failed. The Id was {todoId}",$"api/Todos/Id",todoId);
                return BadRequest(ex.Message);
            }
        }

        // POST api/Todos
        [HttpPost(Name = "CreateTodo")]
        public async Task<ActionResult<TodoModel>> Post([FromBody] string task)
        {
            _logger.LogInformation("POST api/todos/");
            try
            {
                var output = await _data.Create(GetUserId(), task);
                return Ok(output);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "The call to POST api/Todos Failed.");
                return BadRequest(ex.Message);
            }
        }

        // PUT api/Todos/5
        [HttpPut("{todoId}",Name ="UpdateTodoTask")]
        public async Task<ActionResult> Put(int todoId, [FromBody] string task)
        {
            _logger.LogInformation("PUT api/todos/{todoId}", todoId);
            try
            {
                await _data.UpdateTask(GetUserId(), todoId, task);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "The call to PUT api/Todos/{todoId} Failed.",todoId);
                return BadRequest(ex.Message);
            }
        }
        
        // PUT api/Todos/5/Complete
        [HttpPut("{todoId}/Complete",Name ="CompleteTodo")]
        public async Task<ActionResult> Complete(int todoId)
        {
            _logger.LogInformation("PUT api/todos/{todoId}/Complete", todoId);
            try
            {
                await _data.CompleteTodo(GetUserId(), todoId);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "The call to PUT api/Todos/{todoId}/Complete Failed.",todoId);
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/Todos/5
        [HttpDelete("{todoId}",Name ="DeleteTodo")]
        public async Task<ActionResult> Delete(int todoId)
        {
            _logger.LogInformation("DELETE api/todos/{todoId}", todoId);
            try
            {
                await _data.Delete(GetUserId(), todoId);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "The call to DELETE api/Todos/{todoId} Failed.",todoId);
                return BadRequest(ex.Message);
            }
        }
    }
}
