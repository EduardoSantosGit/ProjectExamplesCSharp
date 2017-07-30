namespace ConsoleApplication
{
    public class MethodsParams
    {
        public string ParamsArrayConcat(params int[] values)
        {
            var cont = "";
            for(var i = 0; i < values.Length; i++)
            {
                cont += values[i];
            }
            return cont;
        }
        
        public string ParamsArrayObjectConcat(params object[] values)
        {
            var cont = "";
            for(var i = 0; i < values.Length; i++)
            {
                cont += values[i].ToString();
            }
            return cont;
        }

        public void CalculateRefValue(ref int value)
        {
            value += 500;
        }

        public void ConcatRefValue(ref string value)
        {
            value += " World";
        }
        
        public void AddValueOut(out int value)
        {
            value = 100;
        }
        
        public void SubtractionValueOut(out int value)
        {    
            value = 0;
        }
        
        public void AddPhraseValueOut(out string value)
        {
            value = "Value added with success";
        }
        
    }
}