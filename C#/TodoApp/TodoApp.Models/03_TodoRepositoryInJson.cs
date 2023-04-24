using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TodoApp.Models;

namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepositoryInMemory
    {
        private readonly string _filePath = "";
        private static List<Todo> _todos = new List<Todo>();

        //public TodoRepositoryFile()
        //{
        //    _todos = new List<Todo> { 
        //        new Todo { Id = 1, Title = "ASP.NET Core 학습", IsDone = false} ,
        //        new Todo { Id = 2, Title = "Blazor 학습", IsDone = false} ,
        //        new Todo { Id = 3, Title = "C# 학습", IsDone = true} 
        //    };
        //}

        public TodoRepositoryJson(string filePath = @"C:\workspace\spring\C#\TodoApp\Todos.txt")
        {
            this._filePath = filePath;
            var todos = File.ReadAllText(filePath, Encoding.Default);

            _todos = JsonConvert.DeserializeObject<List<Todo>>(todos);
        }

        // 인-메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            //파일 저장
            string json = JsonConvert.SerializeObject(_todos, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public List<Todo> GetAll()
        {
            return _todos;
        }


    }

}
