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
            //---- 1. část ----
            //---- 1. kapitola
            Task_ID.Add(0);
            Task_ID.Add(1);
            Task_ID.Add(2);
            Task_ID.Add(3);
            //---- 2. kapitola
            Task_ID.Add(4);
            Task_ID.Add(5);
            Task_ID.Add(6);
            Task_ID.Add(7);
            Task_ID.Add(8);
            Task_ID.Add(9);
            //---- 3. kapitola
            Task_ID.Add(10);
            Task_ID.Add(11);
            Task_ID.Add(12);
            Task_ID.Add(13);
            Task_ID.Add(14);

            //---- 2. část ----
            //---- 4. kapitola ----
            Task_ID.Add(15);
            Task_ID.Add(16);
            Task_ID.Add(17);
            Task_ID.Add(18);
            Task_ID.Add(19);
            //---- 5. kapitola ----
            Task_ID.Add(20);
            Task_ID.Add(21);
            Task_ID.Add(22);
            Task_ID.Add(23);
            Task_ID.Add(24);
            //---- 6. kapitola ----
            Task_ID.Add(25);
            Task_ID.Add(26);
            Task_ID.Add(27);

            //---- 3. část ----
            //---- 7. kapitola ----
            Task_ID.Add(28);
            Task_ID.Add(29);
            Task_ID.Add(30);
            Task_ID.Add(31);
            //---- 8. kapitola ----
            Task_ID.Add(32);
            Task_ID.Add(33);
            Task_ID.Add(34);
            Task_ID.Add(35);
            Task_ID.Add(36);
            //---- 9. kapitola ----
            Task_ID.Add(37);
            Task_ID.Add(38);
            Task_ID.Add(39);
            Task_ID.Add(40);
            Task_ID.Add(41);
            Task_ID.Add(42);

            //---- 4. část ---- 
            //---- 10. kapitola
            Task_ID.Add(43);
            Task_ID.Add(44);
            //--------------------------------
            Task_Title.Add("Vyber hrdinu");
            Task_Title.Add("Vzít/nevzít");
            Task_Title.Add("Vzít/nevzít");
            Task_Title.Add("Zahájit cestu");

            Task_Title.Add("Bojovat/nebojovat");
            Task_Title.Add("Vem si to");
            Task_Title.Add("Odpočinek Ano/Ne");
            Task_Title.Add("Pokračovat");
            Task_Title.Add("Bojovat/nebojovat");
            Task_Title.Add("Odměna");

            Task_Title.Add("Pokračovat");
            Task_Title.Add("Návštěva");
            Task_Title.Add("Pokračovat");
            Task_Title.Add("Boj");
            Task_Title.Add("Sestup do údolí");

            Task_Title.Add("Pokračovat");
            Task_Title.Add("Vem si to");
            Task_Title.Add("Seznámit Ano/Ne");
            Task_Title.Add("Pokračovat");
            Task_Title.Add("Nalodit");

            Task_Title.Add("Boj");
            Task_Title.Add("Odměna");
            Task_Title.Add("Pokračovat");

            Task_Title.Add("Pokračovat");
            Task_Title.Add("Odpočinek");
            Task_Title.Add("Boj");
            Task_Title.Add("Pokračovat");

            Task_Title.Add("Pokračovat");
            Task_Title.Add("Pomoc Ano/Ne");
            Task_Title.Add("Odměna");
            Task_Title.Add("Boj");
            Task_Title.Add("Pokračovat");

            Task_Title.Add("Pokračovat");
            Task_Title.Add("Jdi dál");
            Task_Title.Add("Pokračovat");
            Task_Title.Add("Boj");
            Task_Title.Add("Finální souboj");
            Task_Title.Add("Pokračovat");

            Task_Title.Add("Výhra");
            Task_Title.Add("Konec");
            //--------------------------------
            Task_Type.Add("vyber_hrdiny");
            Task_Type.Add("vyber");
            Task_Type.Add("vyber");
            Task_Type.Add("pokracovat");

            Task_Type.Add("boj");
            Task_Type.Add("odmena");
            Task_Type.Add("hospoda");
            Task_Type.Add("nakup");
            Task_Type.Add("boj");
            Task_Type.Add("odmena");

            Task_Type.Add("pokracovat");
            Task_Type.Add("hospoda");
            Task_Type.Add("nakup");
            Task_Type.Add("velitel");
            Task_Type.Add("pokracovat");

            Task_Type.Add("pokracovat");
            Task_Type.Add("odmena");
            Task_Type.Add("nakup");
            Task_Type.Add("pokracovat");
            Task_Type.Add("pokracovat");

            Task_Type.Add("velitel");
            Task_Type.Add("odmena");
            Task_Type.Add("pokracovat");

            Task_Type.Add("pokracovat");
            Task_Type.Add("pokracovat");
            Task_Type.Add("boj");
            Task_Type.Add("pokracovat");

            Task_Type.Add("pokracovat");
            Task_Type.Add("boj");
            Task_Type.Add("odmena");
            Task_Type.Add("velitel");
            Task_Type.Add("pokracovat");

            Task_Type.Add("velitel");
            Task_Type.Add("pokracovat");
            Task_Type.Add("pokračovat");
            Task_Type.Add("velitel");
            Task_Type.Add("velitel");

            Task_Type.Add("pokracovat");
            Task_Type.Add("konec");
            //--------------------------------
            Task_Text.Add("Šermíř,Lučištník,Léčitel");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano, Ne");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            Task_Text.Add("Ano");

            Task_Text.Add("Ano");
            Task_Text.Add("Ano");
            //--------------------------------
            Task_Reward.Add(0);
            Task_Reward.Add(2);
            Task_Reward.Add(3);
            Task_Reward.Add(0);

            Task_Reward.Add(0);
            Task_Reward.Add(4);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(6);

            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(8);

            Task_Reward.Add(0);
            Task_Reward.Add(11);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);

            Task_Reward.Add(0);
            Task_Reward.Add(12);
            Task_Reward.Add(0);

            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(13);

            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(14);
            Task_Reward.Add(0);
            Task_Reward.Add(0);

            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);
            Task_Reward.Add(0);

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
