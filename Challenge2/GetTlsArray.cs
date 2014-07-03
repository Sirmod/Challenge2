namespace Challenge2
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class GetTlsArray
    {
        public string[] GetArray(string text)
        {
            var words = SplitToWords(text);
            return WordsToTls(words);
        }

        private string[] WordsToTls(string[] words)
        {
            var tls = new List<string>();
            foreach (var word in words)
            {
                for (var i = 0; i < word.Length - 2; i++)
                {
                    tls.Add(word.Substring(i, 3));
                }
            }
            return tls.ToArray();
        }

        private string[] SplitToWords(string text)
        {
            text = text.ToLower();
            var regex = new Regex(@"\W");
            return regex.Split(text);
        }
    }
}