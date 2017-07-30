using System;
using Xunit;
using ConsoleApplication;

namespace ProjectTestExamples
{    
    public class OperatorsImplicitTest
    {
        
        [Fact]
        public void Operators_WhenInstanceLong_ReturnsValueLong()
        {    
            var o = new OperatorsImplicit(123456);
            Assert.Equal(true, o == (long) 123456);
        }
        
        [Fact]
        public void Operators_WhenInstanceString_ReturnsValueString()
        {    
            var o = new OperatorsImplicit("enterValue");
            Assert.Equal(true, o == "enterValue");
        }
        
        [Fact]
        public void Operators_WhenInstanceBool_ReturnsValueBool()
        {    
            var o = new OperatorsImplicit(true);
            Assert.Equal(true, o == true);
        }
        
        [Fact]
        public void Operators_WhenInstanceFloat_ReturnsValueFloat()
        {     
            var o = new OperatorsImplicit(4.5f);
            Assert.Equal(true, o == 4.5f);
        }
        
        [Fact]
        public void Operators_WhenInstanceChar_ReturnsValueChar()
        {     
            var o = new OperatorsImplicit('a');
            Assert.Equal(true, o == 'a');
        }
        
    }
}