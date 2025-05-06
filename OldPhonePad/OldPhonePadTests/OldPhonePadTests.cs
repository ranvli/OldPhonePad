using System;
using Xunit;

namespace OldPhonePad
{

    public class OldPhonePadTests
    {
        [Fact]
        public void TestSingleKey()
        {
            Assert.Equal("E", OldPhone.OldPhonePad("33#"));
        }

        [Fact]
        public void TestBackspace()
        {
            Assert.Equal("B", OldPhone.OldPhonePad("227*#"));
        }

        [Fact]
        public void TestHello()
        {
            Assert.Equal("HELLO", OldPhone.OldPhonePad("4433555 555666#"));
        }

        [Fact]
        public void TestMixedSequence()
        {
            Assert.Equal("TURING", OldPhone.OldPhonePad("8 88777444666*664#"));
        }

        [Fact]
        public void TestInvalidEnds()
        {
            Assert.Equal("", OldPhone.OldPhonePad(""));
            Assert.Equal("", OldPhone.OldPhonePad("33"));
        }
    }

}
