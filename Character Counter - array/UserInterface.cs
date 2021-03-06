﻿using System;
using System.IO;

namespace Character_Counter___array
{
    class UserInterface
    {
        public string Output { get; set; }

        private string Convert(CharacterObject[] freq)
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
                    Environment.Exit(0);
                    break;
                case nameof(ArgumentNullException):
                    Output = "You have failed to specify an argument.";
                    Environment.Exit(0);
                    break;
                case nameof(FileLoadException):
                    Output = "The file has failed to load. Please check the file\n" +
                             "name and path to be certain that they are cottect and that " +
                             "the file that you specified does in fact exist at that location.\n";
                    Environment.Exit(0);
                    break;
                case nameof(UnsupportedArgsException):
                    Output = "You have supplied an argument not supported in this version of \n" +
                             "this program. Writing output to a file may be implemented in a\n" +
                             "future version.";
                    Environment.Exit(0);
                    break;
            }
        }

        public void DisplayOutput(CharacterObject[] freqArray)
        {
            Console.WriteLine("CHAR\tASCII\tAMOUNT");
            // fix this, it's causing the repeats!
            foreach (CharacterObject oneCharFreqObj in freqArray)
            {
                if (oneCharFreqObj != null)
                {
                    var storedChar = oneCharFreqObj.Character;
                    Output = String.Format("{0}\t{1}\t{2}",
                        oneCharFreqObj.Character.ToString(),
                        (int)storedChar,
                        oneCharFreqObj.Frequency.ToString());
                    Console.WriteLine(Output);
                }
            }
            Console.WriteLine("End of program.");
            Environment.Exit(0);
        }
    }
}
