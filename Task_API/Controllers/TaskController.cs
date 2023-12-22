using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_API.Mappers;
using Task_API.Models.Forms;
using Task_BLL.Interfaces;
using Task_BLL.Models;

namespace Task_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskModel>> GetAll()
        {
            IEnumerable<TaskModel> tasks = _taskService.GetAll();
            return Ok(tasks);
        }

        [HttpGet("{id}")]

        public ActionResult<TaskModel?> GetById(int id)
        {
            TaskModel? task = _taskService.GetById(id);

            return (task is not null) ? Ok(task) : NotFound();
        }

        [HttpPost]

        public ActionResult<TaskModel> Insert(CreateTaskForm form)
        {
           TaskModel? createdTask = _taskService.Insert(form.ToTaskModel());

            return (createdTask is not null) ? Ok(createdTask) : BadRequest();
        }

        [HttpDelete("{id}")] 
        public ActionResult Delete(int id)
        {
           bool isDeleted = _taskService.Delete(id);

            return (isDeleted) ? Ok() : BadRequest();
        }

        [HttpPut("{id}")]

        public ActionResult Update(UpdateTaskForm form, int id) {
        
            bool isUpdated = _taskService.Update(form.ToTaskModel(), id);

            return (isUpdated) ? Ok() : BadRequest();
        }
        
    }
}
