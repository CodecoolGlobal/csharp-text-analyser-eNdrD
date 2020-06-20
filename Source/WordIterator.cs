using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser.Source
{
    class WordIterator : Iterator
    {
        private FileContent fileContent;
        private int position = -1;


        public WordIterator(FileContent newFileContent)
        {
            this.fileContent = newFileContent;
        }
        public bool HasNext()
        {
            return position < fileContent.wordArray.Length - 1;
        }
        //Returns value and increases an index
        public string MoveNext()
        {
            if (this.HasNext())
            {
                position++;
            }
            var _result = fileContent.wordArray[position];
            return _result;
        }

        //public void Remove()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
