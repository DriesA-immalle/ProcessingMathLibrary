using System;
using Xunit;

namespace ProcessingMathLibTests
{
    public class ProcessingMathLibTest
    {
        [Fact]
        public void SqShouldReturnSquare()
        {
            Assert.Equal(16, ProcessingMathLib.ProcessingMathLib.Sq(4));
        }

        [Fact]
        public void ConstrainShouldKeepValueBetweenMinAndMax()
        {
            Assert.Equal(30, ProcessingMathLib.ProcessingMathLib.Constrain(10, 30, 60));
            Assert.Equal(50, ProcessingMathLib.ProcessingMathLib.Constrain(50, 30, 60));
            Assert.Equal(60, ProcessingMathLib.ProcessingMathLib.Constrain(80, 30, 60));
        }

        [Fact]
        public void MapShouldRemapAValue()
        {
            Assert.Equal(20, ProcessingMathLib.ProcessingMathLib.Map(10, 0, 20, 0, 40));
        }
    }
}
