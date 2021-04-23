using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Counter___array
{
    class FileHandler
    {
        private StreamReader _reader;
        private StreamWriter _writer;
        private string _fileName;
        private string _fullPath;

        public char[] Output { get; set; }

        public char[] SortedOutput { get; set; }

        public FileHandler(string fileName)
        {
            _fileName = fileName;
            _fullPath = Environment.CurrentDirectory + "\\" + fileName;
            _reader = new StreamReader(_fullPath);
            Output = CreateOutput(_reader);
        }

        // need to test this
        private char[] CreateOutput(StreamReader reader)
        {
            char[] result = reader.ReadToEnd().ToCharArray();
            return result;
        }

        //private char[] SortOutput()
        //{

        //}

    }
}
