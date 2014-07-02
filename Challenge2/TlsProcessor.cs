namespace Challenge2
{
    using System.Collections.Generic;

    internal class TlsProcessor
    {
        public string[] GetSolutionTls(string[] tlsArray, int repeats)
        {
            var solutionTls = new List<string>();
            var tlsCountDictionary = CountTlsRepeats(tlsArray);
            foreach (var entry in tlsCountDictionary)
            {
                if (entry.Value == repeats)
                {
                    solutionTls.Add(entry.Key);
                }
            }
            return solutionTls.ToArray();
        }

        private Dictionary<string, int> CountTlsRepeats(string[] tlsArray)
        {
            var tlsCount = new Dictionary<string, int>();
            foreach (var tls in tlsArray)
            {
                if (tlsCount.ContainsKey(tls))
                {
                    tlsCount[tls]++;
                }
                else
                {
                    tlsCount.Add(tls, 1);
                }
            }
            return tlsCount;
        }
    }
}