using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TextAnalyser.Source;

namespace TextAnalyser
{
    class StatisticalAnalysis
    {
        public View displayStats;
        public Dictionary<string, int> resultDict = new Dictionary<string,int>();
        private int resultCounter;
        private Iterator currentIterator;

        public StatisticalAnalysis(Iterator newIterator)
        {
            this.displayStats = new View();
            this.currentIterator = newIterator;

            do
            {
                var currKey = currentIterator.MoveNext();
                resultCounter++;
                if (!resultDict.ContainsKey(currKey))
                {
                    resultDict.Add(currKey, 1);
                }
                else
                {
                    resultDict[currKey]++;
                }
            } while (currentIterator.HasNext());

        }
        public int CountOf(params string[] args)
        {
            int counter = 0;
            foreach (string argument in args) counter += resultDict[argument];
            return counter;
        }
        public int  DictionarySize()
        {
            return resultDict.Values.Count;
        }
        public int Size()
        {
            return resultCounter;
        }
        public ISet<string> OccurMoreThan(int limitNumber)
        {
            var setOccurMoreThan = new HashSet<string>();
            foreach (string resKey in resultDict.Keys)
            {
                if (resultDict[resKey] > limitNumber)
                {
                    setOccurMoreThan.Add(resKey);
                }
            }
            return setOccurMoreThan;
        }
        public Dictionary<string, double> PercentOccurenceOf()
        {
            var resDictOfPerc = new Dictionary<string, double>();
            foreach (var element in resultDict.Keys)
            {
                resDictOfPerc.Add(element, (double)this.DictionarySize()/(double)this.resultDict[element]);
            }
            return resDictOfPerc;
        }
    }
}
