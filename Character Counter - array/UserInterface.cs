using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Counter___array
{
    class UserInterface
    {
        public string Output { get; set; }

        private string Convert(CharacterFrequency[] freq)
        {
            string freqAsString = "";
            // string conversion
            return freqAsString;
        }
        
        public void ExceptionMessageOutput(Type ex)
        {
            switch(ex.Name)
            {
                case nameof(ArgumentException):
                    Output = "Please specify a file for input. \nIt must be located in the " +
                             "same directory from which this program has been ignited. \n";
                    break;
                case nameof(ArgumentNullException):
                    Output = "You have failed to specify an argument.";
                    break;
                case nameof(FileLoadException):
                    Output = "The file has failed to load. Please check the file\n" +
                             "name and path to be certain that they are cottect and that " +
                             "the file that you specified does in fact exist at that location.\n";
                    break;
                case nameof(UnsupportedArgsException):
                    Output = "You have supplied an argument not supported in this version of \n" +
                             "this program. Writing output to a file may be implemented in a\n" +
                             "future version.";
                    break;
            }
        }

        public void DisplayOutput(CharacterFrequency[] freqArray)
        {
            // Output = Convert(freqArray);
            Console.WriteLine("End of program.");
            Environment.Exit(0);
        }
    }
}
