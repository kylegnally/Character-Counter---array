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
        private UserInterface TheUserInterface => _theUserInterface;

        /// <summary>
        /// Property to store the current directory as a string.
        /// </summary>
        private string CurrentDir => _currentDir;

        private FileHandler _aFile;

        /// <summary>
        /// The required array of CharacterFrequency objects.
        /// </summary>
        public CharacterObject[] CharacterObjectCollection;

        private readonly UserInterface _theUserInterface;
        private readonly string _currentDir;


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
            _currentDir = Environment.CurrentDirectory;
            _theUserInterface = new UserInterface();

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
                        _aFile = new FileHandler(args[0]);
                        HandleTheFile(_aFile.Output);
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

        private void HandleTheFile(char[] foundCharacterArray)
        {
            CharacterObjectCollection = new CharacterObject[255]; 
            CharacterObject characterObject = new CharacterObject();
            
            int i = 0;
            while (i < foundCharacterArray.Length)
            {
                foreach (char thisCharacter in foundCharacterArray)
                {
                    int charToCheckIndex = (int)thisCharacter;
                    if (CharacterObjectCollection[charToCheckIndex] == null)
                    {
                        characterObject = new CharacterObject(thisCharacter);
                        CharacterObjectCollection[charToCheckIndex] = characterObject;
                        characterObject.IncrementFrequency();
                    }
                    else
                    {
                        if ((int)thisCharacter == CharacterObjectCollection[charToCheckIndex].ASCII)
                            CharacterObjectCollection[charToCheckIndex].IncrementFrequency();
                    }

                    i++;
                }
            }

            //CullTheNulls(CharacterObjectCollection);

            Console.WriteLine();

            ConsoleKey response;
            do
            {
                Console.Write($"Would you like to sort this list [y/N] ? ");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                {
                    Sort aSort = new Sort(CullTheNulls());
                }
                else if (response == ConsoleKey.N) TheUserInterface.DisplayOutput(CharacterObjectCollection);
            } 
            while (response != ConsoleKey.Y);

        }

        private CharacterObject[] CullTheNulls()
        {
            CharacterObject[] culled;
            int culledLength = 0;
            int j = 0;

            foreach (CharacterObject member in CharacterObjectCollection)
            {
                if (member != null) culledLength++;
            }

            culled = new CharacterObject[culledLength];

            // does not work. Fix!
            //for (int i = 0; i <= culledLength; i++)
            //{
            //    foreach (CharacterObject characterObject in CharacterObjectCollection)
            //    {
            //        if (characterObject != null)
            //        {
            //            culled[j] = new CharacterObject(CharacterObjectCollection[i].Character);
            //            j++;
            //        }
            //    }
            //}

            return culled;
        }
    }
}
