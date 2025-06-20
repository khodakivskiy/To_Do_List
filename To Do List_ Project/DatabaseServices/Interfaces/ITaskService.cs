﻿using To_Do_List__Project.Models;

namespace To_Do_List__Project.DatabaseServices.Interfaces
{
    public interface ITaskService
    {
        void AddTask(TaskModel task);
        TaskModel? GetTaskById(int taskId);
        List<TaskModel> GetAllTasks();
        List<TaskModel> GetActiveTasks();
        List<TaskModel> GetCompletedTasks();
        void UpdateTask(TaskModel task);
        void ClearTasks();
     }
}
