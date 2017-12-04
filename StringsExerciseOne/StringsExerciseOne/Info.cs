using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExerciseOne
{
    class Info
    {
        public string Date;
        public string Title;
        public string Author;
        public int DateLength=10;
        public int TitleLength = 26;
        public int AuthorLength = 31;

        public Info(string Date, string Title, string Author)
        {
            this.Date = Date.PadRight(DateLength);
            this.Title=Title.PadLeft(TitleLength);
            this.Author = Author.PadRight(AuthorLength);
        }
    }
}
