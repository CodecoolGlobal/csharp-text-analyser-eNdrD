using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser.Source
{
    interface Iterator
    {
        bool HasNext();
        string MoveNext();
        //void Remove();
    }
}
