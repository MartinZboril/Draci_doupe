using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Classes
{
   public class Tasks
    {
        List<int> Task_ID = new List<int>();
        List<string> Task_Type = new List<string>();
        List<string> Task_Title = new List<string>();
        List<string> Task_Text = new List<string>();
        List<int> Task_Reward = new List<int>();

        public Tasks()
        {
            Task_ID.Add(0);
            Task_ID.Add(1);
            Task_ID.Add(2);
            Task_ID.Add(3);

            Task_ID.Add(4);
            Task_ID.Add(5);
            Task_ID.Add(6);
            Task_ID.Add(7);

            Task_Type.Add("vyber_hrdiny");
            Task_Type.Add("vyber");
            Task_Type.Add("vyber");
            Task_Type.Add("pokracovat");

            Task_Type.Add("boj");
            Task_Type.Add("odmena");
            Task_Type.Add("hospoda");
            Task_Type.Add("nakup");

            Task_Title.Add("Vyber hrdinu");
            Task_Title.Add("Vzít/nevzít");
            Task_Title.Add("Vzít/nevzít");
            Task_Title.Add("Zahájit cestu");

            Task_Title.Add("Bojovat/nebojovat");
            Task_Title.Add("Vem si to");
            Task_Title.Add("Odpočinek Ano/Ne");
            Task_Title.Add("Vyber co chceš");

            Task_Text.Add("Šermíř,Lučištník,Léčitel,Průzkumník");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");

            Task_Reward.Add(0);
            Task_Reward.Add(2);
            Task_Reward.Add(3);
            Task_Reward.Add(0);

            Task_Reward.Add(0);
            Task_Reward.Add(4);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
        }
        /// <summary>
        /// Metoda pro získání typu úkolu
        /// </summary>
        /// <param name="num">ID úkolu</param>
        /// <returns>Typ úkolu</returns>
        public string GetTaskType(int num)
        {
            string type = Task_Type[num];
            return type;
        }
        /// <summary>
        /// Metoda pro získání názvu úkolu
        /// </summary>
        /// <param name="num">ID úkolu</param>
        /// <returns>Název úkolu</returns>
        public string GetTaskName(int num)
        {
            string name = Task_Title[num];
            return name;
        }
        /// <summary>
        /// Metoda pro získání textu úkolu
        /// </summary>
        /// <param name="num">ID úkolu</param>
        /// <returns>Text úkolu</returns>
        public string GetTaskText(int num)
        {
            string text = Task_Text[num];
            return text;
        }
        /// <summary>
        /// Metoda pro získání číslo odměny úkolu
        /// </summary>
        /// <param name="num">ID úkolu</param>
        /// <returns>Číslo odměny úkolu</returns>
        public int GetTaskReward(int num)
        {
            int reward = Task_Reward[num];
            return reward;
        }
    }
}
