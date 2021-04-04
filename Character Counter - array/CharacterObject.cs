namespace Character_Counter___array
{
    class CharacterObject
    {
        private char _character;
        private int _frequency;
        private int _ascii;

        public char Character
        {
            get => _character;
            set => _character = value;
        }

        public int Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }

        public int ASCII
        {
            get => _ascii;
        }

        public CharacterObject() { }

        public CharacterObject(char charToCheck)
        {
            _character = charToCheck;
            _ascii = (int) _character;
            _frequency = 0;
        }

        public void IncrementFrequency()
        {
            _frequency++;
        }

        public override string ToString()
        {
            return Character.ToString();
        }
    }
}
