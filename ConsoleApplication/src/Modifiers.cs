using System;

namespace ConsoleApplication
{
    public class Modifiers
    {
        private const int _length = 10;
        private const string _name = "united";
        private readonly string _readonly;
        
        public Modifiers(string value)
        {
            _readonly = value;
        }

        public override string ToString()
        {
            return "Values cont int : " + _length
                   + " const string " + _name
                   + " constructor " + _readonly;
        }
    }
}