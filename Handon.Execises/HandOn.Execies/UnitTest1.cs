using Handon.Execises;
using System;
using Xunit;

namespace HandOn.Execies
{
    public class UnitTest1
    {
        [Theory(DisplayName ="CallHoge��Hoge��Ԃ����Ƃ��m�F����B")]
        [InlineData("Hoge")]
        public void Test1(string expect)
        {
            var temp = new Hoge();
            Assert.Equal(expect, temp.CallHoge());
        }
    }
}
