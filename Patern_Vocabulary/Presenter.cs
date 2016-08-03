using System.Collections.Generic;
using System.Linq;

namespace Patern_Vocabulary
{
    public class Presenter
    {
        private WordCollection _wordCollection;

        private IStyleFormater _formater;

        private WordCollectionManager _wcManager;

        public List<string> ShowList()
        {
            return _wordCollection.GetAllWords().Select(word => word.Content).ToList();
        }

        public List<string> ShowList(string letter)
        {
            return _wordCollection.GetWordsByTerm(letter).Select(word => word.Content).ToList();
        }
    }
}