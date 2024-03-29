﻿namespace Challenge2
{
    using System;
    using System.IO;

    internal class Program
    {
        private static readonly string text = File.ReadAllText(@"C:\Users\odf\downloads\text.txt");

        private static void Main()
        {
            var tlsCounter = new TlsProcessor();
            var parser = new GetTlsArray();
            var matchingTls = tlsCounter.GetSolutionTls(parser.GetArray(text), 99);
            foreach (var tls in matchingTls)
            {
                Console.WriteLine("{0}", tls);
            }
            Console.ReadKey();
        }
    }
}