//-----------------------------------------------------------------------
// <copyright file="CanaryTests.cs" company="Juxce">
//     Copyright (c) Juxce. All rights reserved.
// </copyright>
// <author>John Michael Miller</author>
//-----------------------------------------------------------------------
namespace Juxce.Tuneage.PaC.Test.Unit
{
    using Juxce.Tuneage.PaC.Canary;
    using Xunit;

    /// <summary>
    /// Class to test the Canary
    /// </summary>
    public class CanaryTests
    {
        /// <summary>
        /// Verify that the helper class returns Me
        /// </summary>
        [Fact]
        public void HelpShouldBeMe()
        {
            var target = Canary.CanaryHelper.Help();

            Assert.Equal("Me", target);
        }

        /// <summary>
        /// Canary Test
        /// </summary>
        [Fact(Skip = "Pipeline Test")]
        ////[Fact]
        public void HelpShouldBeMeToo()
        {
            var target = Canary.CanaryHelper.Help();

            Assert.Equal("Me Too", target);
        }
    }
}
