using System.Text.RegularExpressions;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string text = new string(Console.ReadLine());
            List<string> sentences = new List<string>(Regex.Split(text, @"(?<=[\.!\?])\s+"));
            List<string> foundSentencesWithPunctuation = new List<string>();
            foreach (string sentence in sentences)
            {
                if (SentenceContainsPunctioation(sentence) == true) foundSentencesWithPunctuation.Add(sentence);
            }
            Console.WriteLine("Sentenses that containces punctuation: ");
            if (foundSentencesWithPunctuation.Count == 0) Console.WriteLine("There are no sentences, that containces puntuation :)");
            else foundSentencesWithPunctuation.ForEach(Console.WriteLine);
        }

        public static bool SentenceContainsPunctioation(String sentence)
        {
            List<string> punctuations = new List<string>() { ":", ";", ",", "-" };
            foreach (var punctuation in punctuations)
            {
                if (sentence.Contains(punctuation))
                {
                    return true;
                }
            }
            return false;
        }
    }
}