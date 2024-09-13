using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;
using TodoApp.Core.Interfaces;
using TodoApp.Service.Interfaces;

namespace TodoApp.Service.Services
{
    public class TodoService : ITodoService
    {

        private readonly IRepository<TodoItem> _repository;

        public TodoService(IRepository<TodoItem> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TodoItem>> GetAllTodosAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TodoItem> GetTodoByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddTodoAsync(TodoItem todoItem)
        {
            await _repository.AddAsync(todoItem);
        }

        public async Task UpdateTodoAsync(TodoItem todoItem)
        {
            _repository.Update(todoItem);
        }

        public async Task DeleteTodoAsync(int id)
        {
            var todo = await _repository.GetByIdAsync(id);
            if (todo != null)
            {
                _repository.Delete(todo);
            }
        }
    }
}
