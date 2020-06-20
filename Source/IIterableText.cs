using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyser.Source;

namespace TextAnalyser
{
    interface IIterableText
    {
        Iterator CharIterator();
        Iterator WordIterator();
    }
}
