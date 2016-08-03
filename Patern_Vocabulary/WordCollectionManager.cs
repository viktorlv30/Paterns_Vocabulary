using System.Collections.Generic;

namespace Patern_Vocabulary
{
    public class WordCollectionManager
    {
        
        public WordCollection GetWcByLanguage(string letter, ELanguage lang)
        {
            var temp = new WordCollection();
            var wcByTermAndLang = new WordCollection();

            foreach (var i in temp.GetWordsByTerm(letter))
            {
                if(i.Language == lang)
                    wcByTermAndLang.Add(i);
            }
           
            return wcByTermAndLang;
        }
    }
}