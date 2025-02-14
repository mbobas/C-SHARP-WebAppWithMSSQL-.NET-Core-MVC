﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskManager2.Models;

namespace taskManager2.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();

        void Add(TaskModel task);
        void Update(int taskId, TaskModel task);

        void Delete(int taskId);

    }
}
