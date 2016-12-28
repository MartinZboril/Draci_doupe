using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Chapter
    {
        List<int> Chapter_ID = new List<int>();
        List<string> Chapter_Title = new List<string>();
        List<string> Chapter_Text = new List<string>();

        public Chapter(int n)
        {
            Chapter_ID.Add(0);
            Chapter_ID.Add(1);
            Chapter_ID.Add(2);
            Chapter_ID.Add(3);

            Chapter_Title.Add("Úvod");
            Chapter_Title.Add("Štít");
            Chapter_Title.Add("Kamínky");
            Chapter_Title.Add("Pochod");

            Chapter_Text.Add("Vítám tě ve hře. Včera nás přepadli zlý bojovnící, sebrali nám skoro vše. To nejdůležitější je, že vza-li kámen, který pohánní náš strom. Je tedy na tobě, aby si ho získal zpět. Budeš muset jít, až do Starověkého Egypta. Cesta bude nebezpečná, proto si vem sebou 2 společníky.");
            Chapter_Text.Add("Po výběr si se podíval před sebe a uviděl jsi štít. Cheš ho nebo ne? Rozhodni a můžeme pokračovat.");
            Chapter_Text.Add("Ještě než si vyšel zastavil tě tvůj kamarád a nabízí ti kamínky, za které si můžeš v budoucnu něco koupit. Vem si je budou se hodit");
            Chapter_Text.Add("Teď, když máš základní výbavu můžeme se vydat na výpravu.");

            _id_chapter = Chapter_ID[n];
            _name_chapter = Chapter_Title[n];
            _text_chapter = Chapter_Text[n];
        }

        private int _id_chapter;
        public int ID_Chapter
        {
            get { return _id_chapter; }
            set { _id_chapter = value; }
        }

        private string _name_chapter;
        public string Name_Chapter
        {
            get { return _name_chapter; }
            set { _name_chapter = value; }
        }

        private string _text_chapter;
        public string Text_Chapter
        {
            get { return _text_chapter; }
            set { _text_chapter = value; }
        }
    }
}
