using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace RomanNumberr;

[TestFixture]
public class ProgramTest
{
    [Test]
    public void TestValidConversions()
    {
        ClassicAssert.AreEqual(1, Program.RomanNumberr("I");// RomanToInt("I"));
        ClassicAssert.AreEqual(4, Program.RomanToInt("IV"));
        ClassicAssert.AreEqual(9, Program.RomanToInt("IX"));
        ClassicAssert.AreEqual(58, Program.RomanToInt("LVIII"));
        ClassicAssert.AreEqual(1994, Program.RomanToInt("MCMXCIV"));
        ClassicAssert.AreEqual(3549, Program.RomanToInt("MMMDXLIX"));
    }
    [Test]
    public void TestInvalidConversions()
    {
        Assert.Throws<ArgumentException>(() => Program.RomanValueIsWrong("IIII"));
        Assert.Throws<ArgumentException>(() => Program.RomanValueIsWrong("XXXX"));
        Assert.Throws<ArgumentException>(() => Program.RomanValueIsWrong("MMMM"));
    }

    [Test]
    public void TestEdgeCases()
    {
        Assert.Throws<ArgumentException>(() => Program.RomanValueIsWrong("A"));
        Assert.Throws<ArgumentException>(() => Program.RomanValueIsWrong(""));
    }
}