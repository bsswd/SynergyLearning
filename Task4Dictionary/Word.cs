using System.Net.NetworkInformation;

namespace Task4Dictionary
{
    class Word
    {
        public string Origin { get; set; }
        public string Translate { get; set; }

        public Word(string origin, string translate)
        {
            Origin = origin;
            Translate = translate;  
        }
    }
}
