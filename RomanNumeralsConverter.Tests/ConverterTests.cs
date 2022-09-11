using FluentAssertions;
using System;

namespace RomanNumeralsConverter.Tests
{
    public class ConverterTests
    {
        private Converter converter;
        [SetUp]
        public void Setup()
        {
            converter = new Converter();
        }

        [Test]
        public void RomanToInteger_Should_Return_Correct_Number_For_The_Upper_Case_Roman_Numeral()
        {
            converter.RomanToInteger("I").Should().Be(1);
            converter.RomanToInteger("II").Should().Be(2);
            converter.RomanToInteger("III").Should().Be(3);
            converter.RomanToInteger("IV").Should().Be(4);
            converter.RomanToInteger("V").Should().Be(5);
            converter.RomanToInteger("VI").Should().Be(6);
            converter.RomanToInteger("VII").Should().Be(7);
            converter.RomanToInteger("VIII").Should().Be(8);
            converter.RomanToInteger("IX").Should().Be(9);
            converter.RomanToInteger("X").Should().Be(10);
        }

        [Test]
        public void RomanToInteger_Should_Return_Correct_Number_For_The_Lower_Case_Roman_Numeral()
        {
            converter.RomanToInteger("i").Should().Be(1);
            converter.RomanToInteger("ii").Should().Be(2);
            converter.RomanToInteger("iii").Should().Be(3);
            converter.RomanToInteger("iv").Should().Be(4);
            converter.RomanToInteger("v").Should().Be(5);
            converter.RomanToInteger("vi").Should().Be(6);
            converter.RomanToInteger("vii").Should().Be(7);
            converter.RomanToInteger("viii").Should().Be(8);
            converter.RomanToInteger("ix").Should().Be(9);
            converter.RomanToInteger("x").Should().Be(10);
        }

        [Test]
        public void Converter_Should_Throw_Argument_Exception_For_An_Empty_Input()
        {
            var ex = Assert.Throws<ArgumentException>(() => converter.RomanToInteger(String.Empty));
            Assert.That(ex.Message, Is.EqualTo("Please enter a value. This can't be empty."));
        }
    }
}