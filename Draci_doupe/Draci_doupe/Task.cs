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
        List<string> Task_Type = new List<string>();
        List<string> Task_Title = new List<string>();
        List<string> Task_Text = new List<string>();
        List<int> Task_Reward = new List<int>();

        public Task(int n)
        {
            Task_ID.Add(0);
            Task_ID.Add(1);
            Task_ID.Add(2);
            Task_ID.Add(3);

            Task_Type.Add("vyber_hrdiny");
            Task_Type.Add("vyber");
            Task_Type.Add("vyber");
            Task_Type.Add("pokracovat");

            Task_Title.Add("Vyber hrdinu");
            Task_Title.Add("Vzít/nevzít");
            Task_Title.Add("Vzít/nevzít");
            Task_Title.Add("Zahájit cestu");

            Task_Text.Add("Šermíř,Lučištník,Léčitel,Průzkumník");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");

            Task_Reward.Add(0);
            Task_Reward.Add(2);
            Task_Reward.Add(3);
            Task_Reward.Add(0);

            _id_task = Task_ID[n];
            _type_task = Task_Type[n];
            _name_task = Task_Title[n];
            _text_task = Task_Text[n];
            _reward_task = Task_Reward[n];
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
        public List<string> TaskSplit(string task)
        {
            List<string> task_option = task.Split(',').ToList<string>();
            return task_option;
        }
    }
}