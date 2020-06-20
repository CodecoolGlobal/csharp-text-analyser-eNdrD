using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAnalyser.Source
{
    class View
    {
        public View() { }
        public void Print(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }
        public void Print(List<string> textsListToPrint)
        {
            foreach (var element in textsListToPrint)
            {
                Console.Write(element + ", ");
            }
        }
        public void Print(Dictionary<string, int> dictToPrintFrom, int numberOfEntries)
        {
            foreach (var key in dictToPrintFrom.Keys)
            {
                Console.WriteLine(key + dictToPrintFrom[key].ToString());
            }
        }
    }
}
