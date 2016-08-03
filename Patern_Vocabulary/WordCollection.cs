using System.Collections.Generic;
using System.Linq;

namespace Patern_Vocabulary
{
    public class WordCollection
    {
        private List<Word> Words { get; set; }

        public ELanguage Language { get; set; }

        public List<Word> GetAllWords()
        {
            return Words;
        }

        public List<Word> GetWordsByTerm(string letter)
        {
            List<Word> termWords = Words.Where(word => word.Content.Substring(0) == letter).ToList();
            return termWords.Count != 0 ? termWords : null;
        }

        public void Add(Word word)
        {
            Words.Add(word);
        }
    }
}