using System;

namespace Patern_Vocabulary
{
    public class HtmlStyleFormater : IStyleFormater
    {
        public string Style(Word word)
        {
            return string.Format("<div>{0}</div><br>", word);
        }
    }
}