using System;

namespace ConsoleApplication
{
    public class OperatorsImplicit
    {
        private readonly string _valueString;
        private readonly long _valueLong;
        private readonly bool _valueBool;
        private readonly float _valueFloat;
        private readonly char _valueChar;

        public OperatorsImplicit(string value)
        {
            _valueString = value;
        }
        
        public OperatorsImplicit(long value)
        {
            _valueLong = value;
        }
        
        public OperatorsImplicit(bool value)
        {
            _valueBool = value;
        }
        
        public OperatorsImplicit(float value)
        {
            _valueFloat = value;
        }
        
        public OperatorsImplicit(char value)
        {
            _valueChar = value;
        }

        public static implicit operator long(OperatorsImplicit o)
        {
            return o._valueLong;
        }
        
        public static implicit operator string(OperatorsImplicit o)
        {
            return o._valueString;
        }

        public static implicit operator bool(OperatorsImplicit o)
        {
            return o._valueBool;
        }
        
        public static implicit operator float(OperatorsImplicit o)
        {
            return o._valueFloat;
        }
        public static implicit operator char(OperatorsImplicit o)
        {
            return o._valueChar;
        }
     
        
    }
}