using ConsoleApplication;
using Xunit;

namespace ProjectTestExamples
{
    public class ModifiersTest
    {    
        [Fact]
        public void Modifiers_WhenInstance_ReturnsToStringComplete()
        {
            var instance = new Modifiers("states");
            var phrase = "Values cont int : " + 10
                + " const string " + "united"
                + " constructor " + "states";
            Assert.Equal(true, instance.ToString() == phrase);
        }
        
    }
}