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
        public Chapter(int n)
        {
            Chapter_ID.Add(1);
            Chapter_ID.Add(2);
            Chapter_ID.Add(3);

            Chapter_Title.Add("Uvod");
            Chapter_Title.Add("Pochod");
            Chapter_Title.Add("Hory");

            Chapter_Text.Add("Ahoj");
            Chapter_Text.Add("Nazdar");
            Chapter_Text.Add("Cau");

            _id_chapter = Chapter_ID[n];
            _name_chapter = Chapter_Title[n];
            _text_chapter = Chapter_Text[n];
        }
    }
}
