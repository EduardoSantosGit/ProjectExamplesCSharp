using Xunit;
using ConsoleApplication;

namespace ProjectTestExamples
{
    public class ContextualKeywordsTest
    {
        [Fact]
        public void NumberReturnClass1_When_Return10()
        {   
            var c = new ContextualKeywords();
            Assert.Equal(c.NumberReturnClass1(),10);
        }
        
        [Fact]
        public void NumberReturnClass2_When_Return10()
        {   
            var c = new ContextualKeywords();
            Assert.Equal(c.NumberReturnClass2(),20);
        }
    }
}