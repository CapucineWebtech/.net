using NUnit.Framework;
using NUnit.Framework.Legacy;

[TestFixture]
public class RomanNumeralTests
{
    [Test]
    public void IsValidRomanNumeral_ValidInputs_ReturnsTrue()
    {
        Assert.IsTrue(Program.IsValidRomanNumeral("I"));
        Assert.IsTrue(Program.IsValidRomanNumeral("IV"));
        Assert.IsTrue(Program.IsValidRomanNumeral("XII"));
        Assert.IsTrue(Program.IsValidRomanNumeral("LXXIII"));
        Assert.IsTrue(Program.IsValidRomanNumeral("CM"));
        Assert.IsTrue(Program.IsValidRomanNumeral("MCMXCIV"));
        Assert.IsTrue(Program.IsValidRomanNumeral("A"));
        Assert.IsTrue(Program.IsValidRomanNumeral("BA"));
        Assert.IsTrue(Program.IsValidRomanNumeral("F"));
    }

    [Test]
    public void IsValidRomanNumeral_InvalidInputs_ReturnsFalse()
    {
        Assert.IsFalse(Program.IsValidRomanNumeral("IIII"));
        Assert.IsFalse(Program.IsValidRomanNumeral("VV"));
        Assert.IsFalse(Program.IsValidRomanNumeral("XXXX"));
        Assert.IsFalse(Program.IsValidRomanNumeral("IL"));
        Assert.IsFalse(Program.IsValidRomanNumeral("IC"));
        Assert.IsFalse(Program.IsValidRomanNumeral("IM"));
        Assert.IsFalse(Program.IsValidRomanNumeral("XCM"));
        Assert.IsFalse(Program.IsValidRomanNumeral("IA"));
        Assert.IsFalse(Program.IsValidRomanNumeral("XI"));
    }

    [Test]
    public void ConvertRomanToInteger_ValidInputs_ReturnsCorrectValue()
    {
        Assert.AreEqual(1, Program.ConvertRomanToInteger("I"));
        Assert.AreEqual(4, Program.ConvertRomanToInteger("IV"));
        Assert.AreEqual(12, Program.ConvertRomanToInteger("XII"));
        Assert.AreEqual(73, Program.ConvertRomanToInteger("LXXIII"));
        Assert.AreEqual(900, Program.ConvertRomanToInteger("CM"));
        Assert.AreEqual(1994, Program.ConvertRomanToInteger("MCMXCIV"));
        Assert.AreEqual(5000, Program.ConvertRomanToInteger("A"));
        Assert.AreEqual(10000, Program.ConvertRomanToInteger("B"));
        Assert.AreEqual(100000, Program.ConvertRomanToInteger("F"));
    }

    [Test]
    public void ConvertRomanToInteger_InvalidInputs_ReturnsNegativeOne()
    {
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("IIII"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("VV"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("XXXX"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("IL"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("IC"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("IM"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("XCM"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("IA"));
        Assert.AreEqual(-1, Program.ConvertRomanToInteger("XI"));
    }
}
