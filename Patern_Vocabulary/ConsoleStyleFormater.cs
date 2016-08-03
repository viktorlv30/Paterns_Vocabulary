using System;

namespace Patern_Vocabulary
{
    public class ConsoleStyleFormater : IStyleFormater
    {
        public string Style(Word word)
        {
            return string.Format("cmd - {0}" + Environment.NewLine, word);
        }
    }
}