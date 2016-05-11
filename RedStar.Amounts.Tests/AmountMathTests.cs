﻿using RedStar.Amounts.StandardUnits;
using Xunit;

namespace RedStar.Amounts.Tests
{
    public class AmountMathTests
    {
        [Fact]
        public void TestMax()
        {
            var amount1 = new Amount(10, TemperatureUnits.DegreeCelcius);
            var amount2 = new Amount(20, TemperatureUnits.DegreeCelcius);

            Assert.Equal(amount2, AmountMath.Max(amount1, amount2));
            Assert.Equal(amount2, AmountMath.Max(amount2, amount1));
        }

        [Fact]
        public void TestMin()
        {
            var amount1 = new Amount(10, TemperatureUnits.DegreeCelcius);
            var amount2 = new Amount(20, TemperatureUnits.DegreeCelcius);

            Assert.Equal(amount1, AmountMath.Min(amount1, amount2));
            Assert.Equal(amount1, AmountMath.Min(amount2, amount1));
        }

        [Fact]
        public void TestMaxWithDifferentUnits()
        {
            var amount1 = new Amount(10, LengthUnits.MilliMeter);
            var amount2 = new Amount(1, LengthUnits.Meter);

            Assert.Equal(amount2, AmountMath.Max(amount1, amount2));
            Assert.Equal(amount2, AmountMath.Max(amount2, amount1));
        }

        [Fact]
        public void TestMinWithDifferentUnits()
        {
            var amount1 = new Amount(10, LengthUnits.MilliMeter);
            var amount2 = new Amount(1, LengthUnits.Meter);

            Assert.Equal(amount1, AmountMath.Min(amount1, amount2));
            Assert.Equal(amount1, AmountMath.Min(amount2, amount1));
        }
    }
}