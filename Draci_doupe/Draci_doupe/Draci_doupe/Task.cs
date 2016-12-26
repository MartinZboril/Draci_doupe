using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Task
    {
        List<int> Task_ID = new List<int>();
        List<string> Task_Title = new List<string>();
        List<string> Task_Text = new List<string>();

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

        private string _text_task;
        public string Text_Task
        {
            get { return _text_task; }
            set { _text_task = value; }
        }
        public Task(int n)
        {
            Task_ID.Add(1);
            Task_ID.Add(2);
            Task_ID.Add(3);

            Task_Title.Add("Vyber hrdinu");
            Task_Title.Add("Sebrat");
            Task_Title.Add("Pomoct");

            Task_Text.Add("Sermir,Lucistnik,Lecitel,Pruzkumnik");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Odejit");

            _id_task = Task_ID[n];
            _name_task = Task_Title[n];
            _text_task = Task_Text[n];
        }
        public List<string> TaskSplit(string task)
        {
            List<string> task_option = task.Split(',').ToList<string>();
            return task_option;
        }
    }
}