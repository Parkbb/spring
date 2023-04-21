using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepositoryInMemory
    {
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo> { 
                new Todo { Id = 1, Title = "ASP.NET Core 학습", IsDone = false} ,
                new Todo { Id = 2, Title = "Blazor 학습", IsDone = false} ,
                new Todo { Id = 3, Title = "C# 학습", IsDone = true} 
            };
        }

        // 인-메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
        }

        public List<Todo> GetAll()
        {
            return _todos;
        }


    }

}
