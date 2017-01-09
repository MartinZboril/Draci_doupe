using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Classes;

namespace Draci_doupe
{
    public class Chapter
    {
        Chapters chapters = new Chapters();
        public Chapter(int n)
        {
            _id_chapter = n;
            _name_chapter = chapters.GetChapterName(n);
            _text_chapter = chapters.GetChapterText(n);
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
