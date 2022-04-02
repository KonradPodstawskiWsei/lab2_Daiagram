using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram {

    class Student : Person {
        protected string group;
        protected List<Task> tasks;

        public string Group { get; set; }
        

        public Student(string name, int age, string group) : this(name, age, group, new List<Task>()) {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age) {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask (string taskName, TaskStatus taskStatus) {
            tasks.Add(new Task(taskName, taskStatus));
        }

        public void RemoveTask(int index) {
            tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus) {
            tasks[index].Status = taskStatus;
        }

        public string RenderTask(string prefix = "\t") {
            string buff = "Tasks: \n";
            
            for (int i = 0; i < tasks.Count(); i++) {
                buff += prefix + (i+1) + ". " + tasks[i].ToString() + " \n";
            }

            return buff;
        }

        public override bool Equals(Object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            } else {
                Student p = (Student)obj;
                return (name == p.name) && (age == p.age);
            }
        }

        public bool sequencEequal<T>(List<T> a, List<T> b) 
            {
            return a.SequenceEqual(b);
        }



        public override string ToString() {
            return "Student: " + name.ToString() + "(" + age.ToString() + " y.o.) \n" +
                "Group: " + group.ToString() + "\n" + RenderTask();
        }
    }
}
