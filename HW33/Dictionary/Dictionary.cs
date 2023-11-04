using System;
using System.Collections.Generic;

namespace Task4Dictionary
{
    class Dictionary
    {
        private IList<Word> _words = new List<Word>();

        public string this[string origin]
        {
            get => FindWord(origin).Translate;
            set => FindWord(origin).Translate = value;
        }

        public void AddWord(Word word) => _words.Add(word);

        private Word FindWord(string origin)
        {
            Word word = null;

            foreach (var item in _words)
                if (item.Origin == origin)
                {
                    word = item;
                    break;
                }
            return word;
        }
    }
}
