namespace Challenge2
{
    using System;

    internal class GetTlsArray
    {
        public string GetArray(string text)
        {
            PunctuationToWhiteSpace(text);
            var words = SplitToWords(text);
            var tls = WordsToTls(words);
        }

        private string[] WordsToTls(string[] words)
        {
            throw new NotImplementedException();
        }

        private string[] SplitToWords(string text)
        {
            throw new NotImplementedException();
        }

        private void PunctuationToWhiteSpace(string text) {}
    }
}