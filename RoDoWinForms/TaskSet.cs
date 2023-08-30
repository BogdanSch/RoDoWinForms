using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoDo
{
    public class TaskSet
    {
        public TaskSet(Control parent, List<Task> tasks)
        {
            Parent = parent;
            Tasks = tasks;
            Draw();
        }

        public Control Parent { get; set; }
        public List<Task> Tasks { get; set; }

        public void Draw()
        {
            Parent.Controls.Clear();

            for (int i = 0; i < Tasks.Count; i++)
            {
                Task task = Tasks[i];
                task.TaskBox.Location = new Point(10, i * Tasks[i].TaskBox.Height + 10);
                task.TaskBox.Checked = task.IsDone;
                Parent.Controls.Add(task.TaskBox);
            }
        }
        public virtual void Add(Task task)
        {
            Tasks.Add(task);
            Parent.Controls.Add(task.TaskBox);
            Draw();
        }

        public virtual void Remove(Task task)
        {
            Parent.Controls.Remove(task.TaskBox);
            Tasks.Remove(task);
            Draw();
        }
    }
}
