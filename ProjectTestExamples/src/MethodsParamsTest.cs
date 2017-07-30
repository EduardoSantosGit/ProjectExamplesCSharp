using System;
using Xunit;
using ConsoleApplication;

namespace ProjectTestExamples
{
    public class MethodsParamsTest
    {
        [Fact]
        public void ParamsArrayConcat_WhenArrayInt_ReturnsString()
        {
            var a = new MethodsParams();
            int[] arrayInt = { 1, 4, 5, 6};
            Assert.Equal("1456", a.ParamsArrayConcat(arrayInt));
        }
        
        [Fact]
        public void ParamsArrayObjectConcat_WhenArrayObject_ReturnsItensConcatString()
        {
            var a = new MethodsParams();
            object[] arrayObject = { 1, "mexico", 5, "chile"};
            Assert.Equal("1mexico5chile", a.ParamsArrayObjectConcat(arrayObject));
        }
        
        [Fact]
        public void CalculateRefValue_WhenRefInt_ReturnsValueSum()
        {   
            //arrange
            var a = new MethodsParams();
            //act
            var some = 1;
            a.CalculateRefValue(ref some);
            //assert
            Assert.Equal(true, some == 501);
        }
        
        [Fact]
        public void ConcatRefValue_WhenRefString_ReturnsValueConcat()
        {   
            //arrange
            var a = new MethodsParams();
            //act
            var prhase = "Hello";
            a.ConcatRefValue(ref prhase);
            //assert
            Assert.Equal(true, prhase == "Hello World");
        }

        [Fact]
        public void AddValueOut_WhenOutInt_ReturnsValueAdd()
        {
            var a = new MethodsParams();
            int some;
            a.AddValueOut(out some);
            Assert.Equal(100, some);
        }
        
        [Fact]
        public void SubtractionValueOut_WhenOutInt_ReturnsValueLess()
        {
            var a = new MethodsParams();
            int some;
            a.SubtractionValueOut(out some);
            Assert.Equal(0, some);
        }
        
        [Fact]
        public void AddPhraseValueOut_WhenOutString_ReturnsValueAddString()
        {
            var a = new MethodsParams();
            string phrase;
            a.AddPhraseValueOut(out phrase);
            Assert.Equal("Value added with success", phrase);
        }
        
    }
}