using Xunit;
using RomainNumber;
using Assert = Xunit.Assert;

namespace RomainNumberTests
{
    public class ProgramTest
    {
        [Fact]
        public void TestConvertRomanToInteger_ValidInput()
        {
            Assert.Equal(1, Program.ConvertRomanToInteger("I"));
            Assert.Equal(5, Program.ConvertRomanToInteger("V"));
            Assert.Equal(10, Program.ConvertRomanToInteger("X"));
            Assert.Equal(50, Program.ConvertRomanToInteger("L"));
            Assert.Equal(100, Program.ConvertRomanToInteger("C"));
            Assert.Equal(500, Program.ConvertRomanToInteger("D"));
            Assert.Equal(1000, Program.ConvertRomanToInteger("M"));
            Assert.Equal(5000, Program.ConvertRomanToInteger("A"));
            Assert.Equal(10000, Program.ConvertRomanToInteger("B"));
            Assert.Equal(50000, Program.ConvertRomanToInteger("E"));
            Assert.Equal(100000, Program.ConvertRomanToInteger("F"));
            Assert.Equal(500000, Program.ConvertRomanToInteger("G"));
            Assert.Equal(1000000, Program.ConvertRomanToInteger("H"));
        }

        [Fact]
        public void TestConvertRomanToInteger_InvalidInput()
        {
            Assert.Throws<ArgumentException>(() => Program.ConvertRomanToInteger("IIII"));
            Assert.Throws<ArgumentException>(() => Program.ConvertRomanToInteger("VV"));
            Assert.Throws<ArgumentException>(() => Program.ConvertRomanToInteger("IC"));
            Assert.Throws<ArgumentException>(() => Program.ConvertRomanToInteger("XIC"));
        }

        [Fact]
        public void TestIsValidRomanNumeral_ValidInput()
        {
            Assert.True(Program.IsValidRomanNumeral("I"));
            Assert.True(Program.IsValidRomanNumeral("V"));
            Assert.True(Program.IsValidRomanNumeral("X"));
            Assert.True(Program.IsValidRomanNumeral("L"));
            Assert.True(Program.IsValidRomanNumeral("C"));
            Assert.True(Program.IsValidRomanNumeral("D"));
            Assert.True(Program.IsValidRomanNumeral("M"));
            Assert.True(Program.IsValidRomanNumeral("A"));
            Assert.True(Program.IsValidRomanNumeral("B"));
            Assert.True(Program.IsValidRomanNumeral("E"));
            Assert.True(Program.IsValidRomanNumeral("F"));
            Assert.True(Program.IsValidRomanNumeral("G"));
            Assert.True(Program.IsValidRomanNumeral("H"));
        }

        [Fact]
        public void TestIsValidRomanNumeral_InvalidInput()
        {
            Assert.False(Program.IsValidRomanNumeral("IIII"));
            Assert.False(Program.IsValidRomanNumeral("VV"));
            Assert.False(Program.IsValidRomanNumeral("IC"));
            Assert.False(Program.IsValidRomanNumeral("XIC"));
        }
    }
}
