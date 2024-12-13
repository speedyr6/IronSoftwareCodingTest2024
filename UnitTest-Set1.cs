namespace IronSoftwareOldPhone
{
    using NUnit.Framework;

    // Test Cases......
    //
    // Just entered some test case to demonstrate.
    // This is not exhaustive!!!
    // Apologies in advance
    //
    //
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_ABCKeys()
        {
            string input = "2 22 222 2222#";
            string expected = "ABC2";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));

        }

        [Test]
        public void Test2_DEFKeys()
        {
            string input = "3 33 333 3333#";
            string expected = "DEF3";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test3_GHIKeys()
        {
            string input = "4 44 444 4444#";
            string expected = "GHI4";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test4_JKLKeys()
        {
            string input = "5 55 555 5555#";
            string expected = "JKL5";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test5_MNOKeys()
        {
            string input = "6 66 666 6666#";
            string expected = "MNO6";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test6_PQRSKeys()
        {
            string input = "7 77 777 7777 77777#";
            string expected = "PQRS7";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test7_TUVKeys()
        {
            string input = "8 88 888 8888#";
            string expected = "TUV8";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test8_WXYZKeys()
        {
            string input = "9 99 999 9999 99999#";
            string expected = "WXYZ9";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test9_TestBackSpaceKeys()
        {
            string input = "2* 33* 444* 5555* 66666** 77777777*** 8*88*888** *99*#";
            string expected = "DHLO7UW";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }


        [Test]
        public void Test10_TestHash()
        {
            string input = "2* 33* 444* 5555*# 66666** 77777777*** 8*88*888** *99*#";
            string expected = "DHL";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }

        [Test]
        public void Test11_InterviewSpaces()
        {
            string input = "444 66 8 33 777 888 444 33 9 0 6 33 0 7 555 33 2 7777 33#";
            string expected = "INTERVIEW ME PLEASE";
            Assert.That(DecodeNumbers.decodeInput(input), Is.EqualTo(expected));
        }
    }
}