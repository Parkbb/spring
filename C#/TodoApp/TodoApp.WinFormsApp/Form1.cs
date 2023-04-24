using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp.Models;

namespace TodoApp.WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ITodoRepositoryInMemory _repository;

        public Form1()
        {
            _repository = new TodoRepositoryJson("C:\\workspace\\spring\\C#\\TodoApp\\Todos.json");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            this.dataGridView1.DataSource = _repository.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            bool isDone = checkBox1.Checked;

            var todo = new Todo { Title = title, IsDone = isDone };
            _repository.Add(todo);

            DisplayData();
        }
    }
}
