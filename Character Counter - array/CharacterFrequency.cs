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
        char _character;
        public char Character { get; set; }

        public int Frequency { get; set; }

        public CharacterFrequency() { }

        public CharacterFrequency(char charToCheck)
        {
            _character = charToCheck;
            if (Equals(charToCheck))
            {
                IncrementFrequency();
            }
        }

        public bool Equals(char charToCheck)
        {
            if (Character == charToCheck)
            {
                return true;
            }
            else
            {
                CharacterFrequency aCharacter = new CharacterFrequency(charToCheck);
            }
            return false;
        }

        public void IncrementFrequency()
        {
            Frequency++;
        }

        public override string ToString()
        {
            return Character.ToString();
        }
    }
}
