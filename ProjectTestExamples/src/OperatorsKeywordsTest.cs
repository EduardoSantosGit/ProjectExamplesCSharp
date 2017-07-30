using System;
using Xunit;
using ConsoleApplication;

namespace ProjectTestExamples
{
    public class OperatorsKeywordsTest
    {
        [Fact]
        public void VerifyUsingAsConversion_WhenArrayObject_ReturnsArrayBool()
        {
            var operators = new OperatorsKeywords();
            object[] arrayObject = { 1, "banana", 4, true};
            Assert.Equal(new bool[] {false, true, false, false}, 
                operators.VerifyUsingAsConversion(arrayObject));
        }
        
        [Fact]
        public void VerifyUsingIsConversion_WhenArrayObject_ReturnsArrayBool()
        {
            var operators = new OperatorsKeywords();
            object[] arrayObject = { 1, 4, true, "mc", "bk"};
            Assert.Equal(new bool[] {false, false, false, true, true},
                operators.VerifyUsingIsConversion(arrayObject));
        }
        
        [Fact]
        public void VerifySizeTypes_WhenType_ReturnsSizeTypeInt()
        {
            var operators = new OperatorsKeywords();
            Assert.Equal(4, operators.VerifySizeTypes(typeof(int)));
        }
        
        [Fact]
        public void VerifySizeTypes_WhenType_ReturnsSizeTypeBool()
        {
            var operators = new OperatorsKeywords();
            Assert.Equal(1, operators.VerifySizeTypes(typeof(bool)));
        }
        
        [Fact]
        public void VerifySizeTypes_WhenType_ReturnsSizeTypeChar()
        {
            var operators = new OperatorsKeywords();
            Assert.Equal(2, operators.VerifySizeTypes(typeof(char)));
        }
        
        [Fact]
        public void VerifyTypeValueInt_WhenType_ReturnsBoolInt()
        {
            var operators = new OperatorsKeywords();
            Assert.Equal(true, operators.VerifyTypeValueInt(typeof(int)));
        }
    }
}