using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Patern_Vocabulary
{
    public class Word
    {
        public string Content { get; set; }

        public List<string> Translation { get; set; }

        public ELanguage Language { get; set; }
        
    }
}