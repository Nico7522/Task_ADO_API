using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_BLL.Interfaces;
using Task_BLL.Mappers;
using Task_BLL.Models;
using Task_DAL.Interfaces;

namespace Task_BLL.Services
{
    public class TaskService : ITaskService
    {

        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _taskRepository.Delete(id);
            return isDeleted;
        }

        public IEnumerable<TaskModel> GetAll()
        {
            return _taskRepository.GetAll().Select(t => t.ToTaskModel());
        }

        public TaskModel? GetById(int id)
        {
           TaskModel? task = _taskRepository.GetById(id)?.ToTaskModel();
             return task;
        }

        public TaskModel? Insert(TaskModel task)
        {
            return _taskRepository.Insert(task.ToTaskEntity())?.ToTaskModel();
        }

        public bool Update(TaskModel task, int id)
        {
            bool isUpdated = _taskRepository.Update(task.ToTaskEntity(), id);
            return isUpdated;
        }
    }
}
