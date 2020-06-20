using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TextAnalyser.Source;

namespace TextAnalyser
{
    class FileContent : IIterableText
    {
        private string fileName;
        public readonly char[] charArray;
        public readonly string[] wordArray;

        public FileContent(string newFileName)
        {
            this.fileName = newFileName;
            string _text = File.ReadAllText(newFileName).ToLower();
            wordArray = _text.Replace("\n", "").Replace("\r", "").Split(new[] {"\t", "   ", "  ", " "}, StringSplitOptions.None);
            charArray = _text.Replace(" ", String.Empty).Replace("\n", "").Replace("\r", "").ToCharArray();
        }
        public Iterator CharIterator()
        {
            Iterator initializedCharIterator = new CharIterator(this);
            return initializedCharIterator;
        }

        public Iterator WordIterator()
        {
            Iterator initializedWordsIterator = new WordIterator(this);
            return initializedWordsIterator;
        }
        public string GetFilename()
        {
            return fileName;
        }
    }
}
