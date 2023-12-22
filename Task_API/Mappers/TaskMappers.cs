using Task_API.Models.Forms;
using Task_BLL.Models;

namespace Task_API.Mappers
{
    public static class TaskMappers
    {

        public static TaskModel ToTaskModel(this CreateTaskForm form)
        {
            return new TaskModel(form.Title, form.Description);
        }

        public static TaskModel ToTaskModel(this UpdateTaskForm form)
        {
            return new TaskModel(form.Title, form.Description);
        }
    }
}
