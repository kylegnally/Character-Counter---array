using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Character_Counter___array
{
    class CharacterFrequency
    {
        public char Character { get; set; }

        public int Frequency { get; set; }

        public CharacterFrequency() { }

        public CharacterFrequency(char charToCheck)
        {
            Character = charToCheck;
        }

        public bool Equals(char charToCheck)
        {
            if (Character == charToCheck)
            {
                return true;
            }
            else
            {
                Character = Character;
            }
            return false;
        }

        public void IncrementFrequency(int i)
        {
            Frequency = Frequency + i;
        }

        public override string ToString()
        {
            return Character.ToString();
        }
    }
}
