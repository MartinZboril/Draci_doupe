using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Classes;

namespace Draci_doupe
{
    public class Task
    {
        Tasks tasks = new Tasks();
        public Task(int n)
        {           
            _id_task = n;
            _type_task = tasks.GetTaskType(n);
            _name_task = tasks.GetTaskName(n);
            _text_task = tasks.GetTaskText(n);
            _reward_task = tasks.GetTaskReward(n);
        }
        private int _id_task;
        public int Id_Task
        {
            get { return _id_task; }
            set { _id_task = value; }
        }

        private string _name_task;
        public string Name_task
        {
            get { return _name_task; }
            set { _name_task = value; }
        }

        private string _type_task;
        public string Type_task
        {
            get { return _type_task; }
            set { _type_task = value; }
        }

        private string _text_task;
        public string Text_Task
        {
            get { return _text_task; }
            set { _text_task = value; }
        }

        private int _reward_task;
        public int Reward_Task
        {
            get { return _reward_task; }
            set { _reward_task = value; }
        }
        /// <summary>
        /// Metoda pro rozdělení string, možnosti pro úkoly
        /// </summary>
        /// <param name="task">String možností</param>
        /// <returns>Kolekci možností</returns>
        public List<string> TaskSplit(string task)
        {
            List<string> task_option = task.Split(',').ToList<string>();
            return task_option;
        }
    }
}