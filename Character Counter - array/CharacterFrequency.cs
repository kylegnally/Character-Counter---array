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
        private char _character;
        private int _frequency;
        public char Character { get; set; }

        public int Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }

        public CharacterFrequency() { }

        public CharacterFrequency(char charToCheck)
        {
            _character = charToCheck;
            _frequency = 1;
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
