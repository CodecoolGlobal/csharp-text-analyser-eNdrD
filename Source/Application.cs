using System;
using System.Collections.Generic;
using System.Linq;

namespace TextAnalyser
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TEXT ANALYSER!");
            for (int i = 0; i < args.Length; i++)
            {
                var nFileContent = new FileContent(args[i]);
                var charfileAnalysis = new StatisticalAnalysis(nFileContent.CharIterator());
                var wordsfileAnalysis = new StatisticalAnalysis(nFileContent.WordIterator());
                var wordsView = wordsfileAnalysis.displayStats;
                var charsView = charfileAnalysis.displayStats;

                //Printing output
                Console.WriteLine($"---{args[i]}---");
                //Number of words
                var nOfWords = wordsfileAnalysis.Size();
                wordsView.Print("Words count: " + nOfWords.ToString());

                //Number of chars
                var nOfChars = charfileAnalysis.Size();
                charsView.Print("Chars count: " + nOfChars.ToString());

                //Dict size
                var nOfUniqueWords = wordsfileAnalysis.DictionarySize();
                wordsView.Print("Dict size: " + nOfUniqueWords.ToString());

                // Most used words
                int _limit = wordsfileAnalysis.Size()/100;
                List<string> wordsMoreThanOne = wordsfileAnalysis.OccurMoreThan(_limit).ToList<string>();
                var words = new List<string>();
                words.Add("Words that consists of >1%: [");
                words.Add(String.Join(", ", wordsMoreThanOne));
                words.Add("]");
                wordsView.Print(words);
                Console.WriteLine();

                //`'love' count: 60` number of times that the word ‘love’ occurred
                var _love = wordsfileAnalysis.CountOf("love");
                wordsView.Print($"'love' count: {_love}");

                //`'hate' count: 4` number of times that the word ‘hate’ occurred * *
                var _hate = wordsfileAnalysis.CountOf("hate");
                wordsView.Print($"'hate' count: {_hate}");

                //`'music' count: 4` number of times that the word ‘music’ occurred
                var _music = wordsfileAnalysis.CountOf("music");

                wordsView.Print($"'music' count: {_music}");

                //`vowels %: 38` what part of all characters are vowels(a, o, i, e, u)

                //`a: e count ratio: 1.54 ` the ratio of ‘a’ to ‘e’ occurrences

                //`[G -> 2.16] [R -> 5.36] .... < and the rest>` % of in whole text of all the letters

                //wordsView.Print(wordsfileAnalysis.resultDict, 0);
            }
        }
    }
}
