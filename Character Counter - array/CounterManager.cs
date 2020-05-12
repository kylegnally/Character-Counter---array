﻿using System;
using System.IO;

namespace Character_Counter___array
{
    class CounterManager
    {
        /// <summary>
        /// Exception Legerdemain for use in a switch in the UserInterface class.
        /// </summary>
        private Type ex;

        /// <summary>
        /// The user interface. In this program it doesn't handle any user input. 
        /// </summary>
        private UserInterface TheUserInterface { get; }

        /// <summary>
        /// Property to store the current directory as a string.
        /// </summary>
        private string CurrentDir { get; }

        /// <summary>
        /// The required array of CharacterFrequency objects.
        /// </summary>
        private CharacterFrequency[] _CharacterFrequencyObjectArray;
        public CharacterFrequency[] CharacterFrequencyObjectArray { get; set; }

        ///// <summary>
        ///// An array to store a running count of the number of times each letter
        ///// in the alphabet appears. Remember- arrays start at 0, so 
        ///// </summary>
        //public int[] DuplicateLetterArray { get; }

        /// <summary>
        /// Constructor for the CounterManager class. 
        /// </summary>
        /// <param name="args"></param>
        public CounterManager(string[] args)
        {
            TheUserInterface = new UserInterface();
            _CharacterFrequencyObjectArray = CharacterFrequencyObjectArray;
            if (args.Length > 1)
            {
                // ordinarily we would allow for writing of the finished product to a file.
                // I won't do this because it's optional for this assignment. But we do need
                // to guard against a user trying to supply an argument for an output file some
                // time in the future when running this version of the program.
                ex = typeof(UnsupportedArgsException);
                TheUserInterface.ExceptionMessageOutput(ex);
                
                // now we'll create the args array, newArgs
                string[] newArgs = new string[1];

                // and replace the args with too many arguments with the one we just made, using
                // the input file argument already supplied:
                args = newArgs;
            }

            // TheUserInterface = new UserInterface();
            CurrentDir = Environment.CurrentDirectory;
            ReadFile(args);
            Environment.Exit(0);
        }
        /// <summary>
        /// Method to read the file from the current directory.
        /// Includes exception types. Assigns the appropriate exception
        /// to the Calls a method to process the file.
        /// </summary>
        /// <param name="args"></param>
        private void ReadFile(string[] args)
        {
            if (args != null)
            {
                
                if (File.Exists(args[0]))
                {
                    try
                    {
                        string fullPath = CurrentDir + "\\" + args[0];
                        using (StreamReader reader = new StreamReader(fullPath))
                        {
                            Process(reader);
                        }
                    }
                    catch
                    {
                        // Since we can use types in switch statements now, we can
                        // use the type of the exception as the case in the switch when
                        // determining which message the user should see.
                        // Exception messages are always obscure to users who aren't 
                        // programmers. This technique allows for an explanation.
                        ex = typeof(FileLoadException);
                        TheUserInterface.ExceptionMessageOutput(ex);
                    }
                }
                else
                {
                    ex = typeof(FileLoadException);
                    TheUserInterface.ExceptionMessageOutput(ex);
                }
                
            }
            else
            {
                ex = typeof(ArgumentNullException);
                TheUserInterface.ExceptionMessageOutput(ex);
            }
        }

        /// <summary>
        /// Method to process the input file.
        /// </summary>
        /// <param name="file"></param>
        private void Process(StreamReader file)
        {
            char[] chars;
            string contents = file.ReadToEnd();
            chars = contents.ToCharArray();
        }

        private void HandleTheFile(char[] chars)
        {
            int i = 0;
            // let's assume someone's file is just the alphabet. We'll need an array
            // that can hold at least one of each letter, but we definitely will not
            // need less than that
            CharacterFrequency characterFrequencyObject = new CharacterFrequency();
            foreach (char aChar in chars)
            {
                if (characterFrequencyObject.Equals(aChar)) characterFrequencyObject.IncrementFrequency();
                else
                {
                    CharacterFrequencyObjectArray[i] = new CharacterFrequency(aChar);
                    i++;
                }

            }

            //// we're going to need to count the number of times 
            //// each letter in the alphabet appears. 
            //int[] duplicateCountArray = new int[26];

            ////FinalFrequencyArray = new CharacterFrequency[chars.Length];
            //int i = 0;
            //foreach (char aCharacter in chars)
            //{
            //    if (chars[0] == '\0') { }
            //    {
            //        int alphabetPosition = (int) aCharacter % 32;
            //        DuplicateLetterArray[alphabetPosition]++;
            //        if (DuplicateLetterArray[alphabetPosition] == 0) FinalFrequencyArray[i] = new CharacterFrequency(aCharacter);
            //        i++;
            //    }
            //}
            //Console.WriteLine("Characters have been set into array.");
        }
    }
}