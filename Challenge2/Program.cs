namespace Challenge2
{
    using System.IO;

    internal class Program
    {
        private static readonly string text = File.ReadAllText(@"C:\Users\odf\downloads\text.txt");

        private static void Main()
        {
            var tlsCounter = new TlsProcessor();
            var parser = new GetTlsArray();
            var matchingTls = tlsCounter.GetTls(parser.GetArray(text), 99);
        }
    }
}