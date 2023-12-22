using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_DAL.Entities;
using Task_DAL.Interfaces;
using Task_DAL.Mappers;
using Task_Tools;

namespace Task_DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DbConnection _connection;
        public TaskRepository(DbConnection connection)
        {
            _connection = connection;
        }
        public bool Delete(int id)
        {
                int nbRow = _connection.ExecuteNonQuery("DELETE FROM Task OUTPUT deleted.Task_Id WHERE Task_Id = @id", false, new { id });
                return nbRow > 0;
        }

        public IEnumerable<TaskEntity> GetAll()
        {
            IEnumerable<TaskEntity> tasks = _connection.ExecuteReader("SELECT * FROM Task", (task => task.ToTaskEntity()));
            return tasks;
        }

        public TaskEntity? GetById(int id)
        {
            TaskEntity? task = _connection.ExecuteReader("SELECT * FROM Task WHERE Task_Id = @id", (task => task.ToTaskEntity()), false, new { id }).SingleOrDefault();
            _connection.Close();
            return task;
        }

        public TaskEntity? Insert(TaskEntity task)
        {
            TaskEntity? createdTask = _connection.ExecuteReader("SPInsertTask", (r => r.ToTaskEntity()) , true, new { task.Title, task.Description }).SingleOrDefault();
            if (createdTask is null) return null;

            _connection.Close();
            return createdTask;
        }

        public bool Update(TaskEntity task, int id)
        {
            int nbRow = _connection.ExecuteNonQuery("UPDATE Task SET Title = @title, [Description] = @description WHERE Task_Id = @id", false, new {title = task.Title, description = task.Description, id});
            _connection.Close();

            return nbRow > 0;
        }
    }
}
