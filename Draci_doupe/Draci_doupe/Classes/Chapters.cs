using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Classes
{
    public class Chapters
    {
        List<int> Chapter_ID = new List<int>();
        List<string> Chapter_Title = new List<string>();
        List<string> Chapter_Text = new List<string>();

        public Chapters()
        {
            Chapter_ID.Add(0);
            Chapter_ID.Add(1);
            Chapter_ID.Add(2);
            Chapter_ID.Add(3);

            Chapter_ID.Add(4);
            Chapter_ID.Add(5);
            Chapter_ID.Add(6);
            Chapter_ID.Add(7);

            Chapter_Title.Add("Úvod");
            Chapter_Title.Add("Štít");
            Chapter_Title.Add("Kamínky");
            Chapter_Title.Add("Pochod");

            Chapter_Title.Add("Pomoc");
            Chapter_Title.Add("Odměna");
            Chapter_Title.Add("Rozhodnutí");
            Chapter_Title.Add("Hospoda");

            Chapter_Text.Add("Vítám tě ve hře. Včera nás přepadli zlý bojovnící, sebrali nám skoro vše. To nejdůležitější je, že vza-li kámen, který pohánní náš strom. Je tedy na tobě, aby si ho získal zpět. Budeš muset jít, až do Starověkého Egypta. Cesta bude nebezpečná, proto si vem sebou 2 společníky.");
            Chapter_Text.Add("Po výběr si se podíval před sebe a uviděl jsi štít. Cheš ho nebo ne? Rozhodni a můžeme pokračovat.");
            Chapter_Text.Add("Ještě než si vyšel zastavil tě tvůj kamarád a nabízí ti kamínky, za které si můžeš v budoucnu něco koupit. Vem si je budou se hodit");
            Chapter_Text.Add("Teď, když máš základní výbavu můžeme se vydat na výpravu.");

            Chapter_Text.Add("Tak to je nemilé, hned co jsi vyrazil, narazil jsi na přepadení karavany. Můžeš se vyhnout nebo bojovat. Pokud se vyhneš cesta bude pokračovat. Pokud budeš chtít bojovat, ztratíš sice životy, ale můžeš dostat odměnu. Je to jen na tobě.");
            Chapter_Text.Add("Odměna pro tebe");
            Chapter_Text.Add("Ušel jsi už poměrně dlouhou cestu. Jestli chceš můžeme si odpočinout v hospodě, která je nedaleko odsuď, neboť další cesta bude náročná. Obsahuje spoustu nebezpečí.");
            Chapter_Text.Add("Vítám tě u nás. Můžeš si vybrat následující zboží");
        }
        /// <summary>
        /// Metoda pro získání názvu kapitoly
        /// </summary>
        /// <param name="num">ID kapitoly</param>
        /// <returns>Název kapitoly</returns>
        public string GetChapterName(int num)
        {
            string name = Chapter_Title[num];
            return name;
        }
        /// <summary>
        /// Metoda pro získání textu kapitoly
        /// </summary>
        /// <param name="num">ID kapitoly</param>
        /// <returns>Text kapitoly</returns>
        public string GetChapterText(int num)
        {
            string text = Chapter_Text[num];
            return text;
        }
    }
}
