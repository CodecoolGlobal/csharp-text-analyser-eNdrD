using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser.Source
{
    class CharIterator : Iterator
    {
        private FileContent fileContent;
        private int position = -1;


        public CharIterator(FileContent newFileContent)
        {
            this.fileContent = newFileContent;
        }
        public bool HasNext()
        {
            return position < fileContent.charArray.Length - 1;
        }
        //Returns value and increases an index
        public string MoveNext()
        {
            if (this.HasNext())
            {
                position++;
            }
            var _result = fileContent.charArray[position].ToString();
            return _result;
        }

        //public void Remove()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
