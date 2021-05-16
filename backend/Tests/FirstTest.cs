using System;
using Xunit;

namespace main
{
    public class FirstTest
    {
        [Fact]
        public void AlwaysTrue()
        {
            Assert.True(true);
        }
    }
}
