using Xunit;
using System;
using MachineLearning.Math;

namespace MachineLearning.Math.Tests
{
    public class SigmoidFunctionTest
    {
        [Fact]
        public void SigmoidFunctionComputesAsExpectedForSmallValuesOfX()
        {
            Assert.Equal(SigmoidFunction.Calc(-10000000), 0);
        }

        [Fact]
        public void SigmoidFunctionComputesAsExpectedWhenXisZero()
        {
            Assert.Equal(SigmoidFunction.Calc(0), 0.5);
        }

        [Fact]
        public void SigmoidFunctionComputesAsExpectedForLargeValuesOfX()
        {
            Assert.Equal(SigmoidFunction.Calc(10000000),1);
        }

        [Fact]
        public void SigmoidFunctionDerivativeComputesAsExpectedForSmallValuesOfX()
        {
            Assert.Equal(SigmoidFunction.CalcDeriv(-10000000), 0);
        }

        [Fact]
        public void SigmoidFunctionDerivativeComputesAsExpectedWhenXisZero()
        {
            Assert.Equal(SigmoidFunction.CalcDeriv(0), 0.25);
        }

        [Fact]
        public void SigmoidFunctionDerivativeComputesAsExpectedForLargeValuesOfX()
        {
            Assert.Equal(SigmoidFunction.CalcDeriv(10000000),0);
        }
    }
}