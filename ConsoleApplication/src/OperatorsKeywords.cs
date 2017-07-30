using System;

namespace ConsoleApplication
{
    public class OperatorsKeywords
    {
        public bool[] VerifyUsingAsConversion(params object[] values)
        {
            var result = new bool[values.Length]; 
            for (var i = 0; i < values.Length; i++)
            {
                var conv = values[i] as string;
                result[i] = conv != null ? true : false;
            }
            return result;
        }

        public bool[] VerifyUsingIsConversion(params object[] values)
        {
            var result = new bool[values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                result[i] = values[i] is string;
            }
            return result;
        }

        public int VerifySizeTypes(Type type)
        {
            if (type == typeof(int))
            {
                return sizeof(int);
            }
            else if (type == typeof(char))
            {
                return sizeof(char);
            }
            else if (type == typeof(bool))
            {
                return sizeof(bool);
            }
            return sizeof(decimal);
        }

        public bool VerifyTypeValueInt(Type type)
        {
            return type == typeof(int);
        }

    }
}